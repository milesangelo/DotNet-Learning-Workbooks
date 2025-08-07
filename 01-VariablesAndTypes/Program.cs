// 🔧 Module 01: Variables and Types - Main Menu
//
// This is your workshop! Pick an exercise to work on.
// Remember: The goal is UNDERSTANDING, not speed.
// Take your time, make mistakes, learn from them.

using System;

class Program
{
    static void Main()
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine(@"
    ╔════════════════════════════════════════════╗
    ║   🔧 VARIABLES & TYPES WORKSHOP 🔧        ║
    ║                                            ║
    ║   Think of variables as your toolbox:     ║
    ║   - Right tool for the right job          ║
    ║   - Keep them organized and labeled       ║
    ║   - Don't use a hammer when you need      ║
    ║     a screwdriver!                        ║
    ╚════════════════════════════════════════════╝
        ");
        Console.ResetColor();

        while (true)
        {
            Console.WriteLine("\n📚 Choose Your Exercise:\n");
            Console.WriteLine("  1. Fix Variable Declarations   [🔴 Broken Code]");
            Console.WriteLine("  2. Debug Inventory System      [🐛 Type Bugs]");
            Console.WriteLine("  3. Refactor Verbose Code       [🧹 Clean It Up]");
            Console.WriteLine("  4. Build Quote Calculator      [🏗️ From Scratch]");
            Console.WriteLine("  5. Type Safety Challenge       [⚠️ Advanced]");
            Console.WriteLine("  6. View Solutions              [✅ Check Work]");
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
                    Console.WriteLine("🏁 Keep practicing! Every rep builds muscle memory.\n");
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
        Console.WriteLine("🔴 EXERCISE 1: Fix Variable Declarations\n");
        Console.ResetColor();
        
        Console.WriteLine("📝 Your Mission:");
        Console.WriteLine("  • Open Exercise1_Broken.cs");
        Console.WriteLine("  • Fix ALL the compiler errors");
        Console.WriteLine("  • Use proper types and naming conventions\n");
        
        Console.WriteLine("🔧 Mechanical Tip:");
        Console.WriteLine("  Think of each variable as a specialized container.");
        Console.WriteLine("  You wouldn't put oil in a coolant reservoir!\n");
        
        Console.WriteLine("⚡ Quick Reminder:");
        Console.WriteLine("  • int = whole numbers (42, -10, 0)");
        Console.WriteLine("  • double = decimals (3.14, -0.5, 99.99)");
        Console.WriteLine("  • string = text (\"Hello\", \"ABC-123\")");
        Console.WriteLine("  • bool = true/false switches");
        Console.WriteLine("  • const = values that NEVER change");
    }

    static void ShowExercise2()
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("🐛 EXERCISE 2: Debug the Inventory System\n");
        Console.ResetColor();
        
        Console.WriteLine("📝 Your Mission:");
        Console.WriteLine("  • Open Exercise2_Broken.cs");
        Console.WriteLine("  • Fix type mismatches and scope issues");
        Console.WriteLine("  • Make the calculations actually work\n");
        
        Console.WriteLine("🔍 Debug Strategy:");
        Console.WriteLine("  1. Read compiler errors from top to bottom");
        Console.WriteLine("  2. Fix one error at a time");
        Console.WriteLine("  3. Re-run after each fix");
        Console.WriteLine("  4. Test the logic once it compiles\n");
        
        Console.WriteLine("💡 Common Issues You'll Find:");
        Console.WriteLine("  • Strings being used for math");
        Console.WriteLine("  • Variables declared in wrong scope");
        Console.WriteLine("  • Missing type conversions");
    }

    static void ShowExercise3()
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("🧹 EXERCISE 3: Refactor Verbose Code\n");
        Console.ResetColor();
        
        Console.WriteLine("📝 Your Mission:");
        Console.WriteLine("  • Open Exercise3_Verbose.cs");
        Console.WriteLine("  • Make the code clean and professional");
        Console.WriteLine("  • Apply DRY principle (Don't Repeat Yourself)\n");
        
        Console.WriteLine("🎯 Refactoring Goals:");
        Console.WriteLine("  • Combine related variables");
        Console.WriteLine("  • Use constants for fixed values");
        Console.WriteLine("  • Eliminate unnecessary variables");
        Console.WriteLine("  • Use string interpolation");
        Console.WriteLine("  • Improve variable names\n");
        
