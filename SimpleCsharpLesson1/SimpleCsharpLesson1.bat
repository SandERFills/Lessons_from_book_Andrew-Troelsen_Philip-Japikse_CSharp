@echo off
rem Пакетный файл для приложения SimpeCsharpApp.exe
rem в котором захватывается возвращаемое им значение.
C:\Users\salag\source\repos\SimpleCsharpLesson1\SimpleCsharpLesson1\bin\Debug\SimpleCsharpLesson1.exe
@if "%ERRORLEVEL%" == "0" goto success
:fail
rem Приложение потерпело неудачу,
echo This application has failed!
echo return value = %ERRORLEVEL%
goto end
:success
rem Приложение успешно завершено,
echo This application has succeeded!
echo return value = %ERRORLEVEL%
goto end
:end
rem Работа сделана,
echo All Done.