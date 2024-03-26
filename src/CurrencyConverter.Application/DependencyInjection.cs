using CurrencyConverter.Application.Handlers;
using CurrencyConverter.Application.Interfaces;
using CurrencyConverter.Application.Services;
using Microsoft.Extensions.DependencyInjection;

namespace CurrencyConverter.Application;

public static class DependencyInjection
{
    public static void AddApplication(this IServiceCollection services)
    {
        services.AddScoped<ValidationService>();
        services.AddScoped<ICurrencyRateDownloadService, CurrencyRateDownloadService>();
        services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(typeof(ConvertRequestHandler).Assembly));
    }
}
