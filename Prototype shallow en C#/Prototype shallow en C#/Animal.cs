using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prototype_shallow_en_C_;

namespace Prototype_shallow_en_C_
{
    public class Animal : ICloneable
    {
        public int Patas { get; set; }
        public string Nombre { get; set; }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
     public object Clone()
        {
            Animal clonado = this.MemberwiseClone() as Animal;
            Detalles detalles = new Detalles();
            detalles.Color = this.Rasgos.Color;
            detalles.Raza = this.Rasgos.Raza;
            clonado.Rasgos = detalles;
            return clonado;
        }
    }


    public class Detalles
{
    public string Color { get; set; }
    public string Raza { get; set; }
}

//De esta manera se demuestra
Animal oAnimal = new Animal() { Nombre = "Oveja Dolly", Patas = 4 };
oAnimal.Rasgos = new Detalles();
oAnimal.Rasgos.Color = "Blanca";
oAnimal.Rasgos.Raza = "Oveja";

Animal oAnimalClonado = oAnimal.Clone() as Animal;
oAnimalClonado.Rasgos.Color = "Negro";
oAnimalClonado.Nombre = "Oveja negra";

Console.WriteLine("animal original: " + oAnimal.Rasgos.Color);
Console.WriteLine("annimal clonado: " + oAnimalClonado.Rasgos.Color);
Console.WriteLine("animal original: " + oAnimal.Nombre);
Console.WriteLine("animal clonado: " + oAnimalClonado.Nombre);