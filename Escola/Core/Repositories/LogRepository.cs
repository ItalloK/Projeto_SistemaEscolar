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
    public class LogRepository : ILog
    {
        public void NovoLog(Log l)
        {
            try
            {
                using (var connection = BancoDeDados.GetConnection())
                {
                    connection.Open();
                    string sql = @"INSERT INTO Logs (Mensagem) VALUES (@Mensagem)";

                    using (var command = new SQLiteCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@Mensagem", l.mensagem);
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show($"Erro SQL: {ex.Message}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro: {ex.Message}");
            }
        }
    }
}
