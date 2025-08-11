// 🔧 Exercise 4: Generic Repository (Bug Hunt)
// Purpose: Minimal Repository<T> with add/find/remove, using a key selector.
//
// Bugs to find (exactly 2):
// 1) Missing constraint/comparer leads to duplicate detection failures
// 2) Remove fails silently due to wrong key used
//
// Acceptance checks:
//   Add 3 parts, find by SKU returns item; remove by SKU reduces count by 1

using System;
using System.Collections.Generic;
using System.Linq;

class Exercise4_GenericRepository
{
    static void Main()
    {
        Console.WriteLine("=== Generic Repository ===\n");

        var repo = new Repository<Part>(p => p.Sku);
        repo.Add(new Part("OF-001", "Oil Filter"));
        repo.Add(new Part("SP-123", "Spark Plug"));
        repo.Add(new Part("AF-456", "Air Filter"));

        var found = repo.Find("SP-123");
        Console.WriteLine(found?.Name ?? "not found");

        repo.Remove("SP-123");
        Console.WriteLine($"Count: {repo.Count}");

        Console.WriteLine("Expected when fixed:\n  Spark Plug\n  Count: 2");
    }
}

// ℹ️ What is a record?
// Records are reference types like classes, but optimized for immutable, data-centric models.
// Key differences from classes:
// - Value-based equality: two records with the same property values are considered equal.
// - Concise syntax: positional records declare properties in the header (like below).
// - With-expressions: create modified copies without mutating the original.
// - Deconstruction: easily unpack into variables.
// Examples:
//   var p = new Part("OF-001", "Oil Filter");
//   var p2 = p with { Name = "Premium Oil Filter" }; // copy with one property changed
//   var (sku, name) = p; // deconstructs the positional record
public record Part(string Sku, string Name);

public class Repository<T>
{
    private readonly Func<T, string> _keySelector;
    private readonly List<T> _items = new();

    public int Count => _items.Count;

    public Repository(Func<T, string> keySelector)
    {
        _keySelector = keySelector;
    }

    public void Add(T item)
    {
        // BUG 1: no duplicate check by key
        _items.Add(item);
    }

    public T? Find(string key)
    {
        return _items.FirstOrDefault(i => _keySelector(i) == key);
    }

    public bool Remove(string key)
    {
        // BUG 2: uses wrong key value to remove
        var idx = _items.FindIndex(i => _keySelector(i) == key + " ");
        if (idx >= 0)
        {
            _items.RemoveAt(idx);
            return true;
        }
        return false;
    }
}
