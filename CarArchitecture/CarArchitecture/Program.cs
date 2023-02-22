using CarArchitecture.Interfaces;
using CarArchitecture.Models;

namespace CarArchitecture
{
    class Program
    {
        public static void Main()
        {
            ILogger log = new Logger();

            Vehicle newVehicle;
            try
            {
                newVehicle = new CarCreator<Car>().CreateCar().DisplayVehicleDetails();

                newVehicle.CheckIfVehicleExists(newVehicle);

                newVehicle.ZeroToOneTwenty(newVehicle, newVehicle.ZeroToSixty);
            }
            catch (Exception ex)
            {
                log.LogFatal(ex);
            }

            Console.ReadKey();
        }
    }
}