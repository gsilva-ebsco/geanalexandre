using GeanAlexandre.Context.CrossCutting.IoC;
using GeanAlexandre.Context.Settings;
using Microsoft.Extensions.DependencyInjection;

namespace GeanAlexandre.Context.CrossCutting
{
    public static class CrossCuttingApi
    {
        public static void ResolveDependencies(this IServiceCollection serviceCollection,
            IMongoSettings mongoSettings)
        {
            new DependencyInject(serviceCollection).Resolve(mongoSettings);
        }
    }
}