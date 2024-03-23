using CurrencyConverter.Contracts.Responses;
using Swashbuckle.AspNetCore.Filters;

#pragma warning disable 1591
public class ConvertResponseExample : IExamplesProvider<ConvertResponse>
{
    public ConvertResponse GetExamples()
    {
        return new ConvertResponse()
        {
            InitialAmount = 350.42m,
            ConvertedAmount = 322.72m,
            CurrencyFrom = "USD",
            CurrencyTo = "EUR",
            RateDate = new DateTime(2024, 03, 23)
        };
    }
}
