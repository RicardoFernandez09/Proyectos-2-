using System;

abstract class Animal
{
    public abstract void Hablar();
}

class Perro : Animal
{
    public override void Hablar() => Console.WriteLine("¡Guau!");
}

class Gato : Animal
{
    public override void Hablar() => Console.WriteLine("¡Miau!");
}

class AnimalFactory
{
    public static Animal CrearAnimal(string tipo)
    {
        return tipo switch
        {
            "perro" => new Perro(),
            "gato" => new Gato(),
            _ => throw new Exception("Tipo de animal desconocido")
        };
    }
}

class Program
{
    static void Main()
    {
        Animal miAnimal = AnimalFactory.CrearAnimal("gato");
        miAnimal.Hablar(); // Imprimir: ¡Miau!
    }
}
