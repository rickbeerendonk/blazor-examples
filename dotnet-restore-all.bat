@echo off
setlocal enabledelayedexpansion

REM Loop through all directories up to 6 levels deep
for /d /r %%d in (*) do (
    REM Check if Program.cs exists in the directory
    if exist "%%d\Program.cs" (
        REM Change to the directory and run dotnet restore
        pushd "%%d"
        echo Current directory: %%d
        dotnet restore
        popd
    )
)
