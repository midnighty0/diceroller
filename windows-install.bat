@echo off
echo Compiling DiceRoller for Windows...
dotnet publish -c Release -p:PublishSingleFile=true -o .\build_output
echo Installing to %USERPROFILE%\diceroller...
mkdir "%USERPROFILE%\diceroller"
move .\build_output\DiceRoller.exe "%USERPROFILE%\diceroller\"
rmdir /s /q .\build_output
echo.
echo Install complete!
