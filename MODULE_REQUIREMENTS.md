# 📋 Module Development Requirements

## 🎯 Overall Learning Objectives

### Core Philosophy
- **Mechanical Mindset**: Every concept must have a clear automotive/mechanical analogy
- **Hands-On First**: Learn by fixing broken things before building new things
- **Repetition Over Speed**: Multiple exercises covering the same concept from different angles
- **Real-World Context**: All examples should relate to auto shop operations, inventory, diagnostics, or service management

### Exercise Requirements Per Module
Each module MUST contain:
1. **3-5 Broken Code Exercises** - Compiler errors and logic bugs to fix
2. **2-3 Refactoring Challenges** - Verbose/repetitive code to clean up
3. **1-2 Build From Scratch** - Create something new with requirements
4. **1 Advanced Challenge** - Combines multiple concepts
5. **Complete Solutions** - With detailed explanations of WHY

---

## 📚 Module-by-Module Requirements

### ✅ Module 01: Variables & Types [COMPLETED]
**Status**: ✅ Fully implemented with 5 exercises

---

### 🔧 Module 02: Conditionals & Logic [IN PROGRESS]

**Mechanical Analogy**: "Diagnostic flowcharts - if this, then that"

**Learning Objectives**:
- Master if/else decision making
- Understand boolean operators (&&, ||, !)
- Learn comparison operators (==, !=, <, >, <=, >=)
- Apply guard clauses and early returns
- Avoid common pitfalls (assignment vs comparison)

**Required Exercises**:

1. **Exercise1_ServiceAdvisor.cs** ✅ (Created)
   - Fix assignment vs comparison (= vs ==)
   - Correct boolean operators (& vs &&)
   - Fix inverted logic
   - Handle string case sensitivity

2. **Exercise2_DiagnosticTree.cs** (TODO)
   - Debug complex nested conditions
   - Fix order of operations issues
   - Handle edge cases
   - Simplify arrow anti-pattern

3. **Exercise3_RefactorNesting.cs** (TODO)
   - Convert deep nesting to guard clauses
   - Extract complex boolean expressions
   - Eliminate duplicate conditions
   - Improve readability

4. **Exercise4_BuildScheduler.cs** (TODO)
   - Build appointment scheduler from scratch
   - Check multiple conditions (day, time, bay availability)
   - Handle conflicts and priorities
   - Use appropriate operators

5. **Challenge_EmergencyTriage.cs** (TODO)
   - Prioritize service requests
   - Consider multiple factors (safety, warranty, customer type)
   - Handle edge cases
   - Optimize decision flow

**Real-World Scenarios**:
- Service recommendations based on mileage/time
- Emergency vs routine service decisions
- Warranty validation logic
- Customer priority systems
- Safety check requirements

**Common Mistakes to Highlight**:
```csharp
// Assignment instead of comparison
if (value = 10)  // WRONG

// Impossible conditions
if (x < 5 && x > 10)  // Can never be true

// String comparison traps
if (status == "ready")  // Case sensitive!

// Short-circuit evaluation
if (obj != null & obj.IsValid)  // Dangerous!
```

---

### 🔧 Module 03: Loops & Iteration

**Mechanical Analogy**: "Torque patterns - repeat the same action systematically"

**Learning Objectives**:
- Master for loops for counting scenarios
- Use while loops for condition-based iteration
- Understand do-while for "at least once" scenarios
- Control flow with break and continue
- Avoid infinite loops and off-by-one errors

**Required Exercises**:

1. **Exercise1_InventoryCount.cs**
   - Fix off-by-one errors in array iteration
   - Correct infinite loops
   - Fix break/continue logic
   - Handle empty collections

2. **Exercise2_ServiceQueue.cs**
   - Process customer queue with while loop
   - Handle priority customers (continue to skip)
   - Stop processing at closing time (break)
   - Avoid processing same customer twice

3. **Exercise3_RefactorDuplication.cs**
   - Replace repetitive code with loops
   - Convert multiple if statements to loop with array
   - Eliminate copy-paste patterns
   - Use appropriate loop type

4. **Exercise4_BuildBatchProcessor.cs**
   - Create parts order batch processor
   - Process until inventory limit reached
   - Skip out-of-stock items
   - Generate order summary

5. **Challenge_PatternGenerator.cs**
   - Create work schedule patterns
   - Handle rotating shifts
   - Generate recurring maintenance schedules
   - Implement nested loops correctly

**Real-World Scenarios**:
- Processing work orders in queue
- Counting inventory items
- Generating recurring schedules
- Batch processing invoices
- Searching for parts in catalog

