namespace CurrencyConverter.Core.Interfaces;

public interface ICurrencyRateClient
{
    Task<Dictionary<string, decimal>> GetRates(DateTime? date);
}
