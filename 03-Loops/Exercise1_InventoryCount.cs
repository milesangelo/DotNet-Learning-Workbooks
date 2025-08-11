// 🔧 Exercise 1: End-of-Day Inventory Summary (Bug Hunt)
//
// Purpose:
//   Produce an end-of-day summary report for parts inventory.
//   The report should show total inventory value, count of low-stock items,
//   and a list of the low-stock part names.
//
// Your task:
//   This program is almost correct but contains 1–2 subtle loop/logic bugs.
//   Find and fix them so the output matches the acceptance checks below.
//
// Acceptance checks (with current sample data):
//   • Total inventory value: $1742.25
//   • Low-stock count (threshold 12): 1
//   • Low-stock items: Brake Pads
//
// Hints:
//   • Check loop bounds when iterating arrays
//   • Review the comparison used for the low-stock threshold

using System;

class Exercise1_InventoryCount
{
    static void Main()
    {
        Console.WriteLine("=== End-of-Day Inventory Summary ===\n");

        // Sample inventory data
        string[] partNames =
        {
            "Oil Filter",
            "Air Filter",
            "Spark Plugs",
            "Brake Pads",
            "Coolant",
            "Belts",
        };
        int[] stockCounts = { 25, 15, 48, 8, 32, 12 };
        double[] unitPrices = { 12.99, 8.50, 3.25, 45.00, 15.75, 22.50 };

        int reorderThreshold = 12;

        double totalValue = 0.0;
        int lowStockCount = 0;

        Console.WriteLine("--- Items ---");

        // BUG 1: Off-by-one — last item is skipped (should iterate all items)
        for (int i = 0; i < partNames.Length - 1; i++)
        {
            Console.WriteLine($"{partNames[i]}: {stockCounts[i]} in stock @ ${unitPrices[i]:F2}");
            totalValue += stockCounts[i] * unitPrices[i];

            // BUG 2: Comparison at threshold — should be strictly less than
            if (stockCounts[i] <= reorderThreshold)
            {
                lowStockCount++;
            }
        }

        Console.WriteLine("\n--- Summary ---");
        Console.WriteLine($"Total inventory value: ${totalValue:F2}");
        Console.WriteLine($"Low-stock items (< {reorderThreshold}): {lowStockCount}");

        Console.WriteLine("Low-stock list:");
        // Print low-stock names in order
        for (int i = 0; i < partNames.Length; i++)
        {
            if (stockCounts[i] < reorderThreshold)
            {
                Console.WriteLine($" • {partNames[i]}");
            }
        }

        Console.WriteLine("\nExpected (when fixed):");
        Console.WriteLine("  Total inventory value: $1742.25");
        Console.WriteLine("  Low-stock items (< 12): 1");
        Console.WriteLine("  Low-stock list: Brake Pads");
    }
}