**Common Mistakes to Highlight**:
```csharp
// Off-by-one error
for (int i = 0; i <= array.Length; i++)  // Crashes!

// Infinite loop
while (running == true) { /* no way to set false */ }

// Wrong loop type
do { GetInput(); } while (false);  // Why use do-while?

// Modifying collection during iteration
foreach (var item in list) { list.Remove(item); }  // Error!
```

---

### 🔧 Module 04: Methods & Functions

**Mechanical Analogy**: "Specialized tools - each does one specific job well"

**Learning Objectives**:
- Extract code into reusable methods
- Understand parameters and return values
- Master method overloading
- Use ref and out parameters appropriately
- Apply single responsibility principle

**Required Exercises**:

1. **Exercise1_ExtractMethods.cs**
   - Refactor 200-line Main() into methods
   - Identify logical groupings
   - Create meaningful method names
   - Proper parameter passing

2. **Exercise2_FixParameters.cs**
   - Debug incorrect parameter types
   - Fix return value issues
   - Correct pass-by-value vs reference bugs
   - Handle optional parameters

3. **Exercise3_OverloadMethods.cs**
   - Create overloaded calculation methods
   - Handle different parameter combinations
   - Avoid ambiguous overloads
   - Use default parameters appropriately

4. **Exercise4_BuildCalculator.cs**
   - Create service cost calculator
   - Methods for labor, parts, tax, discounts
   - Compose methods together
   - Return meaningful values

5. **Challenge_RefactorToMethods.cs**
   - Take monolithic code and decompose
   - Apply DRY principle
   - Create utility methods
   - Build method hierarchy

**Real-World Scenarios**:
- Calculate labor costs
- Validate part numbers
- Format invoices
- Check warranty status
- Process payments

**Common Mistakes to Highlight**:
```csharp
// Method doing too much
void ProcessOrder() { /* 100 lines doing 5 things */ }

// Poor naming
int Calc(int x, int y) { return x * y * 0.08; }  // What?

// Wrong return type
void GetTotal() { Console.WriteLine(total); }  // Should return!

// Side effects
double CalculatePrice() { SaveToDatabase(); return price; }
```

---

### 🔧 Module 05: DRY & Refactoring

**Mechanical Analogy**: "Organizing your toolbox - eliminate duplicates, group related items"

**Learning Objectives**:
- Identify code duplication
- Extract common patterns
- Simplify complex expressions
- Improve code organization
- Reduce maintenance burden

**Required Exercises**:

1. **Exercise1_EliminateDuplication.cs**
   - Find and remove copy-paste code
   - Extract repeated calculations
   - Consolidate similar logic branches
   - Create reusable components

2. **Exercise2_SimplifyExpressions.cs**
   - Break down complex boolean logic
   - Extract magic numbers to constants
   - Use meaningful variable names
   - Reduce nesting levels

3. **Exercise3_ConsolidateLogic.cs**
   - Merge similar methods
   - Remove redundant checks
   - Combine related operations
   - Eliminate dead code

4. **Exercise4_BuildTemplate.cs**
   - Create reusable invoice template
   - Avoid repetition in formatting
   - Use consistent patterns
   - Apply configuration over code

5. **Challenge_MegaRefactor.cs**
   - Refactor 500-line mess
   - Apply all DRY principles
   - Reduce by 60%+
   - Maintain functionality

**Real-World Scenarios**:
- Standardize report generation
- Consolidate validation rules
- Unify error handling
- Centralize configuration
- Template common operations

**Common Mistakes to Highlight**:
```csharp
// Obvious duplication
Console.WriteLine($"Oil: ${oil * 1.08:F2}");
Console.WriteLine($"Filter: ${filter * 1.08:F2}");
Console.WriteLine($"Coolant: ${coolant * 1.08:F2}");

// Hidden duplication
if (type == "oil") { price = base * 1.5; }
if (type == "tire") { price = base * 1.5; }
if (type == "brake") { price = base * 1.5; }

// Repeated patterns
var oil = GetOil(); if (oil == null) return;
var filter = GetFilter(); if (filter == null) return;
var coolant = GetCoolant(); if (coolant == null) return;
```

---

### 🔧 Module 06: Classes & Objects

**Mechanical Analogy**: "Service manuals (classes) vs actual vehicles (objects)"

**Learning Objectives**:
- Design classes to model real-world entities
- Understand properties vs fields
- Create and use constructors
- Implement methods within classes
- Apply encapsulation principles

**Required Exercises**:

1. **Exercise1_FixClassDesign.cs**
   - Repair broken class definitions
   - Fix property accessibility issues
   - Correct constructor problems
   - Handle null reference exceptions

