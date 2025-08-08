// 🔧 Exercise 3: Refactor the Verbose Code
//
// This code works, but it's PAINFUL to read and maintain.
// Your mission: Make it clean and professional.
//
// GOALS:
// 1. Eliminate unnecessary variables
// 2. Use better variable names
// 3. Apply 'var' where appropriate
// 4. Group related data
// 5. Use constants for values that don't change

using System;

class Exercise3_Verbose
{
    static void Main()
    {
        Console.WriteLine("=== Verbose Service Estimate Calculator ===\n");

        // Customer information (WAY too many variables!)
        string customerFirstName = "John";
        string customerMiddleName = "Paul";
        string customerLastName = "Smith";
        string customerStreetAddress = "123 Main St";
        string customerCity = "Springfield";
        string customerState = "IL";
        string customerZip = "62701";
        string customerPhone1 = "555";
        string customerPhone2 = "123";
        string customerPhone3 = "4567";

        // Vehicle information (repetitive and verbose)
        string vehicleManufacturerCompanyName = "Toyota";
        string vehicleModelNameString = "Camry";
        string vehicleYearOfManufacture = "2018";
        string vehicleIdentificationNumberVIN = "1HGBH41JXMN109186";

        // Service items (there's a pattern here we're not using...)
        string service1Name = "Oil Change";
        double service1Price = 39.99;
        double service1Time = 0.5;

        string service2Name = "Tire Rotation";
        double service2Price = 29.99;
        double service2Time = 0.5;

        string service3Name = "Brake Inspection";
        double service3Price = 49.99;
        double service3Time = 1.0;

        // Labor calculation (magic numbers everywhere!)
        double laborRatePerHour = 95.00; // This never changes, why isn't it const?
        double shopFeePercent = 0.10; // Neither does this
        double taxRate = 0.0875; // Or this

        // Calculate totals (so many intermediate variables!)
        double totalLaborHours = service1Time + service2Time + service3Time;
        double totalLaborCost = totalLaborHours * laborRatePerHour;
        double totalPartsCost = service1Price + service2Price + service3Price;
        double subtotalBeforeFees = totalLaborCost + totalPartsCost;
        double shopFeeAmount = subtotalBeforeFees * shopFeePercent;
        double subtotalWithShopFee = subtotalBeforeFees + shopFeeAmount;
        double taxAmount = subtotalWithShopFee * taxRate;
        double grandTotalFinal = subtotalWithShopFee + taxAmount;

        // Display (using concatenation instead of interpolation)
        Console.WriteLine(
            "Customer: " + customerFirstName + " " + customerMiddleName + " " + customerLastName
        );
        Console.WriteLine(
            "Address: "
                + customerStreetAddress
                + ", "
                + customerCity
                + ", "
                + customerState
                + " "
                + customerZip
        );
        Console.WriteLine("Phone: " + customerPhone1 + "-" + customerPhone2 + "-" + customerPhone3);
        Console.WriteLine("");
        Console.WriteLine(
            "Vehicle: "
                + vehicleYearOfManufacture
                + " "
                + vehicleManufacturerCompanyName
                + " "
                + vehicleModelNameString
        );
        Console.WriteLine("VIN: " + vehicleIdentificationNumberVIN);
        Console.WriteLine("");
        Console.WriteLine("Services:");
        Console.WriteLine("  " + service1Name + ": $" + service1Price);
        Console.WriteLine("  " + service2Name + ": $" + service2Price);
        Console.WriteLine("  " + service3Name + ": $" + service3Price);
        Console.WriteLine("");
        Console.WriteLine(
            "Labor ("
                + totalLaborHours
                + " hours @ $"
                + laborRatePerHour
                + "/hr): $"
                + totalLaborCost
        );
        Console.WriteLine("Shop Fee (" + (shopFeePercent * 100) + "%): $" + shopFeeAmount);
        Console.WriteLine("Tax (" + (taxRate * 100) + "%): $" + taxAmount);
        Console.WriteLine("Total: $" + grandTotalFinal);

        // Discount check (using 1 and 0 instead of bool)
        int isRegularCustomer = 1; // Why not use bool?
        if (isRegularCustomer == 1)
        {
            double discountPercent = 0.05;
            double discountAmount = grandTotalFinal * discountPercent;
            double finalAfterDiscount = grandTotalFinal - discountAmount;
            Console.WriteLine("Regular Customer Discount: -$" + discountAmount);
            Console.WriteLine("Final Total: $" + finalAfterDiscount);
        }
    }
}

/*
🔨 REFACTORING TARGETS:

1. COMBINE RELATED DATA
   - Customer name doesn't need 3 variables
   - Phone number doesn't need 3 variables
   - Consider: could some of this be combined better?

2. USE CONSTANTS
   - Labor rate, tax rate, shop fee never change
   - Make them const with UPPER_CASE names

3. ELIMINATE UNNECESSARY VARIABLES
   - Do we need a variable for every calculation step?
   - Can some calculations be combined?

4. USE MODERN C# FEATURES
   - String interpolation instead of concatenation
   - var where the type is obvious
   - Proper bool instead of int flags

5. BETTER NAMES
   - vehicleManufacturerCompanyName → make
   - vehicleModelNameString → model
   - Keep it simple and clear

GOAL: Make this code something you'd be proud to show a colleague!
*/
