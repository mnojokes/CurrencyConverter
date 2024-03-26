using CurrencyConverter.Application.Interfaces;
using CurrencyConverter.Core.Exceptions;
using CurrencyConverter.Core.Interfaces;
using CurrencyConverter.Core.Objects;

namespace CurrencyConverter.Application.Services;

public class CurrencyRateDownloadService : ICurrencyRateDownloadService
{
    private readonly ICurrencyRateClient _currencyRateClient;

    public CurrencyRateDownloadService(ICurrencyRateClient currencyRateClient)
    {
        _currencyRateClient = currencyRateClient;
    }

    public async Task<CurrencyRatesDto> GetRates(DateTime? date)
    {
        if (date is null)
        {
            date = DateTime.UtcNow;
        }

        CurrencyRateClientResponse? rates = await _currencyRateClient.GetRates(date);
        if (rates is null || !rates.IsValid)
        {
            throw new CurrencyRatesNotFoundException($"Rates for {date:yyyy-MM-dd} not found.");
        }

        return new CurrencyRatesDto()
        {
            Base = rates.Base!,
            Rates = rates.Rates!
        };
    }
}
