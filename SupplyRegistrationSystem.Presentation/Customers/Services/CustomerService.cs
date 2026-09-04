using SupplyRegistrationSystem.Presentation.Customers.Models;
namespace SupplyRegistrationSystem.Presentation.Customers.Services;

internal class CustomerService : ICustomerService
{
    private readonly List<Customer> _customerList = []; 

    public Customer AddCustomer(string name, string email)
    {
        var customer = new Customer(name, email);

        _customerList.Add(customer);

        return customer;
    }

    public IReadOnlyList<Customer> GetAllCustomers() 
    {
        return _customerList; 
    }
}
