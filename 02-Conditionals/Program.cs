// 🔧 Module 02: Conditionals & Logic - Main Menu
//
// Welcome to the Conditionals Workshop!
// Think of conditionals as your diagnostic flowchart:
// "If this condition, then take this action"

using System;

class Program
{
    static void Main()
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine(@"
    ╔════════════════════════════════════════════╗
    ║   🔀 CONDITIONALS & LOGIC WORKSHOP 🔀     ║
    ║                                            ║
    ║   Think of conditionals like diagnostic    ║
    ║   flowcharts:                              ║
    ║   • IF no spark → check ignition          ║
    ║   • IF temp high OR pressure low → stop   ║
    ║   • IF oil AND coolant low → investigate  ║
    ╚════════════════════════════════════════════╝
        ");
        Console.ResetColor();

        while (true)
        {
            Console.WriteLine("\n📚 Choose Your Exercise:\n");
            Console.WriteLine("  1. Fix Service Advisor Logic    [🔴 Logic Errors]");
            Console.WriteLine("  2. Debug Diagnostic Tree        [🐛 Nested Nightmare]");
            Console.WriteLine("  3. Refactor Nesting Hell        [🧹 Guard Clauses]");
            Console.WriteLine("  4. Build Smart Scheduler        [🏗️ From Scratch]");
            Console.WriteLine("  5. Emergency Triage System      [⚡ Advanced Challenge]");
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
                    Console.WriteLine("🏁 Keep practicing logical thinking!\n");
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
        Console.WriteLine("🔴 EXERCISE 1: Fix Service Advisor Logic\n");
        Console.ResetColor();
        
        Console.WriteLine("📝 Your Mission:");
        Console.WriteLine("  • Open Exercise1_Broken.cs");
        Console.WriteLine("  • Fix ALL the conditional logic errors");
        Console.WriteLine("  • Make the service recommendations actually work!\n");
        
        Console.WriteLine("🔧 Common Issues You'll Find:");
        Console.WriteLine("  • Assignment (=) instead of comparison (==)");
        Console.WriteLine("  • Wrong boolean operators (& vs &&)");
        Console.WriteLine("  • Inverted logic that makes no sense");
        Console.WriteLine("  • String comparison case sensitivity bugs");
        Console.WriteLine("  • Impossible conditions that can never be true\n");
        
        Console.WriteLine("⚡ Quick Reference:");
        Console.WriteLine("  • Use == to compare, = to assign");
        Console.WriteLine("  • Use && for AND, || for OR (not & and |)");
        Console.WriteLine("  • Strings are case sensitive: \"VIP\" != \"vip\"");
        Console.WriteLine("  • Think: Can something be < 25 AND > 65?");
        Console.WriteLine("  • Use else-if to prevent multiple conditions");
    }

    static void ShowExercise2()
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("🐛 EXERCISE 2: Debug Diagnostic Tree\n");
        Console.ResetColor();
        
        Console.WriteLine("📝 Your Mission:");
        Console.WriteLine("  • Open Exercise2_DiagnosticTree.cs");
        Console.WriteLine("  • Untangle the nested conditional nightmare");
        Console.WriteLine("  • Fix operator precedence and logic errors\n");
        
        Console.WriteLine("🔍 Debug Strategy:");
        Console.WriteLine("  1. Check operator precedence (use parentheses!)");
        Console.WriteLine("  2. Look for impossible conditions");
        Console.WriteLine("  3. Verify string comparisons");
        Console.WriteLine("  4. Test edge cases (null values, out of range)");
        Console.WriteLine("  5. Simplify complex expressions\n");
        
        Console.WriteLine("💡 Pro Tips:");
        Console.WriteLine("  • && has higher precedence than ||");
        Console.WriteLine("  • Use parentheses to make intent clear");
        Console.WriteLine("  • Extract complex conditions to variables");
        Console.WriteLine("  • One condition per line for readability");
    }

    static void ShowExercise3()
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("🧹 EXERCISE 3: Refactor Nesting Hell\n");
        Console.ResetColor();
        
        Console.WriteLine("📝 Your Mission:");
        Console.WriteLine("  • Open Exercise3_RefactorNesting.cs");
        Console.WriteLine("  • Convert deep nesting to guard clauses");
        Console.WriteLine("  • Make the code actually readable!\n");
        
        Console.WriteLine("🎯 Refactoring Techniques:");
        Console.WriteLine("  • Guard clauses: if (!valid) return;");
        Console.WriteLine("  • Early returns instead of deep nesting");
        Console.WriteLine("  • Extract conditions to named variables");
        Console.WriteLine("  • Maximum 3 levels of nesting\n");
        
