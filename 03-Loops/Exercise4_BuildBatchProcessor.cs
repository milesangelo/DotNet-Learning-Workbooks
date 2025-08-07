// 🔧 Exercise 4: Build a Parts Order Batch Processor
//
// BUILD FROM SCRATCH! 
// Create a sophisticated batch processing system that handles
// multiple parts orders efficiently. This is your chance to apply
// everything you've learned about loops to solve a real-world problem.

using System;
using System.Collections.Generic;

class Program
{
    // Part order structure for your batch processor
    public class PartOrder
    {
        public string PartNumber { get; set; } = "";
        public string PartName { get; set; } = "";
        public int QuantityOrdered { get; set; }
        public int QuantityAvailable { get; set; }
        public double UnitPrice { get; set; }
        public string Supplier { get; set; } = "";
        public bool IsRushOrder { get; set; }
        public bool RequiresSpecialHandling { get; set; }
        public int ProcessingTime { get; set; } // minutes
        public string Status { get; set; } = "Pending"; // Pending, Processing, Complete, Backordered
    }
    
    static void Main()
    {
        Console.WriteLine("=== Parts Order Batch Processor ===\n");
        Console.WriteLine("🎯 Your mission: Build this system from scratch!\n");
        
        // Sample data to work with
        var batchOrders = GetSampleOrders();
        
        Console.WriteLine($"📦 {batchOrders.Count} orders ready for batch processing\n");
        
        foreach (var order in batchOrders)
        {
            Console.WriteLine($"  • {order.PartName} (Qty: {order.QuantityOrdered}, Available: {order.QuantityAvailable})");
        }
        
        Console.WriteLine("\n⚠️ PLACEHOLDER - Build your batch processor here!");
        Console.WriteLine("Replace this with your implementation using the requirements below.\n");
        
        // TODO: Implement your batch processing system!
        // ProcessOrderBatch(batchOrders);
        
        ShowRequirements();
    }
    
    static List<PartOrder> GetSampleOrders()
    {
        return new List<PartOrder>
        {
            new PartOrder 
            {
                PartNumber = "OF-001", PartName = "Oil Filter", QuantityOrdered = 50, 
                QuantityAvailable = 45, UnitPrice = 12.99, Supplier = "AutoParts Plus",
                IsRushOrder = false, RequiresSpecialHandling = false, ProcessingTime = 5
            },
            new PartOrder 
            {
                PartNumber = "BP-205", PartName = "Brake Pads", QuantityOrdered = 25, 
                QuantityAvailable = 30, UnitPrice = 45.00, Supplier = "BrakeTech",
                IsRushOrder = true, RequiresSpecialHandling = true, ProcessingTime = 15
            },
            new PartOrder 
            {
                PartNumber = "SP-123", PartName = "Spark Plugs", QuantityOrdered = 100, 
                QuantityAvailable = 0, UnitPrice = 3.25, Supplier = "Ignition Works",
                IsRushOrder = false, RequiresSpecialHandling = false, ProcessingTime = 3
            },
            new PartOrder 
            {
                PartNumber = "AF-456", PartName = "Air Filter", QuantityOrdered = 75, 
                QuantityAvailable = 60, UnitPrice = 8.50, Supplier = "FilterMax",
                IsRushOrder = true, RequiresSpecialHandling = false, ProcessingTime = 8
            },
            new PartOrder 
            {
                PartNumber = "EN-789", PartName = "Engine Belt", QuantityOrdered = 20, 
                QuantityAvailable = 25, UnitPrice = 22.50, Supplier = "BeltCorp",
                IsRushOrder = false, RequiresSpecialHandling = true, ProcessingTime = 12
            },
            new PartOrder 
            {
                PartNumber = "CO-321", PartName = "Coolant", QuantityOrdered = 40, 
                QuantityAvailable = 35, UnitPrice = 15.75, Supplier = "FluidTech",
                IsRushOrder = true, RequiresSpecialHandling = true, ProcessingTime = 20
            }
        };
    }
    
