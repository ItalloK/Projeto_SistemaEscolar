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

namespace Escola.Forms
{
    public partial class F_GerenciarTurmas : Form
    {

        public F_GerenciarTurmas()
        {
            InitializeComponent();
            Funcoes.AtivarPainel(this, panel_GerenciarTurmas);
            //AtivarPainel(panel_GerenciarTurmas);
            CarregarPropriedadesCadTurma(); // carrega as propriedas do form de cadastro de turma
            CarregarPropriedadesAttTurma(); // carrega as propriedades do form de att da turma.
        }

        /*private void AtivarPainel(Panel p)
        {
            panel_GerenciarTurmas.Visible = false;
            panel_CadTurma.Visible = false;
            panel_AtualizarTurma.Visible = false;
            p.Visible = true;
            p.Location = new Point(0, 0);
        }*/

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

        private void CarregarPropriedadesAttTurma()
        {
            for (int i = 0; i < 9; i++)
            {
                int numero = i + 1;
                string texto = numero + " ano";
                cb_EscSerieAtt.Items.Add(new KeyValuePair<int, string>(numero, texto));
            }
            cb_EscSerieAtt.DisplayMember = "Value";
            cb_EscSerieAtt.ValueMember = "Key";
            cb_EscSerieAtt.SelectedIndex = 0;


            cb_EscTipoAtt.Items.Add("Fundamental");
            cb_EscTipoAtt.Items.Add("Medio");
            cb_EscTipoAtt.SelectedIndex = 0;


            cb_EscTurnoAtt.Items.Add("Matutino");
            cb_EscTurnoAtt.Items.Add("Vespertino");
            cb_EscTurnoAtt.Items.Add("Noturno");
            cb_EscTurnoAtt.SelectedIndex = 0;


            for (int i = 0; i < 50; i++)
            {
                int numero = i + 1;
                string texto = numero + (numero == 1 ? " aluno" : " alunos");

                cb_EscMaxAlunosAtt.Items.Add(new KeyValuePair<int, string>(numero, texto));
            }
            cb_EscMaxAlunosAtt.DisplayMember = "Value";
            cb_EscMaxAlunosAtt.ValueMember = "Key";
            cb_EscMaxAlunosAtt.SelectedIndex = 0;
        }

