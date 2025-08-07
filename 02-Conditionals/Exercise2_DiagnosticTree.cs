// 🔧 Exercise 2: Debug the Diagnostic Tree
//
// This diagnostic system has nested conditions gone wrong!
// It's supposed to diagnose car problems systematically,
// but the logic is broken in multiple ways.
//
// BUGS TO FIND & FIX:
// 1. Order of operations issues with mixed && and ||
// 2. Impossible conditions (logical contradictions)
// 3. Missing parentheses causing wrong grouping
// 4. Unreachable code due to logic errors
// 5. Edge cases not handled properly
// 6. Complex expressions that need simplifying

using System;

class Exercise2_DiagnosticTree
{
    static void RunExercise()
    {
        Console.WriteLine("=== Engine Diagnostic System ===\n");

        // Diagnostic data
        bool engineStarts = true;
        bool hasElectricity = true;
        bool hasFuel = true;
        bool hasCompression = false;  // This is the problem!
        int rpmIdle = 750;
        int oilPressure = 15;  // PSI (normal: 25-65)
        double coolantTemp = 225;  // F (normal: 180-220)
        bool checkEngineLight = true;
        string lastService = "oil_change";  // oil_change, tune_up, inspection
        int daysSinceService = 45;

        Console.WriteLine("🔍 Running diagnostics...\n");

        // PROBLEM 1: Order of operations confusion
        // BUG: This doesn't work as expected due to operator precedence
        if (engineStarts && hasElectricity || hasFuel && hasCompression)
        {
            Console.WriteLine("✓ Basic systems functional");
        }
        else
        {
            Console.WriteLine("⚠️ Basic system failure detected");
        }

        // PROBLEM 2: Impossible condition
        // BUG: Temperature can't be both too hot AND too cold!
        if (coolantTemp < 180 && coolantTemp > 220)
        {
            Console.WriteLine("⚠️ Temperature problem");
        }
        else if (coolantTemp >= 180 && coolantTemp <= 220)
        {
            Console.WriteLine("✓ Temperature normal");
        }

        // PROBLEM 3: Complex nested disaster
        // BUG: Arrow anti-pattern with multiple logic errors
        if (engineStarts)
        {
            if (rpmIdle > 500)
            {
                if (rpmIdle < 1000)
                {
                    if (oilPressure > 20)
                    {
                        if (oilPressure < 70)
                        {
                            if (!checkEngineLight)
                            {
                                Console.WriteLine("✓ Engine running perfectly");
                            }
                            else
                            {
                                Console.WriteLine("⚠️ Check engine light on");
                            }
                        }
                        else
                        {
                            Console.WriteLine("⚠️ Oil pressure too high");
                        }
                    }
                    else
                    {
                        Console.WriteLine("⚠️ Oil pressure too low");
                    }
                }
                else
                {
                    Console.WriteLine("⚠️ Idle speed too high");
                }
            }
            else
            {
                Console.WriteLine("⚠️ Idle speed too low");
            }
        }
        else
        {
            Console.WriteLine("⚠️ Engine won't start");
        }

        // PROBLEM 4: String comparison bugs with OR logic
        // BUG: Should use || but mixing with wrong string comparisons
        if (lastService == "Oil_Change" | lastService == "TUNE_UP" | daysSinceService < 30)
        {
            Console.WriteLine("✓ Recent service completed");
        }

        // PROBLEM 5: Contradictory logic
        bool needsImmedateAttention = false;
        // BUG: These conditions fight each other
        if (oilPressure < 25)
        {
            needsImmedateAttention = true;
        }
        if (coolantTemp > 220)
        {
            needsImmedateAttention = true;
        }
        if (engineStarts && rpmIdle > 700 && rpmIdle < 900)
        {
            needsImmedateAttention = false;  // BUG: Why override safety concerns?
        }

        // PROBLEM 6: Wrong operator precedence with dangerous conditions
        // BUG: This is supposed to check for emergency conditions but logic is wrong
        if (oilPressure < 10 || coolantTemp > 240 && !engineStarts || hasCompression == false)
        {
            Console.WriteLine("🚨 EMERGENCY: Stop engine immediately!");
        }

        // PROBLEM 7: Unreachable code due to logic error
        bool canContinueDriving = true;
        if (oilPressure >= 25 && coolantTemp <= 220 && engineStarts)
        {
            canContinueDriving = true;
        }
        else if (oilPressure >= 25 && coolantTemp <= 220 && engineStarts)  // BUG: Identical condition!
        {
            Console.WriteLine("This message will never print");
            canContinueDriving = false;
        }
        else
        {
            canContinueDriving = false;
        }

        // PROBLEM 8: Complex condition that's hard to understand
        // BUG: What is this even checking? And the logic is probably wrong too.
        if ((engineStarts && hasFuel || hasElectricity) && !(oilPressure < 25 && coolantTemp > 220) || checkEngineLight && daysSinceService > 30 && lastService != "inspection")
        {
            Console.WriteLine("System status: Unclear recommendation");
        }

        // PROBLEM 9: Missing null checks and edge cases
        string? errorCode = GetErrorCode(checkEngineLight);
        // BUG: What if errorCode is null?
        if (errorCode.Length > 0 && errorCode.StartsWith("P0"))
        {
            Console.WriteLine($"Engine error code: {errorCode}");
        }

        Console.WriteLine($"\n📊 Final Assessment:");
        Console.WriteLine($"Can continue driving: {canContinueDriving}");
        Console.WriteLine($"Needs immediate attention: {needsImmedateAttention}");
    }

    // Helper method that sometimes returns null
    static string? GetErrorCode(bool hasCheckEngineLight)
    {
        if (hasCheckEngineLight)
        {
            return "P0171"; // Lean mixture code
        }
        return null;  // No error code
    }
}

/*
🔧 DEBUGGING STRATEGY:

1. OPERATOR PRECEDENCE
   && has higher precedence than ||
   Use parentheses to make intentions clear!
   
2. IMPOSSIBLE CONDITIONS
   Think: Can something be < 180 AND > 220?
   
3. ARROW ANTI-PATTERN
   Too much nesting makes code hard to follow
   Consider guard clauses or early returns
   
4. STRING COMPARISON
   "Oil_Change" != "oil_change" 
   Use proper case or ToLower()
   
5. LOGIC CONSISTENCY
   Don't override safety conditions with performance ones!
   
6. NULL SAFETY
   Always check strings for null before using methods
   
7. COMPLEX CONDITIONS
   If you need a comment to explain it, extract to a variable!

🎯 YOUR MISSION:
- Make the diagnostic logic actually work
- Simplify the nested nightmare 
- Fix all the logical contradictions
- Handle edge cases safely
- Make the code readable

When working: fix one issue at a time and test!
*/
