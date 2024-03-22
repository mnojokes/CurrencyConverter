using CurrencyConverter.Application.Services;
using CurrencyConverter.Contracts.Requests;
using Microsoft.AspNetCore.Mvc;

#pragma warning disable 1591

namespace CurrencyConverter.Host.Controllers;

[ApiController]
public class CurrencyRatesController : Controller
{
    private readonly CurrencyRateService _currencyRateService;
    public CurrencyRatesController(CurrencyRateService currencyRateService)
    {
        _currencyRateService = currencyRateService;
    }

#pragma warning restore 1591
    /// <summary>
    /// Convert amount using current or historical currency rate.
    /// </summary>
    /// <remarks>
    /// Usage:<br />
    /// * 'FromDate' is empty: will use the most current available rate for conversion;<br />
    /// * 'FromDate' not empty: will try to do the conversion using the rate from that date.
    /// </remarks>
    /// <response code="200">Successfully converted.</response>
    /// <response code="400">Bad request, problem with entered data.</response>
    /// <response code="500">Server error.</response>
    [HttpGet("rates/convert")]
    [Produces("application/json")]
    public async Task<IActionResult> Convert([FromQuery] ConvertRequest convert)
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// Get all current or historical currency rates.
    /// </summary>
    /// <remarks>
    /// Usage:<br />
    /// * 'FromDate' is empty: returns the most current rates;<br />
    /// * 'FromDate' not empty: tries to get rates for that date.
    /// </remarks>
    /// <response code="200">Successfully retrieved.</response>
    /// <response code="400">Bad request, problem with entered data.</response>
    /// <response code="500">Server error.</response>
    [HttpGet("rates")]
    [Produces("application/json")]
    public async Task<IActionResult> Get([FromQuery] RatesRequest rates)
    {
        throw new NotImplementedException();
    }
}
