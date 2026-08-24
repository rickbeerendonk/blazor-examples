#!/usr/bin/env bash

set -u

is_windows=0
case "$(uname -s)" in
	MINGW*|MSYS*|CYGWIN*|Windows_NT)
		is_windows=1
		;;
esac

failed=0
built=0
skipped=0

while IFS= read -r -d '' project; do
	# WPF/WinForms samples can't be built on macOS/Linux without Windows targeting setup.
	if [[ $is_windows -eq 0 ]] && grep -Eq '<UseWPF>true</UseWPF>|<UseWindowsForms>true</UseWindowsForms>' "$project"; then
		echo "SKIP (Windows-only): $project"
		skipped=$((skipped + 1))
		continue
	fi

	echo "BUILD: $project"
	if dotnet build "$project" -nologo -v q; then
		built=$((built + 1))
	else
		failed=$((failed + 1))
	fi
done < <(find . -name '*.csproj' -print0)

echo
echo "Built:   $built"
echo "Skipped: $skipped"
echo "Failed:  $failed"

if [[ $failed -ne 0 ]]; then
	exit 1
fi
