using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escola
{
    public class Funcoes
    {
        public static string FormatarCodigo(int numero)
        {
            return numero.ToString().PadLeft(6, '0');
        }
    }
}
