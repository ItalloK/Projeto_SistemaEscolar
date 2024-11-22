using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escola
{
    internal class Global
    {
        private static string _nomeEscola = "Escola Padrão";

        public static string NomeEscola
        {
            get => _nomeEscola;
            set
            {
                if (_nomeEscola != value)
                {
                    _nomeEscola = value;
                    NomeEscolaChanged?.Invoke(null, EventArgs.Empty);
                }
            }
        }
        public static event EventHandler NomeEscolaChanged;
    }
}
