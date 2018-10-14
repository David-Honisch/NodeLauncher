@echo off
cls
.\bin\LC2Logo.exe
echo %time%
timeout 1 > NUL
setLocal EnableDelayedExpansion
echo start "%1"
Set "dbfile=lc.db"
Set "exportdir=export"
Set "csvdir=import"
Set "csvfile=import.csv"
Set "csvfilename=%csvdir%\%csvfile%"
Set "csvdirfilename=%csvdir%\_dir_%csvfile%"
Set "pattern=*.exe"
set sexec=".\sqlite3.exe"
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
if not exist link  (
	mkdir link
) else (
	echo link exists
)
for /R ./import %%a in (*.csv) do (
echo %sexec% %dbtempfile% ".import '%%a' %temptable%"
%sexec% %dbtempfile% ".import '%%a' %temptable%"
for /f "usebackq tokens=1-4 delims=," %%b in (%%a) do (
 if not "%%~xb" == ".lnk" (
 echo .\LC2LinkCLI.exe -n "%%~nb" -t ".\link\%%~na%%~xb.lnk" -s "%%b"
 .\bin\LC2LinkCLI.exe -n "%%~nb" -t ".\link\%%~na%%~xb.lnk" -s "%%b"
 	)
)


)
echo quit
quit
@echo on