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
        public bool AttProfessor(Professor p)
        {
            try
            {
                using (var connection = BancoDeDados.GetConnection())
                {
                    connection.Open();
                    string sql = @"UPDATE Professor SET 
                                    Nome = @Nome,
                                    Cpf = @Cpf,
                                    DataNascimento = @DataNascimento,
                                    Nacionalidade = @Nacionalidade,
                                    Naturalidade = @Naturalidade,
                                    Sexo = @Sexo,
                                    CorRaca = @CorRaca,
                                    Endereco = @Endereco,
                                    Telefone = @Telefone
                                    WHERE Cpf = @Cpf;";

                    using (var command = new SQLiteCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@Nome", p.nome);
                        command.Parameters.AddWithValue("@Cpf", p.cpf);
                        command.Parameters.AddWithValue("@DataNascimento", p.dataNascimento);
                        command.Parameters.AddWithValue("@Nacionalidade", p.nacionalidade);
                        command.Parameters.AddWithValue("@Naturalidade", p.naturalidade);
                        command.Parameters.AddWithValue("@Sexo", p.sexo);
                        command.Parameters.AddWithValue("@CorRaca", p.corraca);
                        command.Parameters.AddWithValue("@Endereco", p.endereco);
                        command.Parameters.AddWithValue("@Telefone", p.telefone);

                        int linhasAfetadas = command.ExecuteNonQuery();

                        if (linhasAfetadas > 0)
                        {
                            string msg = $"[PROFESSOR ATUALIZADO]: Nome: {p.nome} | CPF: {p.cpf} | Data de Nascimento: {p.dataNascimento} | Sexo: {p.sexo} | Endereco: {p.endereco} | Naturalidade: {p.naturalidade} | Nacionalidade: {p.nacionalidade} | Cor/Raça: {p.corraca} | Telefone: {p.telefone}";
                            LogRepository lr = new LogRepository();
                            Log l = new Log
                            {
                                mensagem = msg
                            };
                            lr.NovoLog(l);
                            DadosCadastro(p);
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                }
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show($"Erro SQL: {ex.Message}");
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro: {ex.Message}");
                return false;
            }
        }
        public bool DelProfessor(Professor p)
        {
            try
            {
                using (var connection = BancoDeDados.GetConnection())
                {
                    connection.Open();
                    string sqlDelAluno = @"DELETE FROM Professor WHERE Cpf = @Cpf";

                    using (var command = new SQLiteCommand(sqlDelAluno, connection))
                    {
                        command.Parameters.AddWithValue("@Cpf", p.cpf);
                        int linhasAfetadas = command.ExecuteNonQuery();

                        if (linhasAfetadas > 0)
                        {
                            string msg = $"[PROFESSOR DELETADO]: Nome: {p.nome} | CPF: {p.cpf} | Data de Nascimento: {p.dataNascimento} | Sexo: {p.sexo} | Endereco: {p.endereco} | Naturalidade: {p.naturalidade} | Nacionalidade: {p.nacionalidade} | Cor/Raça: {p.corraca} | Telefone: {p.telefone}";
                            LogRepository lr = new LogRepository();
                            Log l = new Log
                            {
                                mensagem = msg
                            };
                            lr.NovoLog(l);
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                }
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show($"Erro SQL: {ex.Message}");
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro: {ex.Message}");
                return false;
            }
        }

        public bool CadProfessor(Professor p)
        {
            try
            {
                using (var connection = BancoDeDados.GetConnection())
                {
                    connection.Open();
                    string sql = "INSERT INTO Professor (Nome, Cpf, DataNascimento, Sexo, Endereco, Naturalidade, Nacionalidade, CorRaca, Telefone) VALUES (@Nome, @Cpf, @DataNascimento, @Sexo, @Endereco, @Naturalidade, @Nacionalidade, @CorRaca, @Telefone)";
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
                        command.Parameters.AddWithValue("@Telefone", p.telefone);

                        int linhasAfetadas = command.ExecuteNonQuery();

                        if (linhasAfetadas > 0)
                        {

                            string msg = $"[PROFESSOR INSERIDO]: Nome: {p.nome} | CPF: {p.cpf} | Data de Nascimento: {p.dataNascimento} | Sexo: {p.sexo} | Endereco: {p.endereco} | Naturalidade: {p.naturalidade} | Nacionalidade: {p.nacionalidade} | Cor/Raça: {p.corraca} | Telefone: {p.telefone}";
                            LogRepository lr = new LogRepository();
                            Log l = new Log
                            {
                                mensagem = msg
                            };
                            lr.NovoLog(l);

                            DadosCadastro(p);
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                }
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show($"Erro: {ex.Message}");
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro: {ex.Message}");
                return false;
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
            Debug.WriteLine($"Telefone......: {p.telefone}");
            Debug.WriteLine(" ~~~~~~~~~~~~ > Professor Cadastrado < ~~~~~~~~~~~~");
        }

        public Professor? BuscarProfessorPorCPF(string cpf)
        {
            using (var connection = BancoDeDados.GetConnection())
            {
                connection.Open();
                string sql = "SELECT Id, Nome, Cpf, DataNascimento, Sexo, Endereco, Naturalidade, Nacionalidade, CorRaca, Telefone FROM Professor WHERE Cpf = @Cpf";

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
                                corraca = reader["CorRaca"]?.ToString() ?? string.Empty,
                                telefone = reader["Telefone"]?.ToString() ?? string.Empty
                            };
                        }
                    }
                }
            }
            return null;
        }
        public List<Professor> PegarTodosProfessores()
        {
            var professores = new List<Professor>();

            using (var connection = BancoDeDados.GetConnection())
            {
                connection.Open();
                string sql = @"SELECT * FROM Professor;";

                using (var command = new SQLiteCommand(sql, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var prof = new Professor
                            {
                                id = Convert.ToInt32(reader["Id"]),
                                nome = reader["Nome"]?.ToString() ?? string.Empty,
                                cpf = reader["Cpf"]?.ToString() ?? string.Empty,
                                dataNascimento = reader["DataNascimento"]?.ToString() ?? string.Empty,
                                sexo = reader["Sexo"]?.ToString() ?? string.Empty,
                                endereco = reader["Endereco"]?.ToString() ?? string.Empty,
                                naturalidade = reader["Naturalidade"]?.ToString() ?? string.Empty,
                                nacionalidade = reader["Nacionalidade"]?.ToString() ?? string.Empty,
                                corraca = reader["CorRaca"]?.ToString() ?? string.Empty,
                                telefone = reader["Telefone"]?.ToString() ?? string.Empty
                            };
                            professores.Add(prof);
                        }
                    }
                }
            }
            return professores;
        }
    }
}
