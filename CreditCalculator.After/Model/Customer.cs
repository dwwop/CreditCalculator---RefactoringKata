namespace CreditCalculator.After.Model;

public class Customer
{
    public Company Company { get; set; }
    public DateTime DateOfBirth { get; init; }
    public string EmailAddress { get; set; }
    public string FirstName { get; init; }
    public string LastName { get; init; }
    public bool HasCreditLimit { get; set; }
    public decimal? CreditLimit { get; set; }
}
