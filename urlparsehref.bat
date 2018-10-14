@echo off
cls
.\bin\LC2Logo.exe
echo %time%
timeout 1 > NUL
setLocal EnableDelayedExpansion
echo start "%1"
Set "dbfile=lc.db"
Set "exportdir=export"
Set "csvdir=save"
Set "csvfile=import.csv"
Set "csvfilename=%csvdir%\%csvfile%"
Set "pattern=/a:d"
set sexec=".\bin\sqlite3.exe"
set dbfile="lc.db"
set dbtempfile="templc.db"
set table="url"
set temptable="tempurl"
SET "QUERY=select rowid, url, url from %temptable% limit 1000000;"
set hr=%time:~0,2%
setLocal EnableDelayedExpansion
set "LINE====================================="
set "out=.\save\auto01.jsonlog"
cls
rem echo call node urlparsehref.js out.html https://www.exxoshost.co.uk/atari/games/automation/AUTOMATION2015A.htm nodejs 1 2 3
@echo off
call node urlparsehref.js https://www.exxoshost.co.uk/atari/games/automation/AUTOMATION2015A.htm nodejs 1 2 3 > %out%
type %out%
call import.bat
@echo on