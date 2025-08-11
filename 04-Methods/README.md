# Module 04: Methods 🧩

## 🎯 Learning Objectives
By the end of this module, you'll understand:
- Method signatures (names, parameters, return types)
- Parameter styles: by value, `out`, `ref`, `params`, defaults
- Overloading vs default parameters
- Pure functions vs side effects
- Guard clauses and input validation
- Composing behavior from small methods

## 📚 Exercises
Each exercise is a small, real-world scenario with 1–2 tiny bugs. Fix them to meet the acceptance checks.

### Exercise 1: Fix Signatures — Parts Total
**File:** `Exercise1_FixSignatures.cs`
- Purpose: Calculate parts total from prices with tax and a shop fee.
- What to fix (1–2 bugs): wrong return type, rounding, missing null/empty guard.
- Acceptance checks:
  - Prices [12.99, 45.00, 8.50], taxRate 0.0875, shopFee 4.99 → Total: `$77.69`.
  - Subtotal remains unchanged after total calculation.

### Exercise 2: Overloads and Defaults — Appointment Slot
**File:** `Exercise2_OverloadsAndDefaults.cs`
- Purpose: Choose next available appointment slot using overloads/defaults.
- What to fix (1–2 bugs): defaults ignored, overload ambiguity.
- Acceptance checks:
  - FindNextSlot("oil_change") → `Wed 10:00`
  - FindNextSlot("inspection", day: 5, hour: 14) → `Fri 14:00`

### Exercise 3: out/ref/params — Preferred Bay
**File:** `Exercise3_OutRefAndParams.cs`
- Purpose: Choose a preferred bay and compute total duration of steps.
- What to fix (1–2 bugs): `out` not assigned on all paths; returns true when no bay found.
- Acceptance checks:
  - TryGetPreferredBay("brake_service", out bay) → `true`, `bay == 3`
  - TryGetPreferredBay("unknown", out bay) → `false`, `bay == -1`
  - TotalDuration(30, 60, 15) → `105`

### Exercise 4: Pure Functions — Pricing Rules
**File:** `Exercise4_PureFunctions.cs`
- Purpose: Keep pricing methods pure and apply discount then tax.
- What to fix (1–2 bugs): stateful side effects; wrong discount/tax order.
- Acceptance checks:
  - ComputeFinalPrice(100, "VIP", 0.10) → `$99.00`
  - Repeated runs with same inputs return same result; no global state.

## ▶️ How to run
Use the `DEBUG_EXERCISE` property to run a single file:
```
dotnet run --project 04-Methods /p:DEBUG_EXERCISE=Exercise1_FixSignatures.cs
```

Keep changes minimal and focused. Aim for readable code with guard clauses.
