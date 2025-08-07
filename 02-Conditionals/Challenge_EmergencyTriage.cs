// 🔧 Challenge: Emergency Service Triage System
//
// ADVANCED CHALLENGE! 
// Build a sophisticated emergency triage system that prioritizes 
// multiple incoming service requests based on complex criteria.
//
// This combines everything: conditionals, priorities, resource allocation,
// and real-time decision making. Think like an ER triage nurse!

using System;
using System.Collections.Generic;

class Program
{
    // Service request structure for your triage system
    public class ServiceRequest
    {
        public string CustomerName { get; set; } = "";
        public string CustomerType { get; set; } = ""; // VIP, Regular, New
        public string VehicleType { get; set; } = ""; // Car, Truck, Motorcycle
        public string ProblemType { get; set; } = ""; // Engine, Brake, Electrical, etc.
        public int SeverityLevel { get; set; } // 1-10 (10 = most urgent)
        public bool IsSafetyIssue { get; set; }
        public bool IsStranded { get; set; }
        public double DistanceFromShop { get; set; } // Miles
        public bool HasAAA { get; set; }
        public bool UnderWarranty { get; set; }
        public DateTime RequestTime { get; set; }
        public double EstimatedCost { get; set; }
        public double EstimatedDuration { get; set; } // Hours
        public bool NeedsSpecialEquipment { get; set; }
        public bool NeedsTowing { get; set; }
    }
    
    static void Main()
    {
        Console.WriteLine("=== Emergency Service Triage System ===\n");
        Console.WriteLine("🚨 Multiple emergency requests incoming!\n");
        
        // Simulate multiple simultaneous emergency requests
        var requests = GetEmergencyRequests();
        
        Console.WriteLine($"📱 {requests.Count} emergency requests received:");
        for (int i = 0; i < requests.Count; i++)
        {
            var req = requests[i];
            Console.WriteLine($"  {i+1}. {req.CustomerName} - {req.ProblemType} (Severity: {req.SeverityLevel})");
        }
        
        Console.WriteLine("\n🎯 YOUR CHALLENGE:");
        Console.WriteLine("Build a TriageRequests() method that:");
        Console.WriteLine("1. Prioritizes all requests intelligently");
        Console.WriteLine("2. Assigns appropriate resources");
        Console.WriteLine("3. Handles resource conflicts");
        Console.WriteLine("4. Provides clear reasoning for decisions");
        Console.WriteLine("5. Optimizes for both safety and business");
        
        // TODO: Implement your triage system!
        // TriageRequests(requests);
        
        Console.WriteLine("\n⚠️ Replace this placeholder with your solution!");
        ShowTriageRequirements();
    }
    
