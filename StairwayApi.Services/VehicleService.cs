using StairwayApi.Domains.Contracts;
using StairwayApi.Services.Contracts;
using StairwayApi.Services.Contracts.Models;

namespace StairwayApi.Services
{
    public class VehicleService(IVehicleRepository vehicleRepository) : IVehicleService
    {
        public IEnumerable<Vehicle> GetVehicles()
        {
            var vehicles = vehicleRepository.GetVehicles();
            return vehicles.Select(x => new Vehicle { Date = x.Date, Summary = x.Summary });
        }
    }
}
