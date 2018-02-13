@echo off
call .\bin\LC2Logo.exe
rem call .\bin\LC2Console2017.exe
call .\bin\LC2Logo.exe
rem LC2RegAppMain.exe -quit -args -e sln -k "SharpDevelop 5.1" -t "C:\Program Files (x86)\SharpDevelop\5.1\bin\SharpDevelop.exe" -d "SharpDevelop 5.1"
bin\LC2RegAppMain.exe -quit -args -e db -k "SQLite Database Browser 2.0 b1" -t "C:\tools\sqlitebrowser_200_b1_win\SQLite Database Browser 2.0 b1.exe" -d "SQLite Database Browser 2.0 b1"
echo DONE
pause