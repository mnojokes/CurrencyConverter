using CurrencyConverter.Contracts.Requests;
using CurrencyConverter.Contracts.Responses;
using MediatR;

namespace CurrencyConverter.Application.Queries;

public record RatesRequest : IRequest<RatesResponse>
{
    public CurrencyRates Data { get; init; }

    public RatesRequest(CurrencyRates data)
        => Data = data;
}
