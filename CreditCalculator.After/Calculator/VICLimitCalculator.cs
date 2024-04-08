using CreditCalculator.After.Model;

namespace CreditCalculator.After.Calculator;

public class VICLimitCalculator : AbstractCreditLimitCalculator
{
    public override decimal? GetCreditLimit(Customer customer)
    {
        return null;
    }
}
