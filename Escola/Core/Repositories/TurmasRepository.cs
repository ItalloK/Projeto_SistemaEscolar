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
    public class TurmasRepository:ITurmas
    {
        public void CadTurma(Turma t)
        {

        }

        public Turma PegarTurma()
        {
            return new Turma();
        }

        public List<Turma> PegarTurmas()
        {
            var turmas = new List<Turma>();

            using (var connection = BancoDeDados.GetConnection())
            {
                connection.Open();
                string sql = @"
                SELECT 
                    t.Id AS TurmaId,
                    t.Tipo,
                    t.Turno,
                    t.Serie,
                    t.MaxAlunos,
                    COUNT(at.AlunoId) AS QuantidadeAlunos
                FROM Turmas t
                LEFT JOIN Aluno_Turma at ON t.Id = at.TurmaId
                GROUP BY t.Id, t.Tipo, t.Turno, t.Serie, t.MaxAlunos;";
                using (var command = new SQLiteCommand(sql, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var turma = new Turma
                            {
                                id = Convert.ToInt32(reader["TurmaId"]),
                                tipo = reader["Tipo"]?.ToString() ?? string.Empty,
                                turno = reader["Turno"]?.ToString() ?? string.Empty,
                                serie = reader["Serie"]?.ToString() ?? string.Empty,
                                maxAlunos = Convert.ToInt32(reader["MaxAlunos"]),
                                quantidadeAlunos = Convert.ToInt32(reader["QuantidadeAlunos"])
                            };
                            turmas.Add(turma);
                        }
                    }
                }
            }
            return turmas;
        }
    }
}
