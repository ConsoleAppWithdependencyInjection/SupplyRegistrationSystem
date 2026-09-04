using SupplyRegistrationSystem.Presentation.Customers.Models;

namespace SupplyRegistrationSystem.Presentation.Customers.Models;

public interface ICustomerService
{
    Customer AddCustomer(string name, string email);


    IReadOnlyList<Customer> GetAllCustomers();
}

