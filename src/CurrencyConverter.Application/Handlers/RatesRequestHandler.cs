using CurrencyConverter.Application.Queries;
using CurrencyConverter.Contracts.Responses;
using CurrencyConverter.Core.Interfaces;
using MediatR;

namespace CurrencyConverter.Application.Handlers;

public class RatesRequestHandler : IRequestHandler<RatesRequest, RatesResponse>
{
    private readonly ICurrencyRateClient _currencyRateClient;

    public RatesRequestHandler(ICurrencyRateClient currencyRateClient)
    {
        _currencyRateClient = currencyRateClient;
    }

    public Task<RatesResponse> Handle(RatesRequest request, CancellationToken cancellationToken)
    {
        var rates = _currencyRateClient.GetRates(request.Data.FromDate);

        throw new NotImplementedException();
    }
}
