// 🔧 Exercise 1: Inventory List (Bug Hunt)
// Purpose: Convert array-style operations to List<T> and perform safe inserts/removes.
//
// Bugs to find (exactly 2):
// 1) Inserts at off-by-one index (wrong position)
// 2) Removes while iterating with foreach (invalid operation)
//
// Acceptance check (expected final order):
//   ["OF-001", "AF-456", "SP-123"]

using System;
using System.Collections.Generic;

class Exercise1_InventoryList
{
    static void Main()
    {
        Console.WriteLine("=== Inventory List ===\n");

        var parts = new List<string> { "OF-001", "SP-123" };

        // Insert "AF-456" between OF-001 and SP-123 (index 1)
        parts.Insert(2, "AF-456"); // BUG 1: wrong index

        // Remove any code starting with "SP" safely
        foreach (var code in parts) // BUG 2: modifying during foreach
        {
            if (code.StartsWith("SP", StringComparison.OrdinalIgnoreCase))
            {
                parts.Remove(code);
            }
        }

        Console.WriteLine(string.Join(", ", parts));
        Console.WriteLine("Expected when fixed: OF-001, AF-456, SP-123");
    }
}