        private void F_GerenciarTurmas_Load(object sender, EventArgs e)
        {
            Funcoes.AtivarPainel(this, panel_GerenciarTurmas);
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

        private void btn_CadAlunoGerenciador_Click(object sender, EventArgs e)
        {
            Funcoes.AtivarPainel(this, panel_CadTurma);
            //AtivarPainel(panel_CadTurma);
        }

        private void btn_CancelarCadTurma_Click(object sender, EventArgs e)
        {
            Funcoes.AtivarPainel(this, panel_GerenciarTurmas);
            //AtivarPainel(panel_GerenciarTurmas);
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

            if (valorSerie > 3 && tipo == "Medio")
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
            if (sucesso)
            {
                MessageBox.Show("Turma cadastrada!");
                LimparCadTela();
                Funcoes.AtivarPainel(this, panel_GerenciarTurmas);
                //AtivarPainel(panel_GerenciarTurmas);
                CarregarDados();
            }
            else
            {
                MessageBox.Show("Turma não cadastrada!");
                return;
            }
        }

        private void LimparCadTela()
        {
            cb_EscSerie.SelectedIndex = 0;
            cb_EscMaxAluno.SelectedIndex = 0;
            cb_EscTipo.SelectedIndex = 0;
            cb_EscTurno.SelectedIndex = 0;
        }

        private void btn_EditarTurma_Click(object sender, EventArgs e)
        {
            ConfiguraAtualizarTurma();
        }

        private void ConfiguraAtualizarTurma() // configura a tela de atualizacao de turma
        {
            if (dgv_Dados.SelectedRows.Count > 0)
            {
                Funcoes.AtivarPainel(this, panel_AtualizarTurma);
                //AtivarPainel(panel_AtualizarTurma);

                DataGridViewRow row = dgv_Dados.SelectedRows[0];
                int turma = Convert.ToInt32(row.Cells["id"].Value);
                string tipo = row.Cells["tipo"].Value?.ToString() ?? string.Empty;
                string turno = row.Cells["turno"].Value?.ToString() ?? string.Empty;

                int maxAlunos = Convert.ToInt32(row.Cells["maxAlunos"].Value);
                int serie = Convert.ToInt32(row.Cells["serie"].Value);

                lbl_TextAttTurma.Text = $"Atualizar Turma: {turma}";
                cb_EscSerieAtt.SelectedIndex = serie - 1;
                cb_EscMaxAlunosAtt.SelectedIndex = maxAlunos - 1;
                cb_EscTurnoAtt.SelectedItem = turno;
                cb_EscTipoAtt.SelectedItem = tipo;
            }
            else
            {
                MessageBox.Show("Selecione uma turma para poder atualizar!");
                return;
            }
        }

        private void LimparTelaAtualizarTurma() // apaga todos os campos onde tem os dados para atualização
        {

        }

        private void btn_CancelarAttTurmaPanel_Click(object sender, EventArgs e)
        {
            Funcoes.AtivarPainel(this, panel_GerenciarTurmas);
            //AtivarPainel(panel_GerenciarTurmas);
            LimparTelaAtualizarTurma();
        }

        private void btn_AttTurmaPanel_Click(object sender, EventArgs e)
        {
            AtualizarTurma();
        }

        private void AtualizarTurma()
        {
            DataGridViewRow row = dgv_Dados.SelectedRows[0];
            int turma = Convert.ToInt32(row.Cells["id"].Value);

            string tipoAtt = cb_EscTipoAtt.Text;
            string turnoAtt = cb_EscTurnoAtt.Text;
            int serieAtt = cb_EscSerieAtt.SelectedIndex + 1;
            int maxAlunosAtt = cb_EscMaxAlunosAtt.SelectedIndex + 1;

            Turma t = new Turma
            {
                id = turma,
                turno = turnoAtt,
                tipo = tipoAtt,
                serie = serieAtt.ToString(),
                maxAlunos = maxAlunosAtt
            };
            TurmasRepository tr = new TurmasRepository();
            bool sucesso = tr.AttTurma(t);
            if (sucesso)
            {
                MessageBox.Show("Turma atualizada!");
                LimparAttTela();
                Funcoes.AtivarPainel(this, panel_GerenciarTurmas);
                //AtivarPainel(panel_GerenciarTurmas);
                CarregarDados();
            }
            else
            {
                MessageBox.Show("Erro ao atualizar turma!");
                return;
            }
        }
        private void LimparAttTela()
        {
            cb_EscSerieAtt.SelectedIndex = 0;
            cb_EscMaxAlunosAtt.SelectedIndex = 0;
            cb_EscTipoAtt.SelectedIndex = 0;
            cb_EscTurnoAtt.SelectedIndex = 0;
        }
        private void btn_DeletarTurma_Click(object sender, EventArgs e)
        {
            DeletarTurma();
        }

        private void DeletarTurma()
        {
            if (dgv_Dados.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgv_Dados.SelectedRows[0];
                int turma = Convert.ToInt32(row.Cells["id"].Value);

                DialogResult resultado = MessageBox.Show($"Deseja realmente deletar a turma: {turma}", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resultado == DialogResult.Yes)
                {
                    Turma t = new Turma
                    {
                        id = turma
                    };

                    TurmasRepository tr = new TurmasRepository();
                    bool sucesso = tr.DelTurma(t);
                    if (sucesso)
                    {
                        MessageBox.Show("Turma deletada!");
                        CarregarDados();
                    }
                    else
                    {
                        MessageBox.Show("Erro ao deletar turma");
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
                MessageBox.Show("Selecione uma turma para poder deletar!");
                return;
            }
        }
    }
}
