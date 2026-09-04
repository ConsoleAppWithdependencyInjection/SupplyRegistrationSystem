using SupplyRegistrationSystem.Presentation.ProductSystem.Services;

namespace SupplyRegistrationSystem.Presentation.ProductSystem.Dialog;

public class ProductDialog(IProductService productService) : IProductDialog
{
    public void AddProductDialog()
    {
        Console.Clear();
        Console.WriteLine("### ADD PRODUCT ###");

        InputDialog("Enter Product LOTR-Number", out string productNumber);
        InputDialog("Enter Product name", out string productName);
        InputDialog("Enter Product price", out string productPrice);

        var registration = DateTime.Now;
        
        var product = productService.AddProduct(productNumber, productName, productPrice, registration);

        if (product is not null)
            Console.WriteLine($"Product with LOTR-Number '{productNumber}' was created");
        else
            Console.WriteLine($"Unable to create new product");

        Console.ReadKey();
    }

    public void ShowAllProducts()
    {
        Console.Clear();
        Console.WriteLine("### PRODUCT LIST ###");

        var products = productService.GetAllProducts();
        foreach (var product in products)
        {
            Console.WriteLine($"{product.ProductName}");
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

