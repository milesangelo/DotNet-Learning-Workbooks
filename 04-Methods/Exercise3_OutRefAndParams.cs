// 🔧 Exercise 3: out/ref/params — Preferred Bay (Bug Hunt)
// Purpose: Choose a preferred bay and compute total duration of steps.
//
// Bugs to find (exactly 2):
// 1) TryGetPreferredBay does not assign out parameter on all paths
// 2) TryGetPreferredBay returns true even when no bay is found
//
// Acceptance checks:
//   TryGetPreferredBay("brake_service", out bay) → true, bay == 3
//   TryGetPreferredBay("unknown", out bay) → false, bay == -1
//   TotalDuration(30, 60, 15) → 105

using System;

class Exercise3_OutRefAndParams
{
    static void Main()
    {
        Console.WriteLine("=== Preferred Bay & Duration ===\n");

        string s1 = "brake_service";
        if (TryGetPreferredBay(s1, out int bay1))
            Console.WriteLine($"{s1} → Bay {bay1}");
        else
            Console.WriteLine($"{s1} → No preferred bay");

        string s2 = "unknown";
        if (TryGetPreferredBay(s2, out int bay2))
            Console.WriteLine($"{s2} → Bay {bay2}");
        else
            Console.WriteLine($"{s2} → No preferred bay");

        var minutes = TotalDuration(30, 60, 15);
        Console.WriteLine($"Total duration: {minutes} min");

        Console.WriteLine(
            "\nExpected when fixed:\n  brake_service → Bay 3\n  unknown → No preferred bay\n  Total duration: 105 min"
        );
    }

    static bool TryGetPreferredBay(string serviceType, out int bay)
    {
        // Normalize input
        NormalizeServiceType(ref serviceType);

        if (serviceType == "oil_change")
        {
            bay = 1;
            return true;
        }
        if (serviceType == "engine_repair")
        {
            bay = 2;
            return true;
        }
        if (serviceType == "brake_service")
        {
            bay = 3;
            return true;
        }

        // BUG 1 + 2: not assigning out param; returning true
        return true;
    }

    static void NormalizeServiceType(ref string serviceType)
    {
        serviceType = serviceType.Trim().ToLowerInvariant();
    }

    static int TotalDuration(params int[] steps)
    {
        int total = 0;
        foreach (var s in steps)
        {
            total += s;
        }
        return total;
    }
}
