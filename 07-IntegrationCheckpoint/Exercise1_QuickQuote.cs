// 🔧 Exercise 1: Quick Quote (Bug Hunt)
// Purpose: Compute a quote from parts, labor, and customer type.
//
// Bugs to find (exactly 2):
// 1) Money precision lost due to int casting
// 2) Applies tax before discount
//
// Acceptance check (expected when fixed):
//   Parts: [12.99, 45.00, 8.50], LaborHours: 2.0 @ $60/hr, Customer: VIP (10% off), Tax 8%
//   → Total: $135.85

using System;

class Exercise1_QuickQuote
{
    static void Main()
    {
        double[] parts = { 12.99, 45.00, 8.50 };
        double laborHours = 2.0;
        double hourlyRate = 60.0;
        string customerType = "VIP";
        double taxRate = 0.08;

        var subtotal = CalculateSubtotal(parts, laborHours, hourlyRate);
        var total = ComputeTotal(subtotal, customerType, taxRate);
        Console.WriteLine($"Total: ${total:F2}");
        Console.WriteLine("Expected when fixed: Total: $135.85");
    }

    static double CalculateSubtotal(double[] parts, double hours, double rate)
    {
        int partsSum = 0; // BUG 1: loses cents
        foreach (var p in parts)
        {
            partsSum += (int)p;
        }
        return partsSum + (hours * rate);
    }

    static double ComputeTotal(double subtotal, string customerType, double taxRate)
    {
        // BUG 2: tax before discount
        var taxed = subtotal * (1 + taxRate);
        var discounted = customerType.Equals("VIP", StringComparison.OrdinalIgnoreCase)
            ? taxed * 0.90
            : taxed;
        return Math.Round(discounted, 2);
    }
}
