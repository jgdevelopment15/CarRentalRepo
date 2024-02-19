using CarRental.Common.DTOs;

namespace CarRental.Business.Interfaces
{
    public interface IVehicleBusiness
    {
        Task<IEnumerable<VehicleDto>> GetVehiclesByLocation(int id);
    }
}
