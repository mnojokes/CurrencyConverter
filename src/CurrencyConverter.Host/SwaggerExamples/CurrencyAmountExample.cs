using CurrencyConverter.Contracts.Requests;
using Swashbuckle.AspNetCore.Filters;

#pragma warning disable 1591
public class CurrencyAmountExample : IExamplesProvider<CurrencyAmount>
{
    public CurrencyAmount GetExamples()
    {
        return new CurrencyAmount()
        {
            Amount = 350.42m,
            CurrencyFrom = "EUR",
            CurrencyTo = "USD",
            FromDate = new DateTime(2024, 2, 13)
        };
    }
}
