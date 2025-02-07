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
        public bool CadTurma(Turma t)
        {
            return true;
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

        public List<Aluno> PegarAlunosPorTurma(Turma t)
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
                        JOIN Aluno_Turma AT ON A.Id = AT.AlunoId
                        WHERE AT.TurmaId = @TurmaId;";

                using (var command = new SQLiteCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@TurmaId", t.id);

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
    }
}
