// 🔧 Exercise 2: Service Dictionary (Bug Hunt)
// Purpose: Map service codes to prices with robust lookups.
//
// Bugs to find (exactly 2):
// 1) Looks up keys without normalizing case
// 2) Missing-key handling throws exception instead of returning null/friendly message
//
// Acceptance checks:
//   Lookup("BRAKE") → 149.99
//   Lookup("unknown") → prints friendly message, returns null

using System;
using System.Collections.Generic;

class Exercise2_ServiceDictionary
{
    static void Main()
    {
        Console.WriteLine("=== Service Price Lookup ===\n");
        var dict = BuildPriceMap();

        Console.WriteLine(Lookup(dict, "BRAKE")?.ToString("F2") ?? "(not found)");
        Console.WriteLine(Lookup(dict, "unknown")?.ToString("F2") ?? "(not found)");
        Console.WriteLine("Expected when fixed:\n  149.99\n  (not found)");
    }

    static Dictionary<string, double> BuildPriceMap()
    {
        return new Dictionary<string, double>
        {
            ["oil_change"] = 29.99,
            ["brake"] = 149.99,
            ["tire_rotation"] = 19.99,
            ["inspection"] = 35.00,
        };
    }

    static double? Lookup(Dictionary<string, double> map, string code)
    {
        // BUG 1: no normalization of key casing
        // BUG 2: throws if missing
        return map[code];
    }
}
