using CreditCalculator.After.Constants;
using CreditCalculator.After.Model;

namespace CreditCalculator.After.Calculator;

public abstract class AbstractCreditLimitCalculator
{
    public abstract decimal? GetCreditLimit(Customer customer);


    protected static decimal GetCreditLimitValue(string firstName, string lastName, DateTime dateOfBirth)
    {
        if (firstName == "John" && lastName == "Doe") return LimitConstants.LimitJohnDoe;

        if (DateTime.Now.Year - dateOfBirth.Year > 40) return LimitConstants.LimitPersonYoungerThan40;

        return LimitConstants.LimitDefault;
    }
}
