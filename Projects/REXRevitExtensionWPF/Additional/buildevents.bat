set SOURCE_PATH=
set DESTINATION_PATH=

if not exist "%DESTINATION_PATH%\$REXModuleName$\$REXModuleName$.dll" goto end
if not exist "%SOURCE_PATH%\$REXModuleName$\$REXModuleName$\bin\Debug\$REXModuleName$.dll" goto end

copy "%SOURCE_PATH%\$REXModuleName$\$REXModuleName$\bin\Debug\$REXModuleName$.dll" "%DESTINATION_PATH%\$REXModuleName$\$REXModuleName$.dll"
copy "%SOURCE_PATH%\$REXModuleName$\$REXModuleName$\bin\Debug\$REXModuleName$.pdb" "%DESTINATION_PATH%\$REXModuleName$\$REXModuleName$.pdb"

:end
