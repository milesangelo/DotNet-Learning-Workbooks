// 🔧 Exercise 2: Customer Validation (Bug Hunt)
// Purpose: Validate Customer using guard clauses.
//
// Bugs to find (exactly 2):
// 1) Allows empty/whitespace name (should throw)
// 2) Does not normalize email to lower or check '@'
//
// Acceptance checks:
//   new Customer("   ", "x@y.com", LoyaltyLevel.Regular) → throws ArgumentException
//   new Customer("Sam", "VIPUser@Email.com", LoyaltyLevel.Vip).Email → "vipuser@email.com"

using System;

class Exercise2_CustomerValidation
{
    static void Main()
    {
        Console.WriteLine("=== Customer Validation ===\n");

        try
        {
            var invalid = new Customer("   ", "x@y.com", LoyaltyLevel.Regular);
            Console.WriteLine("Should have thrown for empty name!");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Caught expected: {ex.GetType().Name}");
        }

        var valid = new Customer("Sam", "VIPUser@Email.com", LoyaltyLevel.Vip);
        Console.WriteLine($"Email: {valid.Email}");
        Console.WriteLine("Expected when fixed: Email: vipuser@email.com");
    }
}

public enum LoyaltyLevel
{
    New,
    Regular,
    Vip,
}

public class Customer
{
    public string Name { get; }
    public string Email { get; }
    public LoyaltyLevel Loyalty { get; }

    public Customer(string name, string email, LoyaltyLevel loyalty)
    {
        // BUG 1: no guard for empty/whitespace
        if (name == null)
            throw new ArgumentException("Name required");

        // BUG 2: no normalization or '@' check
        Name = name;
        Email = email;
        Loyalty = loyalty;
    }
}
