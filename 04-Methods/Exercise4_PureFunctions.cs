// 🔧 Exercise 4: Pure Functions — Pricing Rules (Bug Hunt)
// Purpose: Keep pricing methods pure and apply discount then tax.
//
// Bugs to find (exactly 2):
// 1) Uses a static cache that mutates state (side effect)
// 2) Applies tax before discount in ComputeFinalPrice
//
// Acceptance checks:
//   ComputeFinalPrice(100, "VIP", 0.10) → $99.00
//   Re-running with same inputs returns same output; no global state changes

using System;
using System.Collections.Generic;

class Exercise4_PureFunctions
{
    // BUG 1: Static cache introduces statefulness
    static Dictionary<string, double> Cache = new();

    static void Main()
    {
        Console.WriteLine("=== Pure Pricing ===\n");

        var price1 = ComputeFinalPrice(100, "VIP", 0.10);
        var price2 = ComputeFinalPrice(100, "VIP", 0.10);

        Console.WriteLine($"Run #1: ${price1:F2}");
        Console.WriteLine($"Run #2: ${price2:F2}");
        Console.WriteLine("\nExpected when fixed: Run #1: $99.00, Run #2: $99.00");
    }

    static double ApplyDiscount(double price, string customerType)
    {
        string key = $"{price}:{customerType}";
        if (Cache.TryGetValue(key, out var cached)) // BUG 1: caching side effect
            return cached;

        double discounted = customerType.ToLowerInvariant() switch
        {
            "vip" => price * 0.90,
            "regular" => price * 0.95,
            _ => price,
        };
        Cache[key] = discounted; // BUG 1: stateful mutation
        return discounted;
    }

    static double ApplyTax(double price, double taxRate)
    {
        return Math.Round(price * (1 + taxRate), 2);
    }

    static double ComputeFinalPrice(double basePrice, string customerType, double taxRate)
    {
        // BUG 2: applies tax before discount
        var taxed = ApplyTax(basePrice, taxRate);
        var finalPrice = ApplyDiscount(taxed, customerType);
        return finalPrice;
    }
}
