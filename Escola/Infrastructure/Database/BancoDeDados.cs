using System;
using System.Data.SQLite;
using System.Diagnostics;
using System.IO;

namespace Escola.Infrastructure.Database
{
    internal class BancoDeDados
    {
        private static string stringConexao = "Data Source=Banco de Dados\\database.db;Version=3;";

        static BancoDeDados()
        {
            VerificarBanco();
        }

        public static SQLiteConnection GetConnection()
        {
            return new SQLiteConnection(stringConexao);
        }

        private static void VerificarBanco()
        {
            if (!Directory.Exists("Banco de Dados"))
            {
                Directory.CreateDirectory("Banco de Dados");
            }

            if (!File.Exists("Banco de Dados\\database.db"))
            {
                SQLiteConnection.CreateFile("Banco de Dados\\database.db");
                Console.WriteLine("Banco de dados criado com sucesso!");

                using (SQLiteConnection conexao = new SQLiteConnection(stringConexao))
                {
                    conexao.Open();
                    var tabelasSQL = new Dictionary<string, string>
                    {
                        { "Aluno", @"
                            CREATE TABLE IF NOT EXISTS Aluno (
                                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                                    Nome TEXT NOT NULL,
                                    Cpf TEXT NOT NULL,
                                    DataNascimento TEXT NOT NULL,
                                    Nacionalidade TEXT NOT NULL,
                                    Naturalidade TEXT NOT NULL,
                                    Sexo TEXT NOT NULL,
                                    CorRaca TEXT NOT NULL,
                                    Endereco TEXT NOT NULL
                                )" },
                        { "Responsavel", @"
                            CREATE TABLE IF NOT EXISTS Responsavel (
                                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                                    Nome TEXT NOT NULL,
                                    Cpf TEXT NOT NULL,
                                    Telefone TEXT NOT NULL
                            )" },
                        {"Professor", @"
                            CREATE TABLE IF NOT EXISTS Professor (
                                Id INTEGER PRIMARY KEY AUTOINCREMENT,
                                Nome TEXT NOT NULL,
                                Cpf TEXT NOT NULL,
                                DataNascimento TEXT NOT NULL,
                                Sexo TEXT NOT NULL,
                                Endereco TEXT NOT NULL,
                                Naturalidade TEXT NOT NULL,
                                Nacionalidade TEXT NOT NULL,
                                CorRaca TEXT NOT NULL
                            )"}
                    };

                    foreach (var tabela in tabelasSQL)
                    {
                        using (SQLiteCommand comando = new SQLiteCommand(tabela.Value, conexao))
                        {
                            comando.ExecuteNonQuery();
                            Console.WriteLine($"Tabela '{tabela.Key}' verificada/criada com sucesso.");
                        }
                    }

                    conexao.Close();
                }
            }
            else
            {
                Console.WriteLine("O banco de dados já existe.");
            }
        }
    }
}
