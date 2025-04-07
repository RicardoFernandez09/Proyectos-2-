using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Factory_Method_en_C_;
namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            BebidaEmbriagante bebida = Creador.CreaBebida(Creador.VINO_TINTO);
            Console.WriteLine(bebida.CuantoMeEmbriaga());  // Imprime: 20

            bebida = Creador.CreaBebida(Creador.CERVEZA);
            Console.WriteLine(bebida.CuantoMeEmbriaga());  // Imprime: 5

        }
    }
}