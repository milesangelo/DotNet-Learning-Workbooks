# Module 02: Conditionals & Logic 🔀

## 🎯 Learning Objectives
By the end of this module, you'll understand:
- How to make decisions in code with if/else
- Boolean logic operators (&&, ||, !)
- Comparison operators and their quirks
- Guard clauses and early returns
- Switch statements for multiple conditions

## 🔧 Mechanic's Perspective
Think of conditionals like your diagnostic flowchart:
- **if/else** = Decision points in troubleshooting ("If no spark, check ignition")
- **&&** (AND) = Multiple conditions must be true (oil AND coolant levels OK)
- **||** (OR) = Any condition can be true (warning if temp high OR pressure low)
- **!** (NOT) = Opposite condition (if NOT running, can safely work on it)
- **switch** = Your diagnostic scanner with multiple codes to check

## 📚 Exercises

### Exercise 1: Fix the Service Advisor Logic
**File:** `Exercise1_Broken.cs`
- Assignment vs comparison errors (= vs ==)
- Wrong boolean operators (& vs &&)
- Missing else branches
- Inverted logic

### Exercise 2: Debug the Diagnostic System
**File:** `Exercise2_Debug.cs`
- Complex nested conditions gone wrong
- Order of operations issues
- Edge cases not handled
- String comparison problems

### Exercise 3: Refactor the Decision Tree
**File:** `Exercise3_Refactor.cs`
- Deeply nested if statements (arrow anti-pattern)
- Duplicate condition checks
- Complex boolean expressions that need simplifying
- Convert to guard clauses

### Exercise 4: Build a Service Recommender
**File:** `Exercise4_BuildIt.cs`
- Create from scratch using requirements
- Must handle multiple conditions elegantly
- Use appropriate operators
- Include edge case handling

### Exercise 5: Master the Switch
**File:** `Exercise5_Switch.cs`
- Convert if/else chains to switch
- Use switch expressions (C# 8+)
- Handle all cases exhaustively

## 🔍 Common Pitfalls

### 1. Assignment Instead of Comparison
```csharp
// ❌ BAD - This assigns, doesn't compare!
if (oilLevel = 0)  // Always true, sets oilLevel to 0
{
    AddOil();
}

// ✅ GOOD - Use == for comparison
if (oilLevel == 0)
{
    AddOil();
}
```

### 2. Wrong Boolean Operators
```csharp
// ❌ BAD - Single & doesn't short-circuit
if (engine != null & engine.IsRunning)  // Might crash!
{
    // If engine is null, still evaluates engine.IsRunning
}

// ✅ GOOD - && short-circuits (stops if first is false)
if (engine != null && engine.IsRunning)
{
    // Safe - won't check IsRunning if engine is null
}
```

### 3. String Comparison Traps
```csharp
// ❌ BAD - Case sensitive comparison
string status = GetStatus();  // Returns "Ready"
if (status == "ready")  // Won't match!
{
    StartWork();
}

// ✅ GOOD - Case insensitive comparison
if (status.Equals("ready", StringComparison.OrdinalIgnoreCase))
{
    StartWork();
}
```

### 4. Arrow Anti-Pattern (Too Much Nesting)
```csharp
// ❌ BAD - Nested nightmare
if (hasCustomer)
{
    if (hasAppointment)
    {
        if (partsAvailable)
        {
            if (mechanicFree)
            {
                StartService();
            }
        }
    }
}

// ✅ GOOD - Guard clauses (fail fast)
if (!hasCustomer) return;
if (!hasAppointment) return;
if (!partsAvailable) return;
if (!mechanicFree) return;

StartService();
```

### 5. Complex Boolean Expressions
```csharp
// ❌ BAD - Hard to read and understand
if ((temp > 200 && pressure < 10) || (temp > 180 && pressure < 15) || emergency)
{
    Shutdown();
}

// ✅ GOOD - Extract to meaningful variables
bool overheating = temp > 200 && pressure < 10;
bool nearOverheating = temp > 180 && pressure < 15;
bool shouldShutdown = overheating || nearOverheating || emergency;

if (shouldShutdown)
{
    Shutdown();
}
```

## 💡 Pro Tips

1. **Use guard clauses** - Exit early when conditions aren't met
2. **Name boolean variables clearly** - `isReady` not just `ready`
3. **Avoid negative names** - `isEnabled` not `isNotDisabled`
4. **One condition per line** - Makes debugging easier
5. **Extract complex logic** - If you need comments, make it a variable
6. **Remember short-circuiting** - Put cheap/likely checks first
7. **Consider switch for 3+ conditions** - Cleaner than if/else chains

## 🎓 Self-Check Questions

Before moving to the next module, can you:
- [ ] Explain the difference between & and &&?
- [ ] Write a guard clause pattern?
- [ ] Identify when to use switch vs if/else?
- [ ] Debug inverted boolean logic?
- [ ] Simplify complex boolean expressions?
- [ ] Handle null safely in conditions?

## 🏁 Challenge Project

Create a "Smart Service Scheduler" that:
1. Checks vehicle mileage and recommends services
2. Considers last service dates
3. Factors in driving conditions (city/highway)
4. Applies seasonal checks (winter/summer)
5. Prioritizes safety-critical services
6. Handles edge cases (new car, missing history)

Requirements:
- Use at least 3 different comparison operators
- Include both && and || operators
- Implement guard clauses
- Use a switch statement for service types
- Extract complex conditions to named variables

Remember: Clear logic is better than clever logic. If you have to think hard to understand it, simplify it!
