using CurrencyConverter.Application.Queries;
using CurrencyConverter.Contracts.Responses;
using MediatR;

namespace CurrencyConverter.Application.Handlers;

public class RatesRequestHandler : IRequestHandler<RatesRequest, RatesResponse>
{
    public Task<RatesResponse> Handle(RatesRequest request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
