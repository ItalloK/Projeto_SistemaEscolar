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
    public partial class F_GerenciarResponsaveis : Form
    {
        public F_GerenciarResponsaveis()
        {
            InitializeComponent();
        }

        private void F_GerenciarResponsaveis_Load(object sender, EventArgs e)
        {
            Funcoes.AtivarPainel(this, panel_GerenciarResponsaveis);
            CarregarResponsaveis();
        }

        private void btn_CancelarCadResponsavelP_Click(object sender, EventArgs e)
        {
            Funcoes.AtivarPainel(this, panel_GerenciarResponsaveis);
        }

        private void btn_CadResponsavel_Click(object sender, EventArgs e)
        {
            Funcoes.AtivarPainel(this, panel_CadastrarResponsavel);
        }

        private void CarregarResponsaveis()
        {
            ResponsavelRepository rr = new ResponsavelRepository();
            var responsaveis = rr.PegarTodosResponsaveis();

            dgv_Dados.DataSource = responsaveis;

            if (dgv_Dados.Columns.Count > 0)
            {
                dgv_Dados.Columns["Id"]!.DisplayIndex = 0;
                dgv_Dados.Columns["Nome"]!.DisplayIndex = 1;
                dgv_Dados.Columns["Telefone"]!.DisplayIndex = 2;
                dgv_Dados.Columns["Cpf"]!.DisplayIndex = 3;

                dgv_Dados.Columns["Id"]!.HeaderText = "Codigo";
                dgv_Dados.Columns["Nome"]!.HeaderText = "Nome";
                dgv_Dados.Columns["Telefone"]!.HeaderText = "Telefone";
                dgv_Dados.Columns["cpf"]!.HeaderText = "Cpf";
            }

            foreach (DataGridViewRow row in dgv_Dados.Rows)
            {
                string cpfOriginal = row.Cells["cpf"]?.Value?.ToString() ?? string.Empty;
                if (!string.IsNullOrEmpty(cpfOriginal))
                    row.Cells["cpf"].Value = Funcoes.FormatarCPF(cpfOriginal);

                string telefoneOriginal = row.Cells["telefone"]?.Value?.ToString() ?? string.Empty;
                if (!string.IsNullOrEmpty(telefoneOriginal))
                    row.Cells["telefone"].Value = Funcoes.FormatarTelefone(telefoneOriginal);
            }
        }

        private void dgv_Dados_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv_Dados.SelectedRows.Count > 0) // Verifica se tem linha selecionada
            {
                DataGridViewRow row = dgv_Dados.SelectedRows[0]; // Pega a primeira selecionada
                string respCpf = row.Cells["cpf"].Value?.ToString() ?? string.Empty;

                Responsavel resp = new Responsavel { cpf = respCpf };

                ResponsavelRepository tr = new ResponsavelRepository();
                List<Aluno> alunos = tr.PegarAlunosPorResponsavel(resp);

                dgv_DadosAlunos.DataSource = alunos;

                string[] colunasVisiveis = { "id", "nome", "sexo", "cpf" };
                foreach (DataGridViewColumn column in dgv_DadosAlunos.Columns)
                {
                    column.Visible = colunasVisiveis.Contains(column.Name);
                }

                if (dgv_DadosAlunos.Columns.Count > 0)
                {
                    dgv_DadosAlunos.Columns["Id"]!.DisplayIndex = 0;
                    dgv_DadosAlunos.Columns["Nome"]!.DisplayIndex = 1;
                    dgv_DadosAlunos.Columns["Sexo"]!.DisplayIndex = 2;
                    dgv_DadosAlunos.Columns["Cpf"]!.DisplayIndex = 3;

                    dgv_DadosAlunos.Columns["Id"]!.HeaderText = "Codigo";
                    dgv_DadosAlunos.Columns["Nome"]!.HeaderText = "Nome";
                    dgv_DadosAlunos.Columns["Sexo"]!.HeaderText = "Sexo";
                    dgv_DadosAlunos.Columns["Cpf"]!.HeaderText = "CPF";
                }

                foreach (DataGridViewRow rows in dgv_DadosAlunos.Rows)
                {
                    string cpfOriginal = rows.Cells["cpf"]?.Value?.ToString() ?? string.Empty;
                    if (!string.IsNullOrEmpty(cpfOriginal))
                        rows.Cells["cpf"].Value = Funcoes.FormatarCPF(cpfOriginal);
                }
            }
        }
    }
}
