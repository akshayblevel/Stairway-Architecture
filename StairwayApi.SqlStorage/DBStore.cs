namespace StairwayApi.SqlStorage
{
    public class DBStore : IDBStore
    {
        private static readonly string[] Summaries = new[]
        {
            "BMW", "Audi", "Ferrari"
        };
        public IEnumerable<VehicleEntity> GetVehicles()
        {
            return Enumerable.Range(1, 5).Select(index => new VehicleEntity
            {
                Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
           .ToArray();
        }
    }
}
