namespace CurrencyConverter.Core.Exceptions;

public class CurrencyRatesNotFoundException : Exception
{
    public CurrencyRatesNotFoundException(string message) : base(message) { }
}
