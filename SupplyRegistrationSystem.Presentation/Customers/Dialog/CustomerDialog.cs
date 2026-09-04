using SupplyRegistrationSystem.Presentation.Customers.Services;
namespace SupplyRegistrationSystem.Presentation.Customers.Dialog;


internal class CustomerDialog (ICustomerService customerService): ICustomerDialog
{
    public void AddCustomer()
    {
        Console.WriteLine("Ange kundens namn:");
        string name = Console.ReadLine() ?? "";

        Console.WriteLine("Ange kundens e-postadress;");
        string email = Console.ReadLine() ?? "";

        customerService.AddCustomer(name, email);
    }

    public void ShowAllCustomers()
    {
        var customers = customerService.GetAllCustomers();


        foreach(var customer in customers)
        {
            Console.WriteLine($"{customer.Name} - {customer.Email}");
        }
    }
}