    static void ShowRequirements()
    {
        Console.WriteLine("📋 BATCH PROCESSOR REQUIREMENTS:\n");
        
        Console.WriteLine("🎯 CORE FUNCTIONALITY:");
        Console.WriteLine("Build a method called ProcessOrderBatch() that processes multiple orders efficiently.\n");
        
        Console.WriteLine("🔄 PROCESSING RULES:");
        Console.WriteLine("  1. Process rush orders first (IsRushOrder = true)");
        Console.WriteLine("  2. Skip orders with zero availability (backorder them)");
        Console.WriteLine("  3. Partial fulfillment when quantity available < quantity ordered");
        Console.WriteLine("  4. Special handling items take 2x processing time");
        Console.WriteLine("  5. Stop processing if total time exceeds 4 hours (240 minutes)");
        Console.WriteLine("  6. Group orders by supplier for efficiency bonuses\n");
        
        Console.WriteLine("📊 BATCH LIMITS:");
        Console.WriteLine("  • Maximum processing time: 4 hours (240 minutes)");
        Console.WriteLine("  • Maximum orders per batch: 50");
        Console.WriteLine("  • Rush orders must be completed within first hour");
        Console.WriteLine("  • Special handling requires dedicated time slots\n");
        
        Console.WriteLine("💰 COST CALCULATIONS:");
        Console.WriteLine("  • Base cost = quantity × unit price");
        Console.WriteLine("  • Rush order surcharge: +25%");
        Console.WriteLine("  • Bulk discount: 10% off when total order > $500");
        Console.WriteLine("  • Supplier loyalty discount: 5% off when ordering 3+ items from same supplier\n");
        
        Console.WriteLine("📈 EFFICIENCY BONUSES:");
        Console.WriteLine("  • Same supplier bonus: -20% processing time when grouping orders");
        Console.WriteLine("  • Large quantity bonus: -10% time for orders > 50 units");
        Console.WriteLine("  • Perfect availability bonus: -15% time when exact quantity available\n");
        
        Console.WriteLine("🎯 EXPECTED LOOP USAGE:");
        Console.WriteLine("  ✅ Use while loop for time-limited processing");
        Console.WriteLine("  ✅ Use for loop when iterating through order batches");
        Console.WriteLine("  ✅ Use foreach for simple order enumeration");
        Console.WriteLine("  ✅ Use nested loops for supplier grouping");
        Console.WriteLine("  ✅ Implement break/continue for special cases\n");
        
        Console.WriteLine("🏗️ SUGGESTED STRUCTURE:");
        Console.WriteLine("1. Sort orders by priority (rush first)");
        Console.WriteLine("2. Group orders by supplier for efficiency");
        Console.WriteLine("3. Process each group with time tracking");
        Console.WriteLine("4. Handle partial fulfillment and backorders");
        Console.WriteLine("5. Calculate costs with all discounts/surcharges");
        Console.WriteLine("6. Generate comprehensive batch report\n");
        
        Console.WriteLine("📋 BATCH REPORT SHOULD INCLUDE:");
        Console.WriteLine("  • Orders processed vs. total orders");
        Console.WriteLine("  • Total processing time used");
        Console.WriteLine("  • Rush orders completed on time");
        Console.WriteLine("  • Items backordered");
        Console.WriteLine("  • Total cost with all adjustments");
        Console.WriteLine("  • Efficiency bonuses achieved");
        Console.WriteLine("  • Supplier breakdown\n");
        
        Console.WriteLine("🧪 TEST SCENARIOS:");
        Console.WriteLine("  ✅ Normal batch: All items available, mixed priorities");
        Console.WriteLine("  ⏰ Time limit: Stop processing when 4 hours exceeded");
        Console.WriteLine("  🚨 Rush priority: Rush orders processed first");
        Console.WriteLine("  📦 Partial fulfillment: Some items have limited stock");
        Console.WriteLine("  ❌ Backorders: Zero stock items moved to backorder");
        Console.WriteLine("  💰 Discount calculation: Bulk and loyalty discounts applied");
        Console.WriteLine("  ⚡ Efficiency: Supplier grouping saves time\n");
        
        Console.WriteLine("💡 ADVANCED FEATURES:");
        Console.WriteLine("  🔄 Multi-stage processing (validation → fulfillment → shipping)");
        Console.WriteLine("  📊 Real-time progress tracking with percentage complete");
        Console.WriteLine("  ⚠️ Error handling for invalid orders");
        Console.WriteLine("  🔍 Detailed logging of each processing step");
        Console.WriteLine("  📈 Performance metrics (orders per minute, efficiency rating)\n");
        
        Console.WriteLine("🏆 SUCCESS CRITERIA:");
        Console.WriteLine("  ✅ All loop types used appropriately");
        Console.WriteLine("  ✅ Rush orders processed with priority");
        Console.WriteLine("  ✅ Time limits respected");
        Console.WriteLine("  ✅ Accurate cost calculations");
        Console.WriteLine("  ✅ Comprehensive reporting");
        Console.WriteLine("  ✅ Efficient supplier grouping");
        Console.WriteLine("  ✅ Handles edge cases (empty batch, all backorders)");
        Console.WriteLine("  ✅ Clean, readable code structure\n");
        
        Console.WriteLine("🎯 EXAMPLE USAGE:");
        Console.WriteLine("```csharp");
        Console.WriteLine("var processor = new BatchProcessor();");
        Console.WriteLine("var report = processor.ProcessOrderBatch(orders, maxTime: 240);");
        Console.WriteLine("");
        Console.WriteLine("Console.WriteLine($\"Processed: {report.OrdersCompleted}/{report.TotalOrders}\");");
        Console.WriteLine("Console.WriteLine($\"Time Used: {report.ProcessingTime} minutes\");");
        Console.WriteLine("Console.WriteLine($\"Total Cost: ${report.TotalCost:F2}\");");
        Console.WriteLine("```\n");
        
        Console.WriteLine("🚀 This is a realistic warehouse automation problem!");
        Console.WriteLine("Many businesses use exactly this type of batch processing.");
        Console.WriteLine("Your solution should be something you'd trust in a real shop!");
    }
}

/*
🎯 KEY LEARNING OBJECTIVES:

This exercise combines multiple loop concepts:

1. PRIORITIZATION LOOPS:
   • Sort and process by priority
   • Rush orders first, then regular

2. TIME-LIMITED PROCESSING:
   • while loop with time tracking
   • break when time limit exceeded

3. CONDITIONAL PROCESSING:
   • continue for unavailable items
   • break for critical errors

4. GROUPING AND EFFICIENCY:
   • Nested loops for supplier grouping
   • Calculate efficiency bonuses

5. ACCUMULATION PATTERNS:
   • Track totals, counts, costs
   • Build comprehensive reports

6. EDGE CASE HANDLING:
   • Empty batches
   • All rush orders
   • Time exceeded immediately

💡 REAL-WORLD APPLICATIONS:
- Order fulfillment systems
- Manufacturing batch processing
- Data processing pipelines
- Resource allocation algorithms

This isn't just an exercise - it's a pattern you'll use throughout your career!

Start simple, get the basic loop working, then add features one by one.
You've got this! 🔧
*/
