// 🔧 Exercise 2: Debug the Service Queue Processor
//
// This service queue system is supposed to process customers
// throughout the day, but it has multiple loop control issues.
// It's not handling priorities correctly, can't stop at closing time,
// and sometimes processes the same customer multiple times!

using System;
using System.Collections.Generic;

class Exercise2_ServiceQueue
{
    // Customer data structure
    public class Customer
    {
        public string Name { get; set; } = "";
        public string ServiceType { get; set; } = "";
        public bool IsPriority { get; set; }
        public bool IsProcessed { get; set; }
        public int WaitTime { get; set; } // minutes
        public double ServiceCost { get; set; }
    }

    static void Main()
    {
        Console.WriteLine("=== Service Queue Processor (BROKEN) ===\n");

        // Initialize the service queue
        var serviceQueue = GetCustomerQueue();

        Console.WriteLine($"📋 Starting day with {serviceQueue.Count} customers in queue\n");

        // Shop operating data
        bool shopIsOpen = true;
        int currentTime = 480; // 8:00 AM in minutes (8 * 60)
        int closingTime = 1020; // 5:00 PM in minutes (17 * 60)
        int processedCount = 0;
        double totalRevenue = 0;

        Console.WriteLine("🔧 Processing customer queue...\n");

        // PROBLEM 1: Wrong loop type and condition
        // This should use while loop, not for, since queue changes
        for (int i = 0; i < serviceQueue.Count; i++)
        {
            var customer = serviceQueue[i];

            // PROBLEM 2: Time check is backwards!
            if (currentTime >= closingTime) // BUG: Should be >= not <
            {
                Console.WriteLine($"⏰ Shop closed at {FormatTime(currentTime)}");
                continue; // BUG: Continue doesn't make sense here - should break
            }

            // PROBLEM 3: Priority customer logic is inverted
            if (customer.IsPriority)
            {
                continue; // BUG: This SKIPS priority customers instead of processing them first!
            }

            // PROBLEM 4: Already processed check is wrong
            if (customer.IsProcessed == false) // BUG: Double negative logic, confusing
            {
                continue; // BUG: This skips unprocessed customers!
            }

            // Process the customer
            Console.WriteLine($"🔧 Processing: {customer.Name} - {customer.ServiceType}");

            // PROBLEM 5: Time advancement logic error
            int serviceTime = GetServiceTime(customer.ServiceType);
            currentTime += serviceTime;
            customer.WaitTime += serviceTime; // BUG: Wait time should not include service time!

            // Mark as processed
            customer.IsProcessed = true;
            processedCount++;
            totalRevenue += customer.ServiceCost;

            // PROBLEM 6: Removing from list while iterating!
            serviceQueue.RemoveAt(i); // BUG: This changes indices, skips customers!

            Console.WriteLine($"✅ Completed {customer.Name} at {FormatTime(currentTime)}");
        }

        // PROBLEM 7: Second pass with different loop issues
        Console.WriteLine("\n--- Processing Remaining Priority Customers ---");
        int priorityIndex = 0;
        while (priorityIndex < serviceQueue.Count)
        {
            var customer = serviceQueue[priorityIndex];

            if (!customer.IsPriority)
            {
                priorityIndex++; // Skip non-priority
                continue;
            }

            // PROBLEM 8: Infinite loop potential!
            if (currentTime > closingTime)
            {
                Console.WriteLine("⏰ Too late for more customers");
                // BUG: No break statement! Loop will continue forever
            }

            // Process priority customer
            Console.WriteLine($"⚡ Priority service: {customer.Name}");
            int serviceTime = GetServiceTime(customer.ServiceType);
            currentTime += serviceTime;

            customer.IsProcessed = true;
            processedCount++;
            totalRevenue += customer.ServiceCost;

            // BUG: Not incrementing priorityIndex, will process same customer forever!
        }

        // PROBLEM 9: Nested loop confusion
        Console.WriteLine("\n--- Final Status Report ---");

        // This nested loop makes no sense for this task!
        foreach (var customer in serviceQueue)
        {
            for (int status = 0; status < 3; status++)
            {
                if (status == 0 && customer.IsProcessed)
                {
                    Console.WriteLine($"✅ {customer.Name}: Completed");
                    break; // BUG: Only breaks inner loop
                }
                else if (status == 1 && !customer.IsProcessed)
                {
                    Console.WriteLine($"⏳ {customer.Name}: Still waiting");
                    break;
                }
                else if (status == 2)
                {
                    Console.WriteLine($"❓ {customer.Name}: Unknown status");
                }
                // BUG: This loop runs unnecessarily 3 times per customer
            }
        }

        // PROBLEM 10: Do-while loop used incorrectly
        Console.WriteLine("\n--- Customer Satisfaction Survey ---");
        int surveyIndex = 0;
        do
        {
            if (surveyIndex >= serviceQueue.Count) // BUG: Check should be before array access
            {
                break;
            }

            var customer = serviceQueue[surveyIndex];
            if (customer.IsProcessed && customer.WaitTime > 30)
            {
                Console.WriteLine($"📋 Survey sent to {customer.Name} (waited {customer.WaitTime} min)");
            }

            surveyIndex++;

        } while (surveyIndex < serviceQueue.Count); // BUG: Condition already checked inside!

        // Summary
        Console.WriteLine($"\n📊 End of Day Summary:");
        Console.WriteLine($"Customers processed: {processedCount}");
        Console.WriteLine($"Total revenue: ${totalRevenue:F2}");
        Console.WriteLine($"Closed at: {FormatTime(currentTime)}");
    }

