using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using PetStore;
using PetStore.Data;
using PetStore.Logic;
using System.Text.Json;
using System.Text.Json.Serialization;

var services = CreateServiceCollection();

var productLogic = services.GetService<IProductLogic>();

string userInput = DisplayMenuAndGetInput();

while (userInput.ToLower() != "exit")
{
    if (userInput == "1")
    {
        Console.WriteLine("Please add a Product in JSON format");
        var userInputAsJson = Console.ReadLine();
        var dogLeash = JsonSerializer.Deserialize<Product>(userInputAsJson);
        productLogic.AddProduct(dogLeash);
    }
    else if (userInput == "2")
    {
        Console.Write("What is the id of the product you would like to view? ");
        var id = int.Parse(Console.ReadLine());
        var product = productLogic.GetProductById(id);
        Console.WriteLine(JsonSerializer.Serialize(product));
        Console.WriteLine();
    }
    else if (userInput == "3")
    {
        Console.WriteLine("Add an order in json format");
        var userInputAsJson = Console.ReadLine();
        var order = JsonSerializer.Deserialize<Order>(userInputAsJson);
        productLogic.AddOrder(order);
    }
    else if (userInput == "4")
    {
        Console.Write("Get an order by its id: ");
        var id = int.Parse(Console.ReadLine());
        var order = productLogic.GetOrder(id);
        Console.WriteLine(JsonSerializer.Serialize(order));
        Console.WriteLine();
    }

    userInput = DisplayMenuAndGetInput();
}

static string DisplayMenuAndGetInput()
{
    Console.WriteLine("Press 1 to add a product");
    Console.WriteLine("Press 2 to view a product");
    Console.WriteLine("Press 3 to add and order");
    Console.WriteLine("Press 4 to get an order");
    Console.WriteLine("Type 'exit' to quit");

    return Console.ReadLine();
}

static IServiceProvider CreateServiceCollection()
{
    return new ServiceCollection()
        .AddTransient<IProductLogic, ProductLogic>()
        .AddTransient<IProductRepository, ProductRepository>()
        .AddTransient<IOrderRepository, OrderRepository>()
        .BuildServiceProvider();
}