using CurrencyConverter.Contracts.Requests;
using FluentValidation;

namespace CurrencyConverter.Application.Validators;

internal class RatesRequestValidator : AbstractValidator<RatesRequest>
{
    internal RatesRequestValidator()
    {
        RuleFor(request => request.BaseCurrency)
            .SetValidator(new CurrencyCodeValidator());

        RuleFor(request => request.FromDate)
            .SetValidator(new RateDateValidator());
    }
}
