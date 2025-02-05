using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
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
            using (var connection = BancoDeDados.GetConnection())
            {
                connection.Open();
                string sql = "INSERT INTO Responsavel (Nome, Cpf, Telefone) VALUES (@Nome, @Cpf, @Telefone)";
                using (var command = new SQLiteCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@Nome", this.nome);
                    command.Parameters.AddWithValue("@Cpf", this.cpf);
                    command.Parameters.AddWithValue("@Telefone", this.telefone);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Responsavel cadastrado com sucesso.");
                    DadosCadastro();
                }
            }
        }

        private void DadosCadastro()
        {
            Debug.WriteLine(" ~~~~~~~~~~~~ > Responsavel Cadastrado < ~~~~~~~~~~~~");
            Debug.WriteLine($"Nome.....: {this.nome}");
            Debug.WriteLine($"CPF......: {this.cpf}");
            Debug.WriteLine($"Telefone.: {this.telefone}");
            Debug.WriteLine(" ~~~~~~~~~~~~ > Responsavel Cadastrado < ~~~~~~~~~~~~");
        }
    }

}
