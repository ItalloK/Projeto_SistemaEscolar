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
        public Responsavel? PegarResponsavel(string cpf)
        {
            using (var connection = BancoDeDados.GetConnection())
            {
                connection.Open();
                string sql = "SELECT Id, Nome, Cpf, Telefone FROM Responsavel WHERE Cpf = @Cpf";

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
                                telefone = reader["Cpf"]?.ToString() ?? string.Empty
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
                    string sql = @"INSERT INTO Responsavel (Nome, Cpf, Telefone) 
                                VALUES (@Nome, @Cpf, @Telefone)";

                    using (var command = new SQLiteCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@Nome", r.nome);
                        command.Parameters.AddWithValue("@Cpf", r.cpf);
                        command.Parameters.AddWithValue("@Telefone", r.telefone);
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
            Debug.WriteLine($"Nome.....: {r.nome}");
            Debug.WriteLine($"CPF......: {r.cpf}");
            Debug.WriteLine($"Telefone.: {r.telefone}");
            Debug.WriteLine(" ~~~~~~~~~~~~ > Responsavel Cadastrado < ~~~~~~~~~~~~");
        }

        public bool ResponsavelParaAluno(Responsavel r, Aluno a)
        {
            return true;
        }
    }
}
