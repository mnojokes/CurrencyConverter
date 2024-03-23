using System.ComponentModel.DataAnnotations;

namespace CurrencyConverter.Contracts.Responses;

/// <summary>
/// Successful currency conversion response.
/// </summary>
public record ConvertResponse
{
    /// <summary>
    /// Initial amount in source currency.
    /// </summary>
    [Required] public decimal InitialAmount { get; init; } = default;

    /// <summary>
    /// Converted amount in requested currency.
    /// </summary>
    [Required] public decimal ConvertedAmount { get; init; } = default;

    /// <summary>
    /// Source currency.
    /// </summary>
    [Required] public string CurrencyFrom { get; init; } = string.Empty;

    /// <summary>
    /// Converted currency.
    /// </summary>
    [Required] public string CurrencyTo { get; init; } = string.Empty;

    /// <summary>
    /// Date of conversion rate used.
    /// </summary>
    [Required] public DateTime RateDate { get; init; } = default;

#pragma warning disable 1591
    public ConvertResponse() { }
    public ConvertResponse(decimal initialAmount, decimal convertedAmount, string currencyFrom, string currencyTo, DateTime rateDate)
        => (InitialAmount, ConvertedAmount, CurrencyFrom, CurrencyTo, RateDate) = (initialAmount, convertedAmount, currencyFrom, currencyTo, rateDate);
}
