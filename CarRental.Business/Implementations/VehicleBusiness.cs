using AutoMapper;
using CarRental.Business.Interfaces;
using CarRental.Common.DTOs;
using CarRental.Data;
using CarRental.Data.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace CarRental.Business.Implementations
{
    public class VehicleBusiness : IVehicleBusiness
    {
        private readonly IVehicleRepository _vehicleRepository;
        private readonly IMapper _mapper;

        public VehicleBusiness(IVehicleRepository vehicleRepository, IMapper mapper)
        {
            _vehicleRepository = vehicleRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<VehicleDto>> GetVehiclesByLocation(int id)
        {
            IQueryable<Vehicle> vehicles = _vehicleRepository.GetVehiclesByLocation(id);                        

            List<VehicleDto> vehiclesDto = new();

            foreach (var vehicle in await vehicles.ToListAsync())
            {                                  
                var vehicleDto = _mapper.Map<VehicleDto>(vehicle);
                vehiclesDto.Add(vehicleDto);
            }

            return vehiclesDto;
        }
    }
}
