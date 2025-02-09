using Escola.Core;
using Escola.Core.Entities;
using Escola.Core.Interfaces;
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

namespace Escola
{
    public partial class F_GerenciarProfessores : Form
    {
        private string fotoPath = string.Empty;

        public F_GerenciarProfessores()
        {
            InitializeComponent();
            AtivarPainel(panel_GerenciarProfessores);
            cb_nacionalidade.SelectedIndex = 0;
            cb_CorProfessorCad.SelectedIndex = 0;
            cb_SexoProfessorCad.SelectedIndex = 0;
        }

        private void AtivarPainel(Panel p)
        {
            panel_GerenciarProfessores.Visible = false;
            panel_CadProfessor.Visible = false;
            p.Visible = true;
            p.Location = new Point(0, 0);
        }

        private void btn_CadProfessor_Click(object sender, EventArgs e)
        {
            AtivarPainel(panel_CadProfessor);
        }

        private void btn_CancelarCadastro_Click(object sender, EventArgs e)
        {
            AtivarPainel(panel_GerenciarProfessores);
        }

        private void btn_CarregarFoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Imagens|*.png; *.jpg; *.jpeg;",
                Title = "Selecione uma foto"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                fotoPath = openFileDialog.FileName;
                pb_FotoProfessor.ImageLocation = fotoPath;
            }
        }

        private void btn_CadastrarAluno_Click(object sender, EventArgs e)
        {
            CadastrarProfessor();
        }

        private void CadastrarProfessor()
        {
            mtb_CpfProfessorCad.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            string cpf = mtb_CpfProfessorCad.Text;
            mtb_DataNascCad.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            string dataNasc = mtb_DataNascCad.Text;
            string nome = tb_NomeProfessorCad.Text;
            string nacionalidade = cb_nacionalidade.Text;
            string naturalidade = tb_NaturalidadeProfessorCad.Text;
            string endereco = tb_EnderecoProfessorCad.Text;
            string sexo = cb_SexoProfessorCad.Text;
            string cor = cb_CorProfessorCad.Text;

            mtb_TelefoneProfessorCad.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            string telefone = mtb_TelefoneProfessorCad.Text;

            if (string.IsNullOrWhiteSpace(cpf) || string.IsNullOrEmpty(dataNasc) || string.IsNullOrEmpty(nome)
                || string.IsNullOrWhiteSpace(naturalidade) || string.IsNullOrWhiteSpace(nacionalidade) || string.IsNullOrWhiteSpace(endereco)
                || string.IsNullOrWhiteSpace(sexo) || string.IsNullOrWhiteSpace(cor) || string.IsNullOrEmpty(telefone))
            {
                MessageBox.Show("Preencha todos os dados para poder cadastrar o PROFESSOR.");
                return;
            }

            if (!Funcoes.ValidarData(dataNasc)) return;
            if (!Funcoes.VerificarSeCarregouFoto(fotoPath)) return;

            if (telefone.Length != 11)
            {
                MessageBox.Show("Digite corretamente o telefone!");
                return;
            }

            Professor professor = new Professor
            {
                nome = nome,
                cpf = cpf,
                dataNascimento = dataNasc,
                nacionalidade = nacionalidade,
                naturalidade = naturalidade,
                sexo = sexo,
                corraca = cor,
                endereco = endereco,
                telefone = telefone
            };
            ProfessorRepository repository = new ProfessorRepository();

            bool sucesso = repository.CadProfessor(professor); // cadastra o professor
            if (sucesso)
            {
                MessageBox.Show("Professor cadastrado com sucesso.");
                QrCode.GerarQRcode(cpf, Global.TIPO_PROFESSOR); // gerar qrCode
                Funcoes.SalvarFoto(cpf, fotoPath, Global.TIPO_PROFESSOR); // salvar foto na pasta do professor
                LimparCamposCadastro();
                CarregarProfessores();
                AtivarPainel(panel_GerenciarProfessores);
            }
            else
            {
                MessageBox.Show("Erro ao cadastrar professor.");
                return;
            }
        }

        private void LimparCamposCadastro()
        {
            tb_NomeProfessorCad.Clear();
            pb_FotoProfessor.Image = null;
            fotoPath = string.Empty;
            mtb_DataNascCad.Clear();
            mtb_CpfProfessorCad.Clear();
            cb_nacionalidade.SelectedIndex = 0;
            tb_NaturalidadeProfessorCad.Clear();
            cb_SexoProfessorCad.SelectedIndex = 0;
            cb_CorProfessorCad.SelectedIndex = 0;
            mtb_TelefoneProfessorCad.Clear();
            tb_EnderecoProfessorCad.Clear();
        }

        private void F_GerenciarProfessores_Load(object sender, EventArgs e)
        {
            CarregarProfessores();
        }

        private void CarregarProfessores()
        {
            ProfessorRepository pr = new ProfessorRepository();
            var listProf = pr.PegarTodosProfessores();

            dgv_Dados.DataSource = listProf;

            string[] colunasVisiveis = { "id", "nome", "sexo", "telefone", "cpf" };
            foreach (DataGridViewColumn column in dgv_Dados.Columns)
            {
                column.Visible = colunasVisiveis.Contains(column.Name);
            }

            if (dgv_Dados.Columns.Count > 0)
            {
                dgv_Dados.Columns["Id"]!.DisplayIndex = 0;
                dgv_Dados.Columns["Nome"]!.DisplayIndex = 1;
                dgv_Dados.Columns["Sexo"]!.DisplayIndex = 2;
                dgv_Dados.Columns["Telefone"]!.DisplayIndex = 3; 
                dgv_Dados.Columns["Cpf"]!.DisplayIndex = 4;


                dgv_Dados.Columns["Id"]!.HeaderText = "Codigo";
                dgv_Dados.Columns["Nome"]!.HeaderText = "Nome";
                dgv_Dados.Columns["Sexo"]!.HeaderText = "Sexo";
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

        private void btn_DeletarProfessor_Click(object sender, EventArgs e)
        {
            DeletarProfessor();
        }

        private void DeletarProfessor()
        {
            if (dgv_Dados.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgv_Dados.SelectedRows[0];
                string cpf = row.Cells["cpf"].Value?.ToString() ?? string.Empty;

                DialogResult resultado = MessageBox.Show($"Deseja realmente deletar o professor de CPF: {cpf}", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                cpf = cpf.Replace(".", "").Replace("-", "");

                if (resultado == DialogResult.Yes)
                {
                    Professor p = new Professor
                    {
                        cpf = cpf
                    };

                    ProfessorRepository pr = new ProfessorRepository();
                    bool sucesso = pr.DelProfessor(p);

                    if (sucesso)
                    {
                        Funcoes.DeletarFoto(cpf, Global.TIPO_PROFESSOR);
                        MessageBox.Show("Professor deletado!");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Erro ao deletar professor");
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
                MessageBox.Show("Selecione um professor para poder deletar!");
                return;
            }
        }
    }
}
