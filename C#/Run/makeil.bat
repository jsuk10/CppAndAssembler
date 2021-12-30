@echo off

IF exist %1 (
    csc %1
    ildasm /out=%~n1.il %~n1.exe
    copy %1 ..\Intermediate\Code
    copy %~n1.il ..\Intermediate\Code
    del %~n1.res
    del %~n1.il
    %~n1.exe
    del %~n1.exe
) ELSE  (
    echo "is not exist." 
)