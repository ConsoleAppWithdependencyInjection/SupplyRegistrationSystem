using SupplyRegistrationSystem.Presentation.Supplier.Models;

namespace SupplyRegistrationSystem.Presentation.Supplier.Services;

public interface ISupplierService
{
    void AddSupplier(SupplierModel supplier);
}