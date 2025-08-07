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

### Exercise 1: Fix the Inventory Counter
**File:** `Exercise1_InventoryCount.cs`
- Off-by-one errors in array iteration
- Infinite loop disasters
- Wrong loop types for the job
- Break/continue logic errors

### Exercise 2: Debug the Service Queue
**File:** `Exercise2_ServiceQueue.cs`
- Process customer queue with while loops
- Handle priority customers (continue/skip logic)
- Stop processing at closing time (break logic)
- Avoid processing same customer twice

### Exercise 3: Eliminate Code Duplication
**File:** `Exercise3_RefactorDuplication.cs`
- Replace repetitive code with loops
- Convert multiple if statements to arrays + loops
- Eliminate copy-paste patterns
- Choose the right loop type

### Exercise 4: Build Batch Processor
**File:** `Exercise4_BuildBatchProcessor.cs`
- Create parts order processing system
- Process until limits reached
- Skip unavailable items
- Generate summary reports

### Exercise 5: Pattern Generator Challenge
**File:** `Challenge_PatternGenerator.cs`
- Create work schedule patterns
- Handle rotating shifts
- Generate maintenance schedules
- Master nested loops

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

Create a "Shop Work Order Processor" that:
1. **Processes a queue** of work orders until closing time
2. **Prioritizes emergency** repairs (use continue/break logic)
3. **Batches similar** work together for efficiency
4. **Tracks metrics** (orders completed, time spent, revenue)
5. **Handles interruptions** (emergency calls, parts delays)
6. **Generates reports** with nested loop summaries

Requirements:
- Use at least 3 different loop types appropriately
- Include break/continue logic for special cases
- Process nested data (customers → vehicles → services)
- Handle edge cases (empty queues, time limits)
- Optimize for real-world performance

Remember: Loops are powerful but dangerous. A single mistake can freeze your program or crash your system. Think like a mechanic: measure twice, cut once!
