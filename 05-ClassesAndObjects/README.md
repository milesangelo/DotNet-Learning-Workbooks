# Module 05: Classes & Objects 🧱

## 🎯 Learning Objectives
By the end of this module, you'll understand:
- Classes vs objects; encapsulating state + behavior
- Properties (get/set, init), constructors, guard clauses
- Immutability vs mutability; exposing collections safely
- Basic composition between objects

## 📚 Exercises (each has 1–2 tiny bugs to fix)

### Exercise 1: Part Model
**File:** `Exercise1_PartModel.cs`
- Purpose: Define `Part` with `Name`, `Sku`, and `UnitPrice` and a friendly `ToString`.
- What to fix: constructor assigns fields in the wrong order; price formatting to 2 decimals.
- Acceptance checks:
  - `new Part("Oil Filter", "OF-001", 12.99).ToString()` → `OF-001 - Oil Filter: $12.99`

### Exercise 2: Customer Validation
**File:** `Exercise2_CustomerValidation.cs`
- Purpose: Guard clauses for `Customer(Name, Email, LoyaltyLevel)`.
- What to fix: rejects empty/whitespace name; normalizes email to lower; simple `@` check.
- Acceptance checks:
  - Creating with `"   "` name throws `ArgumentException`.
  - Email `"VIPUser@Email.com"` normalized to `"vipuser@email.com"`.

### Exercise 3: WorkOrder Behavior
**File:** `Exercise3_WorkOrderBehavior.cs`
- Purpose: Manage line items and calculate totals with tax.
- What to fix: total applies tax twice; items list is exposed directly.
- Acceptance checks:
  - Items: (2 × $10) + (1 × $5), tax 10% → Total `$27.50`.

### Exercise 4: Shop Composition
**File:** `Exercise4_ShopComposition.cs`
- Purpose: Manage open/closed work orders in a shop.
- What to fix: `CloseOrder(id)` returns true even when not found; exposes internal list.
- Acceptance checks:
  - Closing id `2` marks it closed and reduces open-count by 1; closing id `999` returns `false`.

## ▶️ How to run
Use the `DEBUG_EXERCISE` property to run a single file:
```
dotnet run --project 05-ClassesAndObjects /p:DEBUG_EXERCISE=Exercise1_PartModel.cs
```
