using CurrencyConverter.Contracts.Requests;
using Swashbuckle.AspNetCore.Filters;

#pragma warning disable 1591
public class CurrencyRatesExample : IExamplesProvider<CurrencyRates>
{
    public CurrencyRates GetExamples()
    {
        return new CurrencyRates()
        {
            BaseCurrency = "EUR",
            FromDate = new DateTime(2024, 2, 13)
        };
    }
}
