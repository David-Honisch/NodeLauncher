@echo off
cls
.\bin\LC2Logo.exe
echo %time%
timeout 1 > NUL
setLocal EnableDelayedExpansion
Set "mime=xml"
Set "exportdir=export\file"
Set "TOCSV=bin\2csv.bat"
Set "CSVTOSQLITE=bin\csv2sqlite.bat"
Set "LINKCSV=bin\linkcsv.bat"
Set "PRG=.\bin\sqlite3.exe"
set "sexec=.\bin\sqlite3.exe"
Set "db=lc"
Set "dbfile=lc.db"
set "dbtempfile=templc.db"
set "table=datalob"
set "temptable=datalob"
SET "QUERY=select rowid, data from %temptable% limit 1000000;"
set hr=%time:~0,2%
setLocal EnableDelayedExpansion
cls
dir /b /s *.nfo > %exportdir%\export.csv
echo %sexec% %dbfile% "create table IF NOT EXISTS %table% ( id INTEGER PRIMARY KEY   AUTOINCREMENT, data text);"
%PRG% %dbfile%  ".read sql.sql"
%sexec% %dbfile% "CREATE TABLE %table%(name TEXT, type TEXT, img BLOB);"
for /R %exportdir% %%a in (*.csv) do (
for /f "usebackq tokens=1-1 delims=," %%b in (%%a) do (
echo %PRG% %dbfile% "INSERT INTO %table%(name,type,img) VALUES('%%~nb','%mime%',readfile('%%b'));"
%PRG% %dbfile% "INSERT INTO %table%(name,type,img) VALUES('%%~nb','%%~xb',readfile('%%b'));"
rem pause 
	)
)
%PRG% %dbfile% "SELECT writefile('~autorun.inf',img) FROM  %table% WHERE name='autorun';"
pause
@echo on