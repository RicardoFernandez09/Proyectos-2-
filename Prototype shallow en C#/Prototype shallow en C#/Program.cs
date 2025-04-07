using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Prototype_shallow_en_C_;

namespace Prototype
{


    class Program
    {
        static void Main(string[] args)
        {
            Animal animal1 = new Animal();
            animal1.Nombre = "Oveja Dolly";
            animal1.Patas = 4;

            Animal animal2 = animal1;
            animal2.Patas = 5;

            Console.WriteLine(animal1.Patas);  // Imprime 5 (problema: ambos apuntan al mismo objeto)
            Animal animalClonado = (Animal)animal1.Clone();
            animalClonado.Patas = 5;

            Console.WriteLine(animal1.Patas);         // Imprime 4
            Console.WriteLine(animalClonado.Patas);   // Imprime 5

        }
    }
}
