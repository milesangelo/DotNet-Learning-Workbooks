// 🔧 Exercise 1: SOLUTION - Service Advisor Logic (Fixed)
//
// Here's the corrected version with explanations of each fix.
// Compare this to your solution!

using System;

class Exercise1_Fixed
{
    static void Main()
    {
        Console.WriteLine("=== Service Advisor System (FIXED) ===\n");

        // Vehicle data
        int mileage = 45000;
        int monthsSinceOilChange = 4;
        int milesSinceOilChange = 4500;
        string customerType = "Regular";
        bool isWeekend = true;
        double engineTemp = 195.5;
        double oilPressure = 40;

        // Fix 1: Use == for comparison, not = for assignment
        if (milesSinceOilChange == 5000)  // ✅ Comparison, not assignment
        {
            Console.WriteLine("✓ Oil change recommended at exactly 5000 miles");
        }

        // Fix 2: Use || (OR) instead of && (AND) - either condition should trigger
        if (milesSinceOilChange > 3000 || monthsSinceOilChange > 3)  // ✅ Either condition
        {
            Console.WriteLine("✓ Oil change needed (mileage OR time)");
        }

        // Fix 3: Use && instead of & for logical AND
        if (engineTemp > 180 && engineTemp < 220)  // ✅ Logical AND with short-circuit
        {
            Console.WriteLine("✓ Engine temperature normal");
        }

        // Fix 4: Correct the impossible logic - fix the range check
        if (oilPressure >= 25 && oilPressure <= 65)  // ✅ Possible condition (within range)
        {
            Console.WriteLine("✓ Oil pressure normal");
        }
        else
        {
            Console.WriteLine("⚠️ Oil pressure abnormal");
        }

        // Fix 5: String comparison is case sensitive - use proper case or ignore case
        if (customerType.Equals("Regular", StringComparison.OrdinalIgnoreCase))  // ✅ Case insensitive
        // Alternative: if (customerType == "Regular") // ✅ Match the exact case
        {
            Console.WriteLine("✓ Regular customer discount applied");
        }

        // Fix 6: Use == for comparison, not = for assignment
        if (isWeekend == false)  // ✅ Comparison
        // Alternative: if (!isWeekend) // ✅ More idiomatic
        {
            Console.WriteLine("✓ No weekend surcharge");
        }
        else
        {
            Console.WriteLine("⚠️ Weekend surcharge applies");
        }

        // Fix 7: Logic for service recommendation - don't overwrite, use proper ranges
        bool needsService = mileage > 30000;  // Basic service at 30k+
        if (mileage > 60000)
        {
            needsService = true;  // ✅ Still needs service at higher mileage (more service!)
        }

        // Fix 8: Use && instead of | for logical operations
        bool underWarranty = true;
        if (mileage > 36000 || monthsSinceOilChange > 36)  // ✅ Logical OR
        {
            underWarranty = false;
        }

        // Fix 9: Add parentheses to make precedence clear
        if ((engineTemp > 220 || oilPressure < 25) && customerType == "VIP")  // ✅ Clear precedence
        {
            Console.WriteLine("⚠️ PRIORITY SERVICE NEEDED");
        }

        // Fix 10: Use else-if structure to prevent all conditions from running
        int bayNumber = 0;
        if (customerType == "VIP")
        {
            bayNumber = 1;
        }
        else if (customerType == "Regular")  // ✅ else if
        {
            bayNumber = 2;
        }
        else if (customerType == "New")  // ✅ else if
        {
            bayNumber = 3;
        }
        else  // ✅ Handle unexpected cases
        {
            bayNumber = 4;  // Default bay
            Console.WriteLine("⚠️ Unknown customer type, using default bay");
        }
        Console.WriteLine($"Assigned to Bay {bayNumber}");

        // Fix 11: Correct the NOT operator precedence
        bool brakesOK = true;
        int brakeThickness = 3;
        if (brakeThickness <= 2)  // ✅ Direct comparison is clearer
        // Alternative: if (!(brakeThickness > 2)) // ✅ Parentheses make it clear
        {
            brakesOK = false;
        }

        // Final summary
        Console.WriteLine("\n--- Service Summary ---");
        Console.WriteLine($"Needs Service: {needsService}");
        Console.WriteLine($"Under Warranty: {underWarranty}");
        Console.WriteLine($"Brakes OK: {brakesOK}");

        // Fix 12: Remove unreachable code (or move return to end)
        Console.WriteLine("Thank you for choosing our shop!");  // ✅ Now reachable
    }
}

/*
🔑 KEY LESSONS FROM FIXES:

1. = vs == 
   ✅ Single = assigns: x = 5
   ✅ Double == compares: x == 5

2. & vs && (also | vs ||)
   ✅ Single & is bitwise (avoid in conditionals)
   ✅ Double && is logical AND with short-circuiting
   ✅ Use && for safety: if (obj != null && obj.IsValid)

3. String Comparison
   ✅ Case matters: "VIP" != "vip"
   ✅ Use StringComparison.OrdinalIgnoreCase for case-insensitive
   ✅ Or ensure your cases match exactly

4. Logical Consistency
   ✅ Can't be < 25 AND > 65 simultaneously
   ✅ Higher mileage usually means MORE service needed
   ✅ Think through the real-world logic

5. Operator Precedence
   ✅ && has higher precedence than ||
   ✅ Use parentheses to be explicit: (A || B) && C
   ✅ Don't make readers guess your intent

6. Control Flow
   ✅ Use else-if to prevent multiple assignments
   ✅ Handle unexpected cases with final else
   ✅ Remove unreachable code (after return statements)

7. NOT Operator
   ✅ !(condition) is clearer than complex logic
   ✅ Be careful with precedence: !(x > 5) vs !x > 5

💡 DEBUGGING STRATEGY:
1. Fix compiler errors first (= vs ==)
2. Test with different data values
3. Trace through the logic manually
4. Check edge cases and impossible conditions
5. Make sure string comparisons work as expected

🎯 BEST PRACTICES:
- One condition per line for complex expressions
- Use meaningful variable names
- Extract complex conditions to named booleans
- Consider the real-world logic, not just syntax
- Test with various input values
*/
