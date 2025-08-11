# Module 07: Integration Checkpoint ✅

Bring together variables, conditionals, loops, methods, classes, and collections in small, realistic tasks.
Each exercise contains 1–2 small bugs inspired by earlier modules. Fix them to meet the acceptance checks.

## Exercises

### Exercise 1: Quick Quote (Variables + Methods)
**File:** `Exercise1_QuickQuote.cs`
- Purpose: Compute a quote from parts, labor hours, and customer type.
- Bugs: type conversion (money precision); wrong discount order.
- Acceptance: Given seeded data → Total matches expected in comments.

### Exercise 2: Service Day Simulator (Loops + Conditionals)
**File:** `Exercise2_ServiceDaySimulator.cs`
- Purpose: Simulate a day: process queue, obey closing time, prioritize emergencies.
- Bugs: break/continue misuse; off-by-one in time.
- Acceptance: Processed count, revenue, remaining match expected.

### Exercise 3: Inventory Auditor (Collections + Methods)
**File:** `Exercise3_InventoryAuditor.cs`
- Purpose: Build low-stock report with `List<T>` + `Dictionary<>`, using helper methods.
- Bugs: missing-key handling; loop bound skip.
- Acceptance: Low-stock list and totals match expected.

### Exercise 4: Mini Report (Classes + Collections)
**File:** `Exercise4_MiniReport.cs`
- Purpose: Aggregate work orders into a mini report by customer.
- Bugs: wrong grouping key; decimal vs int sum.
- Acceptance: Per-customer totals and grand total match expected.

## How to run
```
dotnet run --project 07-IntegrationCheckpoint /p:DEBUG_EXERCISE=Exercise1_QuickQuote.cs
```
