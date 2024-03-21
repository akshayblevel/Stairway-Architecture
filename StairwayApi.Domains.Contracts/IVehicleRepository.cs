namespace StairwayApi.Domains.Contracts
{
    public interface IVehicleRepository
    {
        IEnumerable<VehicleDto> GetVehicles();
    }
}
