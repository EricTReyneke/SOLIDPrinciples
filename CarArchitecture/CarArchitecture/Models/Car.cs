using CarArchitecture.Interfaces;
using NPOI.OpenXmlFormats.Wordprocessing;
using NPOI.SS.Formula.Functions;
using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace CarArchitecture.Models
{
    public class Car : Vehicle, ICar
    {
        //public decimal ZeroToSixty { get; set; }
        //public bool Turbocharger { get; set; }
        //public string BrandName { get; set; }
        //public string VehicleType { get; set; }

        public Car()
        {

        }

        public Car(string vehicleType, string brandName, decimal zeroToSixty, bool turbocharger) : base(vehicleType, brandName, zeroToSixty, turbocharger)
        {
            this.ZeroToSixty = zeroToSixty;
            this.Turbocharger = turbocharger;
            this.BrandName = brandName;
            this.VehicleType = vehicleType;
        }
    }
}