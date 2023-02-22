using CarArchitecture.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarArchitecture.Interfaces
{
    public interface ICar
    {
        public decimal ZeroToSixty { get; set; }

        public bool Turbocharger { get; set; }
    }
}