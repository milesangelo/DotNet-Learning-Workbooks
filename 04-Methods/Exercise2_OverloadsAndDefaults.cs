// 🔧 Exercise 2: Overloads and Defaults — Appointment Slot (Bug Hunt)
// Purpose: Choose the next available appointment slot using overloads/defaults.
//
// Bugs to find (exactly 2):
// 1) Default parameter ignored (always uses 10 even when an hour is provided)
// 2) Overload mismatch: wrong parameter order causes ambiguity/incorrect pick
//
// Acceptance checks:
//   FindNextSlot("oil_change") → Wed 10:00
//   FindNextSlot("inspection", day: 5, hour: 14) → Fri 14:00

using System;

class Exercise2_OverloadsAndDefaults
{
    static void Main()
    {
        Console.WriteLine("=== Appointment Slot Picker ===\n");
        Console.WriteLine(FindNextSlot("oil_change"));
        Console.WriteLine(FindNextSlot("inspection", 5, 14));
        Console.WriteLine("\nExpected when fixed:\n  Wed 10:00\n  Fri 14:00");
    }

    // Overload 1: defaults to a weekday morning
    static string FindNextSlot(string serviceType)
    {
        // Uses default day=3 (Wed) and hour=10
        return FindNextSlot(10, serviceType, 3); // BUG 2: wrong parameter order
    }

    // Overload 2: explicit day and optional hour
    static string FindNextSlot(string serviceType, int day, int hour = 10)
    {
        // BUG 1: ignores provided hour; always uses 10
        var finalHour = 10;
        return FormatSlot(day, finalHour);
    }

    static string FormatSlot(int day, int hour)
    {
        string dayName = day switch
        {
            1 => "Mon",
            2 => "Tue",
            3 => "Wed",
            4 => "Thu",
            5 => "Fri",
            6 => "Sat",
            7 => "Sun",
            _ => "?",
        };
        return $"{dayName} {hour:00}:00";
    }
}
