// 🔧 Module 03: Loops & Iteration - Main Menu
//
// Welcome to the Loops Workshop!
// Think of loops like your systematic work patterns:
// "Repeat the same action until the job is done"

using System;

class Program
{
    static void Main()
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine(@"
    ╔════════════════════════════════════════════╗
    ║   🔄 LOOPS & ITERATION WORKSHOP 🔄        ║
    ║                                            ║
    ║   Think of loops like torque patterns:     ║
    ║   • FOR: Specific repetitions (20 bolts)  ║
    ║   • WHILE: Until condition met (add oil)  ║
    ║   • BREAK: Emergency stop (danger!)       ║
    ║   • CONTINUE: Skip and keep going         ║
    ╚════════════════════════════════════════════╝
        ");
        Console.ResetColor();

        while (true)
        {
            Console.WriteLine("\n📚 Choose Your Exercise:\n");
            Console.WriteLine("  1. Fix Inventory Counter        [🔴 Off-by-One Disasters]");
            Console.WriteLine("  2. Debug Service Queue          [🐛 Infinite Loop Traps]");
            Console.WriteLine("  3. Eliminate Duplication        [🧹 Loop Refactoring]");
            Console.WriteLine("  4. Build Batch Processor        [🏗️ From Scratch]");
            Console.WriteLine("  5. Pattern Generator Master     [⚡ Advanced Nested Loops]");
            Console.WriteLine("  6. View Solutions               [✅ Check Work]");
            Console.WriteLine("  0. Exit Workshop\n");

            Console.Write("Enter choice (0-6): ");
            var choice = Console.ReadLine();

            Console.Clear();
            
            switch (choice)
            {
                case "1":
                    ShowExercise1();
                    break;
                case "2":
                    ShowExercise2();
                    break;
                case "3":
                    ShowExercise3();
                    break;
                case "4":
                    ShowExercise4();
                    break;
                case "5":
                    ShowExercise5();
                    break;
                case "6":
                    ShowSolutions();
                    break;
                case "0":
                    Console.WriteLine("🏁 Keep practicing those loop patterns!\n");
                    return;
                default:
                    Console.WriteLine("❌ Invalid choice. Try again.");
                    break;
            }
            
            if (choice != "0")
            {
                Console.WriteLine("\n" + new string('─', 50));
                Console.WriteLine("Press any key to return to menu...");
                Console.ReadKey();
                Console.Clear();
            }
        }
    }

    static void ShowExercise1()
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("🔴 EXERCISE 1: Fix Inventory Counter\n");
        Console.ResetColor();
        
        Console.WriteLine("📝 Your Mission:");
        Console.WriteLine("  • Open Exercise1_InventoryCount.cs");
        Console.WriteLine("  • Fix ALL the loop disasters");
        Console.WriteLine("  • Prevent crashes and infinite loops!\n");
        
        Console.WriteLine("🔧 Common Loop Bugs You'll Find:");
        Console.WriteLine("  • Off-by-one errors (i <= array.Length)");
        Console.WriteLine("  • Infinite loops (forgot to increment counter)");
        Console.WriteLine("  • Wrong loop types for the job");
        Console.WriteLine("  • Break/continue used incorrectly");
        Console.WriteLine("  • Array bounds violations\n");
        
