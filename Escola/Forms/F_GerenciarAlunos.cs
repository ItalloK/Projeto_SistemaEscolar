﻿using Escola.Core;
using Escola.Core.Entities;
using Escola.Core.Infrastructure;
using Escola.Core.Interfaces;
using Escola.Core.Repositories;
using Escola.Core.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Escola
{
    public partial class F_GerenciarAlunos : Form
    {

        private string fotoPath = string.Empty;
        private string fotoPathAtt = string.Empty;

        public F_GerenciarAlunos()
        {
            InitializeComponent();
            cb_nacionalidade.SelectedIndex = 0;
            cb_CorAlunoCad.SelectedIndex = 0;
            cb_SexoAlunoCad.SelectedIndex = 0;
        }

        private void btn_CadAlunoGerenciador_Click(object sender, EventArgs e)
        {
            Funcoes.AtivarPainel(this, Panel_CadAluno);
        }

        private void btn_CancelarCadastro_Click(object sender, EventArgs e)
        {
            LimparCamposCadastro();
            Funcoes.AtivarPainel(this, Panel_Gerenciar);
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
                pb_FotoAluno.ImageLocation = fotoPath;
            }
        }

        private void btn_CadastrarAluno_Click(object sender, EventArgs e)
        {
            CadastrarAluno();
        }

        private void CadastrarAluno()
        {
            mtb_CpfAlunoCad.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            string cpf = mtb_CpfAlunoCad.Text;
            mtb_DataNascCad.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            string dataNasc = mtb_DataNascCad.Text;
            string nome = tb_NomeAlunoCad.Text;
            string nacionalidade = cb_nacionalidade.Text;
            string naturalidade = tb_NaturalidadeAlunoCad.Text;
            string endereco = tb_EnderecoAlunoCad.Text;
            string sexo = cb_SexoAlunoCad.Text;
            string cor = cb_CorAlunoCad.Text;

            if (!Funcoes.VerificarStrings("Preencha todos os dados para poder cadastrar o Aluno!", cpf, dataNasc, nome, naturalidade, nacionalidade, endereco, sexo, cor)) return;
            if (!Funcoes.ValidarData(dataNasc)) return;
            if (!Funcoes.ValidarCPF(cpf)) return;
            if (!Funcoes.VerificarSeCarregouFoto(fotoPath)) return;

            /**/

            string nomeRes = tb_NomeResponsavel.Text;
            mtb_CpfResponsavel.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            string cpfRes = mtb_CpfResponsavel.Text;
            mtb_TelResponsavel.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            string telefoneRes = mtb_TelResponsavel.Text;


            if (nomeRes == "" || cpfRes == "" || telefoneRes == "")
            {
                MessageBox.Show("Não é possivel cadastrar um aluno sem responsavel, digite os dados!");
                return;
            }

            Responsavel responsavel = new Responsavel
            {
                nome = nomeRes,
                cpf = cpfRes,
                telefone = telefoneRes
            };

            if (!VerificarSeResponsavelTaCadastrado(responsavel)) // verifica se ja ta cadastrado o responsavel
            {
                if (!CadastrarResponsavel(responsavel)) // tenta cadastrar o responsavel
                {
                    return;
                }
            }

            Aluno aluno = new Aluno
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
            AlunoRepository repository = new AlunoRepository();
            bool sucesso = repository.CadAlunoComResponsavel(aluno, responsavel); // cadastra o aluno

            if (sucesso)
            {
                MessageBox.Show("Aluno cadastrado com sucesso.");
                QrCode.GerarQRcode(cpf, Global.TIPO_ALUNO);
                Funcoes.SalvarFoto(cpf, fotoPath, Global.TIPO_ALUNO); // salvar foto na pasta do professor
                LimparCamposCadastro();
                CarregarAlunos();
                Funcoes.AtivarPainel(this, Panel_Gerenciar);
            }
            else
            {
                MessageBox.Show("Erro ao cadastrar aluno.");
                return;
            }
        }
        private void LimparCamposCadastro()
        {
            tb_NomeAlunoCad.Clear();
            pb_FotoAluno.Image = null;
            fotoPath = string.Empty;
            mtb_DataNascCad.Clear();
            mtb_CpfAlunoCad.Clear();
            cb_nacionalidade.SelectedIndex = 0;
            tb_NaturalidadeAlunoCad.Clear();
            cb_SexoAlunoCad.SelectedIndex = 0;
            cb_CorAlunoCad.SelectedIndex = 0;
            tb_EnderecoAlunoCad.Clear();

            mtb_BuscarCPFResp.Clear();
            tb_NomeResponsavel.Clear();
            mtb_CpfResponsavel.Clear();
            mtb_TelResponsavel.Clear();
        }
        private bool CadastrarResponsavel(Responsavel r)
        {
            if (!Funcoes.ValidarCPF(r.cpf)) return false;
            ResponsavelRepository rr = new ResponsavelRepository();
            bool sucesso = rr.CadResponsavel(r);
            if (sucesso)
            {
                MessageBox.Show("Responsavel cadastrado!");
                return true;
            }
            else
            {
                MessageBox.Show("Responsavel não cadastrado!");
                return false;
            }
        }

        private void btn_BuscarResponsavel_Click(object sender, EventArgs e)
        {
            BuscarResponsavel();
        }

        private void BuscarResponsavel()
        {
            mtb_BuscarCPFResp.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            string cpf = mtb_BuscarCPFResp.Text;
            if (!Funcoes.ValidarCPF(cpf)) return;

            ResponsavelRepository rr = new ResponsavelRepository();
            var res = rr.PegarResponsavel(cpf);

            if (res != null)
            {
                int idRes = res.id;
                string nomeRes = res.nome;
                string telefoneRes = res.telefone;
                string cpfRes = res.cpf;
                tb_NomeResponsavel.Text = nomeRes;
                mtb_CpfResponsavel.Text = cpfRes;
                mtb_TelResponsavel.Text = telefoneRes;
                MessageBox.Show("Responsavel encontrado.");
            }
            else
            {
                MessageBox.Show("Responsavel não encontrado!");
                return;
            }
        }

        private void F_GerenciarAlunos_Load(object sender, EventArgs e)
        {
            Funcoes.AtivarPainel(this, Panel_Gerenciar); // qualquer coisa
            CarregarAlunos();
        }

        private void CarregarAlunos()
        {
            AlunoRepository ar = new AlunoRepository();
            var alunos = ar.PegarTodosAlunos();

            dgv_Dados.DataSource = alunos;

            if (dgv_Dados.Columns.Count > 0) // Verifica se as colunas foram geradas
            {
                string[] colunasVisiveis = { "id", "nome", "sexo", "dataNascimento", "cpf" };
                foreach (DataGridViewColumn column in dgv_Dados.Columns)
                {
                    column.Visible = colunasVisiveis.Contains(column.Name);
                }

                dgv_Dados.Columns["id"]!.DisplayIndex = 0;
                dgv_Dados.Columns["nome"]!.DisplayIndex = 1;
                dgv_Dados.Columns["dataNascimento"]!.DisplayIndex = 2;
                dgv_Dados.Columns["sexo"]!.DisplayIndex = 3;
                dgv_Dados.Columns["cpf"]!.DisplayIndex = 4;

                dgv_Dados.Columns["id"]!.HeaderText = "Codigo";
                dgv_Dados.Columns["nome"]!.HeaderText = "Nome";
                dgv_Dados.Columns["dataNascimento"]!.HeaderText = "Data de Nascimento";
                dgv_Dados.Columns["sexo"]!.HeaderText = "Sexo";
                dgv_Dados.Columns["cpf"]!.HeaderText = "CPF";
            }

            foreach (DataGridViewRow row in dgv_Dados.Rows)
            {
                string dataNascOriginal = row.Cells["dataNascimento"]?.Value?.ToString() ?? string.Empty;
                string cpfOriginal = row.Cells["cpf"]?.Value?.ToString() ?? string.Empty;

                if (!string.IsNullOrEmpty(dataNascOriginal))
                    row.Cells["dataNascimento"].Value = Funcoes.FormatarData(dataNascOriginal);
                if (!string.IsNullOrEmpty(cpfOriginal))
                    row.Cells["cpf"].Value = Funcoes.FormatarCPF(cpfOriginal);
            }
        }


        private bool VerificarSeResponsavelTaCadastrado(Responsavel r)
        {
            ResponsavelRepository rr = new ResponsavelRepository();
            bool sucesso = rr.VerificarResponsavel(r);
            if (sucesso)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void dgv_Dados_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv_Dados.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgv_Dados.SelectedRows[0];
                string alunoCpf = row.Cells["cpf"].Value?.ToString() ?? string.Empty;
                alunoCpf = alunoCpf.Replace(".", "").Replace("-", ""); // remove a formatação do CPF antes de procurar o responsavel

                Aluno alunoSelecionado = new Aluno { cpf = alunoCpf };

                ResponsavelRepository rr = new ResponsavelRepository();
                var responsavel = rr.PegarResponsaveisPorAluno(alunoSelecionado);

                dgv_Responsavel.DataSource = responsavel;

                string[] colunasVisiveis = { "id", "nome", "telefone" };
                foreach (DataGridViewColumn column in dgv_Responsavel.Columns)
                {
                    column.Visible = colunasVisiveis.Contains(column.Name);
                }

                if (dgv_Responsavel.Columns.Count > 0)
                {
                    dgv_Responsavel.Columns["Id"]!.DisplayIndex = 0;
                    dgv_Responsavel.Columns["Nome"]!.DisplayIndex = 1;
                    dgv_Responsavel.Columns["Telefone"]!.DisplayIndex = 2;

                    dgv_Responsavel.Columns["Id"]!.HeaderText = "Codigo";
                    dgv_Responsavel.Columns["Nome"]!.HeaderText = "Nome";
                    dgv_Responsavel.Columns["Telefone"]!.HeaderText = "Telefone";
                }
            }
        }

        private void btn_BuscarAlunoG_Click(object sender, EventArgs e)
        {

        }

        private void btn_DeletarAlunoG_Click(object sender, EventArgs e)
        {
            DeletarAluno();
        }

        private void DeletarAluno()
        {
            if (dgv_Dados.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgv_Dados.SelectedRows[0];
                string cpf = row.Cells["cpf"].Value?.ToString() ?? string.Empty;

                DialogResult resultado = MessageBox.Show($"Deseja realmente deletar o aluno de CPF: {cpf}", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                cpf = cpf.Replace(".", "").Replace("-", "");
                Debug.WriteLine($"Cpf aluno a ser deletado: {cpf}");
                if (resultado == DialogResult.Yes)
                {
                    Aluno a = new Aluno
                    {
                        cpf = cpf
                    };

                    AlunoRepository ar = new AlunoRepository();
                    bool sucesso = ar.DelAluno(a);
                    if (sucesso)
                    {
                        Funcoes.DeletarFoto(cpf, Global.TIPO_ALUNO);
                        MessageBox.Show("Aluno deletado!");
                        CarregarAlunos();
                    }
                    else
                    {
                        MessageBox.Show("Erro ao deletar aluno");
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
                MessageBox.Show("Selecione um aluno para poder deletar!");
                return;
            }
        }

        private void btn_AtualizarAlunoG_Click(object sender, EventArgs e)
        {
            ConfigurarAtualizarAluno();
        }

        private void ConfigurarAtualizarAluno() // configura o ambiente de atualizacao do aluno
        {
            if (dgv_Dados.SelectedRows.Count > 0)
            {
                Funcoes.AtivarPainel(this, panel_AtualizarAluno);

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

                tb_NomeAlunoAtt.Text = nome;
                mtb_DataNascAlunoAtt.Text = dataNasc;
                cb_SexoAlunoAtt.Text = sexo;
                mtb_CpfAlunoAtt.Text = cpf;
                tb_NaturalidadeAlunoAtt.Text = naturalidade;
                cb_NacionalidadeAlunoAtt.Text = nacionalidade;
                cb_CorRacaAlunoAtt.Text = corraca;
                tb_EnderecoAlunoAtt.Text = endereco;

                mtb_CpfAlunoAtt.Enabled = false;

                mtb_CpfAlunoAtt.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                string CPFF = mtb_CpfAlunoAtt.Text;

                Funcoes.CarregarImagem(CPFF, Global.TIPO_ALUNO, pb_FotoAlunoAtt, false, null);
            }
            else
            {
                MessageBox.Show("Selecione uma aluno para poder atualizar!");
                return;
            }
        }

        private void btn_CancelarAtualizacaoAluno_Click(object sender, EventArgs e)
        {
            LimparCamposAtualizacao();
            Funcoes.AtivarPainel(this, Panel_Gerenciar);
            //AtivarPainel(Panel_Gerenciar);
        }

        private void LimparCamposAtualizacao()
        {
            tb_NomeAlunoAtt.Clear();
            pb_FotoAlunoAtt.Image = null;
            fotoPath = string.Empty;

            mtb_DataNascAlunoAtt.Clear();
            mtb_CpfAlunoAtt.Clear();
            cb_NacionalidadeAlunoAtt.SelectedIndex = 0;
            tb_NaturalidadeAlunoAtt.Clear();
            cb_SexoAlunoAtt.SelectedIndex = 0;
            cb_CorRacaAlunoAtt.SelectedIndex = 0;
            tb_EnderecoAlunoAtt.Clear();
        }

        private void btn_CarregarImagemAlunoAtt_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Imagens|*.png; *.jpg; *.jpeg;",
                Title = "Selecione uma foto"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                fotoPathAtt = openFileDialog.FileName;
                pb_FotoAlunoAtt.ImageLocation = fotoPathAtt;
            }
        }

        private void btn_AttAluno_Click(object sender, EventArgs e)
        {
            mtb_CpfAlunoAtt.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            string cpf = mtb_CpfAlunoAtt.Text;
            mtb_DataNascAlunoAtt.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            string dataNasc = mtb_DataNascAlunoAtt.Text;
            string nome = tb_NomeAlunoAtt.Text;
            string nacionalidade = cb_NacionalidadeAlunoAtt.Text;
            string naturalidade = tb_NaturalidadeAlunoAtt.Text;
            string endereco = tb_EnderecoAlunoAtt.Text;
            string sexo = cb_SexoAlunoAtt.Text;
            string cor = cb_CorRacaAlunoAtt.Text;

            if (!Funcoes.VerificarStrings("Preencha todos os dados para poder atualizar o Aluno!", cpf, dataNasc, nome, naturalidade, nacionalidade, endereco, sexo, cor)) return;
            if (!Funcoes.ValidarData(dataNasc)) return;

            Aluno aluno = new Aluno
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

            AlunoRepository repository = new AlunoRepository();
            bool sucesso = repository.AttAluno(aluno); // atualiza o aluno

            if (sucesso)
            {
                MessageBox.Show("Aluno atualizado com sucesso.");                
                Funcoes.SalvarFoto(cpf, fotoPathAtt, Global.TIPO_ALUNO); // salvar foto na pasta do professor
                pb_FotoAlunoAtt.Image = null;
                LimparCamposAtualizacao();
                CarregarAlunos();
                Funcoes.AtivarPainel(this, Panel_Gerenciar);
            }
            else
            {
                MessageBox.Show("Erro ao atualizar aluno.");
                return;
            }
        }
    }
}
