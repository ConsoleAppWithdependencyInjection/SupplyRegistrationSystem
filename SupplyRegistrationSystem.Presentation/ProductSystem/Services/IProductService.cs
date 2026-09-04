using SupplyRegistrationSystem.Presentation.Product.Models;

namespace SupplyRegistrationSystem.Presentation.ProductSystem.Services;

public interface IProductService
{
    ProductModel AddProduct(string productNumber, string productName, string productPrice, DateTime productRegistration);

    IReadOnlyList<ProductModel> GetAllProducts();
}
