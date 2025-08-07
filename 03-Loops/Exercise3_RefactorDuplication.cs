// 🔧 Exercise 3: Eliminate Code Duplication with Loops
//
// This code works, but it's FULL of repetitive patterns that scream
// "I should be a loop!" Your job: identify the duplication and
// refactor it into clean, efficient loop-based code.
//
// REFACTORING GOALS:
// 1. Replace repetitive if/else chains with loops + arrays
// 2. Eliminate copy-paste code blocks
// 3. Use appropriate loop types for each situation
// 4. Make the code more maintainable and extensible

using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("=== Auto Shop Price Calculator (REPETITIVE VERSION) ===\n");
        
        // Customer order data
        string customerName = "John Smith";
        bool isVipCustomer = false;
        bool isWarrantyWork = true;
        
        Console.WriteLine($"Processing order for: {customerName}\n");
        
        // DUPLICATION DISASTER #1: Repetitive service pricing
        Console.WriteLine("--- Service Pricing ---");
        
        string service1 = "oil_change";
        double price1 = 0;
        if (service1 == "oil_change")
        {
            price1 = 29.99;
            if (isVipCustomer) price1 = price1 * 0.9; // 10% VIP discount
            if (isWarrantyWork) price1 = price1 * 0.5; // 50% warranty discount
            Console.WriteLine($"Oil Change: ${price1:F2}");
        }
        
        string service2 = "brake_service";
        double price2 = 0;
        if (service2 == "brake_service")
        {
            price2 = 149.99;
            if (isVipCustomer) price2 = price2 * 0.9; // Same discount logic repeated!
            if (isWarrantyWork) price2 = price2 * 0.5; // Same discount logic repeated!
            Console.WriteLine($"Brake Service: ${price2:F2}");
        }
        
        string service3 = "tire_rotation";
        double price3 = 0;
        if (service3 == "tire_rotation")
        {
            price3 = 19.99;
            if (isVipCustomer) price3 = price3 * 0.9; // Same discount logic repeated!
            if (isWarrantyWork) price3 = price3 * 0.5; // Same discount logic repeated!
            Console.WriteLine($"Tire Rotation: ${price3:F2}");
        }
        
        string service4 = "inspection";
        double price4 = 0;
        if (service4 == "inspection")
        {
            price4 = 35.00;
            if (isVipCustomer) price4 = price4 * 0.9; // Same discount logic repeated!
            if (isWarrantyWork) price4 = price4 * 0.5; // Same discount logic repeated!
            Console.WriteLine($"Inspection: ${price4:F2}");
        }
        
        string service5 = "engine_diagnostic";
        double price5 = 0;
        if (service5 == "engine_diagnostic")
        {
            price5 = 89.99;
            if (isVipCustomer) price5 = price5 * 0.9; // Same discount logic repeated!
            if (isWarrantyWork) price5 = price5 * 0.5; // Same discount logic repeated!
            Console.WriteLine($"Engine Diagnostic: ${price5:F2}");
        }
        
        // DUPLICATION DISASTER #2: Repetitive tax calculations
        Console.WriteLine("\n--- Tax Calculations by State ---");
        
        string state1 = "CA";
        double tax1 = 0;
        if (state1 == "CA") tax1 = (price1 + price2 + price3 + price4 + price5) * 0.0975;
        Console.WriteLine($"California tax: ${tax1:F2}");
        
        string state2 = "TX";
        double tax2 = 0;
        if (state2 == "TX") tax2 = (price1 + price2 + price3 + price4 + price5) * 0.0825;
        Console.WriteLine($"Texas tax: ${tax2:F2}");
        
        string state3 = "FL";
        double tax3 = 0;
        if (state3 == "FL") tax3 = (price1 + price2 + price3 + price4 + price5) * 0.06;
        Console.WriteLine($"Florida tax: ${tax3:F2}");
        
        string state4 = "NY";
        double tax4 = 0;
        if (state4 == "NY") tax4 = (price1 + price2 + price3 + price4 + price5) * 0.08;
        Console.WriteLine($"New York tax: ${tax4:F2}");
        
        // DUPLICATION DISASTER #3: Repetitive inventory checks
        Console.WriteLine("\n--- Parts Inventory Check ---");
        
        string part1 = "Oil Filter";
        int stock1 = 25;
        if (stock1 < 10)
        {
            Console.WriteLine($"⚠️ LOW STOCK: {part1} - Only {stock1} left!");
        }
        else if (stock1 < 5)
        {
            Console.WriteLine($"🚨 CRITICAL: {part1} - Only {stock1} left!");
        }
        else
        {
            Console.WriteLine($"✅ OK: {part1} - {stock1} in stock");
        }
        
        string part2 = "Brake Pads";
        int stock2 = 3;
        if (stock2 < 10)
        {
            Console.WriteLine($"⚠️ LOW STOCK: {part2} - Only {stock2} left!");
        }
        else if (stock2 < 5)
        {
            Console.WriteLine($"🚨 CRITICAL: {part2} - Only {stock2} left!");
        }
        else
        {
            Console.WriteLine($"✅ OK: {part2} - {stock2} in stock");
        }
        
        string part3 = "Spark Plugs";
        int stock3 = 15;
        if (stock3 < 10)
        {
            Console.WriteLine($"⚠️ LOW STOCK: {part3} - Only {stock3} left!");
        }
        else if (stock3 < 5)
        {
            Console.WriteLine($"🚨 CRITICAL: {part3} - Only {stock3} left!");
        }
        else
        {
            Console.WriteLine($"✅ OK: {part3} - {stock3} in stock");
        }
        
        string part4 = "Air Filter";
        int stock4 = 8;
        if (stock4 < 10)
        {
            Console.WriteLine($"⚠️ LOW STOCK: {part4} - Only {stock4} left!");
        }
        else if (stock4 < 5)
        {
            Console.WriteLine($"🚨 CRITICAL: {part4} - Only {stock4} left!");
        }
        else
        {
            Console.WriteLine($"✅ OK: {part4} - {stock4} in stock");
        }
        
        string part5 = "Coolant";
        int stock5 = 1;
        if (stock5 < 10)
        {
            Console.WriteLine($"⚠️ LOW STOCK: {part5} - Only {stock5} left!");
        }
        else if (stock5 < 5)
        {
            Console.WriteLine($"🚨 CRITICAL: {part5} - Only {stock5} left!");
        }
        else
        {
            Console.WriteLine($"✅ OK: {part5} - {stock5} in stock");
        }
        
        // DUPLICATION DISASTER #4: Repetitive appointment scheduling
        Console.WriteLine("\n--- Weekly Schedule Generation ---");
        
        // Monday
        Console.WriteLine("Monday Schedule:");
        Console.WriteLine("  8:00 AM - Oil Change (Bay 1)");
        Console.WriteLine("  9:00 AM - Brake Service (Bay 2)");
        Console.WriteLine("  10:00 AM - Inspection (Bay 3)");
        Console.WriteLine("  11:00 AM - Available");
        Console.WriteLine("  12:00 PM - LUNCH BREAK");
        Console.WriteLine("  1:00 PM - Tire Rotation (Bay 1)");
        Console.WriteLine("  2:00 PM - Available");
        Console.WriteLine("  3:00 PM - Engine Diagnostic (Bay 2)");
        Console.WriteLine("  4:00 PM - Available");
        
        // Tuesday  
        Console.WriteLine("Tuesday Schedule:");
        Console.WriteLine("  8:00 AM - Brake Service (Bay 1)");
        Console.WriteLine("  9:00 AM - Oil Change (Bay 3)");
        Console.WriteLine("  10:00 AM - Available");
        Console.WriteLine("  11:00 AM - Inspection (Bay 2)");
        Console.WriteLine("  12:00 PM - LUNCH BREAK");
        Console.WriteLine("  1:00 PM - Engine Diagnostic (Bay 1)");
        Console.WriteLine("  2:00 PM - Tire Rotation (Bay 3)");
        Console.WriteLine("  3:00 PM - Available");
        Console.WriteLine("  4:00 PM - Oil Change (Bay 2)");
        
        // Wednesday
        Console.WriteLine("Wednesday Schedule:");
        Console.WriteLine("  8:00 AM - Inspection (Bay 2)");
        Console.WriteLine("  9:00 AM - Available");
        Console.WriteLine("  10:00 AM - Brake Service (Bay 1)");
        Console.WriteLine("  11:00 AM - Tire Rotation (Bay 3)");
        Console.WriteLine("  12:00 PM - LUNCH BREAK");
        Console.WriteLine("  1:00 PM - Oil Change (Bay 2)");
        Console.WriteLine("  2:00 PM - Engine Diagnostic (Bay 1)");
        Console.WriteLine("  3:00 PM - Available");
        Console.WriteLine("  4:00 PM - Available");
        
        // And this pattern continues for Thursday and Friday...
        // (Omitting for space, but imagine this repeated!)
        
        // DUPLICATION DISASTER #5: Repetitive report generation
        Console.WriteLine("\n--- Monthly Revenue Report ---");
        
        Console.WriteLine("January: $15,234.56");
        Console.WriteLine("February: $18,456.78");
        Console.WriteLine("March: $22,345.67");
        Console.WriteLine("April: $19,876.54");
        Console.WriteLine("May: $25,678.90");
        Console.WriteLine("June: $28,345.67");
        Console.WriteLine("July: $31,234.56");
        Console.WriteLine("August: $29,876.54");
        Console.WriteLine("September: $26,543.21");
        Console.WriteLine("October: $23,456.78");
        Console.WriteLine("November: $21,234.56");
        Console.WriteLine("December: $24,567.89");
        
        double yearTotal = 15234.56 + 18456.78 + 22345.67 + 19876.54 + 25678.90 + 
                          28345.67 + 31234.56 + 29876.54 + 26543.21 + 23456.78 + 
                          21234.56 + 24567.89;
        Console.WriteLine($"Year Total: ${yearTotal:F2}");
        
        Console.WriteLine("\n💭 This code works... but look at all the repetition!");
        Console.WriteLine("   Every time you add a new service, you need to update 5+ places!");
        Console.WriteLine("   Adding a new state? Copy-paste more tax code!");
        Console.WriteLine("   Want to change the discount logic? Find it in 5 places!");
        Console.WriteLine("\n🎯 Your mission: Replace repetition with smart loops!");
    }
}

