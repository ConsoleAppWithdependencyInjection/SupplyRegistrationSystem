using SupplyRegistrationSystem.Presentation.ProductSystem.Dialog;
using SupplyRegistrationSystem.Presentation.ProductSystem.Services;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

var builder = Host.CreateApplicationBuilder(args);
builder.Services.AddSingleton<IProductService, InMemoryProductService>();
builder.Services.AddTransient<IProductDialog, ProductDialog>();
using var host = builder.Build();

var dialog = host.Services.GetRequiredService<IProductDialog>();


bool isRunning = true;

do
{
    Console.Clear();
    Console.WriteLine("### MENU ###");
    Console.WriteLine("[1] CUSTOMER");
    Console.WriteLine("[2] PRODUCTS");
    Console.WriteLine("[3] SUPPLIER");
    Console.WriteLine("[0] EXIT");

    var input = Console.ReadLine();

    switch (input)
    {
        case "1":

            break;
        case "2":
            dialog.AddProductDialog();
            dialog.ShowAllProducts();

            break;
        case "3":

            break;
        case "0":
            Environment.Exit(0);
            break;
        default:
            Console.WriteLine("You must choose a valid option! Press any button to continue...");
            Console.ReadKey();
            break;
    }
}
while (isRunning);