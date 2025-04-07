using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton.program
{
    class Program
    {
        static void Main(string[] args)
        {
            Singleton s1 = Singleton.ObtenerInstancia();
            Console.WriteLine(s1.mensaje);

            Singleton s2 = Singleton.ObtenerInstancia();
            s2.mensaje = "Hola desde otra parte";

            Console.WriteLine(s1.mensaje);  // También muestra: Hola desde otra parte
            Console.ReadLine();
        }
    }
