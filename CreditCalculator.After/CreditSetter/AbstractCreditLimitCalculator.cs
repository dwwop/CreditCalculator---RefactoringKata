using CreditCalculator.After.Model;

namespace CreditCalculator.After.CreditSetter;

public abstract class AbstractCreditLimitCalculator
{
    public abstract decimal? GetCreditLimit(Customer customer);


    protected static decimal GetCreditLimitValue(string firstName, string lastName, DateTime dateOfBirth)
    {
        if (firstName == "John" && lastName == "Doe") return 500.0m;

        if (DateTime.Now.Year - dateOfBirth.Year > 40) return 600.0m;

        return 249.9m;
    }
}
