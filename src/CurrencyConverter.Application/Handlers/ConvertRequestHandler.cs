using CurrencyConverter.Application.Queries;
using CurrencyConverter.Contracts.Responses;
using MediatR;

namespace CurrencyConverter.Application.Handlers;

public class ConvertRequestHandler : IRequestHandler<ConvertRequest, ConvertResponse>
{
    public Task<ConvertResponse> Handle(ConvertRequest request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