        Console.WriteLine("✨ Clean Code Principle:");
        Console.WriteLine("  Code is read 10x more than it's written.");
        Console.WriteLine("  Make it easy for future-you to understand!");
    }

    static void ShowExercise4()
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("🏗️ EXERCISE 4: Build Quote Calculator\n");
        Console.ResetColor();
        
        Console.WriteLine("📝 Build From Scratch:");
        Console.WriteLine("  Create a new file: Exercise4_QuoteCalc.cs\n");
        
        Console.WriteLine("Requirements:");
        Console.WriteLine("  ✓ Get customer name (string)");
        Console.WriteLine("  ✓ Get hours of labor (double)");
        Console.WriteLine("  ✓ Get parts cost (decimal)");
        Console.WriteLine("  ✓ Ask if rush job (bool)");
        Console.WriteLine("  ✓ Use const for HOURLY_RATE ($95)");
        Console.WriteLine("  ✓ Use const for RUSH_FEE ($50)");
        Console.WriteLine("  ✓ Use const for TAX_RATE (8.75%)");
        Console.WriteLine("  ✓ Calculate and display formatted quote\n");
        
        Console.WriteLine("📊 Example Output:");
        Console.WriteLine("  Quote for: John Smith");
        Console.WriteLine("  Labor: 2.5 hours @ $95.00 = $237.50");
        Console.WriteLine("  Parts: $156.78");
        Console.WriteLine("  Rush Fee: $50.00");
        Console.WriteLine("  Subtotal: $444.28");
        Console.WriteLine("  Tax: $38.87");
        Console.WriteLine("  TOTAL: $483.15");
    }

    static void ShowExercise5()
    {
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine("⚠️ EXERCISE 5: Type Safety Challenge\n");
        Console.ResetColor();
        
        Console.WriteLine("🎯 Advanced Challenge:");
        Console.WriteLine("  Create Exercise5_TypeSafety.cs\n");
        
        Console.WriteLine("Your program should demonstrate:");
        Console.WriteLine("  1. Implicit vs explicit conversions");
        Console.WriteLine("  2. Data loss from wrong conversions");
        Console.WriteLine("  3. Parse vs TryParse for user input");
        Console.WriteLine("  4. Nullable reference types");
        Console.WriteLine("  5. The 'as' and 'is' operators\n");
        
        Console.WriteLine("💭 Think About:");
        Console.WriteLine("  • What happens when you put a double into an int?");
        Console.WriteLine("  • When should you use int.Parse vs int.TryParse?");
        Console.WriteLine("  • How do you safely handle null values?");
    }

    static void ShowSolutions()
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("✅ SOLUTIONS GUIDE\n");
        Console.ResetColor();
        
        Console.WriteLine("📁 Solution Files:");
        Console.WriteLine("  • Exercise1_Fixed.cs - Corrected declarations");
        Console.WriteLine("  • Exercise2_Fixed.cs - Debugged inventory");
        Console.WriteLine("  • Exercise3_Clean.cs - Refactored code\n");
        
        Console.WriteLine("⚡ Key Patterns to Remember:\n");
        
        Console.WriteLine("1️⃣ Type Selection:");
        Console.WriteLine("   int count = 42;           // Whole numbers");
        Console.WriteLine("   double price = 19.99;     // Decimals");
        Console.WriteLine("   string name = \"John\";     // Text");
        Console.WriteLine("   bool isReady = true;      // Yes/No\n");
        
        Console.WriteLine("2️⃣ Constants:");
        Console.WriteLine("   const double TAX_RATE = 0.08;");
        Console.WriteLine("   const int MAX_ITEMS = 100;\n");
        
        Console.WriteLine("3️⃣ Null Safety:");
        Console.WriteLine("   string? nullable = null;");
        Console.WriteLine("   int length = nullable?.Length ?? 0;\n");
        
        Console.WriteLine("4️⃣ Type Conversion:");
        Console.WriteLine("   string input = \"42\";");
        Console.WriteLine("   if (int.TryParse(input, out int value)) { }");
    }
}
