using CreditCalculator.After.Model;

namespace CreditCalculator.After;

public class CustomerRepository
{
    private readonly List<Customer> _customers = [];

    public List<Customer> GetCustomers()
    {
        return _customers.ToList();
    }

    public void AddCustomer(Customer customer)
    {
        _customers.Add(customer);
    }
}
