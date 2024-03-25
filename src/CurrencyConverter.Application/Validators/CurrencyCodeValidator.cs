using FluentValidation;

namespace CurrencyConverter.Application.Validators;

internal class CurrencyCodeValidator : AbstractValidator<string>
{
    internal CurrencyCodeValidator(string? propertyName = null)
    {
        string prefix = propertyName is not null ? propertyName + ": " : string.Empty;
        RuleFor(code => code)
            .NotEmpty().WithMessage($"{prefix}Currency code cannot be empty.")
            .Matches("^[a-zA-Z]+$").WithMessage($"{prefix}Currency code can only contain letters.");
    }
}
