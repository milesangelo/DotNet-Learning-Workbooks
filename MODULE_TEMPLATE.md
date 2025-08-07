# Module Template Structure

Use this template to create the remaining modules. Each module should follow this consistent pattern.

## Files for Each Module

```
/XX-ModuleName/
    ├── README.md                  # Module overview and exercises
    ├── Program.cs                 # Main menu for the module
    ├── Exercise1_Broken.cs        # Broken code to fix
    ├── Exercise1_Fixed.cs         # Solution
    ├── Exercise2_Debug.cs         # Debugging challenge
    ├── Exercise2_Solution.cs      # Solution
    ├── Exercise3_Refactor.cs      # Verbose/messy code
    ├── Exercise3_Clean.cs         # Refactored solution
    ├── Exercise4_BuildIt.cs       # Build from scratch
    ├── Challenge_Advanced.cs      # Extra challenge
    └── XX-ModuleName.csproj       # Project file
```

## Module 02: Conditionals Template

```csharp
// Key Concepts to Cover:
// - if/else statements
// - Nested conditions
// - Boolean operators (&&, ||, !)
// - Comparison operators (==, !=, <, >, <=, >=)
// - Guard clauses / early returns
// - Ternary operator (? :)

// Mechanic Analogy:
// "If-else is your diagnostic flowchart - check condition, take action"

// Example Broken Code Pattern:
if (oilLevel = 0)  // Assignment instead of comparison!
{
    AddOil();
}

if (temperature > 100 & pressure > 50)  // Single & instead of &&
{
    // ...
}

// Common string comparison mistake
string status = "Ready";
if (status == "ready")  // Case sensitivity!
{
    // Won't execute
}
```

## Module 03: Loops Template

```csharp
// Key Concepts:
// - for loops (counting)
// - while loops (condition-based)
// - do-while loops (at least once)
// - break and continue
// - Nested loops
// - Infinite loop dangers

// Mechanic Analogy:
// "Loops are your torque pattern - repeat the same action systematically"

// Example Problems:
for (int i = 0; i <= parts.Length; i++)  // Off-by-one error!
{
    Process(parts[i]);  // Will crash on last iteration
}

while (true)  // Infinite loop with no break!
{
    CheckEngine();
}

// Nested loop performance issue
for (int i = 0; i < 1000; i++)
    for (int j = 0; j < 1000; j++)
        for (int k = 0; k < 1000; k++)
            // This runs 1 billion times!
```

## Module 04: Methods Template

```csharp
// Key Concepts:
// - Method declaration and calling
// - Parameters vs arguments
// - Return values vs void
// - Method overloading
// - ref and out parameters
// - Default parameters

// Mechanic Analogy:
// "Methods are specialized tools - each does one job well"

// Refactoring Opportunities:
// BEFORE - Everything in Main()
static void Main()
{
    double hours = 2.5;
    double rate = 95;
    double labor = hours * rate;
    double parts = 156.99;
    double subtotal = labor + parts;
    double tax = subtotal * 0.08;
    double total = subtotal + tax;
    // ... 100 more lines
}

// AFTER - Extracted methods
static void Main()
{
    double labor = CalculateLabor(2.5, 95);
    double total = CalculateTotal(labor, 156.99);
    DisplayInvoice(total);
}
```

## Module 05: DRY Refactoring Template

```csharp
// Focus: Don't Repeat Yourself
// - Identify duplication
// - Extract common code
// - Create reusable components
// - Simplify complex expressions

// Mechanic Analogy:
// "Like organizing your toolbox - eliminate duplicates, group related items"

// Classic DRY Violation:
Console.WriteLine($"Oil Filter: ${oilPrice * 1.08:F2}");
Console.WriteLine($"Air Filter: ${airPrice * 1.08:F2}");
Console.WriteLine($"Fuel Filter: ${fuelPrice * 1.08:F2}");
// Same tax calculation repeated!
```

## Module 06: Classes Template

```csharp
// Key Concepts:
// - Class definition
// - Properties and fields
// - Methods in classes
// - Constructors
// - this keyword
// - Access modifiers

// Mechanic Analogy:
// "Classes are blueprints (service manuals), objects are actual cars"

class Vehicle
{
    public string Make { get; set; }
    public string Model { get; set; }
    public int Mileage { get; set; }
    
    public bool NeedsOilChange()
    {
        return Mileage % 5000 > 4500;
    }
}
```

## Module 07: Collections Template

```csharp
// Key Concepts:
// - Arrays vs Lists
// - List<T> operations
// - foreach loops
// - LINQ basics (Where, Select, FirstOrDefault)
// - Dictionary<TKey, TValue>

// Mechanic Analogy:
// "Collections are your parts inventory - organized, searchable, countable"

List<Part> inventory = new List<Part>();
inventory.Add(new Part { Name = "Oil Filter", Stock = 24 });

var lowStock = inventory.Where(p => p.Stock < 10);
var totalValue = inventory.Sum(p => p.Price * p.Stock);
```

## Module 08: Enums & Switch Template

```csharp
// Key Concepts:
// - Enum declaration and usage
// - Switch statements
// - Switch expressions (C# 8+)
// - Pattern matching
// - Exhaustive handling

// Mechanic Analogy:
// "Enums are like OBD-II codes, switch is your diagnostic scanner"

enum ServiceType
{
    OilChange,
    TireRotation,
    BrakeService,
    Inspection
}

double GetServiceTime(ServiceType service) => service switch
{
    ServiceType.OilChange => 0.5,
    ServiceType.TireRotation => 0.5,
    ServiceType.BrakeService => 2.0,
    ServiceType.Inspection => 1.0,
    _ => throw new ArgumentException("Unknown service")
};
```

## Module 09: Error Handling Template

```csharp
// Key Concepts:
// - try/catch/finally
// - Exception types
// - Throwing exceptions
// - Null checking (?., ??)
// - Defensive programming
// - Input validation

// Mechanic Analogy:
// "Like safety protocols - check for problems before they cause damage"

// Pattern: Parse user input safely
Console.Write("Enter hours: ");
string input = Console.ReadLine();

// BAD - Will crash on invalid input
double hours = double.Parse(input);

// GOOD - Handle invalid input
if (double.TryParse(input, out double hours))
{
    // Use hours safely
}
else
{
    Console.WriteLine("Invalid input. Please enter a number.");
}
```

## Creating New Exercises

### Pattern for Broken Code:
1. Start with working code
2. Introduce 5-8 common mistakes
3. Add comments hinting at problems
4. Include both compile errors and logic bugs

### Pattern for Refactoring:
1. Write overly verbose code that works
2. Include obvious duplication
3. Use poor naming
4. Make it 3x longer than necessary
5. The refactored version should be 50-70% shorter

### Pattern for Build Challenges:
1. Provide clear requirements
2. Give example input/output
3. Specify which concepts to use
4. Include edge cases to handle

## Exercise Difficulty Progression

**Module 1-3:** Focus on syntax and basic concepts
**Module 4-6:** Introduce organization and structure  
**Module 7-9:** Add complexity and real-world patterns

Each module should feel slightly harder than the last, building on previous knowledge.
