@echo off
cls
.\bin\LC2Logo.exe
echo %time%
timeout 1 > NUL
setLocal EnableDelayedExpansion
Set "exportdir=export"
Set "csvdir=import"
Set "TOCSV=bin\2csv.bat"
Set "MSGBOX=bin\msgbox.bat"
Set "CSVTOSQLITE=bin\csv2sqlite.bat"
Set "LINKCSV=bin\linkcsv.bat"
Set "CREATECSV=bin\createcsv.bat"
Set "PRG=LC2SQLiteGUI.exe"
rem SET "QUERY=select rowid, url, url from %temptable% limit 1000000;"
set hr=%time:~0,2%
setLocal EnableDelayedExpansion
cls
echo CHECK DIRECTORY STRUCTURE
if not exist %csvdir%  (
	mkdir %csvdir%
) else (
	echo %csvdir% exists
)
if not exist %exportdir%  (
	mkdir %exportdir%
) else (
	echo %exportdir% exists
)
echo CHECK DIRECTORY STRUCTURE DONE
echo Import files to CSV
call %CREATECSV%
echo Import CSV to SQLite
rem call %TOCSV%
call %CSVTOSQLITE%
start %PRG%
echo Create links by SQLite output
rem %MSGBOX%
REM start %LINKCSV%
@echo on