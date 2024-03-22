using System.ComponentModel.DataAnnotations;

namespace CurrencyConverter.Contracts.Requests;

public record RatesRequest
{
    [Required] public string BaseCurrency { get; init; } = string.Empty;
    public DateTime? FromDate { get; init; } = null;

    public RatesRequest() { }
    public RatesRequest(string baseCurrency, DateTime? fromDate = null)
        => (BaseCurrency, FromDate) = (baseCurrency, fromDate);
}