    static List<Customer> GetCustomerQueue()
    {
        return new List<Customer>
        {
            new Customer { Name = "John Smith", ServiceType = "Oil Change", IsPriority = false, ServiceCost = 29.99, WaitTime = 10 },
            new Customer { Name = "Emergency Sarah", ServiceType = "Brake Repair", IsPriority = true, ServiceCost = 249.99, WaitTime = 5 },
            new Customer { Name = "Mike Johnson", ServiceType = "Tire Rotation", IsPriority = false, ServiceCost = 19.99, WaitTime = 15 },
            new Customer { Name = "VIP Customer", ServiceType = "Full Service", IsPriority = true, ServiceCost = 149.99, WaitTime = 2 },
            new Customer { Name = "Lisa Chen", ServiceType = "Inspection", IsPriority = false, ServiceCost = 35.00, WaitTime = 20 },
            new Customer { Name = "Emergency Bob", ServiceType = "Towing", IsPriority = true, ServiceCost = 99.99, WaitTime = 1 }
        };
    }

    static int GetServiceTime(string serviceType)
    {
        return serviceType switch
        {
            "Oil Change" => 30,
            "Brake Repair" => 120,
            "Tire Rotation" => 45,
            "Full Service" => 180,
            "Inspection" => 60,
            "Towing" => 90,
            _ => 30
        };
    }

    static string FormatTime(int minutes)
    {
        int hours = minutes / 60;
        int mins = minutes % 60;
        return $"{hours}:{mins:D2}";
    }
}

/*
🔧 DEBUGGING STRATEGY:

1. LOOP TYPE SELECTION:
   • Use for when you know exact iterations
   • Use while when condition-based (queue processing)
   • Use foreach for simple iteration over all items

2. MODIFYING COLLECTIONS:
   • NEVER remove items while iterating with for/foreach
   • Use reverse iteration or collect items to remove separately
   • Consider using Queue<T> or Stack<T> for FIFO/LIFO operations

3. BREAK vs CONTINUE:
   • break: Exit the entire loop
   • continue: Skip to next iteration
   • In nested loops, affects only the innermost loop

4. INFINITE LOOP PREVENTION:
   • Always ensure loop condition can become false
   • Check that counters/indices are updated correctly
   • Add safety checks or maximum iteration limits

5. LOGICAL CONDITIONS:
   • Double-check your if conditions
   • !customer.IsProcessed means "not processed" (should process)
   • customer.IsProcessed means "already processed" (skip)

🎯 EXPECTED BEHAVIOR:
1. Process priority customers first
2. Stop processing at closing time
3. Don't process the same customer twice
4. Don't modify collection while iterating
5. Handle empty queue gracefully
6. Provide accurate time and revenue tracking

💡 PRO TIPS:
• Use Queue<T> for FIFO processing
• Sort by priority before processing
• Keep track of state changes carefully
• Test with edge cases (empty queue, all priority, past closing)
*/
