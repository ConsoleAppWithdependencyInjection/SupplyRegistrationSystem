using SupplyRegistrationSystem.Presentation.Product.Models;

namespace SupplyRegistrationSystem.Presentation.ProductSystem.Services;

public interface IProductService
{
    ProductModel CreateProduct(string productNumber, string productName, string productPrice, DateTime productRegistration);

    IReadOnlyList<ProductModel> GetAllProducts();
}
