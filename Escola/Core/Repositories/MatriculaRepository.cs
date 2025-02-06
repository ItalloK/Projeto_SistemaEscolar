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
        public void MatricularAluno(Matricula m)
        {
            using (var connection = BancoDeDados.GetConnection())
            {
                connection.Open();
                string sql = "INSERT INTO Aluno_Turma (AlunoId, TurmaId) VALUES (@AlunoId, @TurmaId)";
                using (var command = new SQLiteCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@AlunoId", m.aluno.id);
                    command.Parameters.AddWithValue("@TurmaId", m.turma.id);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Aluno matriculado com sucesso.");
                }
            }
        }
    }
}
