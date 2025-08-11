// 🔧 Exercise 1: Fix Signatures — Parts Total (Bug Hunt)
// Purpose: Calculate parts total from prices with tax and a shop fee.
//
// Bugs to find (exactly 2):
// 1) CalculateSubtotal returns the wrong type/precision for money
// 2) CalculateTotal applies rounding incorrectly (floor instead of 2-decimal rounding)
//
// Acceptance checks:
//   Prices [12.99, 45.00, 8.50], taxRate 0.0875, shopFee 4.99 → Total: $77.69
//   Subtotal remains unchanged after total calculation

using System;

class Exercise1_FixSignatures
{
    static void Main()
    {
        double[] prices = { 12.99, 45.00, 8.50 };
        double taxRate = 0.0875;
        double shopFee = 4.99;

        Console.WriteLine("=== Parts Total ===\n");
        var subtotal = CalculateSubtotal(prices); // BUG 1: wrong type/precision
        var total = CalculateTotal(subtotal, taxRate, shopFee); // BUG 2: rounding

        Console.WriteLine($"Subtotal: ${subtotal}");
        Console.WriteLine($"Total:    ${total}");
        Console.WriteLine("\nExpected when fixed: Subtotal: $66.49, Total: $77.69");
    }

    // Should return a precise monetary sum
    static int CalculateSubtotal(double[] prices)
    {
        int sum = 0; // BUG 1: using int loses cents
        foreach (var p in prices)
        {
            sum += (int)p;
        }
        return sum;
    }

    // Should: total = Round2(subtotal + shopFee) then apply tax and round to 2 decimals
    static double CalculateTotal(double subtotal, double taxRate, double shopFee)
    {
        var baseAmount = subtotal + shopFee;
        // BUG 2: floor instead of rounding to 2 decimals
        var rounded = Math.Floor(baseAmount * 100) / 100.0;
        var total = rounded * (1 + taxRate);
        return total;
    }
}
