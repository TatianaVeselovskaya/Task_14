using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_14
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat("Феликс", "Cибирская кошка", "мяу");
            cat.ShowInfo();
            Dog dog = new Dog("Шарик", "гав");
            dog.ShowInfo();
            Console.ReadKey();
        }
    }
}