2. **Exercise2_RefactorToOOP.cs**
   - Convert procedural code to objects
   - Group related data and behavior
   - Eliminate global variables
   - Create proper class relationships

3. **Exercise3_BuildVehicleClass.cs**
   - Create Vehicle class from requirements
   - Add maintenance tracking
   - Implement service history
   - Calculate next service dates

4. **Exercise4_CustomerManagement.cs**
   - Design Customer class
   - Track service preferences
   - Maintain contact information
   - Handle customer types (Regular, VIP, New)

5. **Challenge_ShopSystem.cs**
   - Build complete shop model
   - Vehicle, Customer, Service, Invoice classes
   - Proper relationships between objects
   - Business logic in appropriate classes

**Real-World Scenarios**:
- Model vehicles with make, model, year, VIN
- Track customer information and history
- Represent services and parts
- Create invoices and quotes
- Manage shop inventory

**Common Mistakes to Highlight**:
```csharp
// Public fields (bad encapsulation)
class Vehicle { public int mileage; }

// Logic in wrong place
class Invoice { 
    void ChangeOil() { }  // Why is this in Invoice?
}

// Missing constructor validation
class Part {
    Part(string name) { Name = name; }  // What if null?
}

// God class (does everything)
class ShopManager { /* 1000 lines, 50 methods */ }
```

---

### 🔧 Module 07: Collections & Lists

**Mechanical Analogy**: "Parts inventory - organized, searchable, countable"

**Learning Objectives**:
- Choose between arrays and lists
- Master List<T> operations
- Use foreach effectively
- Apply basic LINQ operations
- Work with dictionaries for lookups

**Required Exercises**:

1. **Exercise1_FixCollections.cs**
   - Debug index out of range errors
   - Fix null reference in collections
   - Correct collection modification during iteration
   - Handle empty collection edge cases

2. **Exercise2_InventorySearch.cs**
   - Search and filter parts inventory
   - Sort by various criteria
   - Find items meeting conditions
   - Handle not found scenarios

3. **Exercise3_RefactorArraysToLists.cs**
   - Convert fixed arrays to dynamic lists
   - Eliminate array resizing code
   - Use appropriate collection methods
   - Improve flexibility

4. **Exercise4_BuildOrderSystem.cs**
   - Create order management with lists
   - Add/remove items dynamically
   - Calculate totals with LINQ
   - Group by categories

5. **Challenge_OptimizeLookups.cs**
   - Convert list searches to dictionary
   - Improve performance
   - Handle duplicate keys
   - Implement caching

**Real-World Scenarios**:
- Manage parts inventory
- Track work order queue
- Store customer vehicles
- Maintain price lists
- Cache frequently accessed data

**Common Mistakes to Highlight**:
```csharp
// Modifying during iteration
foreach (var part in parts) {
    if (part.Stock == 0) parts.Remove(part);  // Error!
}

// Not checking for empty
var first = list[0];  // What if empty?

// Inefficient lookups
for (int i = 0; i < list.Count; i++) {
    if (list[i].Id == searchId) { }  // Use LINQ!
}

// Wrong collection type
List<Part> partLookup;  // Should be Dictionary!
```

---

### 🔧 Module 08: Enums & Switch

**Mechanical Analogy**: "Diagnostic codes and code readers"

**Learning Objectives**:
- Define and use enums effectively
- Master switch statements and expressions
- Implement exhaustive handling
- Use pattern matching
- Avoid magic numbers/strings

**Required Exercises**:

1. **Exercise1_FixEnums.cs**
   - Convert magic numbers to enums
   - Fix invalid enum values
   - Handle enum parsing
   - Add missing enum cases

2. **Exercise2_RefactorToSwitch.cs**
   - Convert if/else chains to switch
   - Use switch expressions
   - Eliminate redundant code
   - Improve readability

3. **Exercise3_BuildStatusSystem.cs**
   - Create service status enum
   - Implement state transitions
   - Validate status changes
   - Track status history

4. **Exercise4_DiagnosticCodes.cs**
   - Model OBD-II style codes
   - Categorize by system
   - Implement code lookup
   - Generate descriptions

5. **Challenge_StateManager.cs**
   - Build vehicle state machine
   - Handle all transitions
   - Prevent invalid states
   - Log state changes

**Real-World Scenarios**:
- Service status (Pending, InProgress, Complete)
- Priority levels (Emergency, High, Normal, Low)
- Vehicle systems (Engine, Transmission, Brakes)
- Day of week scheduling
- Payment methods

**Common Mistakes to Highlight**:
```csharp
// Magic numbers instead of enums
if (status == 2) { }  // What's 2?

// Non-exhaustive switch
switch(service) {
    case Service.Oil: break;
    // Missing cases!
}

// Invalid enum values
ServiceType type = (ServiceType)999;  // Dangerous!

// String comparisons instead of enums
if (status == "complete") { }  // Use enum!
```

