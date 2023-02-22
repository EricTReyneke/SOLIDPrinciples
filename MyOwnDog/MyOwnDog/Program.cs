using MyOwnDog.Abstract;
using MyOwnDog.Interfaces;
using MyOwnDog.Models;

namespace MyOwnDog
{
    class Program
    {

        public static void Main()
        {
            GetInformation();
        }

        public static void GetInformation()
        {
            IGetInformation Handler = new Dog();

            while (true)
            {
                try
                {
                    string animalSize = Handler.SizeMenu();

                    if (animalSize.ToLower() != "exit")
                    {
                        string animalName = Handler.AnimalName();

                        decimal animalhealth = Handler.AnimalHeath();

                        Dog dog2 = new(animalName, animalSize, animalhealth);

                        Console.WriteLine($"{animalName} has " + dog2.BiteAttackDamage().ToString() + " bite damage at his/her disposal.");
                    }
                    else
                        break;

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }

                Thread.Sleep(2000);

                Console.Clear();
            }
        }
    }
}