using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escola.Classes
{
    public class Professor : Pessoa
    {
        public string dataNascimento { get; set; }
        public string sexo { get; set; }
        public string endereco { get; set; }
        public string naturalidade { get; set; }
        public string nacionalidade { get; set; }
        public string corraca { get; set; }

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

        public void CadProfessor()
        {
            using (var connection = BancoDeDados.GetConnection())
            {
                connection.Open();
                string sql = "INSERT INTO Professor (Nome, Cpf, DataNascimento, Sexo, Endereco) VALUES (@Nome, @Cpf, @DataNascimento, @Sexo, @Endereco)";
                using (var command = new SQLiteCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@Nome", this.nome);
                    command.Parameters.AddWithValue("@Cpf", this.cpf);
                    command.Parameters.AddWithValue("@DataNascimento", this.dataNascimento);
                    command.Parameters.AddWithValue("@Sexo", this.sexo);
                    command.Parameters.AddWithValue("@Endereco", this.endereco);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Professor cadastrado com sucesso.");
                    DadosCadastro();
                }
            }
        }
        private void DadosCadastro()
        {
            Debug.WriteLine(" ~~~~~~~~~~~~ > Professor Cadastrado < ~~~~~~~~~~~~");
            Debug.WriteLine($"Nome..........: {this.nome}");
            Debug.WriteLine($"CPF...........: {this.cpf}");
            Debug.WriteLine($"Data Nasc.....: {this.dataNascimento}");
            Debug.WriteLine($"Sexo..........: {this.sexo}");
            Debug.WriteLine($"Endereço......: {this.endereco}");
            Debug.WriteLine(" ~~~~~~~~~~~~ > Professor Cadastrado < ~~~~~~~~~~~~");
        }
        public Professor BuscarProfessorPorCPF(string cpf)
        {
            using (var connection = BancoDeDados.GetConnection())
            {
                connection.Open();
                string sql = "SELECT Id, Nome, Cpf, DataNascimento, Sexo, Endereco, Naturalidade, Nacionalidade, CorRaca FROM Professor WHERE Cpf = @Cpf";

                using (var command = new SQLiteCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@Cpf", cpf);

                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            Professor professor = new Professor(
                                reader["Nome"].ToString(),
                                reader["Cpf"].ToString(),
                                reader["DataNascimento"].ToString(),
                                reader["Sexo"].ToString(),
                                reader["Endereco"].ToString(),
                                reader["Naturalidade"].ToString(),
                                reader["Nacionalidade"].ToString(),
                                reader["CorRaca"].ToString()
                            );
                            professor.id = Convert.ToInt32(reader["Id"]);
                            return professor;
                        }
                    }
                }
            }
            return null;
        }
    }
}
