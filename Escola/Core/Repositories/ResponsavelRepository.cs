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
    public class ResponsavelRepository : IResponsavel
    {
        public bool DelResponsavel(Responsavel r)
        {
            try
            {
                using (var connection = BancoDeDados.GetConnection())
                {
                    connection.Open();
                    // primeiro deleta a ligação entre aluno e responsavel
                    string sqlDelResponsavel = @"DELETE FROM Aluno_Responsavel WHERE ResponsavelCpf = @Cpf";
                    using (var command = new SQLiteCommand(sqlDelResponsavel, connection))
                    {
                        command.Parameters.AddWithValue("@Cpf", r.cpf);
                        command.ExecuteNonQuery();
                    }

                    // agora remove o responsavel e mantem o aluno no sistema.
                    string sqlDelAluno = @"DELETE FROM Responsavel WHERE Cpf = @Cpf";

                    using (var command = new SQLiteCommand(sqlDelAluno, connection))
                    {
                        command.Parameters.AddWithValue("@Cpf", r.cpf);
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
        public bool AttResponsavel(Responsavel r)
        {
            try
            {
                using (var connection = BancoDeDados.GetConnection())
                {
                    connection.Open();
                    string sql = @"UPDATE Responsavel SET 
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
                        command.Parameters.AddWithValue("@Nome", r.nome);
                        command.Parameters.AddWithValue("@Cpf", r.cpf);
                        command.Parameters.AddWithValue("@DataNascimento", r.dataNascimento);
                        command.Parameters.AddWithValue("@Nacionalidade", r.nacionalidade);
                        command.Parameters.AddWithValue("@Naturalidade", r.naturalidade);
                        command.Parameters.AddWithValue("@Sexo", r.sexo);
                        command.Parameters.AddWithValue("@CorRaca", r.corraca);
                        command.Parameters.AddWithValue("@Endereco", r.endereco);
                        command.Parameters.AddWithValue("@Telefone", r.telefone);
                        int linhasAfetadas = command.ExecuteNonQuery();
                        if (linhasAfetadas > 0)
                        {
                            DadosCadastro(r);
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

        public List<Aluno> PegarAlunosPorResponsavel(Responsavel r)
        {
            var alunos = new List<Aluno>();

            using (var connection = BancoDeDados.GetConnection())
            {
                connection.Open();
                string sql = @"
                            SELECT 
                                A.Id,
                                A.Nome,
                                A.Cpf,
                                A.DataNascimento,
                                A.Nacionalidade,
                                A.Naturalidade,
                                A.Sexo,
                                A.CorRaca,
                                A.Endereco
                            FROM Aluno A
                            JOIN Aluno_Responsavel AR ON A.Cpf = AR.AlunoCpf
                            JOIN Responsavel R ON AR.ResponsavelCpf = R.Cpf
                            WHERE R.Cpf = @ResponsavelCpf;";

                using (var command = new SQLiteCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@ResponsavelCpf", r.cpf);

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

        public List<Responsavel> PegarTodosResponsaveis()
        {
            var responsaveis = new List<Responsavel>();

            using (var connection = BancoDeDados.GetConnection())
            {
                connection.Open();
                string sql = @"SELECT * FROM Responsavel;";

                using (var command = new SQLiteCommand(sql, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var resp = new Responsavel
                            {
                                id = Convert.ToInt32(reader["Id"]),
                                nome = reader["Nome"]?.ToString() ?? string.Empty,
                                cpf = reader["Cpf"]?.ToString() ?? string.Empty,
                                telefone = reader["Telefone"]?.ToString() ?? string.Empty,
                                dataNascimento = reader["DataNascimento"]?.ToString() ?? string.Empty,
                                sexo = reader["Sexo"]?.ToString() ?? string.Empty,
                                endereco = reader["Endereco"]?.ToString() ?? string.Empty,
                                naturalidade = reader["Naturalidade"]?.ToString() ?? string.Empty,
                                nacionalidade = reader["Nacionalidade"]?.ToString() ?? string.Empty,
                                corraca = reader["CorRaca"]?.ToString() ?? string.Empty
                            };
                            responsaveis.Add(resp);
                        }
                    }
                }
            }
            return responsaveis;
        }

        public Responsavel? PegarResponsavel(string cpf)
        {
            using (var connection = BancoDeDados.GetConnection())
            {
                connection.Open();
                string sql = "SELECT * FROM Responsavel WHERE Cpf = @Cpf";

                using (var command = new SQLiteCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@Cpf", cpf);

                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new Responsavel
                            {
                                id = Convert.ToInt32(reader["Id"]),
                                nome = reader["Nome"]?.ToString() ?? string.Empty,
                                cpf = reader["Cpf"]?.ToString() ?? string.Empty,
                                telefone = reader["Telefone"]?.ToString() ?? string.Empty,
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

        public bool VerificarResponsavel(Responsavel r)
        {
            using (var connection = BancoDeDados.GetConnection())
            {
                connection.Open();
                string sql = "SELECT COUNT(1) FROM Responsavel WHERE Cpf = @Cpf";
                using (var command = new SQLiteCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@Cpf", r.cpf);

                    var result = command.ExecuteScalar(); // retorna num de registros encontrados

                    return Convert.ToInt32(result) > 0; // se encontrar 1 ou +, retorna true
                }
            }
        }

        public bool CadResponsavel(Responsavel r)
        {
            try
            {
                using (var connection = BancoDeDados.GetConnection())
                {
                    connection.Open();
                    string sql = @"INSERT INTO Responsavel (Nome, Cpf, Telefone, DataNascimento, Sexo, Endereco, Naturalidade, Nacionalidade, CorRaca) 
                                VALUES (@Nome, @Cpf, @Telefone, @DataNascimento, @Sexo, @Endereco, @Naturalidade, @Nacionalidade, @CorRaca)";

                    using (var command = new SQLiteCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@Nome", r.nome);
                        command.Parameters.AddWithValue("@Cpf", r.cpf);
                        command.Parameters.AddWithValue("@Telefone", r.telefone);
                        command.Parameters.AddWithValue("@DataNascimento", r.dataNascimento);
                        command.Parameters.AddWithValue("@Sexo", r.sexo);
                        command.Parameters.AddWithValue("@Endereco", r.endereco);
                        command.Parameters.AddWithValue("@Naturalidade", r.naturalidade);
                        command.Parameters.AddWithValue("@Nacionalidade", r.nacionalidade);
                        command.Parameters.AddWithValue("@CorRaca", r.corraca);
                        int linhas = command.ExecuteNonQuery();
                        if (linhas > 0)
                        {
                            DadosCadastro(r);
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
            catch (Exception ex) {
                MessageBox.Show($"Erro: {ex.Message}");
                return false;
            }
            
        }

        public void DadosCadastro(Responsavel r)
        {
            Debug.WriteLine(" ~~~~~~~~~~~~ > Responsavel Cadastrado < ~~~~~~~~~~~~");
            Debug.WriteLine($"Nome............: {r.nome}");
            Debug.WriteLine($"CPF.............: {r.cpf}");
            Debug.WriteLine($"Telefone........: {r.telefone}");
            Debug.WriteLine($"Data Nascimento.: {r.dataNascimento}");
            Debug.WriteLine($"Sexo............: {r.sexo}");
            Debug.WriteLine($"Endereco.: {r.endereco}");
            Debug.WriteLine($"Naturalidade.: {r.naturalidade}");
            Debug.WriteLine($"Nacionalidade.: {r.nacionalidade}");
            Debug.WriteLine($"CorRaca.: {r.corraca}");
            Debug.WriteLine(" ~~~~~~~~~~~~ > Responsavel Cadastrado < ~~~~~~~~~~~~");
        }

        public List<Responsavel> PegarResponsaveisPorAluno(Aluno a)
        {
            var responsaveis = new List<Responsavel>();

            using (var connection = BancoDeDados.GetConnection())
            {
                connection.Open();
                string sql = @"
                        SELECT 
                            R.Id,
                            R.Nome,
                            R.Cpf,
                            R.Telefone
                        FROM Responsavel R
                        JOIN Aluno_Responsavel AT ON R.Cpf = AT.ResponsavelCpf
                        WHERE AT.AlunoCpf = @Cpf;";

                using (var command = new SQLiteCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@Cpf", a.cpf);

                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var resp = new Responsavel
                            {
                                id = Convert.ToInt32(reader["Id"]),
                                nome = reader["Nome"]?.ToString() ?? string.Empty,
                                cpf = reader["Cpf"]?.ToString() ?? string.Empty,
                                telefone = reader["Telefone"]?.ToString() ?? string.Empty
                            };
                            responsaveis.Add(resp);
                        }
                    }
                }
            }
            return responsaveis;
        }
    }
}
