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
cls
if "%hr:~0,1%" equ " " set hr=0%hr:~1,1%
echo _%date:~-4,4%%date:~-10,2%%date:~-7,2%_%hr%%time:~3,2%%time:~6,2%.zip
echo FileName: %csvfilename%
echo Creating file:%csvfilename%
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
rem dir /s /b %pattern% > %csvfilename%
if exist "launch.cmd"  (
	echo FOUND
)
for /R ./import %%a in (*.csv) do (
echo %sexec% %dbtempfile% ".import '%%a' %temptable%"
 %sexec% %dbtempfile% ".import '%%a' %temptable%"
)

copy %dbfile% "_%date:~-4,4%%date:~-10,2%%date:~-7,2%_%hr%%time:~3,2%%time:~6,2%.db"
echo copy temp database
copy .\db\%dbtempfile% .\%dbtempfile%
rem pause
%sexec% %dbtempfile% "create table IF NOT EXISTS %temptable% ( url text);"
for /R %csvdir% %%a in (*.csv) do (
echo %sexec% %dbtempfile% ".import '%%a' %temptable%"
%sexec% %dbtempfile% ".import '%%a' %temptable%"
)
echo export data to csv..
rem .\bin\sqlite3.exe %dbfile% "create table IF NOT EXISTS url ( url text);"
%sexec% %dbtempfile% "%QUERY%" > .\export\export.csv
echo create new table
%sexec% %dbfile% "create table IF NOT EXISTS url ( id INTEGER PRIMARY KEY   AUTOINCREMENT, data text, url text);"
echo CREATE DONE
echo %sexec% %dbfile% ".import '.\export\export.csv' url"
%sexec% %dbfile% ".import '.\export\export.csv' url"
rem pause
rem echo INSERT
rem %sexec% %dbfile% "INSERT INTO url(url,data) SELECT rowid, url, url FROM tempurl";
rem .\bin\sqlite3.exe %dbfile% "INSERT INTO lc.db.TABLE(url,data) SELECT rowid, url, url FROM templc.db.TABLE";
rem echo out
rem %sexec% %dbtempfile% ".dump url" | %sexec% %dbfile%
@echo on