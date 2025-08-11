// 🔧 Exercise 2: Service Queue Processor (Bug Hunt)
//
// Purpose:
//   Process today's service jobs until closing time with emergencies handled first.
//   Track how many jobs were completed and the total revenue.
//
// Your task:
//   This program is almost correct but contains 1–2 subtle logic bugs.
//   Find and fix them so the output matches the acceptance checks below.
//
// Acceptance checks (with current sample data and 8-hour day):
//   • Processed jobs: 5
//   • Total revenue: $549.95
//   • Remaining in queue: 1
//
// Hints:
//   • Verify when you add revenue/time vs. when you check for remaining time
//   • Ensure the remaining count is based on what was actually processed

using System;
using System.Collections.Generic;
using System.Linq;

class Exercise2_ServiceQueue
{
    public class Job
    {
        public string Name { get; set; } = "";
        public bool IsEmergency { get; set; }
        public int DurationMin { get; set; }
        public double Price { get; set; }
    }

    static void Main()
    {
        Console.WriteLine("=== Service Queue Processor ===\n");

        const int dayMinutes = 8 * 60; // 8 hours
        int elapsed = 0;
        int processed = 0;
        double revenue = 0.0;

        var jobs = GetJobs()
            .OrderByDescending(j => j.IsEmergency) // emergencies first
            .ToList();

        foreach (var job in jobs)
        {
            Console.WriteLine(
                $"Considering: {job.Name} ({job.DurationMin} min){(job.IsEmergency ? " [EMERGENCY]" : "")}"
            );

            // BUG 1: Adds revenue/time before verifying available time (last job may not fit)
            revenue += job.Price;
            elapsed += job.DurationMin;

            if (elapsed > dayMinutes)
            {
                Console.WriteLine("⏰ Out of time before starting this job.");
                break; // Should not count this job or its revenue
            }

            processed++;
            Console.WriteLine($"  ✅ Processed at {FormatTime(elapsed)}");
        }

        int remaining = jobs.Count - processed; // BUG 2 possibility: if counting included an unprocessed job

        Console.WriteLine("\n--- End of Day ---");
        Console.WriteLine($"Processed jobs: {processed}");
        Console.WriteLine($"Total revenue: ${revenue:F2}");
        Console.WriteLine($"Remaining in queue: {remaining}");

        Console.WriteLine("\nExpected (when fixed):");
        Console.WriteLine("  Processed jobs: 5");
        Console.WriteLine("  Total revenue: $549.95");
        Console.WriteLine("  Remaining in queue: 1");
    }

    static List<Job> GetJobs()
    {
        return new List<Job>
        {
            new Job
            {
                Name = "Brake Repair",
                IsEmergency = true,
                DurationMin = 120,
                Price = 249.99,
            },
            new Job
            {
                Name = "Oil Change",
                IsEmergency = false,
                DurationMin = 30,
                Price = 29.99,
            },
            new Job
            {
                Name = "Full Service",
                IsEmergency = false,
                DurationMin = 180,
                Price = 149.99,
            },
            new Job
            {
                Name = "Tire Rotation",
                IsEmergency = false,
                DurationMin = 45,
                Price = 19.99,
            },
            new Job
            {
                Name = "Inspection",
                IsEmergency = false,
                DurationMin = 60,
                Price = 35.00,
            },
            new Job
            {
                Name = "Towing",
                IsEmergency = true,
                DurationMin = 90,
                Price = 99.99,
            },
        };
    }

    static string FormatTime(int minutes)
    {
        int hours = minutes / 60;
        int mins = minutes % 60;
        return $"{hours}:{mins:D2}";
    }
}
