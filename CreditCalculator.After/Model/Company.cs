namespace CreditCalculator.After.Model;

public class Company
{
    public static readonly Company RegularClient = new() { Id = 1, Type = CompanyType.RegularClient };
    public static readonly Company ImportantClient = new() { Id = 2, Type = CompanyType.ImportantClient };
    public static readonly Company VeryImportantClient = new() { Id = 3, Type = CompanyType.VeryImportantClient };

    public int Id { get; private init; }

    public CompanyType Type { get; private init; }
}