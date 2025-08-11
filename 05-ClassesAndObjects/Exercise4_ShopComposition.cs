// 🔧 Exercise 4: Shop Composition (Bug Hunt)
// Purpose: Manage open/closed work orders in a shop.
//
// Bugs to find (exactly 2):
// 1) CloseOrder(id) returns true even when not found
// 2) GetOpenOrders exposes internal list reference
//
// Acceptance checks:
//   CloseOrder(2) marks closed and reduces open count by 1; CloseOrder(999) returns false

using System;
using System.Collections.Generic;
using System.Linq;

class Exercise4_ShopComposition
{
    static void Main()
    {
        Console.WriteLine("=== Shop Orders ===\n");

        var shop = new Shop();
        shop.SeedSample();
        Console.WriteLine($"Open before: {shop.GetOpenOrders().Count}");

        bool closed = shop.CloseOrder(2);
        Console.WriteLine($"Close(2): {closed}");
        Console.WriteLine($"Open after: {shop.GetOpenOrders().Count}");

        bool closedBad = shop.CloseOrder(999);
        Console.WriteLine($"Close(999): {closedBad}");

        Console.WriteLine(
            "Expected when fixed: Open before: 2, Close(2): True, Open after: 1, Close(999): False"
        );
    }
}

public class WorkOrder
{
    public int Id { get; }
    public bool IsClosed { get; private set; }

    public WorkOrder(int id)
    {
        Id = id;
        IsClosed = false;
    }

    public void Close() => IsClosed = true;
}

public class Shop
{
    private readonly List<WorkOrder> _orders = new();

    public void SeedSample()
    {
        _orders.Clear();
        _orders.Add(new WorkOrder(1));
        _orders.Add(new WorkOrder(2));
    }

    // BUG 2: exposes internal list directly
    public List<WorkOrder> GetOpenOrders() => _orders.Where(o => !o.IsClosed).ToList();

    public bool CloseOrder(int id)
    {
        var order = _orders.FirstOrDefault(o => o.Id == id);
        if (order == null)
        {
            // BUG 1: returns true even when not found
            return true;
        }
        order.Close();
        return true;
    }
}
