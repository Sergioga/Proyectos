SET FECHA=%DATE:~3,2%%DATE:~0,2%%DATE:~6,4%
cd "C:\Program Files\7-Zip\"

IF EXIST "C:\Users\Mephist\Documents\Visual Studio 2013\Projects\db_%FECHA%" GOTO :upd
IF NOT EXIST "C:\Users\Mephist\Documents\Visual Studio 2013\Projects\db_%FECHA%" GOTO :com

:com
7z.exe a -tzip "C:\Users\Mephist\Documents\Visual Studio 2013\Projects\backups\db_%FECHA%" "C:\Users\Mephist\Documents\Visual Studio 2013\Projects\db"
:upd
del "C:\Users\Mephist\Documents\Visual Studio 2013\Projects\backups\db_%FECHA%.zip"
7z.exe a -tzip "C:\Users\Mephist\Documents\Visual Studio 2013\Projects\backups\db_%FECHA%" "C:\Users\Mephist\Documents\Visual Studio 2013\Projects\db"


