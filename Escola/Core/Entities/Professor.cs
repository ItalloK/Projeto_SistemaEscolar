using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escola.Core.Entities
{
    public class Professor : Pessoa
    {
        public string telefone { get; set; } = string.Empty;
        public string dataNascimento { get; set; } = string.Empty;
        public string sexo { get; set; } = string.Empty;
        public string endereco { get; set; } = string.Empty;
        public string naturalidade { get; set; } = string.Empty;
        public string nacionalidade { get; set; } = string.Empty;
        public string corraca { get; set; } = string.Empty;

        public Professor() { }

        public Professor(string nome, string cpf, string dataNascimento, string sexo, string endereco, string naturalidade, string nacionalidade, string corraca, string telefone)
        {
            this.nome = nome;
            this.cpf = cpf;
            this.dataNascimento = dataNascimento;
            this.sexo = sexo;
            this.endereco = endereco;
            this.naturalidade = naturalidade;
            this.nacionalidade = nacionalidade;
            this.corraca = corraca;
            this.telefone = telefone;
        }
    }
}
