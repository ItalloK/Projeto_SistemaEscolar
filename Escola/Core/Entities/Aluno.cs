using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Escola.Core.Entities
{
    public class Aluno : Pessoa
    {
        public string dataNascimento { get; set; } = string.Empty;
        public string nacionalidade { get; set; } = string.Empty;
        public string naturalidade { get; set; } = string.Empty;
        public string sexo { get; set; } = string.Empty;
        public string corraca { get; set; } = string.Empty;
        public string endereco { get; set; } = string.Empty;

        public Aluno() { }

        public Aluno(string nome, string cpf, string dataNascimento, string nacionalidade, string naturalidade, string sexo, string corraca, string endereco)
        {
            this.nome = nome;
            this.cpf = cpf;
            this.dataNascimento = dataNascimento;
            this.nacionalidade = nacionalidade;
            this.naturalidade = naturalidade;
            this.sexo = sexo;
            this.corraca = corraca;
            this.endereco = endereco;
        }
    }
}
