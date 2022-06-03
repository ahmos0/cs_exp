@rem main02test.bat
@echo off

main02
echo %errorlevel%
echo 「main02.exe」の呼び出し結果です

main02 a
echo %errorlevel%
echo 「main02.exe a」の呼び出し結果です

main02 20 30
echo %errorlevel%
echo 「main02.exe 20 30」の呼び出し結果です

main02 30
echo %errorlevel%
echo 「main02.exe 30」の呼び出し結果です