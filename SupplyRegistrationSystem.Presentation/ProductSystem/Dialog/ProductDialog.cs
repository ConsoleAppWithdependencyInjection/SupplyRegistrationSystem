using SupplyRegistrationSystem.Presentation.ProductSystem.Services;

namespace SupplyRegistrationSystem.Presentation.ProductSystem.Dialog;

public class ProductDialog(IProductService productService) : IProductDialog
{
    public void AddProductDialog()
    {
        Console.Clear();
        Console.WriteLine("### ADD CUSTOMER ###");

        InputDialog("Enter customer name", out string productNumber);
        InputDialog("Enter customer email", out string productName);
        InputDialog("Enter customer email", out string productPrice);

        var registration = DateTime.Now;
        

        var product = productService.CreateProduct(productNumber, productName, productPrice, registration);

        if (product is not null)
            Console.WriteLine($"Customer with id '{productNumber}' was created");
        else
            Console.WriteLine($"Unable to create new customer");

        Console.ReadKey();
    }

    public void ShowAllProducts()
    {
        Console.Clear();
        Console.WriteLine("### CUSTOMER LIST ###");

        var products = productService.GetAllProducts();
        foreach (var product in products)
        {
            Console.WriteLine($"{product}");
        }
        Console.ReadKey();
    }
    private static void InputDialog(string text, out string value)
    {
        do
        {
            Console.Write($"{text}: ");
            value = Console.ReadLine() ?? string.Empty;

            Console.Clear();
        }
        while (string.IsNullOrWhiteSpace(value));
    }
}

