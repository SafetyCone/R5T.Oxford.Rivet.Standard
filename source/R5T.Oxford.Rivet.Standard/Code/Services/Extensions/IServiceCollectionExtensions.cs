using System;

using Microsoft.Extensions.DependencyInjection;


namespace R5T.Oxford.Rivet.Standard
{
    public static class IServiceCollectionExtensions
    {
        public static IServiceCollection AddRivetOrganizationProvider(this IServiceCollection services)
        {
            services.AddSingleton<IOrganizationProvider, RivetOrganizationProvider>();

            return services;
        }
    }
}
