// 🔧 Exercise 1: Fix the Variable Declarations
// 
// This program is FULL of variable problems. Your job:
// 1. Fix all the compiler errors
// 2. Make the variable names follow C# conventions
// 3. Use the right types for the right data
//
// 🎯 DEBUGGING STRATEGY - Learn to Focus on ONE Problem at a Time:
// 
// Since this file has many errors, you can't run it in the debugger yet.
// Here's how to tackle it like a pro mechanic:
//
// STEP 1: Comment out EVERYTHING below "Problem 1" (lines 24-56)
//         Focus ONLY on fixing the first 3 variable declarations
//         Press F5 to debug - if it runs, you fixed Problem 1!
//
// STEP 2: Uncomment Problem 2 (lines 24-26)
//         Fix the uninitialized variable issue
//         Press F5 again - does it run? Great, move on!
//
// STEP 3: Continue this pattern - uncomment one problem at a time
//         Fix it, test it, then move to the next
//
// 💡 WHY THIS WORKS:
// - You eliminate distractions and focus on ONE thing
// - Each success builds confidence
// - You can quickly isolate what broke
// - This is how real developers debug complex problems
//
// Think: "What type of storage bin should this data go in?"

using System;

class Exercise1_Broken
{
    static void Main()
    {
        Console.WriteLine("=== Auto Shop Variable Disaster ===\n");

        // ===== PROBLEM 1: Wrong types (START HERE!) =====
        // 🎯 FOCUS: Fix these 3 lines, then comment out everything below this section
        string boltsInStock = 150;  // Should this really be a string?
        int customerName = "Mike's Auto";  // An int for a name?
        bool partPrice = 45.99;  // A bool for a price?
        // ===== END PROBLEM 1 =====

        /* ===== COMMENT OUT FROM HERE WHEN STARTING =====
        
        // ===== PROBLEM 2: Uninitialized variables =====
        // 🎯 FOCUS: Variables must be given a value before use
        int orderCount;
        Console.WriteLine($"Orders today: {orderCount}");
        // ===== END PROBLEM 2 =====

        // ===== PROBLEM 3: Bad naming conventions =====
        // 🎯 FOCUS: Variable names should follow C# conventions
        int CustomerAge = 35;  // Should start with lowercase
        string part_number = "AB-123";  // Should use camelCase, not snake_case
        // double 2ndDiscount = 0.15;  // Can't start with a number! (This one is too broken - skip it)
        // ===== END PROBLEM 3 =====

        // ===== PROBLEM 4: Using var incorrectly =====
        // 🎯 FOCUS: var must be initialized when declared
        // var mysteryValue;  // var needs initialization! (This one is too broken - skip it)
        // mysteryValue = 42;
        // ===== END PROBLEM 4 =====

        // ===== PROBLEM 5: Constants that should be constants =====
        // 🎯 FOCUS: Values that never change should be const
        double taxRate = 0.0875;  // This never changes, should be const
        int maxItemsPerOrder = 100;  // This is a business rule, should be const
        // ===== END PROBLEM 5 =====

        // ===== PROBLEM 6: Type confusion with math =====
        // 🎯 FOCUS: Can't do math with strings - need numbers
        string hoursWorked = "8";
        string hourlyRate = "45";
        string totalPay = hoursWorked * hourlyRate;  // Can't multiply strings!
        // ===== END PROBLEM 6 =====

        Console.WriteLine($"Bolts: {boltsInStock}");
        Console.WriteLine($"Customer: {customerName}");
        Console.WriteLine($"Part Price: ${partPrice}");
        Console.WriteLine($"Total Pay: ${totalPay}");

        // ===== PROBLEM 7: Null reference waiting to happen =====
        // 🎯 FOCUS: Check for null before using nullable variables
        string? invoiceNumber;  // This is nullable
        int invoiceLength = invoiceNumber.Length;  // Will crash at runtime!
        // ===== END PROBLEM 7 =====

        ===== COMMENT OUT TO HERE WHEN STARTING ===== */

        Console.WriteLine("\nIf you see this, you fixed everything!");
    }
}
