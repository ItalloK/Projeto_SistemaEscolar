using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escola.Core.Entities
{
    public class Log
    {
        public int id { get; set; }
        public string mensagem { get; set; } = string.Empty;
        public string data { get; set; } = string.Empty;

        public Log() { }

        public Log(string mensagem)
        {
            this.mensagem = mensagem;
        }
    }
}
