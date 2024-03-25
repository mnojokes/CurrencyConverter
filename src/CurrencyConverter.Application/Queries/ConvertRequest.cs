using CurrencyConverter.Contracts.Requests;
using CurrencyConverter.Contracts.Responses;
using MediatR;

namespace CurrencyConverter.Application.Queries;

public record ConvertRequest : IRequest<ConvertResponse>
{
    public CurrencyAmount Data { get; init; }

    public ConvertRequest(CurrencyAmount data)
        => Data = data;
}
