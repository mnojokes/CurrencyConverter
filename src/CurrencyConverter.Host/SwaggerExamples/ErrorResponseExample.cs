using CurrencyConverter.Contracts.Responses;
using Swashbuckle.AspNetCore.Filters;

#pragma warning disable 1591
public class ErrorResponseExample : IExamplesProvider<ErrorResponse>
{
    public ErrorResponse GetExamples()
    {
        return new ErrorResponse()
        {
            Message = "Something terrible happened somewhere."
        };
    }
}
