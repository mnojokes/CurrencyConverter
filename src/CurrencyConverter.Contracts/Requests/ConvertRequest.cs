using System.ComponentModel.DataAnnotations;

namespace CurrencyConverter.Contracts.Requests;

public record ConvertRequest
{
    [Required] public decimal Amount { get; init; } = default;
    [Required] public string CurrencyFrom { get; init; } = string.Empty;
    [Required] public string CurrencyTo { get; init; } = string.Empty;
    public DateTime? FromDate { get; init; } = null;

    public ConvertRequest() { }
    public ConvertRequest(decimal amount, string currencyFrom, string currencyTo, DateTime? fromDate = null)
        => (Amount, CurrencyFrom, CurrencyTo, FromDate) = (amount, currencyFrom, currencyTo, fromDate);
}
