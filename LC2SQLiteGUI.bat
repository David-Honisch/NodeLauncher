@echo off
cls
.\bin\LC2Logo.exe
echo %time%
timeout 1 > NUL
setLocal EnableDelayedExpansion
Set "exportdir=export"
Set "csvdir=import"
Set "savedir=save"
set "csvdirfilename=import.csv"
Set "TOCSV=bin\2csv.bat"
Set "MSGBOX=bin\msgbox.bat"
Set "CSVTOSQLITE=bin\csv2sqlite.bat"
Set "LINKCSV=bin\linkcsv.bat"
Set "CREATECSV=bin\createcsv.bat"
Set "PRG=LC2SQLiteGUI.exe"
set "sexec=.\bin\sqlite3.exe"
set "dbfile=lc.db"
set "dbtempfile=templc.db"
set "table=url"
set "temptable=tempurls"
set "importsql=.\\LC2SQLiteGUI.sql"
set "tempimportsql=.\\LC2SQLiteGUI.util.sql"
set "dropsql=.\\bin\\droptables.sql"
rem SET "QUERY=select rowid, name from %temptable% limit 1000000;"
SET "QUERY=select name from %temptable% limit 1000000;"
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
echo Reading all files
REM dir /s /b > ./import/all.csv
REM call .\bin\createcsv.bat
echo -------------------------------------------
setlocal enabledelayedexpansion
echo -------------------------------------------
echo reset... %csvdir%\%csvdirfilename%
echo -------------------------------------------
type nul> %csvdir%\%csvdirfilename%
echo -------------------------------------------
echo running...
REM for %%i in (C D E F G H I J K L M N O P Q R S T U V W X Y Z) DO ( 
	REM @if exist %%i: ( @echo %%i )
	REM @if exist %%i: ( dir /b /s %%i:\*.* >> %csvdir%\%csvdirfilename% )
REM )
rem dir /b /s ./save/*.csv >> %csvdir%\%csvdirfilename%
echo Reset:%csvdir%\%csvdirfilename%
type nul>%csvdir%\%csvdirfilename%
echo Loop:%savedir%
for /R %savedir% %%a in (*.csv) do (
rem echo %sexec% %dbfile% ".import '%%a' %temptable%"
rem %sexec% %dbtempfile% ".import '%%a' %temptable%"
type %%a >> %csvdir%\%csvdirfilename%
)
echo -------------------------------------------
@echo off
echo Delete old database
del lc.db
echo CREATE DATABASE %sexec%
rem %sexec% %dbfile%
echo -------------------------------------------
echo read %tempimportsql%"
call %sexec% %dbtempfile% ".read %tempimportsql%"
echo -------------------------------------------
echo read %importsql%"
call %sexec% %dbfile% ".read %importsql%"
echo -------------------------------------------
for /R ./import %%a in (*.csv) do (
echo %sexec% %dbtempfile% ".import '%%a' %temptable%"
%sexec% %dbtempfile% ".import '%%a' %temptable%"
)
echo -------------------------------------------
echo RESET %csvdir%\export.csv
echo -------------------------------------------
type nul>%csvdir%\export.csv
echo -------------------------------------------
rem call %sexec% %dbfile% -csv "%QUERY%" > .\export\export.csv
call %sexec% %dbtempfile% "%QUERY%" > %csvdir%\export.csv
echo %sexec% %dbfile% ".import '%csvdir%\export.csv' %table%"
%sexec% %dbfile% ".import '%csvdir%\export.csv' %table%"
echo DROP TEMP TABLE
rem call %sexec% lc.db ".read %dropsql%"
start %PRG%
rem pause
@echo on