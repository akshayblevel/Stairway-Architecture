using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StairwayApi.Domains.Contracts
{
    public class VehicleDto
    {
        public DateOnly Date { get; set; }

        public string? Summary { get; set; }
    }
}
