namespace SupplyRegistrationSystem.Presentation.Product.Models;

public class ProductModel(string productNumber, string productName, string productPrice, DateTime productRegistration)
{
    public string ProductId { get; set; } = productNumber;
    public string ProductName { get; set; } = productName;
    public string ProductPrice { get; set; } = productPrice;
    public DateTime ProductRegistration { get; set; } = productRegistration;
}