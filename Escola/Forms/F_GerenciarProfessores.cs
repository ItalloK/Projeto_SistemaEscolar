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
        private string fotoPathAtt = string.Empty;

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
            Panel_AtualizarProfessor.Visible = false;
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
                        CarregarProfessores();
                        //this.Close();
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

        private void btn_AttProfessorG_Click(object sender, EventArgs e)
        {
            ConfigurarAtualizarProfessor();
        }

        private void btn_CancelarAttProf_Click(object sender, EventArgs e)
        {
            LimparCamposAtualizacao();
            AtivarPainel(panel_GerenciarProfessores);
        }

        private void LimparCamposAtualizacao()
        {
            tb_NomeProfAtt.Clear();
            tb_EnderecoProfAtt.Clear();
            pb_FotoProfAtt.Image = null;
            fotoPathAtt = string.Empty;

            mtb_DataNascProfAtt.Clear();
            mtb_CpfProfAtt.Clear();
            cb_NacionalidadeProfAtt.SelectedIndex = 0;
            tb_NaturalidadeProfAtt.Clear();
            cb_SexoProfAtt.SelectedIndex = 0;
            cb_CorRacaProfAtt.SelectedIndex = 0;
            tb_EnderecoProfAtt.Clear();
        }

        private void ConfigurarAtualizarProfessor()
        {
            if (dgv_Dados.SelectedRows.Count > 0)
            {

                AtivarPainel(Panel_AtualizarProfessor);
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

                //Debug.Print($"Nome: {nome} | Data: {dataNasc} | Sexo: {sexo} | Cpf: {cpf} | Naturalidade: {naturalidade} | Nacionalidade: {nacionalidade} | Cor: {corraca} | Telefone: {telefone} | Endereco: {endereco}");

                tb_NomeProfAtt.Text = nome;
                mtb_CpfProfAtt.Text = cpf;
                mtb_DataNascProfAtt.Text = dataNasc;
                cb_SexoProfAtt.Text = sexo;
                cb_NacionalidadeProfAtt.Text = nacionalidade;
                tb_NaturalidadeProfAtt.Text = naturalidade;
                cb_CorRacaProfAtt.Text = corraca;
                mtb_TelProfAtt.Text = telefone;
                tb_EnderecoProfAtt.Text = endereco;

                mtb_CpfProfAtt.Enabled = false;

                mtb_CpfProfAtt.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                string CPFF = mtb_CpfProfAtt.Text;

                Funcoes.CarregarImagem(CPFF, Global.TIPO_PROFESSOR, pb_FotoProfAtt, false, null);
            }
            else
            {
                MessageBox.Show("Selecione uma professor para poder atualizar!");
                return;
            }
        }

        private void btn_AttProf_Click(object sender, EventArgs e)
        {
            mtb_CpfProfAtt.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            string cpf = mtb_CpfProfAtt.Text;
            mtb_DataNascProfAtt.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            string dataNasc = mtb_DataNascProfAtt.Text;
            string nome = tb_NomeProfAtt.Text;
            string nacionalidade = cb_NacionalidadeProfAtt.Text;
            string naturalidade = tb_NaturalidadeProfAtt.Text;
            string endereco = tb_EnderecoProfAtt.Text;
            string sexo = cb_SexoProfAtt.Text;
            string cor = cb_CorRacaProfAtt.Text;
            mtb_TelProfAtt.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            string telefone = mtb_TelProfAtt.Text;

            if (string.IsNullOrWhiteSpace(cpf) || string.IsNullOrEmpty(dataNasc) || string.IsNullOrEmpty(nome)
                || string.IsNullOrWhiteSpace(naturalidade) || string.IsNullOrWhiteSpace(nacionalidade) || string.IsNullOrWhiteSpace(endereco)
                || string.IsNullOrWhiteSpace(sexo) || string.IsNullOrWhiteSpace(cor) || string.IsNullOrWhiteSpace(telefone))
            {
                MessageBox.Show("Preencha todos os dados para poder atualizar o PROFESSOR!");
                return;
            }

            if (!Funcoes.ValidarData(dataNasc)) return;
            //if (!Funcoes.VerificarSeCarregouFoto(fotoPathAtt)) return;

            Professor professor = new Professor
            {
                nome = nome,
                telefone = telefone,
                cpf = cpf,
                dataNascimento = dataNasc,
                nacionalidade = nacionalidade,
                naturalidade = naturalidade,
                sexo = sexo,
                corraca = cor,
                endereco = endereco
            };

            ProfessorRepository repository = new ProfessorRepository();
            bool sucesso = repository.AttProfessor(professor); // atualiza o professor

            if (sucesso)
            {
                MessageBox.Show("Professor atualizado com sucesso.");
                Funcoes.SalvarFoto(cpf, fotoPathAtt, Global.TIPO_PROFESSOR); // salvar foto na pasta do professor
                pb_FotoProfAtt.Image = null;
                LimparCamposAtualizacao();
                CarregarProfessores();
                AtivarPainel(panel_GerenciarProfessores);
            }
            else
            {
                MessageBox.Show("Erro ao atualizar professor.");
                return;
            }
        }

        private void btn_CarregarFotoAtt_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Imagens|*.png; *.jpg; *.jpeg;",
                Title = "Selecione uma foto"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                fotoPathAtt = openFileDialog.FileName;
                pb_FotoProfAtt.ImageLocation = fotoPathAtt;
            }
        }
    }
}
