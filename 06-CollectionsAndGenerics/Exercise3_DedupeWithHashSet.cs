// 🔧 Exercise 3: Dedupe with HashSet (Bug Hunt)
// Purpose: Remove duplicate part codes while preserving the first-seen order.
//
// Bugs to find (exactly 2):
// 1) HashSet use loses original order in output
// 2) Dedupe should be case-insensitive
//
// Acceptance check:
//   Input: ["OF-001", "BP-205", "of-001", "SP-123"] → Output: ["OF-001", "BP-205", "SP-123"]

using System;
using System.Collections.Generic;

class Exercise3_DedupeWithHashSet
{
    static void Main()
    {
        Console.WriteLine("=== Dedupe Parts ===\n");

        var input = new List<string> { "OF-001", "BP-205", "of-001", "SP-123" };
        var output = Dedupe(input);
        Console.WriteLine(string.Join(", ", output));
        Console.WriteLine("Expected when fixed: OF-001, BP-205, SP-123");
    }

    static List<string> Dedupe(List<string> codes)
    {
        // BUG 1: using HashSet iteration (unordered)
        var set = new HashSet<string>();
        foreach (var c in codes)
        {
            // BUG 2: case-sensitive compare
            set.Add(c);
        }
        return new List<string>(set);
    }
}
