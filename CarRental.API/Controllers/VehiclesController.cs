using CarRental.Business.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CarRental.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VehiclesController : ControllerBase
    {
        private readonly IVehicleBusiness _vehicleBusiness;

        public VehiclesController(IVehicleBusiness vehicleBusiness)
        {
            _vehicleBusiness = vehicleBusiness;
        }

        [HttpGet("ByLocation/{id}")]
        public async Task<IActionResult> GetVehiclesByLocation(int id)
        {
           var result = _vehicleBusiness.GetVehiclesByLocation(id);

            return Ok(result);
        }

    }
}
