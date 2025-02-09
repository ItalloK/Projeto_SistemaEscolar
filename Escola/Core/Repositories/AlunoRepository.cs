using Escola.Core.Entities;
using Escola.Core.Infrastructure;
using Escola.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escola.Core.Repositories
{
    public class AlunoRepository : IAluno
    {
        public bool DelAluno(Aluno a)
        {
            try
            {
                using (var connection = BancoDeDados.GetConnection())
                {
                    connection.Open();
                    // primeiro deleta a ligação entre aluno e responsavel
                    string sqlDelResponsavel = @"DELETE FROM Aluno_Responsavel WHERE AlunoCpf = @Cpf";
                    using (var command = new SQLiteCommand(sqlDelResponsavel, connection))
                    {
                        command.Parameters.AddWithValue("@Cpf", a.cpf);
                        command.ExecuteNonQuery();
                    }

                    // agora remove o aluno e mantem o responsavel no sistema.
                    string sqlDelAluno = @"DELETE FROM Aluno WHERE Cpf = @Cpf";

                    using (var command = new SQLiteCommand(sqlDelAluno, connection))
                    {
                        command.Parameters.AddWithValue("@Cpf", a.cpf);
                        int linhasAfetadas = command.ExecuteNonQuery();

                        if (linhasAfetadas > 0)
                        {
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

        public List<Aluno> PegarTodosAlunos()
        {
            var alunos = new List<Aluno>();

            using (var connection = BancoDeDados.GetConnection())
            {
                connection.Open();
                string sql = @"SELECT * FROM Aluno";
                using (var command = new SQLiteCommand(sql, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var aluno = new Aluno
                            {
                                id = Convert.ToInt32(reader["Id"]),
                                nome = reader["Nome"]?.ToString() ?? string.Empty,
                                cpf = reader["Cpf"]?.ToString() ?? string.Empty,
                                dataNascimento = reader["DataNascimento"]?.ToString() ?? string.Empty,
                                nacionalidade = reader["Nacionalidade"]?.ToString() ?? string.Empty,
                                naturalidade = reader["Naturalidade"]?.ToString() ?? string.Empty,
                                sexo = reader["Sexo"]?.ToString() ?? string.Empty,
                                corraca = reader["CorRaca"]?.ToString() ?? string.Empty,
                                endereco = reader["Endereco"]?.ToString() ?? string.Empty
                            };
                            alunos.Add(aluno);
                        }
                    }
                }
            }
            return alunos;
        }

        public bool CadAlunoComResponsavel(Aluno a, Responsavel r)
        {
            try
            {
                using (var connection = BancoDeDados.GetConnection())
                {
                    connection.Open();
                    string sql = @"INSERT INTO Aluno (Nome, Cpf, DataNascimento, Nacionalidade, Naturalidade, Sexo, CorRaca, Endereco) 
                           VALUES (@Nome, @Cpf, @DataNascimento, @Nacionalidade, @Naturalidade, @Sexo, @CorRaca, @Endereco)";

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

                        int linhasAfetadas = command.ExecuteNonQuery();

                        if (linhasAfetadas > 0)
                        {
                            string sqlNew = @"INSERT INTO Aluno_Responsavel (AlunoCpf, ResponsavelCpf) VALUES (@ACpf, @RCpf)";
                            using (var commandNew = new SQLiteCommand(sqlNew, connection))
                            {
                                commandNew.Parameters.AddWithValue("@ACpf", a.cpf);
                                commandNew.Parameters.AddWithValue("@RCpf", r.cpf);
                                commandNew.ExecuteNonQuery();
                            }

                            DadosCadastro(a);
                            return true;
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
            return false;
        }

        public bool CadAluno(Aluno a)
        {
            try
            {
                using (var connection = BancoDeDados.GetConnection())
                {
                    connection.Open();
                    string sql = @"INSERT INTO Aluno (Nome, Cpf, DataNascimento, Nacionalidade, Naturalidade, Sexo, CorRaca, Endereco) 
                           VALUES (@Nome, @Cpf, @DataNascimento, @Nacionalidade, @Naturalidade, @Sexo, @CorRaca, @Endereco)";

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

                        int linhasAfetadas = command.ExecuteNonQuery();

                        if (linhasAfetadas > 0)
                        {
                            DadosCadastro(a);
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

        public void DadosCadastro(Aluno a)
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

        public bool VerificarAlunoMatriculado(Aluno a)
        {
            using (var connection = BancoDeDados.GetConnection())
            {
                connection.Open();
                string sql = "SELECT COUNT(1) FROM Aluno_Turma WHERE AlunoId = @Id";

                using (var command = new SQLiteCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@Id", a.id);

                    var result = command.ExecuteScalar();
                    return Convert.ToInt32(result) == 0; // true se não tiver matriculado.
                }
            }
        }
    }
}
