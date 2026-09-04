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
        string companyName = ReadRequired("Ange företagsnamn: ");
        string phoneNumber = ReadRequired("Ange telefonnummer: ");
        string billingAddress = ReadRequired("Ange faktureringsadress: ");
        string organizationNumber = ReadRequired("Ange organisationsnummer: ");

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

        List<SupplierModel> suppliers = _supplierService.GetSuppliers();

        Console.WriteLine();
        Console.WriteLine("Alla registrerade leverantörer:");

        foreach (SupplierModel item in suppliers)
        {
            Console.WriteLine();
            Console.WriteLine($"Företagsnamn: {item.CompanyName}");
            Console.WriteLine($"Telefonnummer: {item.PhoneNumber}");
            Console.WriteLine($"Faktureringsadress: {item.BillingAddress}");
            Console.WriteLine($"Organisationsnummer: {item.OrganizationNumber}");
        }
    }

    private string ReadRequired(string message)
    {
        string input;

        do
        {
            Console.Write(message);
            input = Console.ReadLine() ?? "";

            if (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Fältet får inte vara tomt.");
            }

        } while (string.IsNullOrWhiteSpace(input));

        return input;
    }
}