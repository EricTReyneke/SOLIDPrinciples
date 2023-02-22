using MyOwnDog.Abstract;
using MyOwnDog.Interfaces;
using System.Text.RegularExpressions;

namespace MyOwnDog.Models
{
    public enum SizeEnum
    {
        Exit,
        Small,
        Medium,
        Large
    }

    public class Dog : Animal, IAttacks, IGetInformation
    {
        public Dog(string name, string size, decimal health) : base(name, size, health)
        {

        }

        public Dog() : base()
        {

        }

        public decimal BiteAttackDamage()
        {
            return Health * 0.25m;
        }

        public override string SizeMenu()
        {
            int option = 0;

            while (true)
            {
                Console.WriteLine("Please select the size of your dog.\n" +
                             "1. Small.\n" +
                             "2. Medium.\n" +
                             "3. Large.\n" +
                             "0. Exit.");
                option = int.Parse(Console.ReadLine());

                if (option >= 0 && option <= 3)
                    break;
                else
                    Console.WriteLine("Please enter a usable number.");
            }

            return ((SizeEnum)option).ToString();
        }

        public override string AnimalName()
        {
            string animalName = string.Empty;

            while (true)
            {
                Console.Write("Please enter your Animals name: ");
                animalName = Console.ReadLine();

                if (Regex.IsMatch(animalName, "^[a-zA-Z]+$"))
                    break;
                else
                    Console.WriteLine("Please enter a valid name: ");
            }

            return animalName;
        }

        public override decimal AnimalHeath()
        {
            decimal health = 0;

            while (true)
            {
                Console.Write($"Please enter your Animals health: ");
                health = decimal.Parse(Console.ReadLine());

                if (health > 0 && health <= 100)
                    break;
                else
                    Console.WriteLine("Please enter valid health between 0.01 and 100");
            }

            return health;
        }
    }
}
