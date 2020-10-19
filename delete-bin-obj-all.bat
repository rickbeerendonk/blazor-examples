FOR /d /r . %d in (bin) DO @IF EXIST "%d" rm -rf "%d"
FOR /d /r . %d in (obj) DO @IF EXIST "%d" rm -rf "%d"
