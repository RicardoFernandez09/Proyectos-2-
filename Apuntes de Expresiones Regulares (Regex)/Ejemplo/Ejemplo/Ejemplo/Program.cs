using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        string texto = "Puedes escribirme a ejemplo@gmail.com o contacto@empresa.org";

        string patron = @"[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}";
        MatchCollection coincidencias = Regex.Matches(texto, patron);

        Console.WriteLine("Correos encontrados:");
        foreach (Match match in coincidencias)
        {
            Console.WriteLine(match.Value);
        }
    }
}
