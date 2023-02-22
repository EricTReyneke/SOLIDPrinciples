using MyOwnDog.Interfaces;
using MyOwnDog.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyOwnDog.Abstract
{

    public abstract class Animal : IGetInformation
    {
        public string Name { get; set; }
        public string Size { get; set; }
        public decimal Health { get; set; }

        public Animal(string Name, string Size, decimal Health)
        {
            this.Name = Name;
            this.Size = Size;
            this.Health = Health;
        }

        public Animal()
        {

        }

        public abstract string SizeMenu();

        public abstract string AnimalName();

        public abstract decimal AnimalHeath();
    }
}
