using CarArchitecture.Interfaces;
using NPOI.Util.ArrayExtensions;
using System.ComponentModel;

namespace CarArchitecture.Models
{
    public class CarCreator<TCar> : ICarCreator<TCar> where TCar : ICar, new()
    {
        public CarCreator()
        {
        }

        public TCar CreateCar(object stats)
        {            
            TCar car = new TCar();

            stats.GetType().GetProperties().ToList().ForEach(prop =>
            {
                if (typeof(TCar).GetProperty(prop.Name) != null)
                    typeof(TCar).GetProperty(prop.Name).SetValue(car, stats.GetType().GetProperty(prop.Name).GetValue(stats));
            });
            return car;
        }

        public TCar CreateCar()
        {
            TCar car = new TCar();

            typeof(TCar).GetProperties().ToList().ForEach(prop =>
            {
                Console.WriteLine($"Please input {prop.GetCustomAttributes(typeof(DescriptionAttribute), false)[0]} ");
                prop.DeclaringType.GetMethod("TryParse").Invoke(prop.GetValue(car), )
                prop.SetValue(car, Console.ReadLine());
            });

            return car;
        }
    }
}