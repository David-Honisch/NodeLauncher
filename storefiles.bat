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
set "out=.\save\auto01.json"
cls
call %sexec% %dbfile% "create TABLE IF NOT EXISTS fileblob ( id integer primary key asc autoincrement, timestamp text default (datetime()), data text);commit;"
for /R %csvdir% %%a in (*.*) do (
    echo '%%a'
    call %sexec% %dbfile% "INSERT INTO fileblob(data) VALUES (readfile('%%a'))";
)
@echo on