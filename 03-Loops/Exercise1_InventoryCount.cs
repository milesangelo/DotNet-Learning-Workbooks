// 🔧 Exercise 1: Fix the Inventory Counter
//
// This inventory counting system is broken in multiple ways!
// It has classic loop errors that cause crashes, infinite loops,
// and wrong results. Your job: make it actually work.
//
// BUGS TO FIX:
// 1. Off-by-one errors (most common loop bug!)
// 2. Infinite loops that will freeze the program
// 3. Wrong loop types for the task
// 4. Break/continue used incorrectly
// 5. Array bounds violations
// 6. Logic errors in counting and accumulation

using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("=== Auto Parts Inventory Counter (BROKEN) ===\n");
        
        // Sample inventory data
        string[] partNames = { "Oil Filter", "Air Filter", "Spark Plugs", "Brake Pads", "Coolant", "Belts" };
        int[] stockCounts = { 25, 15, 48, 8, 32, 12 };
        double[] unitPrices = { 12.99, 8.50, 3.25, 45.00, 15.75, 22.50 };
        bool[] isLowStock = { false, true, false, true, false, true };
        
        Console.WriteLine("🔍 Running inventory checks...\n");
        
        // PROBLEM 1: Off-by-one error - will crash!
        Console.WriteLine("--- All Parts List ---");
        for (int i = 0; i <= partNames.Length; i++)  // BUG: <= should be <
        {
            Console.WriteLine($"{i + 1}. {partNames[i]} - Stock: {stockCounts[i]}");
        }
        
        // PROBLEM 2: Infinite loop disaster!
        Console.WriteLine("\n--- Low Stock Alert ---");
        int checkIndex = 0;
        while (checkIndex < isLowStock.Length)
        {
            if (isLowStock[checkIndex])
            {
                Console.WriteLine($"⚠️ {partNames[checkIndex]} is low on stock!");
            }
            // BUG: Forgot to increment checkIndex! This will run forever!
        }
        
        // PROBLEM 3: Wrong loop type choice
        Console.WriteLine("\n--- Total Value Calculation ---");
        double totalValue = 0;
        int valueIndex = 0;
        while (valueIndex < stockCounts.Length)  // BUG: for loop would be better
        {
            totalValue += stockCounts[valueIndex] * unitPrices[valueIndex];
            valueIndex++;
        }
        Console.WriteLine($"Total inventory value: ${totalValue:F2}");
        
        // PROBLEM 4: Break used incorrectly
        Console.WriteLine("\n--- Expensive Items Search ---");
        for (int i = 0; i < unitPrices.Length; i++)
        {
            if (unitPrices[i] < 20.00)
            {
                break;  // BUG: This exits completely instead of skipping cheap items!
            }
            Console.WriteLine($"Expensive: {partNames[i]} - ${unitPrices[i]}");
        }
        
        // PROBLEM 5: Continue logic error
        Console.WriteLine("\n--- Available Parts (In Stock) ---");
        for (int i = 0; i < stockCounts.Length; i++)
        {
            if (stockCounts[i] > 0)
            {
                continue;  // BUG: This skips items that ARE in stock!
            }
            Console.WriteLine($"✓ {partNames[i]} - {stockCounts[i]} units");
        }
        
        // PROBLEM 6: Array bounds and logic mixing
        Console.WriteLine("\n--- Stock Status Report ---");
        for (int i = 1; i <= partNames.Length; i++)  // BUG: Starting at 1, going to Length
        {
            // BUG: Using i as array index when it starts at 1
            string status = stockCounts[i] < 10 ? "LOW" : "OK";
            Console.WriteLine($"{partNames[i]}: {stockCounts[i]} units - {status}");
        }
        
        // PROBLEM 7: Nested loop nightmare
        Console.WriteLine("\n--- Finding Parts Under $20 ---");
        bool foundAffordable = false;
        for (int outer = 0; outer < partNames.Length; outer++)
        {
            for (int inner = 0; inner < unitPrices.Length; inner++)
            {
                // BUG: Comparing wrong indices! Should be same index
                if (unitPrices[inner] < 20.00)
                {
                    Console.WriteLine($"Affordable: {partNames[outer]}");
                    foundAffordable = true;
                    break;  // BUG: Only breaks inner loop, outer continues
                }
            }
        }
        
        // PROBLEM 8: Do-while used inappropriately
        Console.WriteLine("\n--- Reorder Recommendations ---");
        int reorderIndex = 0;
        do
        {
            if (stockCounts[reorderIndex] < 15)
            {
                Console.WriteLine($"Reorder: {partNames[reorderIndex]}");
            }
            reorderIndex++;
        } while (reorderIndex <= stockCounts.Length);  // BUG: <= instead of <, also do-while unnecessary
        
        // PROBLEM 9: Accumulation error
        Console.WriteLine("\n--- Low Stock Count ---");
        int lowStockCount = 0;
        foreach (bool lowStock in isLowStock)
        {
            if (lowStock)
            {
                lowStockCount = 1;  // BUG: Setting to 1 instead of incrementing!
            }
        }
        Console.WriteLine($"Items with low stock: {lowStockCount}");
        
        // PROBLEM 10: Performance disaster with nested loops
        Console.WriteLine("\n--- Cross-Reference Check (This will be slow!) ---");
        for (int i = 0; i < partNames.Length; i++)
        {
            for (int j = 0; j < partNames.Length; j++)
            {
                for (int k = 0; k < partNames.Length; k++)
                {
                    // BUG: Triple nested loop for no good reason!
                    // This runs 6³ = 216 times for just 6 items!
                    if (i == j && j == k)  // Only true when all equal
                    {
                        Console.WriteLine($"Found match: {partNames[i]}");
                    }
                }
            }
        }
        
        Console.WriteLine("\n❌ If you see this message, you got lucky!");
        Console.WriteLine("This code has many bugs that should prevent it from running.");
    }
}

/*
🐛 DEBUGGING GUIDE:

1. OFF-BY-ONE ERRORS:
   ✅ for (int i = 0; i < array.Length; i++)  // Correct
   ❌ for (int i = 0; i <= array.Length; i++) // Crashes
   ❌ for (int i = 1; i <= array.Length; i++) // Wrong indices

2. INFINITE LOOPS:
   Always ask: "What makes this condition false?"
   Common mistake: forgetting to increment counter

3. CHOOSING LOOP TYPES:
   • for: When you know exact number of iterations
   • while: When condition-based (don't know count)
   • do-while: When you need at least one iteration
   • foreach: When processing all items in collection

4. BREAK vs CONTINUE:
   • break: Exit loop immediately
   • continue: Skip to next iteration
   • Make sure you understand which loop they affect!

5. ARRAY INDEXING:
   Arrays start at 0, end at Length-1
   Valid indices: 0, 1, 2, ..., Length-1

6. NESTED LOOPS:
   Be careful! O(n²) or O(n³) can be very slow
   Ask: "Do I really need nested loops?"

🎯 YOUR MISSION:
1. Fix all compiler errors first
2. Test with different data
3. Verify counting logic is correct
4. Ensure no infinite loops
5. Choose appropriate loop types
6. Make the output make sense

💡 TESTING TIP:
Add some Console.WriteLine statements to trace what's happening
in your loops, especially for the problematic ones!
*/
