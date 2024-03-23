using System.ComponentModel.DataAnnotations;

namespace CurrencyConverter.Contracts.Responses;

/// <summary>
/// Object representing an error response.
/// </summary>
public record ErrorResponse
{
    /// <summary>
    /// Error content will be stored here.
    /// </summary>
    [Required] public string Message { get; init; } = string.Empty;

#pragma warning disable 1591
    public ErrorResponse() { }
    public ErrorResponse(string message)
        => Message = message;
}
