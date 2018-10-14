@echo off
set source=%1
set target=%2
echo JSON2CSV call node LC2json2csv.js %source% %target%
REM pause
call node LC2json2csv.js %source% %target%
rem pause
@echo on