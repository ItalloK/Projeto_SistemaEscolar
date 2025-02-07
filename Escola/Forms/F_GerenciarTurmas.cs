﻿using Escola.Core.Entities;
using Escola.Core.Repositories;
using Escola.Core.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Escola.Forms
{
    public partial class F_GerenciarTurmas : Form
    {

        public F_GerenciarTurmas()
        {
            InitializeComponent();
            AtivarPainel(panel_GerenciarTurmas);
            CarregarPropriedadesCadTurma(); // carrega as propriedas do form de cadastro de turma
        }

        private void AtivarPainel(Panel p)
        {
            panel_GerenciarTurmas.Visible = false;
            panel_CadTurma.Visible = false;
            p.Visible = true;
            p.Location = new Point(0, 0);
        }

        private void CarregarPropriedadesCadTurma()
        {
            for (int i = 0; i < 9; i++)
            {
                int numero = i + 1;
                string texto = numero + " ano";
                cb_EscSerie.Items.Add(new KeyValuePair<int, string>(numero, texto));
            }
            cb_EscSerie.DisplayMember = "Value";
            cb_EscSerie.ValueMember = "Key";
            cb_EscSerie.SelectedIndex = 0;


            cb_EscTipo.Items.Add("Fundamental");
            cb_EscTipo.Items.Add("Medio");
            cb_EscTipo.SelectedIndex = 0;


            cb_EscTurno.Items.Add("Matutino");
            cb_EscTurno.Items.Add("Vespertino");
            cb_EscTurno.Items.Add("Noturno");
            cb_EscTurno.SelectedIndex = 0;


            for (int i = 0; i < 50; i++)
            {
                int numero = i + 1;
                string texto = numero + (numero == 1 ? " aluno" : " alunos");

                cb_EscMaxAluno.Items.Add(new KeyValuePair<int, string>(numero, texto));
            }
            cb_EscMaxAluno.DisplayMember = "Value";
            cb_EscMaxAluno.ValueMember = "Key";
            cb_EscMaxAluno.SelectedIndex = 0;
        }

        private void F_GerenciarTurmas_Load(object sender, EventArgs e)
        {
            CarregarDados();
        }

        private void CarregarDados()
        {
            TurmasRepository tr = new TurmasRepository();
            var turmas = tr.PegarTurmas();

            dgv_Dados.DataSource = turmas;
            if (dgv_Dados.Columns.Count > 0) // Verifica se as colunas foram geradas
            {
                dgv_Dados.Columns["id"]!.DisplayIndex = 0;
                dgv_Dados.Columns["tipo"]!.DisplayIndex = 1;
                dgv_Dados.Columns["turno"]!.DisplayIndex = 2;
                dgv_Dados.Columns["serie"]!.DisplayIndex = 3;
                dgv_Dados.Columns["quantidadeAlunos"]!.DisplayIndex = 4;
                dgv_Dados.Columns["maxAlunos"]!.DisplayIndex = 5;

                dgv_Dados.Columns["id"]!.HeaderText = "Turma";
                dgv_Dados.Columns["tipo"]!.HeaderText = "Tipo";
                dgv_Dados.Columns["turno"]!.HeaderText = "Turno";
                dgv_Dados.Columns["serie"]!.HeaderText = "Serie";
                dgv_Dados.Columns["quantidadeAlunos"]!.HeaderText = "Alunos";
                dgv_Dados.Columns["maxAlunos"]!.HeaderText = "Max Alunos";
            }
        }

        private void dgv_Dados_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv_Dados.SelectedRows.Count > 0) // Verifica se tem linha selecionada
            {
                DataGridViewRow row = dgv_Dados.SelectedRows[0]; // Pega a primeira selecionada
                int turmaId = Convert.ToInt32(row.Cells["id"].Value);

                Turma turmaSelecionada = new Turma { id = turmaId };

                TurmasRepository tr = new TurmasRepository();
                List<Aluno> alunos = tr.PegarAlunosPorTurma(turmaSelecionada);

                dgv_DadosAluno.DataSource = alunos;

                string[] colunasVisiveis = { "id", "nome", "sexo" };
                foreach (DataGridViewColumn column in dgv_DadosAluno.Columns)
                {
                    column.Visible = colunasVisiveis.Contains(column.Name);
                }

                if (dgv_DadosAluno.Columns.Count > 0)
                {
                    dgv_DadosAluno.Columns["Id"]!.DisplayIndex = 0;
                    dgv_DadosAluno.Columns["Nome"]!.DisplayIndex = 1;
                    dgv_DadosAluno.Columns["Sexo"]!.DisplayIndex = 2;

                    dgv_DadosAluno.Columns["Id"]!.HeaderText = "Codigo";
                    dgv_DadosAluno.Columns["Nome"]!.HeaderText = "Nome";
                    dgv_DadosAluno.Columns["Sexo"]!.HeaderText = "Sexo";
                }
            }
        }

        private void dgv_DadosAluno_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            //função abaixo pega o ' id ' ou ' codigo ' e poe 5 zeros antes do id do aluno;
            if (dgv_DadosAluno.Columns[e.ColumnIndex].Name == "id" && e.Value != null)
            {
                int id = Convert.ToInt32(e.Value);
                e.Value = Funcoes.FormatarCodigo(id);
                e.FormattingApplied = true;
            }
        }

        private void btn_CadAlunoGerenciador_Click(object sender, EventArgs e)
        {
            AtivarPainel(panel_CadTurma);
        }

        private void btn_CancelarCadTurma_Click(object sender, EventArgs e)
        {
            AtivarPainel(panel_GerenciarTurmas);
        }

        private void btn_CadastrarTurma_Click(object sender, EventArgs e)
        {
            CadastrarTurma();
        }

        private void CadastrarTurma()
        {
            int valorMaxAlunos = (int)((KeyValuePair<int, string>)cb_EscMaxAluno.SelectedItem).Key;

            if (valorMaxAlunos < 1 || valorMaxAlunos > 50)
            {
                MessageBox.Show("O numero maximo de alunos não pode ser menor que 1 ou maior que 50!");
                return;
            }

            int valorSerie = (int)((KeyValuePair<int, string>)cb_EscSerie.SelectedItem).Key;

            if (valorSerie < 1 || valorSerie > 9)
            {
                MessageBox.Show("A serie nao pode ser menor que 1 ou maior que 9!");
                return;
            }

            string tipo = cb_EscTipo.Text;
            string turno = cb_EscTurno.Text;

            if(valorSerie > 3 && tipo == "Medio")
            {
                MessageBox.Show("Erro, a serie não pode ser maior que 3 e o tipo medio!");
                return;
            }

            Turma turma = new Turma
            {
                serie = valorSerie.ToString(),
                tipo = tipo,
                turno = turno,
                maxAlunos = valorMaxAlunos
            };

            TurmasRepository tr = new TurmasRepository();
            bool sucesso = tr.CadTurma(turma);
            if (sucesso) {
                MessageBox.Show("Turma cadastrada!");
                this.Close();
            }
            else
            {
                MessageBox.Show("Turma não cadastrada!");
                return;
            }
        }
    }
}
