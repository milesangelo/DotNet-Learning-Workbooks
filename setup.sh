#!/bin/bash

# 🔧 Zero to Hero C# - Project Setup Script
# This script creates all the project folders and initializes them

echo "🔧 Setting up Zero to Hero C# Learning Workshop..."
echo ""

# Create all module directories
modules=(
    "01-VariablesAndTypes"
    "02-Conditionals"
    "03-Loops"
    "04-Methods"
    "05-DRYRefactoring"
    "06-ClassesAndObjects"
    "07-Collections"
    "08-EnumsAndSwitch"
    "09-ErrorHandling"
)

for module in "${modules[@]}"; do
    if [ ! -d "$module" ]; then
        echo "📁 Creating $module..."
        mkdir -p "$module"
        
        # Create the project file if it doesn't exist
        if [ ! -f "$module/$module.csproj" ]; then
            cat > "$module/$module.csproj" << EOF
<Project Sdk="Microsoft.NET.Sdk">

  <PropertyGroup>
    <OutputType>Exe</OutputType>
    <TargetFramework>net9.0</TargetFramework>
    <RootNamespace>$(echo $module | sed 's/[0-9]*-//')</RootNamespace>
    <ImplicitUsings>enable</ImplicitUsings>
    <Nullable>enable</Nullable>
  </PropertyGroup>

</Project>
EOF
        fi
        
        # Create a placeholder Program.cs if it doesn't exist
        if [ ! -f "$module/Program.cs" ]; then
            cat > "$module/Program.cs" << EOF
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("🔧 Module: $module");
        Console.WriteLine("📚 Check the README.md for exercises!");
        Console.WriteLine("\nThis module is not yet implemented.");
        Console.WriteLine("Start with Module 01 to learn the pattern.");
    }
}
EOF
        fi
    fi
done

# Build the solution
echo ""
echo "🔨 Building solution..."
dotnet build ZeroToHeroCSharp.sln

echo ""
echo "✅ Setup complete!"
echo ""
echo "📖 Next steps:"
echo "  1. Open this folder in VS Code"
echo "  2. Start with 01-VariablesAndTypes"
echo "  3. Open any .cs file and press F5 to run"
echo "  4. Read the README.md in each module folder"
echo ""
echo "💡 Remember: It's not about speed, it's about understanding!"
