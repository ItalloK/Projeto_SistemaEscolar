﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Escola.Classes
{
    public class Aluno : Pessoa
    {
        public string dataNascimento { get; set; }
        public string nacionalidade { get; set; }
        public string naturalidade { get; set; }
        public string sexo { get; set; }
        public string corraca { get; set; }
        public string endereco { get; set; }

        public Aluno(string nome, string cpf, string dataNascimento, string nacionalidade, string naturalidade, string sexo, string corraca, string endereco)
        {
            this.nome = nome;
            this.cpf = cpf;
            this.dataNascimento = dataNascimento;
            this.nacionalidade = nacionalidade;
            this.naturalidade = naturalidade;
            this.sexo = sexo;
            this.corraca = corraca;
            this.endereco = endereco;
        }

        public void CadAluno()
        {
            using (var connection = BancoDeDados.GetConnection())
            {
                connection.Open();
                string sql = "INSERT INTO Aluno (Nome, Cpf, DataNascimento, Nacionalidade, Naturalidade, Sexo, CorRaca, Endereco) VALUES (@Nome, @Cpf, @DataNascimento, @Nacionalidade, @Naturalidade, @Sexo, @CorRaca, @Endereco)";
                using (var command = new SQLiteCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@Nome", this.nome);
                    command.Parameters.AddWithValue("@Cpf", this.cpf);
                    command.Parameters.AddWithValue("@DataNascimento", this.dataNascimento);
                    command.Parameters.AddWithValue("@Nacionalidade", this.nacionalidade);
                    command.Parameters.AddWithValue("@Naturalidade", this.naturalidade);
                    command.Parameters.AddWithValue("@Sexo", this.sexo);
                    command.Parameters.AddWithValue("@CorRaca", this.corraca);
                    command.Parameters.AddWithValue("@Endereco", this.endereco);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Aluno cadastrado com sucesso.");
                    DadosCadastro();                    
                }
            }
        }

        private void DadosCadastro()
        {
            Debug.WriteLine(" ~~~~~~~~~~~~ > Aluno Cadastrado < ~~~~~~~~~~~~");
            Debug.WriteLine($"Nome..........: {this.nome}");
            Debug.WriteLine($"CPF...........: {this.cpf}");
            Debug.WriteLine($"Data Nasc.....: {this.dataNascimento}");
            Debug.WriteLine($"Naturalidade..: {this.nacionalidade}");
            Debug.WriteLine($"Nacionalidade.: {this.naturalidade}");
            Debug.WriteLine($"Sexo..........: {this.sexo}");
            Debug.WriteLine($"Cor e Raça....: {this.corraca}");
            Debug.WriteLine($"Endereço......: {this.endereco}");
            Debug.WriteLine(" ~~~~~~~~~~~~ > Aluno Cadastrado < ~~~~~~~~~~~~");
        }

        public Aluno BuscarAlunoPorCPF(string cpf)
        {
            using (var connection = BancoDeDados.GetConnection())
            {
                connection.Open();
                string sql = "SELECT Id, Nome, Cpf, DataNascimento, Nacionalidade, Naturalidade, Sexo, CorRaca, Endereco FROM Aluno WHERE Cpf = @Cpf";

                using (var command = new SQLiteCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@Cpf", cpf);

                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            Aluno aluno = new Aluno(
                                reader["Nome"].ToString(),
                                reader["Cpf"].ToString(),
                                reader["DataNascimento"].ToString(),
                                reader["Nacionalidade"].ToString(),
                                reader["Naturalidade"].ToString(),
                                reader["Sexo"].ToString(),
                                reader["CorRaca"].ToString(),
                                reader["Endereco"].ToString()
                            );
                            aluno.id = Convert.ToInt32(reader["Id"]);
                            return aluno;
                        }
                    }
                }
            }
            return null;
        }
    }
}
