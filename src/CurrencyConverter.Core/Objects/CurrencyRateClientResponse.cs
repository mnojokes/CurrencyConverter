namespace CurrencyConverter.Core.Objects;

public class CurrencyRateClientResponse
{
    public string? Base { get; set; } = null;
    public Dictionary<string, decimal>? Rates { get; set; } = null;

    public bool IsValid
    {
        get { return Base is not null && Rates is not null; }
    }
}
