# Module 06: Collections & Generics 🗂️

## 🎯 Learning Objectives
By the end of this module, you'll understand:
- Arrays vs `List<T>` vs `Dictionary<TKey,TValue>` vs `HashSet<T>`
- Iteration patterns and when to use each collection
- Basics of generics and type safety
- Searching, lookups, grouping, and de-duplication

## 📚 Exercises (each has 1–2 tiny bugs to fix)

### Exercise 1: Inventory List
**File:** `Exercise1_InventoryList.cs`
- Purpose: Convert array operations to `List<T>` and manage inserts/removes.
- What to fix: off-by-one insert; removing while iterating.
- Acceptance checks:
  - After operations, list count and order match expected comment.

### Exercise 2: Service Dictionary
**File:** `Exercise2_ServiceDictionary.cs`
- Purpose: Map service codes to prices with robust lookups.
- What to fix: missing-key handling; wrong key casing.
- Acceptance checks:
  - Lookup("BRAKE") → 149.99; Lookup("unknown") → prints friendly message, returns null.

### Exercise 3: Dedupe with HashSet
**File:** `Exercise3_DedupeWithHashSet.cs`
- Purpose: Remove duplicates while preserving original order.
- What to fix: using `HashSet` but losing order; case-insensitive dedupe.
- Acceptance checks:
  - Input: ["OF-001", "BP-205", "of-001", "SP-123"] → Output: ["OF-001", "BP-205", "SP-123"].

### Exercise 4: Generic Repository
**File:** `Exercise4_GenericRepository.cs`
- Purpose: Minimal `Repository<T>` with add/find/remove.
- What to fix: missing constraint or equality comparer; remove fails silently.
- Acceptance checks:
  - Add 3 parts, find by SKU returns item; remove by SKU reduces count by 1.

## ▶️ How to run
Use the `DEBUG_EXERCISE` property to run a single file:
```
dotnet run --project 06-CollectionsAndGenerics /p:DEBUG_EXERCISE=Exercise1_InventoryList.cs
```
