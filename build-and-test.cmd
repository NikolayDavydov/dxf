@echo off
setlocal

set thisdir=%~dp0
set configuration=Debug
set runtests=true

:parseargs
if "%1" == "" goto argsdone
if /i "%1" == "-c" goto set_configuration
if /i "%1" == "--configuration" goto set_configuration
if /i "%1" == "-notest" goto set_notest
if /i "%1" == "--notest" goto set_notest

echo Unsupported argument: %1
goto error

:set_configuration
set configuration=%2
shift
shift
goto parseargs

:set_notest
set runtests=false
shift
goto parseargs

:argsdone

:: run code generator
set GENERATOR_DIR=%thisdir%src\IxMilia.Dxf.Generator
set LIBRARY_DIR=%thisdir%src\IxMilia.Dxf
pushd "%GENERATOR_DIR%"
dotnet restore
if errorlevel 1 goto error
dotnet build --configuration %configuration%
if errorlevel 1 goto error
dotnet run --configuration %configuration% --no-restore --no-build -- "%LIBRARY_DIR%"
if errorlevel 1 goto error
popd

:: build
dotnet restore
if errorlevel 1 goto error
dotnet build --configuration %configuration%
if errorlevel 1 goto error

:: run tests
if /i "%runtests%" == "true" (
    dotnet test --configuration %configuration% --no-restore --no-build
    if errorlevel 1 goto error
)

:: create packages
dotnet pack --no-restore --no-build --configuration %configuration%
set PACKAGE_COUNT=0
for %%a in ("%thisdir%artifacts\packages\%configuration%\*.nupkg") do set /a PACKAGE_COUNT+=1
if not "%PACKAGE_COUNT%" == "1" echo Expected a single NuGet package but found %PACKAGE_COUNT% at '%thisdir%artifacts\packages\%configuration%' && goto error

goto :eof

:error
echo Error building project.
exit /b 1
