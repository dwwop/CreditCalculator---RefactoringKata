using CreditCalculator.After.Model;

namespace CreditCalculator.After.CreditSetter;

public static class CreditCalculatorFactory
{
    private static readonly Dictionary<CompanyType, Func<AbstractCreditLimitCalculator>> Dictionary = new()
    {
        { CompanyType.RegularClient, () => new RCLimitCalculator() },
        { CompanyType.ImportantClient, () => new ICLimitCalculator() },
        { CompanyType.VeryImportantClient, () => new VICLimitCalculator() }
    };

    public static AbstractCreditLimitCalculator Create(CompanyType type)
    {
        if (Dictionary.TryGetValue(type, out var creator)) return creator();

        throw new Exception("unknown type: " + type);
    }
}
