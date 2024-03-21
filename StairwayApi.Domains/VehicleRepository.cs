using StairwayApi.Domains.Contracts;
using StairwayApi.SqlStorage;

namespace StairwayApi.Domains
{
    public class VehicleRepository(IDBStore dBStore) : IVehicleRepository
    {
        public IEnumerable<VehicleDto> GetVehicles()
        {
            var vehicles =  dBStore.GetVehicles();
            return vehicles.Select(x => new VehicleDto { Date = x.Date, Summary = x.Summary }); 
        }
    }
}
