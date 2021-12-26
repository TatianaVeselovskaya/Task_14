using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_14
{
    abstract class Animal
    {
        public abstract string Name { get; set; }
        public Animal(string name)
        {
            Name = name;
        }
        public abstract void Say();

        public void ShowInfo()
        {
            Console.WriteLine(Name);
            Say();
        }
    }

    class Cat : Animal
    {
        string breed;
        string name;
        public override string Name
        {
            get => name;
            set => name = value;
        }

        public Cat(string name, string breed, string say)
            : base(name)
        {
            this.breed = breed;
        }
        public override void Say()
        {
            Console.WriteLine(breed);
            Console.WriteLine("Мяу");
            Console.WriteLine();
        }
    }
    class Dog : Animal
    {
        private string name;
        public override string Name
        {
            get => name;
            set => name = value;
        }

        public Dog(string name, string say)
            : base(name)
        {
           
        }
        public override void Say()
        {
            Console.WriteLine("Гав");
        }
    }
}