---

### 🔧 Module 09: Error Handling & Validation

**Mechanical Analogy**: "Safety protocols - check before damage occurs"

**Learning Objectives**:
- Implement try/catch effectively
- Validate input before processing
- Handle null values safely
- Use defensive programming
- Provide meaningful error messages

**Required Exercises**:

1. **Exercise1_FixErrorHandling.cs**
   - Add missing try/catch blocks
   - Fix overly broad catches
   - Correct exception swallowing
   - Improve error messages

2. **Exercise2_InputValidation.cs**
   - Validate user input
   - Use TryParse instead of Parse
   - Check ranges and formats
   - Provide helpful feedback

3. **Exercise3_NullSafety.cs**
   - Fix null reference exceptions
   - Add null checks
   - Use null-conditional operators
   - Handle nullable types

4. **Exercise4_BuildValidator.cs**
   - Create VIN validator
   - Validate phone numbers
   - Check email formats
   - Verify part numbers

5. **Challenge_RobustCalculator.cs**
   - Build calculator that never crashes
   - Handle all edge cases
   - Provide clear error messages
   - Recover gracefully

**Real-World Scenarios**:
- Validate VIN numbers
- Check part compatibility
- Verify customer data
- Handle payment failures
- Recover from service errors

**Common Mistakes to Highlight**:
```csharp
// No error handling
int value = int.Parse(userInput);  // Crashes on bad input!

// Swallowing exceptions
try { DoWork(); } catch { }  // Silent failure!

// Too broad catch
catch (Exception) { }  // Catches everything!

// No null check
customer.Name.ToUpper();  // What if customer is null?

// Poor error messages
catch { Console.WriteLine("Error"); }  // Not helpful!
```

---

## 🎯 Final Projects Requirements

### Project A: Auto Shop Management System

**Requirements**:
- Customer management (CRUD operations)
- Vehicle tracking with service history
- Appointment scheduling system
- Inventory management
- Invoice generation
- Service recommendations based on mileage/time
- Reports (daily, weekly, monthly)

**Must Use**:
- Classes for all entities
- Collections for data storage
- Methods for all operations
- Proper error handling
- Enums for status/types
- LINQ for queries

### Project B: Diagnostic Code System

**Requirements**:
- Read and parse diagnostic codes
- Categorize by system (engine, transmission, etc.)
- Severity levels (critical, warning, info)
- Suggested fixes database
- Cost estimation
- History tracking
- Export reports

**Must Use**:
- Switch for code categories
- Dictionary for lookups
- Error handling for invalid codes
- Classes for code definitions
- Methods for calculations
- File I/O for persistence

---

## 📊 Quality Standards

### Code Style Requirements
- Meaningful variable names (no single letters except loop counters)
- Methods under 20 lines
- Classes under 200 lines
- No deep nesting (max 3 levels)
- Comments for complex logic only

### Exercise Complexity Progression
- **Modules 1-3**: 70% syntax, 30% logic
- **Modules 4-6**: 50% syntax, 50% logic
- **Modules 7-9**: 30% syntax, 70% logic
- **Final Projects**: 10% syntax, 90% logic

### Documentation Requirements
Each exercise must include:
- Clear problem statement
- Expected output example
- Hints without giving away solution
- Common pitfalls section
- "Why this matters" explanation

### Testing Checklist
Before marking complete, each module must:
- [ ] Compile without errors when fixed
- [ ] Cover all stated learning objectives
- [ ] Include variety of exercise types
- [ ] Progress in difficulty
- [ ] Relate to real-world scenarios
- [ ] Have complete solutions with explanations

---

## 🚀 Implementation Priority

1. **High Priority** (Complete first)
   - Module 02: Conditionals (partially done)
   - Module 03: Loops
   - Module 04: Methods

2. **Medium Priority** (Core OOP)
   - Module 06: Classes
   - Module 07: Collections
   - Module 09: Error Handling

3. **Lower Priority** (Enhancement)
   - Module 05: DRY Refactoring
   - Module 08: Enums & Switch
   - Final Projects

---

## 📝 Success Metrics

Students are ready to advance when they can:
- Fix broken code without step-by-step guidance
- Identify code smells and refactor independently
- Build small programs from requirements
- Debug logic errors systematically
- Explain their code choices

## 🎓 Additional Resources Needed

- Cheat sheet for each module (1-page PDF)
- Video walkthrough for first exercise of each module
- Common errors reference guide
- Quick reference for automotive analogies
- Progress tracking spreadsheet template
