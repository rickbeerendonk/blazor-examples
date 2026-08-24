#!/usr/bin/env bash

set -euo pipefail

while IFS= read -r -d '' project; do
	echo "RESTORE: $project"
	dotnet restore "$project" -nologo -v q
done < <(find . -name '*.csproj' -print0)
