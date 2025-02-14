using Escola.Core.Entities;
using Escola.Core.Infrastructure;
using Escola.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escola.Core.Repositories
{
    public class MatriculaRepository : IMatricula
    {
        public bool MatricularAluno(Matricula m)
        {
            try
            {
                using (var connection = BancoDeDados.GetConnection())
                {
                    connection.Open();
                    string sql = "INSERT INTO Aluno_Turma (AlunoId, TurmaId) VALUES (@AlunoId, @TurmaId)";
                    using (var command = new SQLiteCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@AlunoId", m.aluno.id);
                        command.Parameters.AddWithValue("@TurmaId", m.turma.id);
                        int linhasAfetadas = command.ExecuteNonQuery();
                        if (linhasAfetadas > 0)
                        {
                            string msg = $"[ALUNO MATRICULADO]: ID Aluno: {m.aluno.id} | ID Turma: {m.turma.id}";
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
            }catch(SQLiteException ex)
            {
                MessageBox.Show($"Erro SQL: {ex.Message}");
                return false;
            }catch(Exception ex)
            {
                MessageBox.Show($"Erro: {ex.Message}");
                return false;
            }
            
        }
    }
}
