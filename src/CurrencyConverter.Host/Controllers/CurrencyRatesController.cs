using CurrencyConverter.Application.Services;
using CurrencyConverter.Contracts.Requests;
using CurrencyConverter.Contracts.Responses;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Filters;

#pragma warning disable 1591

namespace CurrencyConverter.Host.Controllers;

[ApiController]
public class CurrencyRatesController : Controller
{
    private readonly ValidationService _validationService;
    public CurrencyRatesController(ValidationService validationService)
    {
        _validationService = validationService;
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
    /// <param name="convert">Conversion request.</param>
    /// <returns>Conversion result.</returns>
    /// <response code="200">Successfully converted.</response>
    /// <response code="400">Bad request, problem with entered data.</response>
    /// <response code="500">Server error.</response>
    [HttpGet("rates/convert")]
    [Produces("application/json")]
    [ProducesResponseType(typeof(ConvertResponse), 200)]
    [SwaggerResponseExample(200, typeof(ConvertResponseExample))]
    [ProducesResponseType(typeof(ErrorResponse), 400)]
    [SwaggerResponseExample(400, typeof(ErrorResponseExample))]
    [ProducesResponseType(typeof(ErrorResponse), 500)]
    [SwaggerResponseExample(500, typeof(ErrorResponseExample))]
    public async Task<IActionResult> Convert([FromQuery] ConvertRequest convert)
    {
        _validationService.Validate(convert);

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
    /// <param name="rates">Rates request.</param>
    /// <returns>Dictionary containing conversion rates relative to base currency.</returns>
    /// <response code="200">Successfully retrieved.</response>
    /// <response code="400">Bad request, problem with entered data.</response>
    /// <response code="500">Server error.</response>
    [HttpGet("rates")]
    [Produces("application/json")]
    [ProducesResponseType(typeof(RatesResponse), 200)]
    [SwaggerResponseExample(200, typeof(RatesResponseExample))]
    [ProducesResponseType(typeof(ErrorResponse), 400)]
    [SwaggerResponseExample(400, typeof(ErrorResponseExample))]
    [ProducesResponseType(typeof(ErrorResponse), 500)]
    [SwaggerResponseExample(500, typeof(ErrorResponseExample))]
    public async Task<IActionResult> Get([FromQuery] RatesRequest rates)
    {
        _validationService.Validate(rates);

        throw new NotImplementedException();
    }
}
