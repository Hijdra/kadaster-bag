using Hya.Kadaster.Bag.Options;
using Hya.Kadaster.Bag.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Hya.Kadaster.Bag;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddBagServices(this IServiceCollection services, Action<BagOptions> configureOptions)
    {
        var options = new BagOptions
        {
            IsLive = false,
            ApiKey = ""
        };
        configureOptions(options);

        services.AddHttpService<IAddressService, AddressService>(options);

        return services;
    }

    private static IServiceCollection AddHttpService<TClient, TImplementation>(this IServiceCollection services, BagOptions options)
        where TClient : class
        where TImplementation : class, TClient
    {
        services.AddTransient<TClient, TImplementation>();
        services.AddHttpClient<TClient, TImplementation>(client =>
        {
            var url = options.IsLive
                ? "https://api.bag.kadaster.nl/lvbag/individuelebevragingen/v2/"
                : "https://api.bag.acceptatie.kadaster.nl/lvbag/individuelebevragingen/v2/";

            client.BaseAddress = new Uri(url);
            client.DefaultRequestHeaders.Add("X-Api-Key", options.ApiKey);
        });

        return services;
    }
}