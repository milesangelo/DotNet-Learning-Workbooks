// 🔧 Exercise 1: Fix the Variable Declarations
// 
// This program is FULL of variable problems. Your job:
// 1. Fix all the compiler errors
// 2. Make the variable names follow C# conventions
// 3. Use the right types for the right data
//
// Run this first to see all the errors, then fix them one by one.
// Think: "What type of storage bin should this data go in?"

using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("=== Auto Shop Variable Disaster ===\n");

        // Problem 1: Wrong types
        string boltsInStock = 150;  // Should this really be a string?
        int customerName = "Mike's Auto";  // An int for a name?
        bool partPrice = 45.99;  // A bool for a price?
        
        // Problem 2: Uninitialized variables (will cause compiler error)
        int orderCount;
        Console.WriteLine($"Orders today: {orderCount}");
        
        // Problem 3: Bad naming conventions
        int CustomerAge = 35;  // Should start with lowercase
        string part_number = "AB-123";  // Should use camelCase, not snake_case
        double 2ndDiscount = 0.15;  // Can't start with a number!
        
        // Problem 4: Using var incorrectly
        var mysteryValue;  // var needs initialization!
        mysteryValue = 42;
        
        // Problem 5: Constants that should be constants
        double taxRate = 0.0875;  // This never changes, should be const
        int maxItemsPerOrder = 100;  // This is a business rule, should be const
        
        // Problem 6: Type confusion with math
        string hoursWorked = "8";
        string hourlyRate = "45";
        string totalPay = hoursWorked * hourlyRate;  // Can't multiply strings!
        
        Console.WriteLine($"Bolts: {boltsInStock}");
        Console.WriteLine($"Customer: {customerName}");
        Console.WriteLine($"Part Price: ${partPrice}");
        Console.WriteLine($"Total Pay: ${totalPay}");
        
        // Problem 7: Null reference waiting to happen
        string? invoiceNumber;  // This is nullable
        int invoiceLength = invoiceNumber.Length;  // Will crash at runtime!
        
        Console.WriteLine("\nIf you see this, you fixed everything!");
    }
}
