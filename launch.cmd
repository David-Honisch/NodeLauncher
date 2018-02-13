@echo off
call .\bin\LC2Logo.exe
pause
rem call .\bin\LC2Console2017.exe
pause
call .\bin\LC2Logo.exe
LC2RegAppMain.exe -quit -args -e sln -k "SharpDevelop 5.1" -t "C:\Program Files (x86)\SharpDevelop\5.1\bin\SharpDevelop.exe" -d "SharpDevelop 5.1"
echo DONE
pause