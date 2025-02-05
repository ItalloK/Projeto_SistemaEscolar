using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escola.Classes
{
    public class Responsavel : Pessoa
    {
        public string telefone { get; set; }

        public Responsavel(string nome, string cpf, string telefone)
        {
            this.nome = nome;
            this.cpf = cpf;
            this.telefone = telefone;
        }

        public void CadResponsavel()
        {
            Debug.WriteLine(" ~~~~~~~~~~~~ > Responsavel Cadastrado < ~~~~~~~~~~~~");
            Debug.WriteLine($"Nome.....: {this.nome}");
            Debug.WriteLine($"CPF......: {this.cpf}");
            Debug.WriteLine($"Telefone.: {this.telefone}");
            Debug.WriteLine(" ~~~~~~~~~~~~ > Responsavel Cadastrado < ~~~~~~~~~~~~");
        }
    }

}
