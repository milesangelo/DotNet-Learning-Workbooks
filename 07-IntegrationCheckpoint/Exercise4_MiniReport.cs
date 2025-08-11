// 🔧 Exercise 4: Mini Report (Bug Hunt)
// Purpose: Aggregate work orders into a mini report by customer.
//
// Bugs to find (exactly 2):
// 1) Grouping by wrong key (uses order Id instead of Customer)
// 2) Totals summed with int instead of decimal
//
// Acceptance check (expected when fixed):
//   Per-customer totals and grand total match expected in comments (see output).

using System;
using System.Collections.Generic;
using System.Linq;

class Exercise4_MiniReport
{
    record WorkOrder(int Id, string Customer, decimal Amount);

    static void Main()
    {
        var orders = new List<WorkOrder>
        {
            new(1, "Alice", 120.50m),
            new(2, "Bob", 89.99m),
            new(3, "Alice", 45.00m),
            new(4, "Bob", 30.00m),
        };

        // BUG 1: wrong grouping key
        var groups = orders.GroupBy(o => o.Id);

        // BUG 2: sum into int
        int grand = 0;
        foreach (var g in groups)
        {
            var total = g.Sum(o => (int)o.Amount);
            grand += total;
            Console.WriteLine($"{g.Key}: ${total}");
        }
        Console.WriteLine($"Grand: ${grand}");

        Console.WriteLine(
            "Expected when fixed:\n  Alice: $165.50\n  Bob: $119.99\n  Grand: $285.49"
        );
    }
}
