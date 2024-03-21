using Microsoft.AspNetCore.Mvc;
using StairwayApi.Services.Contracts;
using StairwayApi.Services.Contracts.Models;

namespace StairwayApi.App.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class VehicleController(IVehicleService vehicleService, ILogger<VehicleController> logger) : ControllerBase
    {
        [HttpGet(Name = "GetVehicle")]
        public IEnumerable<Vehicle> Get()
        {
            return vehicleService.GetVehicles();
        }
    }
}
