using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("=== Module 04: Methods ===\n");
        Console.WriteLine("This module uses DEBUG_EXERCISE to run a specific exercise file.\n");
        Console.WriteLine("Examples:");
        Console.WriteLine(
            "  dotnet run --project 04-Methods /p:DEBUG_EXERCISE=Exercise1_FixSignatures.cs"
        );
        Console.WriteLine(
            "  dotnet run --project 04-Methods /p:DEBUG_EXERCISE=Exercise2_OverloadsAndDefaults.cs"
        );
        Console.WriteLine(
            "  dotnet run --project 04-Methods /p:DEBUG_EXERCISE=Exercise3_OutRefAndParams.cs"
        );
        Console.WriteLine(
            "  dotnet run --project 04-Methods /p:DEBUG_EXERCISE=Exercise4_PureFunctions.cs"
        );
    }
}
