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
        public string dataNascimento { get; set; } = string.Empty;
        public string sexo { get; set; } = string.Empty;
        public string endereco { get; set; } = string.Empty;
        public string naturalidade { get; set; } = string.Empty;
        public string nacionalidade { get; set; } = string.Empty;
        public string corraca { get; set; } = string.Empty;

        public Responsavel() { }

        public Responsavel(string nome, string cpf, string telefone, string dataNascimento, string sexo, string endereco, string naturalidade, string nacionalidade, string corraca)
        {
            this.nome = nome;
            this.cpf = cpf;
            this.telefone = telefone;
            this.dataNascimento = dataNascimento;
            this.sexo = sexo;
            this.endereco = endereco;
            this.naturalidade = naturalidade;
            this.nacionalidade = nacionalidade;
            this.corraca = corraca;
        }
    }
}
