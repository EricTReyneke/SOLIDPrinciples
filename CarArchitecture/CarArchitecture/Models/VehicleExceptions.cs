using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarArchitecture.Models
{
    public class VehicleExceptions : Exception
    {
        public int Severity { get; set; }
        public VehicleExceptions(string message) : base(message)
        {

        }
    }
}