/*
🎯 REFACTORING MISSIONS:

1. SERVICE PRICING LOOP:
   Replace the 5 repetitive service blocks with:
   • Arrays for service names and base prices
   • A loop to process all services
   • Single discount calculation method

2. TAX CALCULATION LOOP:
   Replace the 4 repetitive tax blocks with:
   • Arrays for state names and tax rates
   • A loop to calculate taxes for all states
   • One total calculation

3. INVENTORY CHECK LOOP:
   Replace the 5 repetitive inventory blocks with:
   • Arrays for part names and stock levels
   • A loop with the stock level logic
   • Single method to determine stock status

4. SCHEDULE GENERATION:
   Replace the repetitive schedule printing with:
   • 2D array or nested structure for schedule data
   • Nested loops to print days and time slots
   • Common format for all schedule entries

5. REVENUE REPORT:
   Replace the 12 repetitive month lines with:
   • Array of month names and revenue values
   • Loop to display each month
   • Automatic total calculation

🏆 SUCCESS CRITERIA:

✅ Eliminate all copy-paste code
✅ Use appropriate loop types (for, foreach, while)
✅ Make it easy to add new services/states/parts
✅ Single place to change business logic
✅ Code is shorter and more maintainable

💡 PATTERNS TO APPLY:

1. ARRAYS + LOOPS:
   string[] services = {"oil_change", "brake_service", ...};
   double[] prices = {29.99, 149.99, ...};
   for (int i = 0; i < services.Length; i++) { ... }

2. FOREACH FOR SIMPLE ITERATION:
   foreach (string month in monthNames) { ... }

3. METHODS TO ELIMINATE DUPLICATE LOGIC:
   double ApplyDiscounts(double price, bool isVip, bool isWarranty)

4. NESTED LOOPS FOR 2D DATA:
   for (int day = 0; day < days.Length; day++)
   for (int hour = 0; hour < hours.Length; hour++)

🚀 BONUS CHALLENGES:
• Use Dictionary<string, double> for service pricing
• Create classes for better data organization  
• Add methods to encapsulate repeated logic
• Make the code data-driven (read from files/database)

Remember: If you're copy-pasting code, there's probably a loop pattern hiding there!
*/
