using FluentValidation;

namespace CurrencyConverter.Application.Validators;

internal class RateDateValidator : AbstractValidator<DateTime?>
{
    private static DateTime _minDate = new DateTime(1999, 1, 1);

    internal RateDateValidator()
    {
        RuleFor(date => date)
            .GreaterThanOrEqualTo(_minDate).When(date => date != null).WithMessage($"Date cannot be before {_minDate:yyyy-MM-dd}.")
            .LessThanOrEqualTo(DateTime.UtcNow).When(date => date != null).WithMessage("Date cannot be in the future.");
    }
}
