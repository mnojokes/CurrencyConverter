using System.ComponentModel.DataAnnotations;

namespace CurrencyConverter.Contracts.Responses;

/// <summary>
/// Object representing a rates response.
/// </summary>
public record RatesResponse
{
    /// <summary>
    /// Base currency used for displaying rates.
    /// </summary>
    [Required] public string BaseCurrency { get; init; } = string.Empty;

    /// <summary>
    /// Date of conversion rates.
    /// </summary>
    [Required] public DateTime RateDate { get; init; } = default;

    /// <summary>
    /// Dictionary with string and decimal pairs, containing all converted rates.
    /// </summary>
    [Required] public Dictionary<string, decimal> Rates { get; init; }

#pragma warning disable 1591
    public RatesResponse() { Rates = new Dictionary<string, decimal>(); }
    public RatesResponse(string baseCurrency, DateTime rateDate, Dictionary<string, decimal> rates)
        => (BaseCurrency, RateDate, Rates) = (baseCurrency, rateDate, rates);
}
