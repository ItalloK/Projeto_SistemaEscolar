using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Escola.Classes
{
    public class Aluno : Pessoa
    {
        public string dataNascimento { get; set; }
        public string nacionalidade { get; set; }
        public string naturalidade { get; set; }
        public string sexo { get; set; }
        public string corraca { get; set; }
        public string endereco { get; set; }

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

        public void CadAluno()
        {
            Debug.WriteLine(" ~~~~~~~~~~~~ > Aluno Cadastrado < ~~~~~~~~~~~~");
            Debug.WriteLine($"Nome..........: {this.nome}");
            Debug.WriteLine($"CPF...........: {this.cpf}");
            Debug.WriteLine($"Data Nasc.....: {this.dataNascimento}");
            Debug.WriteLine($"Naturalidade..: {this.nacionalidade}");
            Debug.WriteLine($"Nacionalidade.: {this.naturalidade}");
            Debug.WriteLine($"Sexo..........: {this.sexo}");
            Debug.WriteLine($"Cor e Raça....: {this.corraca}");
            Debug.WriteLine($"Endereço......: {this.endereco}");
            Debug.WriteLine(" ~~~~~~~~~~~~ > Aluno Cadastrado < ~~~~~~~~~~~~");
        }
    }
}
