namespace CurrencyConverter.Core.Objects;

public class CurrencyRatesDto
{
    public string Base { get; set; } = string.Empty;
    public Dictionary<string, decimal> Rates { get; set; } = new Dictionary<string, decimal>();
}
