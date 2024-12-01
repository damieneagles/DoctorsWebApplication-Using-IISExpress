ECHO Copying DACPAC...
REM cd C:\[Solutions]\[2023DoctorsWebApplication]\DoctorsWebApplication
xcopy /e /y /-I DoctorsDatabase\bin\release\DoctorsDatabase.dacpac DoctorsWebApplication\bin\Release\net9.0\publish\DoctorsDatabase.dacpac

