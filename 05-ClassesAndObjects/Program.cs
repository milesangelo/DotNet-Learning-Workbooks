using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("=== Module 05: Classes & Objects ===\n");
        Console.WriteLine("This module uses DEBUG_EXERCISE to run a specific exercise file.\n");
        Console.WriteLine("Examples:");
        Console.WriteLine(
            "  dotnet run --project 05-ClassesAndObjects /p:DEBUG_EXERCISE=Exercise1_PartModel.cs"
        );
        Console.WriteLine(
            "  dotnet run --project 05-ClassesAndObjects /p:DEBUG_EXERCISE=Exercise2_CustomerValidation.cs"
        );
        Console.WriteLine(
            "  dotnet run --project 05-ClassesAndObjects /p:DEBUG_EXERCISE=Exercise3_WorkOrderBehavior.cs"
        );
        Console.WriteLine(
            "  dotnet run --project 05-ClassesAndObjects /p:DEBUG_EXERCISE=Exercise4_ShopComposition.cs"
        );
    }
}
