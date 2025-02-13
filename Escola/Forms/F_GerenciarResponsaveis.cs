using Escola.Core;
using Escola.Core.Entities;
using Escola.Core.Repositories;
using Escola.Core.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
            cb_nacionalidade.SelectedIndex = 0;
            cb_SexoCad.SelectedIndex = 0;
            cb_CorRacaCad.SelectedIndex = 0;
            Funcoes.AtivarPainel(this, panel_CadastrarResponsavel);
        }

        private void CarregarResponsaveis()
        {
            ResponsavelRepository rr = new ResponsavelRepository();
            var responsaveis = rr.PegarTodosResponsaveis();

            dgv_Dados.DataSource = responsaveis;

            string[] colunasVisiveis = { "id", "nome", "telefone", "cpf" };
            foreach (DataGridViewColumn column in dgv_Dados.Columns)
            {
                column.Visible = colunasVisiveis.Contains(column.Name);
            }

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
                respCpf = respCpf.Replace(".", "").Replace("-", "");


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

        private void btn_AttProfessorG_Click(object sender, EventArgs e)
        {
            CarregarAttResponsaveis();
        }

        private void CarregarAttResponsaveis()
        {
            if (dgv_Dados.SelectedCells.Count > 0)
            {
                Funcoes.AtivarPainel(this, panel_AtualizarResponsaveis);

                DataGridViewRow row = dgv_Dados.SelectedRows[0];
                int id = Convert.ToInt32(row.Cells["id"].Value);
                string nome = row.Cells["Nome"].Value?.ToString() ?? string.Empty;
                string dataNasc = row.Cells["dataNascimento"].Value?.ToString() ?? string.Empty;
                string sexo = row.Cells["sexo"].Value?.ToString() ?? string.Empty;
                string cpf = row.Cells["cpf"].Value?.ToString() ?? string.Empty;
                string naturalidade = row.Cells["naturalidade"].Value?.ToString() ?? string.Empty;
                string nacionalidade = row.Cells["nacionalidade"].Value?.ToString() ?? string.Empty;
                string corraca = row.Cells["corraca"].Value?.ToString() ?? string.Empty;
                string endereco = row.Cells["endereco"].Value?.ToString() ?? string.Empty;
                string telefone = row.Cells["telefone"].Value?.ToString() ?? string.Empty;

                tb_NomeAtt.Text = nome;
                mtb_dataNascAtt.Text = dataNasc;
                cb_SexoAtt.Text = sexo;
                mtb_CpfAtt.Text = cpf;
                tb_NaturalidadeAtt.Text = naturalidade;
                cb_NacionalidadeAtt.Text = nacionalidade;
                cb_CorRacaAtt.Text = corraca;
                tb_EnderecoAtt.Text = endereco;
                mtb_TelefoneAtt.Text = telefone;

                mtb_CpfAtt.Enabled = false;
            }
            else
            {
                MessageBox.Show("Selecione uma responsavel para poder atualizar!");
                return;
            }
        }

        private void btn_CancelarAtualizarP_Click(object sender, EventArgs e)
        {
            LimparDadosAttResponsavel();
            Funcoes.AtivarPainel(this, panel_GerenciarResponsaveis);
        }

        private void LimparDadosAttResponsavel() // limpa os dados da atualização no form;
        {
            tb_NomeAtt.Clear();
            mtb_CpfAtt.Clear();
            mtb_dataNascAtt.Clear();
            cb_NacionalidadeAtt.SelectedIndex = 0;
            tb_NaturalidadeAtt.Clear();
            cb_SexoAtt.SelectedIndex = 0;
            cb_CorRacaAtt.SelectedIndex = 0;
            tb_EnderecoAtt.Clear();
            mtb_TelefoneAtt.Clear();
        }

        private void LimparCamposCadastro()
        {
            tb_NomeCad.Clear();
            mtb_CpfCad.Clear();
            mtb_DataNascCad.Clear();
            cb_nacionalidade.SelectedIndex = 0;
            tb_NaturalidadeCad.Clear();
            cb_SexoCad.SelectedIndex = 0;
            cb_CorRacaCad.SelectedIndex = 0;
            tb_EnderecoCad.Clear();
            mtb_TelefoneCad.Clear();
        }

        private void btn_CadResponsavelP_Click(object sender, EventArgs e)
        {
            CadastrarResponsavel();
        }

        private void CadastrarResponsavel()
        {
            string nome = tb_NomeCad.Text;
            mtb_DataNascCad.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            string dataNasc = mtb_DataNascCad.Text;
            mtb_CpfCad.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            string cpf = mtb_CpfCad.Text;
            string nacionalidade = cb_nacionalidade.Text;
            string naturalidade = tb_NaturalidadeCad.Text;
            string sexo = cb_SexoCad.Text;
            string corraca = cb_CorRacaCad.Text;
            mtb_TelefoneCad.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            string telefone = mtb_TelefoneCad.Text;
            string endereco = tb_EnderecoCad.Text;

            if (!Funcoes.VerificarStrings("Preencha todos os dados para poder cadastrar um Responsavel!", nome, dataNasc, cpf, nacionalidade, naturalidade, sexo, corraca, telefone, endereco)) return;
            if (!Funcoes.ValidarData(dataNasc)) return;

            Responsavel r = new Responsavel
            {
                nome = nome,
                dataNascimento = dataNasc,
                cpf = cpf,
                nacionalidade = nacionalidade,
                naturalidade = naturalidade,
                sexo = sexo,
                corraca = corraca,
                telefone = telefone,
                endereco = endereco
            };

            ResponsavelRepository rr = new ResponsavelRepository();
            bool sucesso = rr.CadResponsavel(r);
            if (sucesso)
            {
                MessageBox.Show("Responsavel Cadastrado!");
                LimparCamposCadastro();
                CarregarResponsaveis();
                Funcoes.AtivarPainel(this, panel_GerenciarResponsaveis);
            }
            else
            {
                MessageBox.Show("Erro ao cadastrar responsavel.");
                return;
            }

        }

        private void btn_AtualizarRespP_Click(object sender, EventArgs e)
        {
            mtb_CpfAtt.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            string cpf = mtb_CpfAtt.Text;
            mtb_dataNascAtt.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            string dataNasc = mtb_dataNascAtt.Text;
            string nome = tb_NomeAtt.Text;
            string nacionalidade = cb_NacionalidadeAtt.Text;
            string naturalidade = tb_NaturalidadeAtt.Text;
            string endereco = tb_EnderecoAtt.Text;
            string sexo = cb_SexoAtt.Text;
            string cor = cb_CorRacaAtt.Text;
            mtb_TelefoneAtt.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            string telefone = mtb_TelefoneAtt.Text;

            if (!Funcoes.VerificarStrings("Preencha todos os dados para poder atualizar o Responsavel!", nome, dataNasc, cpf, nacionalidade, naturalidade, sexo, cor, telefone, endereco)) return;
            if (!Funcoes.ValidarTelefone(telefone)) return;
            if (!Funcoes.ValidarData(dataNasc)) return;

            Responsavel responsavel = new Responsavel
            {
                nome = nome,
                cpf = cpf,
                telefone = telefone,
                dataNascimento = dataNasc,
                nacionalidade = nacionalidade,
                naturalidade = naturalidade,
                sexo = sexo,
                corraca = cor,
                endereco = endereco
            };

            ResponsavelRepository rr = new ResponsavelRepository();
            bool sucesso = rr.AttResponsavel(responsavel); // atualiza o responsavel

            if (sucesso)
            {
                MessageBox.Show("Responsavel atualizado com sucesso.");
                LimparDadosAttResponsavel();
                CarregarResponsaveis();
                Funcoes.AtivarPainel(this, panel_GerenciarResponsaveis);
            }
            else
            {
                MessageBox.Show("Erro ao atualizar responsavel.");
                return;
            }
        }

        private void btn_DeletarProfessor_Click(object sender, EventArgs e)
        {
            DeletarResponsavel();
        }

        private void DeletarResponsavel()
        {
            if (dgv_Dados.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgv_Dados.SelectedRows[0];
                string cpf = row.Cells["cpf"].Value?.ToString() ?? string.Empty;

                DialogResult resultado = MessageBox.Show($"Deseja realmente deletar o responsavel de CPF: {cpf}", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                cpf = cpf.Replace(".", "").Replace("-", "");
                Debug.WriteLine($"Cpf responsavel a ser deletado: {cpf}");
                if (resultado == DialogResult.Yes)
                {
                    Responsavel r = new Responsavel
                    {
                        cpf = cpf
                    };

                    ResponsavelRepository rr = new ResponsavelRepository();
                    bool sucesso = rr.DelResponsavel(r);
                    if (sucesso)
                    {
                        MessageBox.Show("Responsavel deletado!");
                        CarregarResponsaveis();
                    }
                    else
                    {
                        MessageBox.Show("Erro ao deletar responsavel");
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Voce cancelou!");
                    return;
                }
            }
            else
            {
                MessageBox.Show("Selecione um responsavel para poder deletar!");
                return;
            }
        }
    }
}
