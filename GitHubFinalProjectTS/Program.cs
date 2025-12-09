using GitHubFinalProjectTS.Models;
using GitHubFinalProjectTS.Services;

Console.WriteLine("=== Coffee Kiosk Pattern Test ===");

// ----------------------------------
// FACTORY METHOD — create base drink
// ----------------------------------
DrinkCreator creator = new SimpleDrinkCreator();

IDrink drink = creator.CreateDrink("latte");

Console.WriteLine("\nFactory Method:");
Console.WriteLine($"Created: {drink.Name}");
Console.WriteLine($"Base Price: {drink.BasePrice:C}");
Console.WriteLine($"Description: {drink.GetDescription()}");

// ----------------------------------
// DECORATOR — add milk + sugar
// ----------------------------------
drink = new MilkDecorator(drink);
drink = new SugarDecorator(drink);

Console.WriteLine("\nDecorator:");
Console.WriteLine($"With Add-ons Price: {drink.BasePrice:C}");
Console.WriteLine($"Description: {drink.GetDescription()}");

// ----------------------------------
// STRATEGY — apply discount
// ----------------------------------
IDiscountStrategy strategy = new StudentDiscountStrategy();
PricingContext pricing = new PricingContext(strategy);

decimal finalPrice = pricing.CalculateFinalPrice(drink.BasePrice);

Console.WriteLine("\nStrategy:");
Console.WriteLine("Discount: Student (10%)");
Console.WriteLine($"Final Price: {finalPrice:C}");

Console.WriteLine("\n=== Test Complete ===");
Console.ReadLine();
