using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Data.Interfaces
{
    public interface IVehicleRepository
    {
        IQueryable<Vehicle> GetVehiclesByLocation(int id); 
    }
}
