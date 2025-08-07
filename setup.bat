@echo off
REM 🔧 Zero to Hero C# - Project Setup Script (Windows)
REM This script creates all the project folders and initializes them

echo 🔧 Setting up Zero to Hero C# Learning Workshop...
echo.

REM Create all module directories
set modules=01-VariablesAndTypes 02-Conditionals 03-Loops 04-Methods 05-DRYRefactoring 06-ClassesAndObjects 07-Collections 08-EnumsAndSwitch 09-ErrorHandling

for %%m in (%modules%) do (
    if not exist "%%m" (
        echo 📁 Creating %%m...
        mkdir "%%m"
    )
)

REM Build the solution
echo.
echo 🔨 Building solution...
dotnet build ZeroToHeroCSharp.sln

echo.
echo ✅ Setup complete!
echo.
echo 📖 Next steps:
echo   1. Open this folder in VS Code
echo   2. Start with 01-VariablesAndTypes
echo   3. Open any .cs file and press F5 to run
echo   4. Read the README.md in each module folder
echo.
echo 💡 Remember: It's not about speed, it's about understanding!
pause
