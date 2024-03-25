using CurrencyConverter.Application.Services;
using Microsoft.Extensions.DependencyInjection;
public static class DependencyInjection
{
    public static void AddApplication(this IServiceCollection services)
    {
        services.AddScoped<ValidationService>();
    }
}
