// 🔧 Exercise 1: Fix the Service Advisor Logic
//
// This service advisor system is making terrible recommendations!
// It has multiple conditional logic errors that need fixing.
//
// BUGS TO FIX:
// 1. Assignment instead of comparison (=  vs ==)
// 2. Wrong boolean operators (& vs &&, | vs ||)
// 3. Inverted logic (using wrong operators)
// 4. Missing else branches causing wrong output
// 5. String comparison case sensitivity issues

using System;

class Exercise1_Broken
{
    static void Main()
    {
        Console.WriteLine("=== Broken Service Advisor System ===\n");

        // Vehicle data
        int mileage = 45000;
        int monthsSinceOilChange = 4;
        int milesSinceOilChange = 4500;
        string customerType = "Regular";  // Can be "New", "Regular", or "VIP"
        bool isWeekend = true;
        double engineTemp = 195.5;  // Normal is 180-220
        double oilPressure = 40;     // Normal is 25-65 PSI

        // Check if oil change needed
        // BUG: Assignment instead of comparison!
        if (milesSinceOilChange = 5000)
        {
            Console.WriteLine("✓ Oil change recommended at exactly 5000 miles");
        }

        // BUG: Should recommend if EITHER condition is true, not both
        if (milesSinceOilChange > 3000 & monthsSinceOilChange > 3)
        {
            Console.WriteLine("✓ Oil change needed (mileage AND time)");
        }

        // Check engine health
        // BUG: Wrong operator - should be && not &
        if (engineTemp > 180 & engineTemp < 220)
        {
            Console.WriteLine("✓ Engine temperature normal");
        }

        // BUG: Logic is inverted! 
        if (oilPressure < 25 && oilPressure > 65)  // This is impossible!
        {
            Console.WriteLine("✓ Oil pressure normal");
        }
        else
        {
            Console.WriteLine("⚠️ Oil pressure abnormal");
        }

        // Customer discount check
        // BUG: String comparison is case sensitive!
        if (customerType == "vip")  // Won't match "VIP"
        {
            Console.WriteLine("✓ VIP discount applied");
        }

        // Weekend surcharge
        // BUG: Assignment instead of comparison again!
        if (isWeekend = false)
        {
            Console.WriteLine("✓ No weekend surcharge");
        }
        else
        {
            Console.WriteLine("⚠️ Weekend surcharge applies");
        }

        // Complex service recommendation
        // BUG: Multiple issues here!
        bool needsService = false;
        if (mileage > 30000)
        {
            needsService = true;
        }
        if (mileage > 60000)  // BUG: This overwrites the previous value!
        {
            needsService = false;  // Why would we NOT need service at higher mileage?
        }

        // Warranty check
        bool underWarranty = true;
        // BUG: Using bitwise OR instead of logical OR
        if (mileage > 36000 | monthsSinceOilChange > 36)
        {
            underWarranty = false;
        }

        // Priority calculation
        // BUG: Mixing && and || incorrectly - needs parentheses!
        if (engineTemp > 220 || oilPressure < 25 && customerType == "VIP")
        {
            Console.WriteLine("⚠️ PRIORITY SERVICE NEEDED");
        }

        // Service bay assignment
        int bayNumber = 0;
        // BUG: No else-if structure, all conditions run!
        if (customerType == "VIP")
        {
            bayNumber = 1;
        }
        if (customerType == "Regular")
        {
            bayNumber = 2;
        }
        if (customerType == "New")
        {
            bayNumber = 3;
        }
        // BUG: bayNumber could still be 0!
        Console.WriteLine($"Assigned to Bay {bayNumber}");

        // Brake check logic
        bool brakesOK = true;
        int brakeThickness = 3;  // mm
        // BUG: NOT operator used incorrectly
        if (!brakeThickness > 2)  // This is !(brake > 2) not (!brake) > 2
        {
            brakesOK = false;
        }

        // Final summary
        Console.WriteLine("\n--- Service Summary ---");
        Console.WriteLine($"Needs Service: {needsService}");
        Console.WriteLine($"Under Warranty: {underWarranty}");
        Console.WriteLine($"Brakes OK: {brakesOK}");

        // BUG: Dead code - unreachable!
        return;
        Console.WriteLine("Thank you for choosing our shop!");
    }
}

/*
🐛 DEBUGGING TIPS:

1. = vs == 
   - Single = assigns a value
   - Double == compares values

2. & vs && (also | vs ||)
   - Single & is bitwise AND (avoid in conditionals)
   - Double && is logical AND (use this!)
   - && short-circuits, & doesn't

3. Impossible conditions
   - Can a number be < 25 AND > 65 at the same time?
   - Think through the logic!

4. String comparison
   - "VIP" != "vip" (case matters!)
   - Use StringComparison options or ToLower()

5. Operator precedence
   - && has higher precedence than ||
   - Use parentheses to be clear!

When you're done, the program should give accurate service recommendations!
*/
