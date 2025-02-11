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

namespace Escola
{
    public partial class F_Carteirinha : Form
    {

        public F_Carteirinha()
        {
            InitializeComponent();
            CarregarFundo();
            ConfigurarFundoTexto();
        }

        private void F_Carteirinha_Load(object sender, EventArgs e)
        {
            cb_Tipo.SelectedIndex = 0;
        }

        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            mtb_CpfBuscar.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            string cpf = mtb_CpfBuscar.Text;

            if (!Funcoes.ValidarCPF(cpf)) return;

            int index = cb_Tipo.SelectedIndex;
            if (index == 0)
            {
                BuscarAluno(cpf);
            }
            else if (index == 1)
            {
                BuscarProfessor(cpf);
            }
            else
            {
                MessageBox.Show("Selecione a opcao que deseja gerar a carteirinha (Aluno/Professor)!");
                return;
            }
        }

        private void BuscarAluno(string cpf)
        {
            AlunoRepository repository = new AlunoRepository();
            Aluno? aluno = repository.BuscarAlunoPorCPF(cpf);

            if (aluno != null)
            {
                lbl_Nome.Text = aluno.nome;
                lbl_DataNasc.Text = Funcoes.FormatarData(aluno.dataNascimento);
                lbl_Sexo.Text = aluno.sexo;
                lbl_Codigo.Text = aluno.id.ToString();//Funcoes.FormatarCodigo(aluno.id);

                lbl_TextTurma.Text = "Turma:";
                lbl_Turma.Text = "101";
                lbl_TextSerie.Text = "Serie:";
                lbl_Serie.Text = "8º ANO";

                Funcoes.CarregarImagem(cpf, Global.TIPO_ALUNO, pb_FotoPerfil, true, pb_QrCode);
            }
            else
            {
                MessageBox.Show("Aluno não encontrado.");
            }
        }

        private void BuscarProfessor(string cpf)
        {
            ProfessorRepository repository = new ProfessorRepository();
            Professor? professor = repository.BuscarProfessorPorCPF(cpf);

            if (professor != null)
            {
                lbl_Nome.Text = professor.nome;
                lbl_DataNasc.Text = Funcoes.FormatarData(professor.dataNascimento);
                lbl_Sexo.Text = professor.sexo;
                lbl_Codigo.Text = professor.id.ToString();//Funcoes.FormatarCodigo(professor.id);
                lbl_TextTurma.Text = "Tipo:";
                lbl_Turma.Text = "Professor";
                lbl_TextSerie.Text = "";
                lbl_Serie.Text = "";
                Funcoes.CarregarImagem(cpf, Global.TIPO_PROFESSOR, pb_FotoPerfil, true, pb_QrCode);
            }
            else
            {
                MessageBox.Show("Professor não encontrado.");
            }
        }

        private void CarregarFundo()
        {
            Configs.AppSettings _settings = Configs.CarregarConfiguracoes();
            if (_settings.FundoCarteirinha != "")
            {
                pb_FundoCarteirinha.Image = Image.FromFile(_settings.FundoCarteirinha);
            }
            else
            {
                panel_Fundo.BackgroundImage = null;
            }
        }

        private void ConfigurarFundoTexto()
        {
            pb_FundoCarteirinha.Controls.Add(lbl_TextNome);
            pb_FundoCarteirinha.Controls.Add(lbl_TextCodigo);
            pb_FundoCarteirinha.Controls.Add(lbl_TextDataNasc);
            pb_FundoCarteirinha.Controls.Add(lbl_TextSexo);
            pb_FundoCarteirinha.Controls.Add(lbl_TextTurma);
            pb_FundoCarteirinha.Controls.Add(lbl_TextSerie);

            lbl_Nome.BackColor = Color.Transparent;
            lbl_DataNasc.BackColor = Color.Transparent;
            lbl_Sexo.BackColor = Color.Transparent;
            lbl_Turma.BackColor = Color.Transparent;
            lbl_Serie.BackColor = Color.Transparent;
            lbl_Codigo.BackColor = Color.Transparent;

            pb_FundoCarteirinha.Controls.Add(lbl_Nome);
            pb_FundoCarteirinha.Controls.Add(lbl_DataNasc);
            pb_FundoCarteirinha.Controls.Add(lbl_Sexo);
            pb_FundoCarteirinha.Controls.Add(lbl_Turma);
            pb_FundoCarteirinha.Controls.Add(lbl_Serie);
            pb_FundoCarteirinha.Controls.Add(lbl_Codigo);

            pb_FundoCarteirinha.Controls.Add(pb_QrCode);
        }

        private void F_Carteirinha_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (pb_FundoCarteirinha.Image != null)
            {
                pb_FundoCarteirinha.Image.Dispose(); 
                pb_FundoCarteirinha.Image = null;    
            }
            if (pb_FotoPerfil.Image != null)
            {
                pb_FotoPerfil.Image.Dispose();  
                pb_FotoPerfil.Image = null; 
            }
            if (pb_QrCode.Image != null)
            {
                pb_QrCode.Image.Dispose();
                pb_QrCode.Image = null;
            }
        }
    }
}