        Console.WriteLine("⚡ Quick Reference:");
        Console.WriteLine("  • Array bounds: 0 to Length-1 (use < not <=)");
        Console.WriteLine("  • Always increment your while loop counter!");
        Console.WriteLine("  • break = exit loop, continue = skip to next iteration");
        Console.WriteLine("  • Choose for when you know count, while for conditions");
        Console.WriteLine("  • Test with different data sizes");
    }

    static void ShowExercise2()
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("🐛 EXERCISE 2: Debug Service Queue\n");
        Console.ResetColor();
        
        Console.WriteLine("📝 Your Mission:");
        Console.WriteLine("  • Open Exercise2_ServiceQueue.cs");
        Console.WriteLine("  • Fix the customer processing logic");
        Console.WriteLine("  • Handle priorities and time limits correctly\n");
        
        Console.WriteLine("🔍 Debug Strategy:");
        Console.WriteLine("  1. Identify infinite loop potential");
        Console.WriteLine("  2. Check break/continue logic");
        Console.WriteLine("  3. Verify collection modification during iteration");
        Console.WriteLine("  4. Test priority customer handling");
        Console.WriteLine("  5. Ensure proper loop termination\n");
        
        Console.WriteLine("💡 Key Concepts:");
        Console.WriteLine("  • Don't modify collections while iterating");
        Console.WriteLine("  • Use Queue<T> for FIFO processing");
        Console.WriteLine("  • break exits loop, continue skips iteration");
        Console.WriteLine("  • Always ensure loop conditions can become false");
        Console.WriteLine("  • Handle edge cases (empty queue, all priorities)");
    }

    static void ShowExercise3()
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("🧹 EXERCISE 3: Eliminate Code Duplication\n");
        Console.ResetColor();
        
        Console.WriteLine("📝 Your Mission:");
        Console.WriteLine("  • Open Exercise3_RefactorDuplication.cs");
        Console.WriteLine("  • Replace ALL repetitive code with loops");
        Console.WriteLine("  • Make the code maintainable and extensible\n");
        
        Console.WriteLine("🎯 Refactoring Targets:");
        Console.WriteLine("  • 5 repetitive service pricing blocks");
        Console.WriteLine("  • 4 identical tax calculation patterns");
        Console.WriteLine("  • 5 copy-paste inventory checks");
        Console.WriteLine("  • Repetitive schedule generation");
        Console.WriteLine("  • Manual monthly revenue calculations\n");
        
        Console.WriteLine("✨ DRY (Don't Repeat Yourself) Patterns:");
        Console.WriteLine("  // Instead of:");
        Console.WriteLine("  Console.WriteLine(service1);");
        Console.WriteLine("  Console.WriteLine(service2);");
        Console.WriteLine("  Console.WriteLine(service3);");
        Console.WriteLine("  ");
        Console.WriteLine("  // Use:");
        Console.WriteLine("  foreach (string service in services)");
        Console.WriteLine("      Console.WriteLine(service);");
    }

    static void ShowExercise4()
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("🏗️ EXERCISE 4: Build Batch Processor\n");
        Console.ResetColor();
        
        Console.WriteLine("📝 Build From Scratch:");
        Console.WriteLine("  Create Exercise4_BatchProcessor.cs\n");
        
        Console.WriteLine("🎯 Core Requirements:");
        Console.WriteLine("  ✓ Process multiple parts orders in batches");
        Console.WriteLine("  ✓ Handle rush orders with priority");
        Console.WriteLine("  ✓ Respect time limits (4-hour processing window)");
        Console.WriteLine("  ✓ Skip unavailable items (move to backorder)");
        Console.WriteLine("  ✓ Group orders by supplier for efficiency");
        Console.WriteLine("  ✓ Calculate costs with discounts and surcharges\n");
        
        Console.WriteLine("🔄 Key Loop Patterns to Use:");
        Console.WriteLine("  • while loop for time-limited processing");
        Console.WriteLine("  • for loop for batch iteration");
        Console.WriteLine("  • foreach for simple enumeration");
        Console.WriteLine("  • Nested loops for supplier grouping");
        Console.WriteLine("  • break/continue for special cases\n");
        
        Console.WriteLine("🧪 Test Your Solution With:");
        Console.WriteLine("  ✅ Normal batch (mixed priorities, all available)");
        Console.WriteLine("  ⏰ Time limit exceeded scenario");
        Console.WriteLine("  🚨 All rush orders scenario");
        Console.WriteLine("  📦 Partial fulfillment (limited stock)");
        Console.WriteLine("  💰 Discount calculation accuracy");
    }

    static void ShowExercise5()
    {
        Console.ForegroundColor = ConsoleColor.DarkMagenta;
        Console.WriteLine("⚡ EXERCISE 5: Pattern Generator Master\n");
        Console.ResetColor();
        
        Console.WriteLine("🎯 Advanced Challenge:");
        Console.WriteLine("  Open Challenge_PatternGenerator.cs\n");
        
        Console.WriteLine("🚨 Your Mission:");
        Console.WriteLine("  Master nested loops by creating 5 different");
        Console.WriteLine("  pattern generators for real shop operations\n");
        
        Console.WriteLine("🏗️ Pattern Types to Build:");
        Console.WriteLine("  1. Work Schedule Generator (rotating shifts)");
        Console.WriteLine("  2. Maintenance Matrix (equipment schedules)");
        Console.WriteLine("  3. Shop Layout ASCII Art (floor plans)");
        Console.WriteLine("  4. Dynamic Price Grid (service matrices)");
        Console.WriteLine("  5. Hierarchical Inventory Report (tree structure)\n");
        
        Console.WriteLine("🔥 Advanced Techniques:");
        Console.WriteLine("  • Multi-dimensional thinking");
        Console.WriteLine("  • Nested for loops with complex logic");
        Console.WriteLine("  • Performance optimization");
        Console.WriteLine("  • Visual formatting and alignment");
        Console.WriteLine("  • Real-world applicability\n");
        
        Console.WriteLine("🏆 This is where loops get REALLY powerful!");
        Console.WriteLine("You'll be creating patterns that are genuinely useful");
        Console.WriteLine("in real auto shop management systems.");
    }

    static void ShowSolutions()
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("✅ SOLUTIONS & LOOP PATTERNS\n");
        Console.ResetColor();
        
        Console.WriteLine("📁 Available Solutions:");
        Console.WriteLine("  • Solutions will be added as you progress!");
        Console.WriteLine("  • Compare your approaches with the provided solutions\n");
        
        Console.WriteLine("🔄 Essential Loop Patterns:\n");
        
        Console.WriteLine("1️⃣ Counting Pattern:");
        Console.WriteLine("   for (int i = 0; i < count; i++)");
        Console.WriteLine("   {");
        Console.WriteLine("       // Do something count times");
        Console.WriteLine("   }\n");
        
        Console.WriteLine("2️⃣ Accumulation Pattern:");
        Console.WriteLine("   double total = 0;");
        Console.WriteLine("   foreach (var item in items)");
        Console.WriteLine("   {");
        Console.WriteLine("       total += item.Value;");
        Console.WriteLine("   }\n");
        
        Console.WriteLine("3️⃣ Search Pattern:");
        Console.WriteLine("   for (int i = 0; i < items.Length; i++)");
        Console.WriteLine("   {");
        Console.WriteLine("       if (items[i] == target)");
        Console.WriteLine("       {");
        Console.WriteLine("           return i; // Found it!");
        Console.WriteLine("       }");
        Console.WriteLine("   }\n");
        
        Console.WriteLine("4️⃣ Conditional Processing:");
        Console.WriteLine("   foreach (var customer in customers)");
        Console.WriteLine("   {");
        Console.WriteLine("       if (!customer.IsActive)");
        Console.WriteLine("           continue; // Skip inactive");
        Console.WriteLine("       ProcessCustomer(customer);");
        Console.WriteLine("   }\n");
        
        Console.WriteLine("5️⃣ Time-Limited Processing:");
        Console.WriteLine("   while (hasWork && timeRemaining > 0)");
        Console.WriteLine("   {");
        Console.WriteLine("       ProcessNextItem();");
        Console.WriteLine("       timeRemaining -= GetProcessingTime();");
        Console.WriteLine("   }\n");
        
        Console.WriteLine("6️⃣ Nested Grid Processing:");
        Console.WriteLine("   for (int row = 0; row < rows; row++)");
        Console.WriteLine("   {");
        Console.WriteLine("       for (int col = 0; col < cols; col++)");
        Console.WriteLine("       {");
        Console.WriteLine("           grid[row, col] = CalculateValue(row, col);");
        Console.WriteLine("       }");
        Console.WriteLine("   }\n");
        
        Console.WriteLine("⚠️ Common Pitfalls to Avoid:");
        Console.WriteLine("  • Off-by-one: use < not <= with .Length");
        Console.WriteLine("  • Infinite loops: always increment counters");
        Console.WriteLine("  • Collection modification during iteration");
        Console.WriteLine("  • Wrong loop type for the job");
        Console.WriteLine("  • Forgetting break/continue affects innermost loop only\n");
        
        Console.WriteLine("💡 Loop Selection Guide:");
        Console.WriteLine("  • for: Known number of iterations");
        Console.WriteLine("  • while: Condition-based, unknown count");
        Console.WriteLine("  • do-while: At least one iteration needed");
        Console.WriteLine("  • foreach: Processing all items in collection");
        Console.WriteLine("  • break: Exit loop immediately");
        Console.WriteLine("  • continue: Skip to next iteration");
    }
}
