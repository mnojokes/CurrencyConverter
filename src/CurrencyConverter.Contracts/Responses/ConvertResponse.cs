namespace CurrencyConverter.Contracts.Responses;

public record ConvertResponse
{
    public decimal InitialAmount { get; init; } = default;
    public decimal ConvertedAmount { get; init; } = default;
    public string CurrencyFrom { get; init; } = string.Empty;
    public string CurrencyTo { get; init; } = string.Empty;
    public DateTime RateDate { get; init; } = default;

    public ConvertResponse() { }
    public ConvertResponse(decimal initialAmount, decimal convertedAmount, string currencyFrom, string currencyTo, DateTime rateDate)
        => (InitialAmount, ConvertedAmount, CurrencyFrom, CurrencyTo, RateDate) = (initialAmount, convertedAmount, currencyFrom, currencyTo, rateDate);
}
