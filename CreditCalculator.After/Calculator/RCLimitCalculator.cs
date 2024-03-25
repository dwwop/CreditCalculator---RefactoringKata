using CreditCalculator.After.Model;

namespace CreditCalculator.After.CreditSetter;

public class RCLimitCalculator : AbstractCreditLimitCalculator
{
    public override decimal? GetCreditLimit(Customer customer)
    {
        // Do credit check

        var creditLimit = GetCreditLimitValue(
            customer.FirstName,
            customer.LastName,
            customer.DateOfBirth);

        return creditLimit;
    }
}
