using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using CarArchitecture.Interfaces;
using CarArchitecture.Models;

namespace CarArchitecture.Models
{
    public static class CarExtension
    {
        public static void CheckIfVehicleExists(this IGetInformation information, IVehicle tempCar)
        {
            Type tempCarName = tempCar.GetType();
            try
            {
                if (tempCar == null)
                    throw new ArgumentNullException("There was an error instantiating car");
                else
                    Console.WriteLine($"\nYour {tempCarName.Name} has been instantiated");
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine(ex);
            }
        }

        public static void ZeroToOneTwenty(this IVehicle vehicle, IVehicle tempCar, decimal zeroToSixsty)
        {
            try
            {
                Console.WriteLine($"\nYour {tempCar.BrandName} reaches 120mph in: {zeroToSixsty * 2}");
            }
            catch(Exception ex)
            {
                throw new VehicleExceptions("There was an error trying to display the Zero To One Twenty Time.");
            }
        }
    }
}
