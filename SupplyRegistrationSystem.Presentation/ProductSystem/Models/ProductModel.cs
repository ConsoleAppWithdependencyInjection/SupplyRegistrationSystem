namespace SupplyRegistrationSystem.Presentation.Product.Models;

public class ProductModel(string productNumber, string productName, string productPrice, DateTime productRegistration)
{
    string productId { get; set; } = productNumber;
    string productName { get; set; } = productName;
    string productPrice { get; set; } = productPrice;
    DateTime ProductRegistration { get; set; } = productRegistration;
}