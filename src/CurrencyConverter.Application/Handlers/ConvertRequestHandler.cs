using CurrencyConverter.Application.Queries;
using CurrencyConverter.Contracts.Responses;
using CurrencyConverter.Core.Interfaces;
using MediatR;

namespace CurrencyConverter.Application.Handlers;

public class ConvertRequestHandler : IRequestHandler<ConvertRequest, ConvertResponse>
{
    private readonly ICurrencyRateClient _currencyRateClient;

    public ConvertRequestHandler(ICurrencyRateClient currencyRateClient)
    {
        _currencyRateClient = currencyRateClient;
    }
    public async Task<ConvertResponse> Handle(ConvertRequest request, CancellationToken cancellationToken)
    {
        var rates = _currencyRateClient.GetRates(request.Data.FromDate);

        throw new NotImplementedException();
    }
}
