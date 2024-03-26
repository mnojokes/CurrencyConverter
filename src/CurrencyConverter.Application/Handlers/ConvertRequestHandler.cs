using CurrencyConverter.Application.Interfaces;
using CurrencyConverter.Application.Queries;
using CurrencyConverter.Contracts.Responses;
using CurrencyConverter.Core.Objects;
using MediatR;

namespace CurrencyConverter.Application.Handlers;

public class ConvertRequestHandler : IRequestHandler<ConvertRequest, ConvertResponse>
{
    private readonly ICurrencyRateDownloadService _currencyRateDownloadService;

    public ConvertRequestHandler(ICurrencyRateDownloadService currencyRateDownloadService)
    {
        _currencyRateDownloadService = currencyRateDownloadService;
    }
    public async Task<ConvertResponse> Handle(ConvertRequest request, CancellationToken cancellationToken)
    {
        CurrencyRatesDto rates = await _currencyRateDownloadService.GetRates(request.Data.FromDate);

        throw new NotImplementedException();
    }
}
