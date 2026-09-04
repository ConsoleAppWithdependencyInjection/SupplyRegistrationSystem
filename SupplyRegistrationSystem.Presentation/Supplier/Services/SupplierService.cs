using SupplyRegistrationSystem.Presentation.Supplier.Models;

namespace SupplyRegistrationSystem.Presentation.Supplier.Services;

public class SupplierService : ISupplierService
{
    private readonly List<SupplierModel> _suppliers = [];

    public void AddSupplier(SupplierModel supplier)
    {
        _suppliers.Add(supplier);
    }

    public List<SupplierModel> GetSuppliers()
    {
        return _suppliers;
    }
}