// 🔧 Exercise 1: Part Model (Bug Hunt)
// Purpose: Define Part with Name, Sku, UnitPrice and a friendly ToString.
//
// Bugs to find (exactly 2):
// 1) Constructor assigns fields in wrong order
// 2) ToString does not format price to 2 decimals
//
// Acceptance check:
//   new Part("Oil Filter", "OF-001", 12.99).ToString() → "OF-001 - Oil Filter: $12.99"

using System;

class Exercise1_PartModel
{
    static void Main()
    {
        var p = new Part("Oil Filter", "OF-001", 12.99);
        Console.WriteLine(p.ToString());
        Console.WriteLine("Expected when fixed: OF-001 - Oil Filter: $12.99");
    }
}

public class Part
{
    public string Name { get; init; }
    public string Sku { get; init; }
    public double UnitPrice { get; init; }

    public Part(string name, string sku, double unitPrice)
    {
        // BUG 1: swapped assignments
        Sku = name;
        Name = sku;
        UnitPrice = unitPrice;
    }

    public override string ToString()
    {
        // BUG 2: not formatted to 2 decimals
        return $"{Sku} - {Name}: ${UnitPrice}";
    }
}
