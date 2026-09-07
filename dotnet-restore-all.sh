#!/usr/bin/env bash

set -uo pipefail

failed=0

while IFS= read -r -d '' project; do
	echo "RESTORE: $project"
	if ! dotnet restore "$project" -nologo -v q; then
		echo "FAILED: $project" >&2
		failed=1
	fi
done < <(find . -name '*.csproj' -print0)

exit "$failed"
