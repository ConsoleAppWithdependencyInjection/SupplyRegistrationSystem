using SupplyRegistrationSystem.Presentation.Product.Models;

namespace SupplyRegistrationSystem.Presentation.ProductSystem.Services;

public class InMemoryProductService : IProductService
{
    private readonly List<ProductModel> _productsList = [];
    public ProductModel AddProduct (string productNumber, string productName, string productPrice, DateTime createdDate)
    {
        var product = CreateProduct(productNumber, productName, productPrice, createdDate);

        _productsList.Add(product);

        return product;
    }
    public IReadOnlyList<ProductModel> GetAllProducts()
    {
        return _productsList;
            
    }
    public ProductModel CreateProduct(
    string productNumber,
    string productName,
    string productPrice,
    DateTime createdDate)
    {
        return new ProductModel(
            productNumber,
            productName,
            productPrice,
            createdDate);
    }
}
