using CurrencyConverter.Core.Objects;

namespace CurrencyConverter.Core.Interfaces;

public interface ICurrencyRateClient
{
    Task<CurrencyRateClientResponse?> GetRates(DateTime? date);
}
