using System.ComponentModel.DataAnnotations;

namespace CurrencyConverter.Contracts.Requests;

/// <summary>
/// Object representing currency conversion request.
/// </summary>
public record ConvertRequest
{
    /// <summary>
    /// Source currency amount to convert.
    /// </summary>
    [Required] public decimal Amount { get; init; } = default;

    /// <summary>
    /// Source currency.
    /// </summary>
    [Required] public string CurrencyFrom { get; init; } = string.Empty;

    /// <summary>
    /// Currency to convert to.
    /// </summary>
    [Required] public string CurrencyTo { get; init; } = string.Empty;

    /// <summary>
    /// Optional: convert using a historical rate.
    /// </summary>
    public DateTime? FromDate { get; init; } = null;

#pragma warning disable 1591
    public ConvertRequest() { }
    public ConvertRequest(decimal amount, string currencyFrom, string currencyTo, DateTime? fromDate = null)
        => (Amount, CurrencyFrom, CurrencyTo, FromDate) = (amount, currencyFrom, currencyTo, fromDate);
}
