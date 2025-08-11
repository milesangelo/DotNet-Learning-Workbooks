// 🔧 Exercise 3: Weekly Work Summary (Bug Hunt)
//
// Purpose:
//   Generate a weekly summary of completed work orders and revenue.
//   Print per-day details, then totals and averages.
//
// Your task:
//   This program is almost correct but contains 1–2 subtle loop/logic bugs.
//   Find and fix them so the output matches the acceptance checks below.
//
// Acceptance checks (with current sample data):
//   • Total Orders: 71
//   • Total Revenue: $3195.00
//   • Average Orders/Day: 10.14
//
// Hints:
//   • Verify the loop index range for 7-day data
//   • Check where accumulators are initialized

using System;

class Exercise3_RefactorDuplication
{
    static void Main()
    {
        Console.WriteLine("=== Weekly Work Summary ===\n");

        string[] days = { "Mon", "Tue", "Wed", "Thu", "Fri", "Sat", "Sun" };
        int[] workOrdersPerDay = { 12, 15, 10, 18, 9, 7, 0 };
        double[] revenuePerDay = { 540.00, 675.00, 450.00, 810.00, 405.00, 315.00, 0.00 };

        int totalOrders = 0;
        double totalRevenue = 0.0;

        Console.WriteLine("Day  Orders  Revenue");
        Console.WriteLine("---------------------");

        // BUG 1: Starts at index 1, skipping Monday
        for (int i = 1; i < days.Length; i++)
        {
            // BUG 2: Accumulators reset inside loop
            totalOrders = 0;
            totalRevenue = 0.0;

            Console.WriteLine(
                $"{days[i], -3}  {workOrdersPerDay[i], 6}  ${revenuePerDay[i], 7:F2}"
            );
            totalOrders += workOrdersPerDay[i];
            totalRevenue += revenuePerDay[i];
        }

        double averageOrdersPerDay = totalOrders / 7.0;

        Console.WriteLine("\n--- Totals ---");
        Console.WriteLine($"Total Orders: {totalOrders}");
        Console.WriteLine($"Total Revenue: ${totalRevenue:F2}");
        Console.WriteLine($"Average Orders/Day: {averageOrdersPerDay:F2}");

        Console.WriteLine("\nExpected (when fixed):");
        Console.WriteLine("  Total Orders: 71");
        Console.WriteLine("  Total Revenue: $3195.00");
        Console.WriteLine("  Average Orders/Day: 10.14");
    }
}
