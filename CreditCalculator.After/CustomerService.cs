using CreditCalculator.After.CreditSetter;
using CreditCalculator.After.Model;

namespace CreditCalculator.After;

public class CustomerService
{
    private readonly CompanyRepository _companyRepository = new();
    private readonly CustomerRepository _customerRepository = new();

    public bool AddCustomer(
        string firstName,
        string lastName,
        string email,
        DateTime dateOfBirth,
        int companyId)
    {
        if (!IsNameEmpty(firstName, lastName)) return false;

        if (!IsEmailInvalid(email)) return false;

        if (!IsYoungerThan21(dateOfBirth)) return false;

        var company = _companyRepository.GetById(companyId);

        var customer = new Customer
        {
            Company = company,
            DateOfBirth = dateOfBirth,
            EmailAddress = email,
            FirstName = firstName,
            LastName = lastName
        };

        var calculator = CreditCalculatorFactory.Create(company.Type);
        var creditLimit = calculator.GetCreditLimit(customer);

        if (!IsLimitTooLow(creditLimit)) return false;

        if (creditLimit != null)
        {
            customer.HasCreditLimit = true;
            customer.CreditLimit = creditLimit;
        }

        _customerRepository.AddCustomer(customer);

        return true;
    }

    private static bool IsLimitTooLow(decimal? creditLimit)
    {
        return creditLimit is not < 500;
    }

    private static bool IsYoungerThan21(DateTime dateOfBirth)
    {
        var now = DateTime.Now;
        var age = now.Year - dateOfBirth.Year;

        if (now.Month < dateOfBirth.Month ||
            (now.Month == dateOfBirth.Month && now.Day < dateOfBirth.Day))
            age--;


        return age >= 21;
    }

    private static bool IsEmailInvalid(string email)
    {
        return email.Contains('@') || email.Contains('.');
    }

    private static bool IsNameEmpty(string firstName, string lastName)
    {
        return !string.IsNullOrEmpty(firstName) && !string.IsNullOrEmpty(lastName);
    }
}
