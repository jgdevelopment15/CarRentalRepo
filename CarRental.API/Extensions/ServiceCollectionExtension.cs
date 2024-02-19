using CarRental.Business.Implementations;
using CarRental.Business.Interfaces;
using CarRental.Data.Implementations;
using CarRental.Data.Interfaces;
using System.Runtime.CompilerServices;

namespace CarRental.API.Extensions
{
    public static class ServiceCollectionExtension
    {
        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddTransient<IVehicleRepository, VehicleRepository>();
            services.AddTransient<IVehicleBusiness, VehicleBusiness>();

            return services;

        }
    }
}
