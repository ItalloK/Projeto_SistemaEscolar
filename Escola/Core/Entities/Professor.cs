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
        public string? dataNascimento { get; set; }
        public string? sexo { get; set; }
        public string? endereco { get; set; }
        public string? naturalidade { get; set; }
        public string? nacionalidade { get; set; }
        public string? corraca { get; set; }

        public Professor() { }

        public Professor(string nome, string cpf, string dataNascimento, string sexo, string endereco, string naturalidade, string nacionalidade, string corraca)
        {
            this.nome = nome;
            this.cpf = cpf;
            this.dataNascimento = dataNascimento;
            this.sexo = sexo;
            this.endereco = endereco;
            this.naturalidade = naturalidade;
            this.nacionalidade = nacionalidade;
            this.corraca = corraca;
        }
    }
}
