using CurrencyConverter.Core.Interfaces;
using CurrencyConverter.Core.Objects;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System.Net;

namespace CurrencyConverter.Infrastructure.Clients;

public class OpenExchangeRatesClient : ICurrencyRateClient
{
    private readonly IHttpClientFactory _httpClientFactory;
    private const string _ratesApiBaseUrl = "https://openexchangerates.org/api/historical";

    private const string _apiKeyConfigSection = "CurrencyRatesAPIKey";
    private readonly string _apiKey;

    public OpenExchangeRatesClient(IHttpClientFactory httpClientFactory, IConfiguration configuration)
    {
        _httpClientFactory = httpClientFactory;
        _apiKey = configuration.GetValue<string>(_apiKeyConfigSection)
            ?? throw new ArgumentNullException(_apiKeyConfigSection);
    }

    public async Task<CurrencyRateClientResponse?> GetRates(DateTime? date)
    {
        if (date is null)
        {
            date = DateTime.UtcNow;
        }

        HttpClient client = _httpClientFactory.CreateClient(HttpClientTypes.ExponentialBackoff);
        string url = $"{_ratesApiBaseUrl}/{date:yyyy-MM-dd}.json?app_id={_apiKey}";

        CurrencyRateClientResponse? rateData = null;
        try
        {
            var response = await client.GetAsync(url);
            switch (response.IsSuccessStatusCode)
            {
                case true:
                    rateData = JsonConvert.DeserializeObject<CurrencyRateClientResponse>(await response.Content.ReadAsStringAsync());
                    break;
                case false when response.StatusCode == HttpStatusCode.BadRequest:
                    break;
                case false:
                    response.EnsureSuccessStatusCode();
                    break;
            }
        }
        catch (Exception ex)
        {
            throw new Exception($"Error downloading rates: {ex.Message}");
        }

        return rateData;
    }
}
