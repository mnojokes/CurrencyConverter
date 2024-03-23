using CurrencyConverter.Contracts.Requests;
using Swashbuckle.AspNetCore.Filters;

#pragma warning disable 1591
public class ConvertRequestExample : IExamplesProvider<ConvertRequest>
{
    public ConvertRequest GetExamples()
    {
        return new ConvertRequest()
        {
            Amount = 350.42m,
            CurrencyFrom = "EUR",
            CurrencyTo = "USD",
            FromDate = new DateTime(2024, 2, 13)
        };
    }
}
