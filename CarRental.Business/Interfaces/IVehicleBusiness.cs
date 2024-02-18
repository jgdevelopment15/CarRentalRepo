using CarRental.Common.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Business.Interfaces
{
    public interface IVehicleBusiness
    {
        IEnumerable<VehicleDto> GetVehiclesByLocation(int id);
    }
}
