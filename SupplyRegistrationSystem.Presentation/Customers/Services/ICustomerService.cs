using SupplyRegistrationSystem.Presentation.Customers.Models;
namespace SupplyRegistrationSystem.Presentation.Customers.Services;

public interface ICustomerService
{
    Customer AddCustomer(string name, string email);


    IReadOnlyList<Customer> GetAllCustomers();
}

