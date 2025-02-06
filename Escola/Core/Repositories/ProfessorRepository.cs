using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Diagnostics;
using Escola.Core.Entities;
using Escola.Core.Infrastructure;
using Escola.Core.Interfaces;

namespace Escola.Core.Repositories
{
    public class ProfessorRepository : IProfessor
    {
        public void CadProfessor(Professor p)
        {
            using (var connection = BancoDeDados.GetConnection())
            {
                connection.Open();
                string sql = "INSERT INTO Professor (Nome, Cpf, DataNascimento, Sexo, Endereco, Naturalidade, Nacionalidade, CorRaca) VALUES (@Nome, @Cpf, @DataNascimento, @Sexo, @Endereco, @Naturalidade, @Nacionalidade, @CorRaca)";
                using (var command = new SQLiteCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@Nome", p.nome);
                    command.Parameters.AddWithValue("@Cpf", p.cpf);
                    command.Parameters.AddWithValue("@DataNascimento", p.dataNascimento);
                    command.Parameters.AddWithValue("@Sexo", p.sexo);
                    command.Parameters.AddWithValue("@Endereco", p.endereco);
                    command.Parameters.AddWithValue("@Naturalidade", p.naturalidade);
                    command.Parameters.AddWithValue("@Nacionalidade", p.nacionalidade);
                    command.Parameters.AddWithValue("@CorRaca", p.corraca);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Professor cadastrado com sucesso.");
                    DadosCadastro(p);
                }
            }
        }
        public void DadosCadastro(Professor p)
        {
            Debug.WriteLine(" ~~~~~~~~~~~~ > Professor Cadastrado < ~~~~~~~~~~~~");
            Debug.WriteLine($"Nome..........: {p.nome}");
            Debug.WriteLine($"CPF...........: {p.cpf}");
            Debug.WriteLine($"Data Nasc.....: {p.dataNascimento}");
            Debug.WriteLine($"Naturalidade..: {p.nacionalidade}");
            Debug.WriteLine($"Nacionalidade.: {p.naturalidade}");
            Debug.WriteLine($"Sexo..........: {p.sexo}");
            Debug.WriteLine($"Cor e Raça....: {p.corraca}");
            Debug.WriteLine($"Endereço......: {p.endereco}");
            Debug.WriteLine(" ~~~~~~~~~~~~ > Professor Cadastrado < ~~~~~~~~~~~~");
        }

        public Professor? BuscarProfessorPorCPF(string cpf)
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
                            return new Professor
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
