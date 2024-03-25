using CurrencyConverter.Core.Interfaces;
using CurrencyConverter.Infrastructure.Clients;
using Microsoft.Extensions.DependencyInjection;
using Polly;
using Polly.Extensions.Http;

namespace CurrencyConverter.Infrastructure;

public static class DependencyInjection
{
    public static void AddInfrastructure(this IServiceCollection services)
    {
        services.AddScoped<ICurrencyRateClient, OpenExchangeRatesClient>();

        services.AddHttpClient(HttpClientTypes.ExponentialBackoff)
            .AddPolicyHandler(GetRetryPolicy());
    }
    static IAsyncPolicy<HttpResponseMessage> GetRetryPolicy()
    {
        return HttpPolicyExtensions
            .HandleTransientHttpError()
            .WaitAndRetryAsync(3, retryAttempt =>
                TimeSpan.FromSeconds(Math.Pow(2, retryAttempt)));
    }
}
