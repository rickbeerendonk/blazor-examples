find . -type d -maxdepth 6 -exec test -e "{}/wasm" ';' -exec bash -c "cd '{}/wasm' && echo $path && pwd && dotnet build" \;
