using CurrencyConverter.Core.Objects;

namespace CurrencyConverter.Application.Interfaces;

public interface ICurrencyRateDownloadService
{
    Task<CurrencyRatesDto> GetRates(DateTime? date);
}
