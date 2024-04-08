using CreditCalculator.After.Model;

namespace CreditCalculator.After.Calculator;

public class ICLimitCalculator : AbstractCreditLimitCalculator
{
    public override decimal? GetCreditLimit(Customer customer)
    {
        // Do credit check and double credit limit

        var creditLimit = GetCreditLimitValue(
            customer.FirstName,
            customer.LastName,
            customer.DateOfBirth);

        creditLimit *= 2;
        return creditLimit;
    }
}
