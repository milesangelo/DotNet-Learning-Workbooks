# Module 01: Variables & Types 🔧

## 🎯 Learning Objectives
By the end of this module, you'll understand:
- How to declare and initialize variables
- The difference between value types and reference types
- Why type safety matters (and how it saves you from bugs)
- When to use `var` vs explicit types
- How to work with constants

## 🔩 Mechanic's Perspective
Think of variables like labeled storage bins in your shop:
- **int** = Bin for counting things (bolts, spark plugs, miles)
- **string** = Bin for text labels (customer names, part numbers, VIN)
- **bool** = Bin for yes/no switches (engine on/off, door locked/unlocked)
- **double** = Bin for precise measurements (fuel level, tire pressure, voltage)
- **const** = Permanent label that never changes (like shop policy or tax rate)

## 📚 Exercises

### Exercise 1: Fix the Variable Declarations
**File:** `Exercise1_Broken.cs`
- Multiple type mismatches
- Uninitialized variables
- Wrong naming conventions

### Exercise 2: Debug the Auto Shop Inventory
**File:** `Exercise2_Broken.cs`
- Fix variable scope issues
- Correct type conversions
- Handle string concatenation properly

### Exercise 3: Refactor the Verbose Code
**File:** `Exercise3_Verbose.cs`
- Replace repetitive declarations with better names
- Use appropriate types (not everything is a string!)
- Apply `var` where it makes sense



## 🔍 Common Pitfalls

### 1. Using the Wrong Type
```csharp
// ❌ BAD - Using string for numbers
string partCount = "42";
string total = partCount + 10; // This won't do math!

// ✅ GOOD - Use the right type
int partCount = 42;
int total = partCount + 10; // Now it adds correctly
```

### 2. Not Initializing Variables
```csharp
// ❌ BAD - Uninitialized variable
int customerCount;
Console.WriteLine(customerCount); // Compiler error!

// ✅ GOOD - Always initialize
int customerCount = 0;
Console.WriteLine(customerCount); // Works fine
```

### 3. Magic Numbers
```csharp
// ❌ BAD - What does 1.0875 mean?
double totalPrice = partPrice * 1.0875;

// ✅ GOOD - Use named constants
const double SALES_TAX_RATE = 1.0875;
double totalPrice = partPrice * SALES_TAX_RATE;
```

## 💡 Pro Tips

1. **Name variables clearly** - `customerName` not `cn` or `temp`
2. **Use `var` when the type is obvious** - `var name = "John";` is fine
3. **Don't use `var` when it's unclear** - `var result = Calculate();` is confusing
4. **Constants prevent "magic number" bugs** - Define rates, limits, and fees as const
5. **Initialize at declaration when possible** - Prevents null reference errors

## 🎓 Self-Check Questions

Before moving to the next module, can you:
- [ ] Explain the difference between `int` and `double`?
- [ ] Know when to use `const` vs regular variables?
- [ ] Understand why `string age = 25;` is problematic?
- [ ] Convert between common types safely?
- [ ] Name variables following C# conventions?

## 🏁 Challenge Project
Create a simple "Parts Calculator" that:
1. Takes in part name (string)
2. Quantity needed (int)
3. Unit price (double)
4. Whether customer gets a discount (bool)
5. Uses constants for discount rate and tax rate
6. Outputs total cost with tax

Remember: The goal isn't to rush through. It's to build muscle memory. Every repetition makes the next one easier!
