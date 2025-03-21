using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

class Program
{
    static void Main()
    {
        // Ruta del archivo XML
        string path = "C:\\Users\\rf024\\OneDrive\\Escritorio\\XML";
        XElement storeXml = XElement.Load(path);

        // Obtener elementos del XML
        var beers = from beer in storeXml.Element("beers").Elements("beer")
                    select beer;

        Console.WriteLine("Lista de cervezas:");
        foreach (var beer in beers)
        {
            Console.WriteLine(beer.Value);
        }

        // Ordenar por nombre
        var orderedBeers = from beer in beers
                           orderby beer.Value
                           select beer;

        Console.WriteLine("\nCervezas ordenadas alfabéticamente:");
        foreach (var beer in orderedBeers)
        {
            Console.WriteLine(beer.Value);
        }

        // Filtrar por estilo 'porter'
        var porterBeers = from beer in beers
                          where (string)beer.Attribute("style") == "porter"
                          select beer;

        Console.WriteLine("\nCervezas tipo Porter:");
        foreach (var beer in porterBeers)
        {
            Console.WriteLine(beer.Value);
        }

        // Ordenar por atributo 'style'
        var orderedByStyle = from beer in beers
                             orderby (string)beer.Attribute("style")
                             select beer;

        Console.WriteLine("\nCervezas ordenadas por estilo:");
        foreach (var beer in orderedByStyle)
        {
            Console.WriteLine($"{beer.Value} - {beer.Attribute("style").Value}");
        }

        // Convertir los elementos a una clase personalizada
        var beerList = from beer in beers
                       select new Beer
                       {
                           Name = beer.Value,
                           Style = (string)beer.Attribute("style")
                       };

        Console.WriteLine("\nLista de objetos Beer:");
        foreach (var beer in beerList)
        {
            Console.WriteLine($"{beer.Name} - {beer.Style}");
        }
    }
}

class Beer
{
    public string Name { get; set; }
    public string Style { get; set; }
}
