﻿using System.ComponentModel.DataAnnotations;

namespace CurrencyConverter.Contracts.Requests;

/// <summary>
/// Object representing the rates request.
/// </summary>
public record RatesRequest
{
    /// <summary>
    /// Currency to use as a base.
    /// </summary>
    [Required] public string BaseCurrency { get; init; } = string.Empty;

    /// <summary>
    /// Optional: retrieve rates from a specified date.
    /// </summary>
    public DateTime? FromDate { get; init; } = null;

#pragma warning disable 1591
    public RatesRequest() { }
    public RatesRequest(string baseCurrency, DateTime? fromDate = null)
        => (BaseCurrency, FromDate) = (baseCurrency, fromDate);
}
