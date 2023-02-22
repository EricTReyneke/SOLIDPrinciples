using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarArchitecture.Interfaces
{
    public interface IVehicle : IGetInformation
    {
        public string BrandName { get; set; }

        public string VehicleType { get; set; }
    }
}
