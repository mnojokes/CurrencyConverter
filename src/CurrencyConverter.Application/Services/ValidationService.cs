using CurrencyConverter.Application.Validators;
using CurrencyConverter.Contracts.Requests;
using CurrencyConverter.Core.Exceptions;
using FluentValidation.Results;
using System.Text;

namespace CurrencyConverter.Application.Services;
public class ValidationService
{
    private readonly ConvertRequestValidator _convertRequestValidator;
    private readonly RatesRequestValidator _ratesRequestValidator;

    public ValidationService()
    {
        _convertRequestValidator = new ConvertRequestValidator();
        _ratesRequestValidator = new RatesRequestValidator();
    }
    public void Validate(ConvertRequest request)
    {
        ValidationResult result = _convertRequestValidator.Validate(request);
        HandleValidationResult(result);
    }

    public void Validate(RatesRequest request)
    {
        ValidationResult result = _ratesRequestValidator.Validate(request);
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
