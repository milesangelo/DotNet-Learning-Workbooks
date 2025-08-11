// 🔧 Exercise 2: Service Day Simulator (Bug Hunt)
// Purpose: Simulate processing of a daily queue with priorities and closing time.
//
// Bugs to find (exactly 2):
// 1) Uses continue instead of break at closing time
// 2) Off-by-one when checking remaining minutes
//
// Acceptance check (expected when fixed):
//   Processed: 5, Revenue: $549.95, Remaining: 1

using System;
using System.Collections.Generic;
using System.Linq;

class Exercise2_ServiceDaySimulator
{
    class Job
    {
        public string Name { get; set; } = "";
        public bool Emergency { get; set; }
        public int Minutes { get; set; }
        public double Price { get; set; }
    }

    static void Main()
    {
        var jobs = Seed().OrderByDescending(j => j.Emergency).ToList();
        int day = 8 * 60;
        int elapsed = 0;
        int processed = 0;
        double revenue = 0;

        foreach (var j in jobs)
        {
            // BUG 2: off-by-one: should be if (elapsed + j.Minutes > day)
            if (elapsed + j.Minutes >= day)
            {
                Console.WriteLine("Closing time reached.");
                // BUG 1: continue instead of break
                continue;
            }

            elapsed += j.Minutes;
            revenue += j.Price;
            processed++;
        }

        int remaining = jobs.Count - processed;
        Console.WriteLine(
            $"Processed: {processed}, Revenue: ${revenue:F2}, Remaining: {remaining}"
        );
        Console.WriteLine("Expected when fixed: Processed: 5, Revenue: $549.95, Remaining: 1");
    }

    static List<Job> Seed() =>
        new()
        {
            new Job
            {
                Name = "Brake Repair",
                Emergency = true,
                Minutes = 120,
                Price = 249.99,
            },
            new Job
            {
                Name = "Oil Change",
                Emergency = false,
                Minutes = 30,
                Price = 29.99,
            },
            new Job
            {
                Name = "Full Service",
                Emergency = false,
                Minutes = 180,
                Price = 149.99,
            },
            new Job
            {
                Name = "Tire Rotation",
                Emergency = false,
                Minutes = 45,
                Price = 19.99,
            },
            new Job
            {
                Name = "Inspection",
                Emergency = false,
                Minutes = 60,
                Price = 35.00,
            },
            new Job
            {
                Name = "Towing",
                Emergency = true,
                Minutes = 90,
                Price = 99.99,
            },
        };
}
