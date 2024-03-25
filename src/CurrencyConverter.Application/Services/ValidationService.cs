using CurrencyConverter.Application.Validators;
using CurrencyConverter.Contracts.Requests;
using CurrencyConverter.Core.Exceptions;
using FluentValidation.Results;
using System.Text;

namespace CurrencyConverter.Application.Services;
public class ValidationService
{
    private readonly CurrencyAmountValidator _currencyAmountValidator;
    private readonly CurrencyRatesValidator _currencyRatesValidator;

    public ValidationService()
    {
        _currencyAmountValidator = new CurrencyAmountValidator();
        _currencyRatesValidator = new CurrencyRatesValidator();
    }
    public void Validate(CurrencyAmount request)
    {
        ValidationResult result = _currencyAmountValidator.Validate(request);
        HandleValidationResult(result);
    }

    public void Validate(CurrencyRates request)
    {
        ValidationResult result = _currencyRatesValidator.Validate(request);
        HandleValidationResult(result);
    }

    private void HandleValidationResult(ValidationResult result)
    {
        if (!result.IsValid)
        {
            throw new DataValidationException(GetErrorMessages(result));
        }
    }

    private string GetErrorMessages(ValidationResult result)
    {
        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < result.Errors.Count; ++i)
        {
            sb.Append(result.Errors[i].ErrorMessage);
            if (i < result.Errors.Count - 1)
            {
                sb.Append(' ');
            }
        }

        return sb.ToString();
    }
}
