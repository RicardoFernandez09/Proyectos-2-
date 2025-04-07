using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Method_en_C_
{
    class Creador
    {
        public static class Creador
        {
            public const string VINO_TINTO = "VINO_TINTO";
            public const string CERVEZA = "CERVEZA";

            public static BebidaEmbriagante CreaBebida(string tipo)
            {
                switch (tipo)
                {
                    case VINO_TINTO:
                        return new VinoTinto();
                    case CERVEZA:
                        return new Cerveza();
                    default:
                        return null;
                }
            }
        }

    }
}
