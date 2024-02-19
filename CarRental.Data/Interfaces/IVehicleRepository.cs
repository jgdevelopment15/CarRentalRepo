namespace CarRental.Data.Interfaces
{
    public interface IVehicleRepository
    {
        IQueryable<Vehicle> GetVehiclesByLocation(int id); 
    }
}
