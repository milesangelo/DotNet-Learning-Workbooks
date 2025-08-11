using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("=== Module 07: Integration Checkpoint ===\n");
        Console.WriteLine("Run a single integrative exercise using DEBUG_EXERCISE.\n");
        Console.WriteLine("Examples:");
        Console.WriteLine(
            "  dotnet run --project 07-IntegrationCheckpoint /p:DEBUG_EXERCISE=Exercise1_QuickQuote.cs"
        );
        Console.WriteLine(
            "  dotnet run --project 07-IntegrationCheckpoint /p:DEBUG_EXERCISE=Exercise2_ServiceDaySimulator.cs"
        );
        Console.WriteLine(
            "  dotnet run --project 07-IntegrationCheckpoint /p:DEBUG_EXERCISE=Exercise3_InventoryAuditor.cs"
        );
        Console.WriteLine(
            "  dotnet run --project 07-IntegrationCheckpoint /p:DEBUG_EXERCISE=Exercise4_MiniReport.cs"
        );
    }
}
