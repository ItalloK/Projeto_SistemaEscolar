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
            cb_nacionalidade.SelectedIndex = 0;
            cb_CorProfessorCad.SelectedIndex = 0;
            cb_SexoProfessorCad.SelectedIndex = 0;
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

            if (string.IsNullOrWhiteSpace(cpf) || string.IsNullOrEmpty(dataNasc) || string.IsNullOrEmpty(nome)
                || string.IsNullOrWhiteSpace(naturalidade) || string.IsNullOrWhiteSpace(nacionalidade) || string.IsNullOrWhiteSpace(endereco)
                || string.IsNullOrWhiteSpace(sexo) || string.IsNullOrWhiteSpace(cor))
            {
                MessageBox.Show("Preencha todos os dados para poder cadastrar o PROFESSOR.");
                return;
            }

            if (!Funcoes.VerificarSeCarregouFoto(fotoPath)) return;

            Professor professor = new Professor
            {
                nome = nome,
                cpf = cpf,
                dataNascimento = dataNasc,
                nacionalidade = nacionalidade,
                naturalidade = naturalidade,
                sexo = sexo,
                corraca = cor,
                endereco = endereco
            };
            ProfessorRepository repository = new ProfessorRepository();

            bool sucesso = repository.CadProfessor(professor); // cadastra o professor
            if (sucesso)
            {
                MessageBox.Show("Professor cadastrado com sucesso.");
                QrCode.GerarQRcode(cpf, Global.TIPO_PROFESSOR); // gerar qrCode
                Funcoes.SalvarFoto(cpf, fotoPath, Global.TIPO_PROFESSOR); // salvar foto na pasta do professor
                this.Close();
            }
            else
            {
                MessageBox.Show("Erro ao cadastrar professor.");
                return;
            }
        }
    }
}
