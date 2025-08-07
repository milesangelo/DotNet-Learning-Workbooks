// 🔧 Exercise 2: Debug the Auto Shop Inventory
//
// This inventory tracker has multiple bugs related to types and scope.
// The logic is mostly right, but the types are all wrong!
// 
// YOUR MISSION:
// 1. Fix all type-related errors
// 2. Fix variable scope issues
// 3. Make the calculations actually work
// 4. Add proper type conversions where needed

using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("=== Buggy Auto Shop Inventory System ===\n");
        
        // Inventory counts (something's wrong with these types...)
        string oilFilters = "24";
        string airFilters = "18";
        string sparkPlugs = "156";
        
        // Prices (stored incorrectly)
        int oilFilterPrice = "12.99";  // Compiler error!
        int airFilterPrice = "18.50";
        int sparkPlugPrice = "4.25";
        
        // Calculate total inventory value (this math won't work...)
        string totalOilValue = oilFilters * oilFilterPrice;
        string totalAirValue = airFilters * airFilterPrice;
        string totalSparkValue = sparkPlugs * sparkPlugPrice;
        
        // Customer order
        Console.WriteLine("Customer Order:");
        bool orderOilFilters = "yes";  // Wrong type!
        int quantityOil = "3";
        
        // Try to check if we have enough (broken comparison)
        if (oilFilters >= quantityOil)  // Can't compare strings like this!
        {
            Console.WriteLine("✓ Oil filters in stock");
            // Update inventory (this subtraction won't work)
            oilFilters = oilFilters - quantityOil;
        }
        
        // Calculate order total
        {
            // Scope problem - these variables die in this block!
            double orderSubtotal = quantityOil * oilFilterPrice;
            double taxAmount = orderSubtotal * 0.08;
        }
        
        // This won't compile - variables are out of scope!
        double orderTotal = orderSubtotal + taxAmount;
        
        // Part lookup system (using wrong types)
        int partNumber = 12345;  // Should this be a string?
        bool stockLevel = 45;  // A bool for quantity?
        
        // Concatenation vs Addition confusion
        string code1 = "10";
        string code2 = "20";
        string combinedCode = code1 + code2;  // Will this give us 30 or "1020"?
        Console.WriteLine($"Combined code: {combinedCode}");
        
        // Integer division problem
        int totalParts = 100;
        int numBins = 3;
        int partsPerBin = totalParts / numBins;  // What about the remainder?
        Console.WriteLine($"Parts per bin: {partsPerBin}");
        
        // Display results (if it even compiles...)
        Console.WriteLine("\n--- Inventory Report ---");
        Console.WriteLine($"Oil Filters: {oilFilters} @ ${oilFilterPrice} = ${totalOilValue}");
        Console.WriteLine($"Air Filters: {airFilters} @ ${airFilterPrice} = ${totalAirValue}");
        Console.WriteLine($"Spark Plugs: {sparkPlugs} @ ${sparkPlugPrice} = ${totalSparkValue}");
        Console.WriteLine($"Order Total: ${orderTotal:F2}");
    }
}

/* 
🐛 BUGS TO FIX:

1. String/Number confusion everywhere
2. Can't do math with strings  
3. Variable scope problems
4. Wrong types for the data
5. Integer division losing precision
6. Type conversion issues

HINT: Think about what TYPE each piece of data should be:
- Counts → int
- Prices → double or decimal
- Part numbers → string (even if they look like numbers!)
- Yes/No → bool
*/
