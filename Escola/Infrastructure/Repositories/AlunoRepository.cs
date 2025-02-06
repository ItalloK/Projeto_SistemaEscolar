using Escola.Core.Entities;
using Escola.Infrastructure.Database;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escola.Infrastructure.Repositories
{
    public class AlunoRepository
    {
        public void CadAluno(Aluno a)
        {
            using (var connection = BancoDeDados.GetConnection())
            {
                connection.Open();
                string sql = "INSERT INTO Aluno (Nome, Cpf, DataNascimento, Nacionalidade, Naturalidade, Sexo, CorRaca, Endereco) VALUES (@Nome, @Cpf, @DataNascimento, @Nacionalidade, @Naturalidade, @Sexo, @CorRaca, @Endereco)";
                using (var command = new SQLiteCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@Nome", a.nome);
                    command.Parameters.AddWithValue("@Cpf", a.cpf);
                    command.Parameters.AddWithValue("@DataNascimento", a.dataNascimento);
                    command.Parameters.AddWithValue("@Nacionalidade", a.nacionalidade);
                    command.Parameters.AddWithValue("@Naturalidade", a.naturalidade);
                    command.Parameters.AddWithValue("@Sexo", a.sexo);
                    command.Parameters.AddWithValue("@CorRaca", a.corraca);
                    command.Parameters.AddWithValue("@Endereco", a.endereco);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Aluno cadastrado com sucesso.");
                    DadosCadastro(a);
                }
            }
        }

        private void DadosCadastro(Aluno a)
        {
            Debug.WriteLine(" ~~~~~~~~~~~~ > Aluno Cadastrado < ~~~~~~~~~~~~");
            Debug.WriteLine($"Nome..........: {a.nome}");
            Debug.WriteLine($"CPF...........: {a.cpf}");
            Debug.WriteLine($"Data Nasc.....: {a.dataNascimento}");
            Debug.WriteLine($"Naturalidade..: {a.nacionalidade}");
            Debug.WriteLine($"Nacionalidade.: {a.naturalidade}");
            Debug.WriteLine($"Sexo..........: {a.sexo}");
            Debug.WriteLine($"Cor e Raça....: {a.corraca}");
            Debug.WriteLine($"Endereço......: {a.endereco}");
            Debug.WriteLine(" ~~~~~~~~~~~~ > Aluno Cadastrado < ~~~~~~~~~~~~");
        }

        public Aluno? BuscarAlunoPorCPF(string cpf)
        {
            using (var connection = BancoDeDados.GetConnection())
            {
                connection.Open();
                string sql = "SELECT Id, Nome, Cpf, DataNascimento, Sexo, Endereco, Naturalidade, Nacionalidade, CorRaca FROM Aluno WHERE Cpf = @Cpf";

                using (var command = new SQLiteCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@Cpf", cpf);

                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new Aluno
                            {
                                id = Convert.ToInt32(reader["Id"]),
                                nome = reader["Nome"]?.ToString() ?? string.Empty,
                                cpf = reader["Cpf"]?.ToString() ?? string.Empty,
                                dataNascimento = reader["DataNascimento"]?.ToString() ?? string.Empty,
                                sexo = reader["Sexo"]?.ToString() ?? string.Empty,
                                endereco = reader["Endereco"]?.ToString() ?? string.Empty,
                                naturalidade = reader["Naturalidade"]?.ToString() ?? string.Empty,
                                nacionalidade = reader["Nacionalidade"]?.ToString() ?? string.Empty,
                                corraca = reader["CorRaca"]?.ToString() ?? string.Empty
                            };
                        }
                    }
                }
            }
            return null;
        }
    }
}
