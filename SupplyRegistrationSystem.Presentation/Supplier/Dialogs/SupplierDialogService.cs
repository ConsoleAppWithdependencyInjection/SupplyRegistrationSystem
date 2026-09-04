using SupplyRegistrationSystem.Presentation.Supplier.Models;
using SupplyRegistrationSystem.Presentation.Supplier.Services;

namespace SupplyRegistrationSystem.Presentation.Supplier.Dialogs;

public class SupplierDialogService : ISupplierDialog
{
    private readonly ISupplierService _supplierService;

    public SupplierDialogService(ISupplierService supplierService)
    {
        _supplierService = supplierService;
    }

    public void AddSupplier()
    {
        Console.Write("Ange företagsnamn: ");
        string companyName = Console.ReadLine() ?? "";

        Console.Write("Ange telefonnummer: ");
        string phoneNumber = Console.ReadLine() ?? "";

        Console.Write("Ange faktureringsadress: ");
        string billingAddress = Console.ReadLine() ?? "";

        Console.Write("Ange organisationsnummer: ");
        string organizationNumber = Console.ReadLine() ?? "";

        SupplierModel supplier = new()
        {
            CompanyName = companyName,
            PhoneNumber = phoneNumber,
            BillingAddress = billingAddress,
            OrganizationNumber = organizationNumber
        };

        _supplierService.AddSupplier(supplier);

        Console.WriteLine();
        Console.WriteLine($"Leverantören {supplier.CompanyName} har lagts till.");
        Console.WriteLine($"Telefonnummer: {supplier.PhoneNumber}");
        Console.WriteLine($"Faktureringsadress: {supplier.BillingAddress}");
        Console.WriteLine($"Organisationsnummer: {supplier.OrganizationNumber}");
    }
}