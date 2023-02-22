using CarArchitecture.Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CarArchitecture.Models
{
    public class Vehicle : IVehicle
    {
        [Description("Brand Name")]
        public string BrandName { get; set; }
        public string VehicleType { get; set; }
        public decimal ZeroToSixty { get; set; }
        public bool Turbocharger { get; set; }

        public Vehicle(string vehicleType, string brandName, decimal zeroToSixty, bool turbocharger)
        {
            this.ZeroToSixty = zeroToSixty;
            this.Turbocharger = turbocharger;
            this.BrandName = brandName;
            this.VehicleType = vehicleType;
        }

        public Vehicle()
        {

        }

        public ArrayList GetVehicleDetails()
        {
            ArrayList vehicleDetails = new ArrayList();

            string vehicleType;
            while(true)
            {
                Console.Write("Please enter What type of Vehicle you want to register: ");
                vehicleType = Console.ReadLine();

                if (Regex.IsMatch(vehicleType, @"^[a-zA-Z]+$"))
                    break;
                else
                    Console.WriteLine("\nPlease enter a valid Vehicle name.\n");
            }

            vehicleDetails.Add(vehicleType);

            string brandName;
            while (true)
            {
                Console.Write("\nPlease enter the brand of the Vehicle you want to register: ");
                brandName = Console.ReadLine();

                if (Regex.IsMatch(brandName, @"^[a-zA-Z]+$"))
                    break;
                else
                    Console.WriteLine("\nPlease enter a valid Vehicle brand name.");
            }

            vehicleDetails.Add(brandName);

            string zeroToSixty;
            decimal checkDecimal = 0m;
            while (true)
            {
                try
                {
                    Console.Write("\nPlease enter the zero to sixty time (In seconds) for your car: ");
                    zeroToSixty = Console.ReadLine();

                    if (Decimal.TryParse(zeroToSixty, out checkDecimal))
                    {
                        if (checkDecimal < 100 && checkDecimal > 0)
                        {
                            break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("\nPlease enter a valid zero to sixty time.");
                    }
                }
                catch
                {
                    throw new VehicleExceptions("Please make sure you enter a valid decimal using a \".\" and not a \",\".");
                }
            }

            vehicleDetails.Add(zeroToSixty);

            bool turbocharger = false;
            while (true)
            {
                Console.Write("\nIs your vehicle turbo charged (Yes/No): ");
                string result = Console.ReadLine();

                if (result.ToLower() == "yes")
                {
                    turbocharger = true;
                    break;
                }
                else if (result.ToLower() == "no")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("\nPlease enter Yes or Not.");
                }
            }

            vehicleDetails.Add(turbocharger);

            return vehicleDetails;
        }

        public Vehicle DisplayVehicleDetails()
        {
            ArrayList vehicleDetails = GetVehicleDetails();

            Vehicle carPlaceholder = new Car();
            try
            {
                carPlaceholder = new Car(vehicleDetails[0].ToString(), vehicleDetails[1].ToString(), decimal.Parse(vehicleDetails[2].ToString()), (bool)vehicleDetails[3]);
            }
            catch (Exception)
            {
                if (carPlaceholder == null)
                    throw new VehicleExceptions("The Vehicle failed instantiation using the list.");
            }

            Console.WriteLine();

            Console.WriteLine($"Your vehicle type is: {carPlaceholder.VehicleType}\n" +
                              $"The brand name of your vehicle is: {carPlaceholder.BrandName}\n" +
                              $"The zero to sixty for your vehicle is: {carPlaceholder.ZeroToSixty}\n" +
                              $"Is your car turbo turbocharger: {carPlaceholder.Turbocharger}");

            while (ExitProgram() == false)
            {
                DisplayVehicleDetails();
            }

            return carPlaceholder;
        }

        public static bool ExitProgram()
        {
            Console.WriteLine();

            bool checkExitStatus = false;
            while (true)
            {
                Console.Write("Do you wish to exit the system (Yes/No):  ");
                string result = Console.ReadLine();

                if (result.ToLower() == "yes")
                {
                    checkExitStatus = true;
                    break;
                }
                else if (result.ToLower() == "no")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Please enter Yes or Not.");
                }
            }

            return checkExitStatus;
        }
    }
}