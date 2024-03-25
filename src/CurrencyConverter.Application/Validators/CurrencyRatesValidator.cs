using CurrencyConverter.Contracts.Requests;
using FluentValidation;

namespace CurrencyConverter.Application.Validators;

internal class CurrencyRatesValidator : AbstractValidator<CurrencyRates>
{
    internal CurrencyRatesValidator()
    {
        RuleFor(request => request.BaseCurrency)
            .SetValidator(new CurrencyCodeValidator());

        RuleFor(request => request.FromDate)
            .SetValidator(new RateDateValidator());
    }
}
