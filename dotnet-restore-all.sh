find . -type d -maxdepth 6 -exec test -e "{}/Program.cs" ';' -exec bash -c "cd '{}' && echo $path && pwd && dotnet restore" \;
