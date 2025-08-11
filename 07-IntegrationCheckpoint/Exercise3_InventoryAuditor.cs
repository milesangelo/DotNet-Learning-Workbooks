// 🔧 Exercise 3: Inventory Auditor (Bug Hunt)
// Purpose: Build a low-stock report using List<T> + Dictionary<TKey,TValue> and helper methods.
//
// Bugs to find (exactly 2):
// 1) Missing-key handling in dictionary causes exception
// 2) Loop bound skips last item
//
// Acceptance check (expected when fixed):
//   Low-stock (< 12): ["Brake Pads"], Count: 1

using System;
using System.Collections.Generic;

class Exercise3_InventoryAuditor
{
    static void Main()
    {
        var names = new List<string>
        {
            "Oil Filter",
            "Air Filter",
            "Spark Plugs",
            "Brake Pads",
            "Coolant",
            "Belts",
        };
        var stock = new Dictionary<string, int>
        {
            ["Oil Filter"] = 25,
            ["Air Filter"] = 15,
            ["Spark Plugs"] = 48,
            ["Brake Pads"] = 8,
            ["Coolant"] = 32,
            ["Belts"] = 12,
        };

        int threshold = 12;
        var low = new List<string>();

        // BUG 2: loop skips the last item
        for (int i = 0; i < names.Count - 1; i++)
        {
            var n = names[i];
            // BUG 1: assumes key present; should handle missing
            if (stock[n] < threshold)
            {
                low.Add(n);
            }
        }

        Console.WriteLine($"Low-stock (< {threshold}): [" + string.Join(", ", low) + "]");
        Console.WriteLine($"Count: {low.Count}");
        Console.WriteLine("Expected when fixed: Low-stock (< 12): [Brake Pads], Count: 1");
    }
}
