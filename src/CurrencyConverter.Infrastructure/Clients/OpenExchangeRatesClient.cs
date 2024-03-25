using CurrencyConverter.Core.Interfaces;

namespace CurrencyConverter.Infrastructure.Clients;

public class OpenExchangeRatesClient : ICurrencyRateClient
{
    private readonly IHttpClientFactory _httpClientFactory;

    public OpenExchangeRatesClient(IHttpClientFactory httpClientFactory)
    {
        _httpClientFactory = httpClientFactory;
    }

    public async Task<Dictionary<string, decimal>> GetRates(DateTime? date)
    {
        return await GetRatesInternal(date ?? DateTime.UtcNow);
    }

    private async Task<Dictionary<string, decimal>> GetRatesInternal(DateTime date)
    {
        HttpClient client = _httpClientFactory.CreateClient(HttpClientTypes.ExponentialBackoff);

        throw new NotImplementedException();
    }
}
