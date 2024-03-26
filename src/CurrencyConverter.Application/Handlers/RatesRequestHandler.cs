using CurrencyConverter.Application.Interfaces;
using CurrencyConverter.Application.Queries;
using CurrencyConverter.Contracts.Responses;
using CurrencyConverter.Core.Objects;
using MediatR;

namespace CurrencyConverter.Application.Handlers;

public class RatesRequestHandler : IRequestHandler<RatesRequest, RatesResponse>
{
    private readonly ICurrencyRateDownloadService _currencyRateDownloadService;

    public RatesRequestHandler(ICurrencyRateDownloadService currencyRateDownloadService)
    {
        _currencyRateDownloadService = currencyRateDownloadService;
    }

    public async Task<RatesResponse> Handle(RatesRequest request, CancellationToken cancellationToken)
    {
        CurrencyRatesDto rates = await _currencyRateDownloadService.GetRates(request.Data.FromDate);

        throw new NotImplementedException();
    }
}
