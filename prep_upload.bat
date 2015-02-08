@rem prep_uploads.bat
@rem Usage: create necessary zips and copy files to the top.

@rem rar a -afzip -r -p%3 %2.zip %1\*.*
@echo off
set setupdir=AoBExtractorSetup
:: retrieving  name of current directory
for %%* in (.) do set MyDir=%%~n*
:: adding safety factor for no directory, i.e a drive
if not defined MyDir set MyDir=%CD:\=%
:: telling you what it is
:: echo the current directory is %MyDir%
cd %MyDir%\bin\Release
ECHO %CD%
IF EXIST "%MyDir%.zip" DEL /Q "%MyDir%.zip"
winrar a -afzip "%MyDir%.zip" "%MyDir%.exe"
echo "%~DP0%MyDir%"
:: IF EXIST "%~DP0\%MyDir%.zip" DEL /Q "%MyDir%.zip"
copy /B "%MyDir%.zip" "%~DP0"
cd "%~DP0"
copy /B "%~DP0%setupdir%\release\*.msi" "%~DP0"
pause
