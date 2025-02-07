using Escola.Core.Entities;
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
    }
}
