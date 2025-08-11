// 🔧 Exercise 3: WorkOrder Behavior (Bug Hunt)
// Purpose: Manage line items and calculate totals with tax.
//
// Bugs to find (exactly 2):
// 1) CalculateTotal applies tax twice
// 2) Items list is exposed directly (external mutation)
//
// Acceptance check:
//   Items: (2 × $10) + (1 × $5), tax 10% → Total $27.50

using System;
using System.Collections.Generic;
using System.Linq;

class Exercise3_WorkOrderBehavior
{
    static void Main()
    {
        Console.WriteLine("=== WorkOrder Totals ===\n");

        var wo = new WorkOrder();
        wo.AddItem(new LineItem("Oil Filter", 10m, 2));
        wo.AddItem(new LineItem("Coolant", 5m, 1));

        var total = wo.CalculateTotal(0.10m);
        Console.WriteLine($"Total: ${total:F2}");
        Console.WriteLine("Expected when fixed: Total: $27.50");
    }
}

public class LineItem
{
    public string Name { get; }
    public decimal UnitPrice { get; }
    public int Quantity { get; }

    public LineItem(string name, decimal unitPrice, int quantity)
    {
        Name = name;
        UnitPrice = unitPrice;
        Quantity = quantity;
    }
}

public class WorkOrder
{
    private readonly List<LineItem> _items = new();

    // BUG 2: exposes internal list directly
    public List<LineItem> Items => _items;

    public void AddItem(LineItem item)
    {
        _items.Add(item);
    }

    public bool RemoveItem(string name)
    {
        var idx = _items.FindIndex(i => i.Name == name);
        if (idx >= 0)
        {
            _items.RemoveAt(idx);
            return true;
        }
        return false;
    }

    public decimal CalculateTotal(decimal taxRate)
    {
        decimal subtotal = _items.Sum(i => i.UnitPrice * i.Quantity);
        // BUG 1: applies tax twice
        decimal withTax = subtotal * (1 + taxRate);
        decimal finalTotal = withTax * (1 + taxRate);
        return finalTotal;
    }
}
