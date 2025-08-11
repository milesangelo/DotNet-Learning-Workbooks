# Module 03: Loops & Iteration 🔄

## 🎯 Learning Objectives
By the end of this module, you'll understand:
- When to use for loops vs while loops vs do-while
- How to control loop flow with break and continue
- Common loop patterns (counting, accumulating, searching)
- How to avoid infinite loops and off-by-one errors
- Nested loops and their performance implications

## 🔧 Mechanic's Perspective
Think of loops like your systematic work patterns:
- **for loop** = Torque sequence (specific number of repetitions: "20 bolts, each to 85 ft-lbs")
- **while loop** = Condition-based work ("keep adding oil while level is low")
- **do-while** = "Try at least once" pattern ("attempt start, then check if running")
- **break** = Emergency stop ("stop immediately if something's wrong")
- **continue** = Skip and next ("skip damaged parts, continue with good ones")

## 📚 Exercises

### Exercise 1: End-of-Day Inventory Summary
**File:** `Exercise1_InventoryCount.cs`
- **Purpose**: Calculate total inventory value and list low-stock items.
- **What to fix (1–2 bugs)**:
  - Loop bound skips the last item
  - Low-stock threshold comparison includes border incorrectly
- **Acceptance checks** (with sample data):
  - Total inventory value: `$1742.25`
  - Low-stock count: `1` (threshold 12)
  - Low-stock items: `Brake Pads`

### Exercise 2: Service Queue Processor
**File:** `Exercise2_ServiceQueue.cs`
- **Purpose**: Process jobs (emergencies first) until closing; track processed count and revenue.
- **What to fix (1–2 bugs)**:
  - Revenue/time added before verifying remaining time
  - Remaining count should reflect actually unprocessed jobs
- **Acceptance checks** (with sample data, 8-hour day):
  - Processed jobs: `5`
  - Total revenue: `$549.95`
  - Remaining in queue: `1`

### Exercise 3: Weekly Work Summary
**File:** `Exercise3_RefactorDuplication.cs`
- **Purpose**: Print daily stats, then weekly totals and averages.
- **What to fix (1–2 bugs)**:
  - Loop starts at index 1, skipping Monday
  - Accumulators reset inside the loop
- **Acceptance checks** (with sample data):
  - Total Orders: `71`
  - Total Revenue: `$3195.00`
  - Average Orders/Day: `10.14`

## 🔍 Common Pitfalls

### 1. Off-By-One Errors
```csharp
// ❌ BAD - Will crash on last iteration
for (int i = 0; i <= array.Length; i++)
{
    Console.WriteLine(array[i]); // Crashes when i == array.Length
}

// ✅ GOOD - Correct boundary
for (int i = 0; i < array.Length; i++)
{
    Console.WriteLine(array[i]);
}
```

### 2. Infinite Loops
```csharp
// ❌ BAD - Loop never ends
int count = 0;
while (count < 10)
{
    Console.WriteLine(count);
    // Forgot to increment count!
}

// ✅ GOOD - Counter increments
while (count < 10)
{
    Console.WriteLine(count);
    count++; // Don't forget this!
}
```

### 3. Wrong Loop Type
```csharp
// ❌ BAD - Using while when for is clearer
int i = 0;
while (i < parts.Length)
{
    ProcessPart(parts[i]);
    i++;
}

// ✅ GOOD - For loop is more appropriate
for (int i = 0; i < parts.Length; i++)
{
    ProcessPart(parts[i]);
}
```

### 4. Modifying Collection During Iteration
```csharp
// ❌ BAD - Modifying while iterating
foreach (var part in partsList)
{
    if (part.IsDefective)
        partsList.Remove(part); // Runtime error!
}

// ✅ GOOD - Use reverse loop or separate list
for (int i = partsList.Count - 1; i >= 0; i--)
{
    if (partsList[i].IsDefective)
        partsList.RemoveAt(i);
}
```

### 5. Nested Loop Performance Issues
```csharp
// ❌ BAD - O(n²) performance disaster
for (int i = 0; i < 1000; i++)
{
    for (int j = 0; j < 1000; j++)
    {
        // This runs 1,000,000 times!
        ProcessExpensiveOperation();
    }
}

// ✅ GOOD - Consider if you really need nested loops
// Maybe use a Dictionary for lookups instead?
```

## 💡 Pro Tips

1. **Choose the right loop type**:
   - `for`: When you know how many iterations
   - `while`: When you don't know iteration count
   - `do-while`: When you need at least one iteration
   - `foreach`: When processing all items in collection

2. **Guard against infinite loops**:
   - Always ensure loop condition can become false
   - Include safety counters for while loops
   - Be careful with floating-point comparisons

3. **Use meaningful loop variables**:
   - `i`, `j`, `k` for simple counters
   - `customerIndex`, `partNumber` for domain-specific loops

4. **Consider performance**:
   - Cache array.Length in variable for performance
   - Be careful with nested loops
   - Break early when possible

5. **Master break and continue**:
   - `break`: Exit loop immediately
   - `continue`: Skip to next iteration
   - Use sparingly and with clear comments

## 🔄 Loop Pattern Library

### Counting Pattern
```csharp
for (int i = 0; i < count; i++)
{
    // Do something count times
}
```

### Accumulation Pattern
```csharp
double total = 0;
for (int i = 0; i < prices.Length; i++)
{
    total += prices[i];
}
```

### Search Pattern
```csharp
int foundIndex = -1;
for (int i = 0; i < items.Length; i++)
{
    if (items[i] == searchValue)
    {
        foundIndex = i;
        break; // Found it, no need to continue
    }
}
```

### Conditional Processing Pattern
```csharp
foreach (var customer in customers)
{
    if (!customer.IsActive)
        continue; // Skip inactive customers
        
    ProcessCustomer(customer);
}
```

## 🎓 Self-Check Questions

Before moving to the next module, can you:
- [ ] Explain when to use for vs while vs do-while?
- [ ] Identify and fix off-by-one errors?
- [ ] Use break and continue appropriately?
- [ ] Avoid infinite loop traps?
- [ ] Choose efficient approaches for nested operations?
- [ ] Recognize when NOT to use loops?

## 🏁 Challenge Project

Create a simple "Work Order Processor" that:
1. Processes a list of work orders one by one
2. Skips orders that are marked as "on hold" (continue)
3. Stops processing when reaching closing time (break)
4. Counts how many orders were completed
5. Calculates total revenue

Requirements:
- Use a for loop to iterate through orders
- Include break/continue logic appropriately
- Keep a running total of completed orders
- Handle basic edge cases (empty list, no valid orders)

Remember: Loops are powerful but dangerous. A single mistake can freeze your program or crash your system. Think like a mechanic: measure twice, cut once!
