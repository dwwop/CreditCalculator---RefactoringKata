using CreditCalculator.After.Model;

namespace CreditCalculator.After;

public class CompanyRepository
{
    private readonly List<Company> _companies =
    [
        Company.RegularClient,
        Company.ImportantClient,
        Company.VeryImportantClient
    ];

    public Company GetById(int companyId)
    {
        return _companies.Single(c => c.Id == companyId);
    }
}
