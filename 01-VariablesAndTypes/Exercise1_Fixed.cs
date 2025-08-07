// 🔧 Exercise 1: SOLUTION - Fixed Variable Declarations
// 
// Here's the corrected version with explanations of each fix.
// Compare this to your solution!

using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("=== Auto Shop Variables (FIXED) ===\n");

        // Fix 1: Use correct types for the data
        int boltsInStock = 150;  // ✅ Counting items = int
        string customerName = "Mike's Auto";  // ✅ Text = string
        double partPrice = 45.99;  // ✅ Money with decimals = double (or decimal for money)
        
        // Fix 2: Initialize variables before use
        int orderCount = 0;  // ✅ Always initialize!
        Console.WriteLine($"Orders today: {orderCount}");
        
        // Fix 3: Follow C# naming conventions
        int customerAge = 35;  // ✅ camelCase for variables
        string partNumber = "AB-123";  // ✅ camelCase, not snake_case
        double secondDiscount = 0.15;  // ✅ Can't start with number, spell it out
        
        // Fix 4: var needs initialization
        var mysteryValue = 42;  // ✅ var can infer type from initialization
        
        // Fix 5: Use const for values that never change
        const double TAX_RATE = 0.0875;  // ✅ Constants in UPPER_CASE
        const int MAX_ITEMS_PER_ORDER = 100;  // ✅ Business rules as constants
        
        // Fix 6: Use numeric types for math
        int hoursWorked = 8;  // ✅ Hours as number
        double hourlyRate = 45.0;  // ✅ Rate as double
        double totalPay = hoursWorked * hourlyRate;  // ✅ Now math works!
        
        Console.WriteLine($"Bolts: {boltsInStock}");
        Console.WriteLine($"Customer: {customerName}");
        Console.WriteLine($"Part Price: ${partPrice:F2}");  // F2 = 2 decimal places
        Console.WriteLine($"Total Pay: ${totalPay:F2}");
        
        // Fix 7: Check for null before using
        string? invoiceNumber = null;  // Explicitly nullable
        int invoiceLength = invoiceNumber?.Length ?? 0;  // ✅ Null-safe with ?? operator
        Console.WriteLine($"Invoice length: {invoiceLength}");
        
        Console.WriteLine("\n✅ All variables fixed! Great job!");
        
        // Bonus: Show the tax calculation
        double totalWithTax = partPrice * (1 + TAX_RATE);
        Console.WriteLine($"\nPart with tax: ${totalWithTax:F2}");
    }
}

/* 
🔑 KEY LESSONS:

1. CHOOSE THE RIGHT TYPE
   - int: Whole numbers (counts, ages, quantities)
   - double: Decimals (measurements, percentages)
   - decimal: Money (when precision matters)
   - string: Text
   - bool: True/false

2. NAMING CONVENTIONS
   - Variables: camelCase (startTime, partNumber)
   - Constants: UPPER_CASE (MAX_SPEED, TAX_RATE)
   - No spaces, no starting with numbers

3. ALWAYS INITIALIZE
   - Prevents "use of unassigned variable" errors
   - Makes your intent clear
   - Safer code

4. USE CONST FOR FIXED VALUES
   - Tax rates, fees, limits
   - Prevents accidental changes
   - Makes code more maintainable

5. NULL SAFETY
   - Use ? for nullable types
   - Check with ?. or ?? operators
   - Never assume a value exists
*/
