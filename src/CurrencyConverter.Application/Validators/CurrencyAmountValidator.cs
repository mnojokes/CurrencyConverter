﻿using CurrencyConverter.Contracts.Requests;
using FluentValidation;

namespace CurrencyConverter.Application.Validators;

internal class CurrencyAmountValidator : AbstractValidator<CurrencyAmount>
{
    public CurrencyAmountValidator()
    {
        RuleFor(request => request.Amount)
            .GreaterThan(0m);

        RuleFor(request => request.CurrencyFrom)
            .SetValidator(new CurrencyCodeValidator("CurrencyFrom"));

        RuleFor(request => request.CurrencyTo)
            .SetValidator(new CurrencyCodeValidator("CurrencyTo"));

        RuleFor(request => request.FromDate)
            .SetValidator(new RateDateValidator());
    }
}
