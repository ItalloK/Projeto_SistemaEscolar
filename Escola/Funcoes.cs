using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
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
        public static string FormatarData(string data)
        {
            data = data.Trim();
            if (data.Length == 8)
            {
                return data.Insert(2, "/").Insert(5, "/");
            }
            else
            {
                Debug.WriteLine("[FUNCOES] A data deve ter exatamente 8 caracteres (ddMMyyyy).");
                return data;
            }
        }

    }
}