    static List<ServiceRequest> GetEmergencyRequests()
    {
        return new List<ServiceRequest>
        {
            new ServiceRequest 
            {
                CustomerName = "Sarah Johnson",
                CustomerType = "VIP",
                VehicleType = "Car",
                ProblemType = "Brake",
                SeverityLevel = 9, // Very serious!
                IsSafetyIssue = true,
                IsStranded = false,
                DistanceFromShop = 5.2,
                HasAAA = true,
                UnderWarranty = true,
                RequestTime = DateTime.Now.AddMinutes(-15),
                EstimatedCost = 450.00,
                EstimatedDuration = 3.0,
                NeedsSpecialEquipment = false,
                NeedsTowing = false
            },
            new ServiceRequest 
            {
                CustomerName = "Mike Rodriguez",
                CustomerType = "Regular",
                VehicleType = "Truck",
                ProblemType = "Engine",
                SeverityLevel = 10, // Maximum urgency!
                IsSafetyIssue = true,
                IsStranded = true,
                DistanceFromShop = 15.7,
                HasAAA = false,
                UnderWarranty = false,
                RequestTime = DateTime.Now.AddMinutes(-8),
                EstimatedCost = 1200.00,
                EstimatedDuration = 6.0,
                NeedsSpecialEquipment = true,
                NeedsTowing = true
            },
            new ServiceRequest 
            {
                CustomerName = "Emily Chen",
                CustomerType = "New",
                VehicleType = "Car",
                ProblemType = "Electrical",
                SeverityLevel = 6,
                IsSafetyIssue = false,
                IsStranded = true,
                DistanceFromShop = 2.1,
                HasAAA = true,
                UnderWarranty = true,
                RequestTime = DateTime.Now.AddMinutes(-25),
                EstimatedCost = 275.00,
                EstimatedDuration = 2.5,
                NeedsSpecialEquipment = false,
                NeedsTowing = false
            },
            new ServiceRequest 
            {
                CustomerName = "Robert Wilson",
                CustomerType = "VIP",
                VehicleType = "Motorcycle",
                ProblemType = "Transmission",
                SeverityLevel = 7,
                IsSafetyIssue = true,
                IsStranded = true,
                DistanceFromShop = 8.3,
                HasAAA = false,
                UnderWarranty = false,
                RequestTime = DateTime.Now.AddMinutes(-3),
                EstimatedCost = 800.00,
                EstimatedDuration = 4.0,
                NeedsSpecialEquipment = true,
                NeedsTowing = true
            },
            new ServiceRequest 
            {
                CustomerName = "Lisa Thompson",
                CustomerType = "Regular",
                VehicleType = "Car",
                ProblemType = "Cooling",
                SeverityLevel = 8,
                IsSafetyIssue = true,
                IsStranded = false,
                DistanceFromShop = 12.4,
                HasAAA = true,
                UnderWarranty = true,
                RequestTime = DateTime.Now.AddMinutes(-20),
                EstimatedCost = 650.00,
                EstimatedDuration = 4.5,
                NeedsSpecialEquipment = false,
                NeedsTowing = false
            }
        };
    }
    
