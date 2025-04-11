using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        string directory = @"C:\Users\rf024\OneDrive\Escritorio\Expresiones Regulares";
        Console.Write("Buscar por artista (dejar vacío si no): ");
        string artist = Console.ReadLine();

        Console.Write("Buscar por año (dejar vacío si no): ");
        string year = Console.ReadLine();

        var files = SearchSongs(directory, artist, year);

        Console.WriteLine("\n🎶 Canciones encontradas:");
        foreach (var file in files)
        {
            Console.WriteLine(file);
        }
    }

    static string[] SearchSongs(string directory, string artist, string year)
    {
        // Construir patrón dinámico
        string artistPattern = string.IsNullOrWhiteSpace(artist) ? ".*" : Regex.Escape(artist);
        string yearPattern = string.IsNullOrWhiteSpace(year) ? @"\d{4}" : Regex.Escape(year);

        // Coldplay.*\(2008\)\.mp3
        string pattern = $@"^{artistPattern}.*\({yearPattern}\)\.mp3$";

        var result = new List<string>();

        foreach (var file in Directory.GetFiles(directory, "*.mp3"))
        {
            string fileName = Path.GetFileName(file);
            if (Regex.IsMatch(fileName, pattern, RegexOptions.IgnoreCase))
            {
                result.Add(fileName);
            }
        }

        return result.ToArray();
    }
}
