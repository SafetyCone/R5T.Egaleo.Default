using System;

using Microsoft.Extensions.DependencyInjection;

using R5T.Dacia;


namespace R5T.Egaleo.Default
{
    public static class IServiceCollectionExtensions
    {
        /// <summary>
        /// Adds the <see cref="OrganizationDirectoryNameConvention"/> implementation of <see cref="IOrganizationDirectoryNameConvention"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceCollection AddDefaultOrganizationDirectoryNameConvention(this IServiceCollection services)
        {
            services.AddSingleton<IOrganizationDirectoryNameConvention, OrganizationDirectoryNameConvention>();

            return services;
        }

        /// <summary>
        /// Adds the <see cref="OrganizationDirectoryNameConvention"/> implementation of <see cref="IOrganizationDirectoryNameConvention"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static ServiceAction<IOrganizationDirectoryNameConvention> AddDefaultOrganizationDirectoryNameConventionAction(this IServiceCollection services)
        {
            var serviceAction = new ServiceAction<IOrganizationDirectoryNameConvention>(() => services.AddDefaultOrganizationDirectoryNameConvention());
            return serviceAction;
        }
    }
}
