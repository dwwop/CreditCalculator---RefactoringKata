using CreditCalculator.After.Model;

namespace CreditCalculator.After.CreditSetter;

public class VICLimitCalculator : AbstractCreditLimitCalculator
{
    public override decimal? GetCreditLimit(Customer customer)
    {
        return null;
    }
}
