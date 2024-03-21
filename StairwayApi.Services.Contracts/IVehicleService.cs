using StairwayApi.Services.Contracts.Models;

namespace StairwayApi.Services.Contracts
{
    public interface IVehicleService
    {
        IEnumerable<Vehicle> GetVehicles();
    }
}
