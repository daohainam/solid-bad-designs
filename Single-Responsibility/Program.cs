// See https://aka.ms/new-console-template for more information
using Single_Responsibility;

var cart = new ShoppingCart();
cart.Add(new ShoppingCartItem()
{
    Price = 1200,
    ProductId = 1,
    Quantity = 1,
    Title = "iPhone 12"
});
cart.Add(new ShoppingCartItem()
{
    Price = 1400,
    ProductId = 1,
    Quantity = 2,
    Title = "iPhone 14"
});

cart.Print();

Console.WriteLine("Writing to file...");
cart.SaveToFile("cart.json");

cart.Clear();
Console.WriteLine($"Now is empty == {!cart.Items.Any()}");
cart.Print();

cart.LoadFromFile("cart.json");
Console.WriteLine("Loaded from file");
cart.Print();
