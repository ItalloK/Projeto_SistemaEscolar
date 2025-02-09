using Escola.Core.Infrastructure;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Escola.Core.Entities
{
    public class Responsavel : Pessoa
    {
        public string telefone { get; set; } = string.Empty;

        public Responsavel() { }

        public Responsavel(string nome, string cpf, string telefone)
        {
            this.nome = nome;
            this.cpf = cpf;
            this.telefone = telefone;
        }
    }
}