        Console.WriteLine("✨ Guard Clause Pattern:");
        Console.WriteLine("  // Instead of:");
        Console.WriteLine("  if (hasCustomer) {");
        Console.WriteLine("    if (hasAppointment) {");
        Console.WriteLine("      if (partsAvailable) {");
        Console.WriteLine("        DoWork();");
        Console.WriteLine("  // Use:");
        Console.WriteLine("  if (!hasCustomer) return;");
        Console.WriteLine("  if (!hasAppointment) return;");
        Console.WriteLine("  if (!partsAvailable) return;");
        Console.WriteLine("  DoWork();");
    }

    static void ShowExercise4()
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("🏗️ EXERCISE 4: Build Smart Scheduler\n");
        Console.ResetColor();
        
        Console.WriteLine("📝 Build From Scratch:");
        Console.WriteLine("  Create Exercise4_SmartScheduler.cs\n");
        
        Console.WriteLine("🎯 Core Requirements:");
        Console.WriteLine("  ✓ Multiple customer types (VIP, Regular, New)");
        Console.WriteLine("  ✓ Different service types with constraints");
        Console.WriteLine("  ✓ Business hour validation");
        Console.WriteLine("  ✓ Emergency service logic");
        Console.WriteLine("  ✓ Resource allocation (bays, mechanics)");
        Console.WriteLine("  ✓ Priority-based scheduling\n");
        
        Console.WriteLine("💡 Key Concepts to Apply:");
        Console.WriteLine("  • Guard clauses for input validation");
        Console.WriteLine("  • Switch expressions for service types");
        Console.WriteLine("  • Complex boolean logic for priority");
        Console.WriteLine("  • Edge case handling");
        Console.WriteLine("  • Clear, readable conditionals\n");
        
        Console.WriteLine("🧪 Test Cases to Handle:");
        Console.WriteLine("  ✅ Happy path: VIP brake service");
        Console.WriteLine("  ❌ Invalid: Weekend regular customer");
        Console.WriteLine("  ⚠️ Edge: All mechanics busy");
        Console.WriteLine("  🚨 Emergency: Override normal rules");
    }

    static void ShowExercise5()
    {
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine("⚡ EXERCISE 5: Emergency Triage Challenge\n");
        Console.ResetColor();
        
        Console.WriteLine("🎯 Advanced Challenge:");
        Console.WriteLine("  Open Challenge_EmergencyTriage.cs\n");
        
        Console.WriteLine("🚨 Your Mission:");
        Console.WriteLine("  Build a sophisticated triage system that handles");
        Console.WriteLine("  multiple emergency requests with complex priorities\n");
        
        Console.WriteLine("💭 This Challenge Combines:");
        Console.WriteLine("  • Multi-criteria decision making");
        Console.WriteLine("  • Priority scoring algorithms");
        Console.WriteLine("  • Resource allocation under constraints");
        Console.WriteLine("  • Safety-first logic");
        Console.WriteLine("  • Real-world business rules\n");
        
        Console.WriteLine("🏆 Mastery Goals:");
        Console.WriteLine("  • Balance safety, service, and business needs");
        Console.WriteLine("  • Handle resource conflicts intelligently");
        Console.WriteLine("  • Provide clear reasoning for decisions");
        Console.WriteLine("  • Code that you'd trust with people's safety!\n");
        
        Console.WriteLine("⚖️ Key Principle:");
        Console.WriteLine("  In emergency triage, SAFETY ALWAYS COMES FIRST,");
        Console.WriteLine("  regardless of customer type or business considerations.");
    }

    static void ShowSolutions()
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("✅ SOLUTIONS & PATTERNS\n");
        Console.ResetColor();
        
        Console.WriteLine("📁 Available Solutions:");
        Console.WriteLine("  • Exercise1_Fixed.cs - Logic error fixes");
        Console.WriteLine("  • More solutions coming as you progress!\n");
        
        Console.WriteLine("🔑 Key Patterns to Master:\n");
        
        Console.WriteLine("1️⃣ Comparison vs Assignment:");
        Console.WriteLine("   if (value == 10)    // ✅ Compare");
        Console.WriteLine("   if (value = 10)     // ❌ Assign (always true!)\n");
        
        Console.WriteLine("2️⃣ Boolean Operators:");
        Console.WriteLine("   if (a && b)         // ✅ Logical AND");
        Console.WriteLine("   if (a & b)          // ❌ Bitwise AND\n");
        
        Console.WriteLine("3️⃣ Guard Clauses:");
        Console.WriteLine("   if (!isValid) return;  // ✅ Fail fast");
        Console.WriteLine("   DoWork();              // ✅ Clean flow\n");
        
        Console.WriteLine("4️⃣ Complex Conditions:");
        Console.WriteLine("   bool canSchedule = hasCustomer && ");
        Console.WriteLine("                      isBusinessHours && ");
        Console.WriteLine("                      hasMechanic;");
        Console.WriteLine("   if (canSchedule) { ... }\n");
        
        Console.WriteLine("5️⃣ String Comparison:");
        Console.WriteLine("   if (type.Equals(\"VIP\", StringComparison.OrdinalIgnoreCase))\n");
        
        Console.WriteLine("6️⃣ Operator Precedence:");
        Console.WriteLine("   if ((temp > 220 || pressure < 25) && isVIP)");
        Console.WriteLine("   // Parentheses make intent clear!");
        
        Console.WriteLine("\n💡 Remember: Clear logic beats clever logic!");
    }
}
