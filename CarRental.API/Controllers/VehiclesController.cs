using CarRental.Business.Interfaces;
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
            var result = await _vehicleBusiness.GetVehiclesByLocation(id);

            return Ok(result);
        }

    }
}
