using CarRental.Business.Interfaces;
using CarRental.Common.DTOs;
using CarRental.Data;
using CarRental.Data.Implementations;
using CarRental.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Business.Implementations
{
    public class VehicleBusiness : IVehicleBusiness
    {
        private readonly IVehicleRepository vehicleRepository;

        public VehicleBusiness(IVehicleRepository vehicleRepository)
        {
            this.vehicleRepository = vehicleRepository;
        }

        public IEnumerable<VehicleDto> GetVehiclesByLocation(int id)
        {
            IQueryable<Vehicle> vehicles = vehicleRepository.GetVehiclesByLocation(id);

            List<VehicleDto> vehiclesDto = new();

            foreach (var vehicle in vehicles)
            {
                var vehicleDto = new VehicleDto()
                {
                    Id = vehicle.Id,
                    VehicleType = vehicle.VehicleType.Name,
                    Make = vehicle.Make,
                    Model = vehicle.Model,
                    Year = vehicle.Year,
                    Color = vehicle.Color,
                    PricePerDay = vehicle.PricePerDay,
                    Location = string.Concat(vehicle.Location.Name, ", ", vehicle.Location.City, ", ", vehicle.Location.State, ", ", vehicle.Location.Country)
                };

                vehiclesDto.Add(vehicleDto);
            }

            return vehiclesDto;
        }
    }
}
