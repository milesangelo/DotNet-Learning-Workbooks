using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("=== Module 06: Collections & Generics ===\n");
        Console.WriteLine("This module uses DEBUG_EXERCISE to run a specific exercise file.\n");
        Console.WriteLine("Examples:");
        Console.WriteLine(
            "  dotnet run --project 06-CollectionsAndGenerics /p:DEBUG_EXERCISE=Exercise1_InventoryList.cs"
        );
        Console.WriteLine(
            "  dotnet run --project 06-CollectionsAndGenerics /p:DEBUG_EXERCISE=Exercise2_ServiceDictionary.cs"
        );
        Console.WriteLine(
            "  dotnet run --project 06-CollectionsAndGenerics /p:DEBUG_EXERCISE=Exercise3_DedupeWithHashSet.cs"
        );
        Console.WriteLine(
            "  dotnet run --project 06-CollectionsAndGenerics /p:DEBUG_EXERCISE=Exercise4_GenericRepository.cs"
        );
    }
}
