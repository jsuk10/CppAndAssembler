@csc %1
@ildasm /out=%~n1.il %~n1.exe
@del %~n1.exe
@del %~n1.res
@copy %1 ..\Intermediate\Code
@copy %~n1.il ..\Intermediate\Code