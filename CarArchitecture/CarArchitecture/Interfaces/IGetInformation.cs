using CarArchitecture.Models;
using NPOI.SS.Formula.Functions;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarArchitecture.Interfaces
{
    public interface IGetInformation
    {
        public ArrayList GetVehicleDetails();

        public Vehicle DisplayVehicleDetails();
    }
}
