using CarRental.Data.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace CarRental.Data.Implementations
{
    public class VehicleRepository : IVehicleRepository
    {
        private readonly CarrentalContext _carrentalContext;

        public VehicleRepository(CarrentalContext carrentalContext)
        {
            _carrentalContext = carrentalContext;
        }

        public IQueryable<Vehicle> GetVehiclesByLocation(int id)
        {
            var vehicles = _carrentalContext.Vehicles
                .Include(x => x.Location)
                .Include(x => x.VehicleType)
                .Where(x => x.LocationId == id);

            return vehicles;
        }
    }
}
