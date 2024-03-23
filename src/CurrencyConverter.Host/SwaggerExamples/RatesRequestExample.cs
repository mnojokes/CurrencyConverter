using CurrencyConverter.Contracts.Requests;
using Swashbuckle.AspNetCore.Filters;

#pragma warning disable 1591
public class RatesRequestExample : IExamplesProvider<RatesRequest>
{
    public RatesRequest GetExamples()
    {
        return new RatesRequest()
        {
            BaseCurrency = "EUR",
            FromDate = new DateTime(2024, 2, 13)
        };
    }
}