    static void ShowTriageRequirements()
    {
        Console.WriteLine("\n📋 TRIAGE SYSTEM REQUIREMENTS:");
        Console.WriteLine("\n🎯 PRIORITY FACTORS (in order of importance):");
        Console.WriteLine("  1. SAFETY FIRST - Life-threatening issues get absolute priority");
        Console.WriteLine("  2. STRANDED STATUS - People stuck get priority over mobile customers");
        Console.WriteLine("  3. SEVERITY LEVEL - Higher numbers = more urgent");
        Console.WriteLine("  4. CUSTOMER TYPE - VIP > Regular > New (but safety trumps this!)");
        Console.WriteLine("  5. DISTANCE - Closer customers get slight priority");
        Console.WriteLine("  6. WAIT TIME - Earlier requests get tiebreaker priority");
        Console.WriteLine("  7. WARRANTY STATUS - Warranty work slightly prioritized");
        
        Console.WriteLine("\n🔧 RESOURCE CONSTRAINTS:");
        Console.WriteLine("  • Only 2 mobile mechanics available");
        Console.WriteLine("  • Only 1 tow truck available");  
        Console.WriteLine("  • Shop has 4 bays (1 with special equipment)");
        Console.WriteLine("  • Maximum 3 emergency services per hour");
        Console.WriteLine("  • Senior mechanic needed for severity 8+ problems");
        
        Console.WriteLine("\n⚖️ BUSINESS RULES:");
        Console.WriteLine("  • Safety issues always come first (regardless of customer type)");
        Console.WriteLine("  • VIP customers get preference when safety is equal");
        Console.WriteLine("  • Stranded customers take priority over mobile ones");
        Console.WriteLine("  • New customers might need additional verification time");
        Console.WriteLine("  • Warranty work has different profit margins");
        Console.WriteLine("  • Long-distance calls need travel time consideration");
        
        Console.WriteLine("\n📊 YOUR TRIAGE METHOD SHOULD:");
        Console.WriteLine("  1. Calculate a priority score for each request");
        Console.WriteLine("  2. Sort requests by priority");
        Console.WriteLine("  3. Assign appropriate resources (mechanic, bay, tow truck)");
        Console.WriteLine("  4. Handle resource conflicts intelligently");
        Console.WriteLine("  5. Provide estimated response times");
        Console.WriteLine("  6. Give clear explanations for prioritization decisions");
        Console.WriteLine("  7. Suggest alternatives when resources are limited");
        
        Console.WriteLine("\n🧮 SUGGESTED SCORING ALGORITHM:");
        Console.WriteLine("  Priority Score = ");
        Console.WriteLine("    (SafetyMultiplier * 1000) +");
        Console.WriteLine("    (StrandedBonus * 500) +");
        Console.WriteLine("    (SeverityLevel * 100) +");
        Console.WriteLine("    (CustomerTypeBonus * 50) +");
        Console.WriteLine("    (WarrantyBonus * 25) +");
        Console.WriteLine("    (DistanceBonus * 10) +");
        Console.WriteLine("    (WaitTimeBonus * 5)");
        
        Console.WriteLine("\n💡 ADVANCED FEATURES TO CONSIDER:");
        Console.WriteLine("  • Multi-criteria decision making");
        Console.WriteLine("  • Resource optimization");
        Console.WriteLine("  • Customer communication (ETA updates)");
        Console.WriteLine("  • Dynamic re-prioritization as new requests arrive");
        Console.WriteLine("  • Cost-benefit analysis");
        Console.WriteLine("  • Load balancing across mechanics");
        
        Console.WriteLine("\n🧪 EXPECTED OUTPUT EXAMPLE:");
        Console.WriteLine("  === TRIAGE RESULTS ===");
        Console.WriteLine("  Priority 1: Mike Rodriguez (Score: 2850)");
        Console.WriteLine("    Reason: Stranded + Safety + Severity 10");
        Console.WriteLine("    Assigned: Mobile Mechanic #1 + Tow Truck");
        Console.WriteLine("    ETA: 25 minutes");
        Console.WriteLine("  ");
        Console.WriteLine("  Priority 2: Sarah Johnson (Score: 1975)");
        Console.WriteLine("    Reason: Safety + VIP + High Severity");
        Console.WriteLine("    Assigned: Bay #3 (ready now)");
        Console.WriteLine("    ETA: Customer can drive in");
        
        Console.WriteLine("\n🎖️ BONUS CHALLENGES:");
        Console.WriteLine("  • Handle edge cases (all mechanics busy, equipment down)");
        Console.WriteLine("  • Implement a waiting list with notifications");
        Console.WriteLine("  • Add weather considerations (rain affects mobile service)");
        Console.WriteLine("  • Create a callback system for status updates");
        Console.WriteLine("  • Optimize for maximum shop revenue vs. customer satisfaction");
        
        Console.WriteLine("\n🏆 MASTERY CRITERIA:");
        Console.WriteLine("  ✅ Logical, defensible prioritization");
        Console.WriteLine("  ✅ Proper resource allocation");
        Console.WriteLine("  ✅ Clear reasoning for decisions");
        Console.WriteLine("  ✅ Handles edge cases gracefully");
        Console.WriteLine("  ✅ Balances safety, service, and business needs");
        Console.WriteLine("  ✅ Code is clean and well-structured");
        
        Console.WriteLine("\n🚀 This is a real-world problem!");
        Console.WriteLine("Emergency service dispatchers face exactly these decisions.");
        Console.WriteLine("Your solution should be something you'd trust with people's safety!");
    }
    
    // TODO: Implement these methods!
    
    /*
    static List<ServiceRequest> TriageRequests(List<ServiceRequest> requests)
    {
        // Your sophisticated triage logic goes here!
        // Return the sorted list by priority
    }
    
    static int CalculatePriority(ServiceRequest request)
    {
        // Calculate and return priority score
    }
    
    static void AssignResources(List<ServiceRequest> sortedRequests)
    {
        // Assign mechanics, bays, tow trucks
    }
    
    static void DisplayTriageResults(List<ServiceRequest> triaged)
    {
        // Show the final prioritization with explanations
    }
    */
}

/*
🎯 FINAL THOUGHT:

This challenge combines everything you've learned about conditionals:
- Complex decision trees
- Multiple criteria evaluation  
- Priority scoring algorithms
- Resource allocation
- Edge case handling
- Clear logical reasoning

The goal isn't just to make it work - it's to make decisions you can 
defend and explain. In the real world, you might have to justify why
Customer A got served before Customer B.

Think like a professional: What would you want if YOU were the customer
calling for emergency service?

Good luck! 🔧⚡
*/
