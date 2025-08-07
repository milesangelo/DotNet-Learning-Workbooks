// 🔧 Exercise 4: Build a Smart Appointment Scheduler
//
// BUILD FROM SCRATCH! 
// Create a sophisticated appointment scheduling system that makes 
// smart decisions based on multiple factors.
//
// This is your chance to apply everything you've learned about
// conditionals to solve a real-world problem from the ground up.

using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("=== Smart Appointment Scheduler ===\n");
        Console.WriteLine("🎯 Your mission: Build this system from scratch!\n");
        
        // TODO: Replace this placeholder with your implementation
        Console.WriteLine("⚠️ PLACEHOLDER - Build your scheduler here!");
        
        // Uncomment and modify this when you start:
        // TestYourScheduler();
    }
    
    // TODO: Implement this method
    static void TestYourScheduler()
    {
        Console.WriteLine("🧪 Testing your scheduler...\n");
        
        // Test cases to verify your logic
        Console.WriteLine("Test 1: VIP customer, brake service, weekday morning");
        // TODO: Call your scheduling method here
        
        Console.WriteLine("\nTest 2: New customer, emergency, weekend");
        // TODO: Call your scheduling method here
        
        Console.WriteLine("\nTest 3: Regular customer, oil change, busy day");
        // TODO: Call your scheduling method here
    }
}

/*
📋 REQUIREMENTS SPECIFICATION:

🎯 CORE FUNCTIONALITY:
Build a method called ScheduleAppointment() that takes parameters and returns a booking result.

📥 INPUT PARAMETERS:
- customerName (string) - Customer's full name
- customerType (string) - "New", "Regular", or "VIP" 
- serviceType (string) - "oil_change", "brake_service", "engine_repair", "inspection"
- isEmergency (bool) - Rush service needed?
- requestedDay (int) - Day of week (1=Monday, 7=Sunday)
- requestedHour (int) - Hour in 24-format (8-17 for business hours)
- estimatedDuration (double) - Hours needed for service

🏪 SHOP CONSTRAINTS:
- Business hours: 8 AM to 5 PM, Monday-Friday
- Weekend emergency service: Available for VIP only, 50% surcharge
- Maximum appointment duration: 6 hours
- Bay capacity: 4 bays total
- Lunch break: 12-1 PM (no new appointments)

👥 CUSTOMER RULES:
- VIP customers: First priority, can book weekend emergencies
- Regular customers: Standard priority, weekdays only
- New customers: Must book inspection first (unless emergency)
- Emergency service: Available anytime for VIP, business hours for others

🔧 SERVICE RULES:
- Oil change: 30 minutes, any bay, any mechanic
- Brake service: 2 hours, needs brake specialist (Bay 1 or 3)
- Engine repair: 3-6 hours, needs senior mechanic (Bay 2 only)
- Inspection: 1 hour, any bay, morning slots preferred

⚖️ BUSINESS LOGIC:
- Priority order: Emergency VIP > Emergency Regular > VIP > Regular > New
- Overbooking allowed: Max 2 appointments per time slot (except engine work)
- Cancellation window: Must be 2+ hours in advance
- Weather delays: Engine work not available during rain (simulate with random)

📊 OUTPUT REQUIREMENTS:
Return a structured result with:
- Success/failure status
- Assigned bay number (if successful)
- Scheduled time
- Estimated cost
- Any warnings or notes
- Wait list position (if fully booked)

🎯 EXAMPLE USAGE:
```csharp
var result = ScheduleAppointment(
    customerName: "John Smith",
    customerType: "VIP", 
    serviceType: "brake_service",
    isEmergency: false,
    requestedDay: 3,     // Wednesday
    requestedHour: 10,   // 10 AM
    estimatedDuration: 2.0
);

Console.WriteLine($"Status: {result.IsBooked}");
Console.WriteLine($"Bay: {result.BayNumber}");
Console.WriteLine($"Cost: ${result.EstimatedCost:F2}");
```

🏗️ SUGGESTED STRUCTURE:

1. Create a Result class to return booking information
2. Validate input parameters first (guard clauses!)
3. Check business hours and day availability
4. Apply customer priority rules
5. Find available bay based on service type
6. Calculate pricing with any surcharges
7. Return comprehensive result

💡 PRO TIPS:

1. Use enums for customer types and service types (more robust than strings)
2. Extract complex conditions to well-named boolean variables
3. Consider creating helper methods for specific checks
4. Use switch expressions for pricing logic
5. Don't forget edge cases (null names, invalid days, etc.)

🧪 TEST SCENARIOS TO HANDLE:

✅ Happy path: VIP brake service on Tuesday at 10 AM
❌ Invalid time: Appointment at 11 PM
❌ Weekend regular: Regular customer wants weekend service  
❌ Overbooked: All bays full at requested time
❌ Wrong service: New customer wants engine work (needs inspection first)
⚠️ Warning: Appointment during lunch break
🔄 Reschedule: Suggest alternative times if requested slot unavailable

🎖️ BONUS CHALLENGES:

1. Implement a waiting list system
2. Add automatic rescheduling suggestions
3. Include weather simulation for engine work
4. Create loyalty points calculation for VIP customers
5. Add multi-day service booking for major repairs

🎯 SUCCESS CRITERIA:

- Compiles without errors
- Handles all edge cases gracefully
- Uses appropriate conditional logic (if/else, switch, ternary)
- Follows guard clause pattern for validation
- Clean, readable code structure
- Comprehensive test coverage

Remember: This is a real-world problem! Think about what could go wrong
and how to handle it elegantly. Good software anticipates problems.

Start small, get it working, then add features. You've got this! 🔧
*/
