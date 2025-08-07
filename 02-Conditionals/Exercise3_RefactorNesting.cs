// 🔧 Exercise 3: Refactor the Nesting Nightmare
//
// This appointment scheduler works, but it's a MESS!
// The logic is buried under layers of nested if statements.
// Your job: Refactor this into clean, readable code.
//
// REFACTORING GOALS:
// 1. Convert deep nesting to guard clauses (fail fast)
// 2. Extract complex boolean expressions to named variables
// 3. Eliminate duplicate condition checks
// 4. Make the flow easier to follow
// 5. Reduce cognitive load (less mental juggling)

using System;

class Exercise3_RefactorNesting
{
    static void RunExercise()
    {
        Console.WriteLine("=== Service Appointment Scheduler (Messy Version) ===\n");

        // Customer and appointment data
        string customerName = "John Smith";
        string customerType = "VIP";
        bool hasValidInsurance = true;
        bool hasPendingBills = false;
        int requestedDay = 3;  // 1=Monday, 2=Tuesday, etc.
        int requestedHour = 9;  // 24-hour format
        string serviceType = "brake_service";
        bool isEmergency = false;

        // Shop data
        bool[] mechanicAvailable = { false, true, true, false, true }; // Bay 1-5
        int[] baySpecialty = { 1, 2, 2, 3, 1 }; // 1=general, 2=brake, 3=engine
        bool hasNecessaryParts = true;
        double estimatedHours = 2.5;

        // The NESTING NIGHTMARE begins here...
        // This works but is impossible to maintain!

        Console.WriteLine("🔍 Processing appointment request...");

        if (customerName != null && customerName.Length > 0)
        {
            if (customerType == "VIP" || customerType == "Regular" || customerType == "New")
            {
                if (hasValidInsurance == true)
                {
                    if (hasPendingBills == false)
                    {
                        if (requestedDay >= 1 && requestedDay <= 5)
                        {
                            if (requestedHour >= 8 && requestedHour <= 17)
                            {
                                if (serviceType == "oil_change" || serviceType == "brake_service" || serviceType == "engine_work" || serviceType == "inspection")
                                {
                                    if (hasNecessaryParts == true)
                                    {
                                        // Find available mechanic
                                        bool foundMechanic = false;
                                        int assignedBay = -1;

                                        for (int bay = 0; bay < mechanicAvailable.Length; bay++)
                                        {
                                            if (mechanicAvailable[bay] == true)
                                            {
                                                if (serviceType == "brake_service")
                                                {
                                                    if (baySpecialty[bay] == 2 || baySpecialty[bay] == 1)
                                                    {
                                                        foundMechanic = true;
                                                        assignedBay = bay + 1;
                                                        break;
                                                    }
                                                }
                                                else if (serviceType == "engine_work")
                                                {
                                                    if (baySpecialty[bay] == 3 || baySpecialty[bay] == 1)
                                                    {
                                                        foundMechanic = true;
                                                        assignedBay = bay + 1;
                                                        break;
                                                    }
                                                }
                                                else
                                                {
                                                    if (baySpecialty[bay] == 1)
                                                    {
                                                        foundMechanic = true;
                                                        assignedBay = bay + 1;
                                                        break;
                                                    }
                                                }
                                            }
                                        }

                                        if (foundMechanic == true)
                                        {
                                            if (estimatedHours <= 8)
                                            {
                                                if (isEmergency == true)
                                                {
                                                    Console.WriteLine($"🚨 EMERGENCY appointment scheduled!");
                                                    Console.WriteLine($"Customer: {customerName} ({customerType})");
                                                    Console.WriteLine($"Service: {serviceType}");
                                                    Console.WriteLine($"Bay: {assignedBay}");
                                                    Console.WriteLine($"Time: Day {requestedDay}, {requestedHour}:00");
                                                    Console.WriteLine($"Duration: {estimatedHours} hours");
                                                }
                                                else
                                                {
                                                    if (customerType == "VIP")
                                                    {
                                                        Console.WriteLine($"✅ VIP appointment scheduled!");
                                                        Console.WriteLine($"Customer: {customerName}");
                                                        Console.WriteLine($"Service: {serviceType}");
                                                        Console.WriteLine($"Bay: {assignedBay} (VIP priority)");
                                                        Console.WriteLine($"Time: Day {requestedDay}, {requestedHour}:00");
                                                        Console.WriteLine($"Duration: {estimatedHours} hours");
                                                        Console.WriteLine($"Complimentary coffee and Wi-Fi included!");
                                                    }
                                                    else
                                                    {
                                                        Console.WriteLine($"✅ Regular appointment scheduled!");
                                                        Console.WriteLine($"Customer: {customerName} ({customerType})");
                                                        Console.WriteLine($"Service: {serviceType}");
                                                        Console.WriteLine($"Bay: {assignedBay}");
                                                        Console.WriteLine($"Time: Day {requestedDay}, {requestedHour}:00");
                                                        Console.WriteLine($"Duration: {estimatedHours} hours");
                                                    }
                                                }
                                            }
                                            else
                                            {
                                                Console.WriteLine("❌ Service too long (max 8 hours per day)");
                                            }
                                        }
                                        else
                                        {
                                            Console.WriteLine("❌ No qualified mechanic available");
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("❌ Necessary parts not in stock");
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("❌ Invalid service type");
                                }
                            }
                            else
                            {
                                Console.WriteLine("❌ Invalid time (shop hours: 8 AM - 5 PM)");
                            }
                        }
                        else
                        {
                            Console.WriteLine("❌ Invalid day (Monday-Friday only)");
                        }
                    }
                    else
                    {
                        Console.WriteLine("❌ Cannot schedule with pending bills");
                    }
                }
                else
                {
                    Console.WriteLine("❌ Valid insurance required");
                }
            }
            else
            {
                Console.WriteLine("❌ Invalid customer type");
            }
        }
        else
        {
            Console.WriteLine("❌ Customer name required");
        }

        Console.WriteLine("\n💭 This code works... but at what cost?");
        Console.WriteLine("   - 15+ levels of nesting!");
        Console.WriteLine("   - Impossible to debug");
        Console.WriteLine("   - Duplicate logic everywhere");
        Console.WriteLine("   - Arrow anti-pattern in full effect");

        // Even more nested horror for special cases...
        if (isEmergency)
        {
            if (customerType == "VIP")
            {
                if (hasValidInsurance)
                {
                    if (!hasPendingBills)
                    {
                        if (serviceType == "engine_work" || serviceType == "brake_service")
                        {
                            // Emergency logic buried 5 levels deep!
                            Console.WriteLine("⚡ Emergency VIP fast-track enabled");
                        }
                    }
                }
            }
        }
    }
}

/*
🎯 YOUR REFACTORING MISSION:

1. GUARD CLAUSES (Fail Fast)
   Instead of: if (valid) { ... big block ... }
   Use: if (!valid) return; ... rest of code ...

2. EXTRACT CONDITIONS
   Instead of: if (a > 5 && b < 10 && c == "test")
   Use: bool isValidCondition = a > 5 && b < 10 && c == "test";
        if (isValidCondition)

3. EARLY RETURNS
   Don't nest everything in one big if block
   Exit early when requirements aren't met

4. MEANINGFUL NAMES
   Give your extracted booleans descriptive names
   hasValidCustomerInfo, isWithinBusinessHours, etc.

5. ELIMINATE DUPLICATION
   The customer type checking happens multiple times!

🏆 SUCCESS CRITERIA:
- Maximum 3 levels of nesting
- No duplicate condition checks
- Each method under 20 lines
- Clear, readable flow
- Easy to add new conditions

BONUS CHALLENGE:
Extract logical groups into separate methods:
- ValidateCustomer()
- ValidateAppointment()  
- FindAvailableBay()
- ScheduleAppointment()

Remember: The best code reads like well-written prose!
*/
