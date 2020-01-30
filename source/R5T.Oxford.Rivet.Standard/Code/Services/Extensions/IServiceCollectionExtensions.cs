using System;

using Microsoft.Extensions.DependencyInjection;

using R5T.Dacia;


namespace R5T.Oxford.Rivet.Standard
{
    public static class IServiceCollectionExtensions
    {
        /// <summary>
        /// Adds the Rivet-based <see cref="IOrganizationProvider"/> service.
        /// </summary>
        public static IServiceCollection AddRivetOrganizationProvider(this IServiceCollection services)
        {
            services.AddDefaultRivetOrganizationProvider();

            return services;
        }

        /// <summary>
        /// Adds the Rivet-based <see cref="IOrganizationProvider"/> service.
        /// </summary>
        public static ServiceAction<IOrganizationProvider> AddRivetOrganizationProviderAction(this IServiceCollection services)
        {
            var serviceAction = new ServiceAction<IOrganizationProvider>(() => services.AddRivetOrganizationProvider());
            return serviceAction;
        }
    }
}
