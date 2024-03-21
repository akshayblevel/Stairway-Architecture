namespace StairwayApi.SqlStorage
{
    public interface IDBStore
    {
        IEnumerable<VehicleEntity> GetVehicles();
    }
}
