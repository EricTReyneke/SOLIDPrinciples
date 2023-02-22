using MyOwnDog.Abstract;
using MyOwnDog.Interfaces;

namespace MyOwnDog.Models
{

    public class Cat : Animal, IAttacks
    {
        public Cat(string Name, string Size, decimal Health) : base(Name, Size, Health)
        {

        }

        public Cat()
        {

        }

        public decimal BiteAttackDamage()
        {
            return Health * 0.10m;
        }

        public override decimal AnimalHeath()
        {
            Console.Write($"Please enter your Animals health: ");
            decimal health = int.Parse(Console.ReadLine());

            return health;
        }

        public override string AnimalName()
        {
            Console.Write("Please enter your Animals name: ");
            string AnimalName = Console.ReadLine();

            return AnimalName;
        }

        public override string SizeMenu()
        {
            Console.WriteLine("Please select the size of your dog.\n" +
                              "1. Small.\n" +
                              "2. Medium.\n" +
                              "3. Large.\n" +
                              "0. Exit.");
            int Option = int.Parse(Console.ReadLine());

            return ((SizeEnum)Option).ToString();
        }
    }
}
