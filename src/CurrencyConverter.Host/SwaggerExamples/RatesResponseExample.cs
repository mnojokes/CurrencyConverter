using CurrencyConverter.Contracts.Responses;
using Swashbuckle.AspNetCore.Filters;

#pragma warning disable 1591
public class RatesResponseExample : IExamplesProvider<RatesResponse>
{
    public RatesResponse GetExamples()
    {
        return new RatesResponse()
        {
            BaseCurrency = "USD",
            RateDate = new DateTime(2024, 3, 23),
            Rates = new Dictionary<string, decimal>
            {
                { "AED", 3.6729m },
                { "AUD", 1.5347m },
                { "BTC", 0.000015583401m },
                { "CHF", 0.897945m },
                { "DOGE", 6.22606855m },
                { "EUR", 0.92095m },
                { "GBP", 0.793588m }
            }
        };
    }
}
