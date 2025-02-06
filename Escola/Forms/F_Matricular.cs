using Escola.Core.Entities;
using Escola.Core.Interfaces;
using Escola.Core.Repositories;
using Escola.Core.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Escola.Forms
{
    public partial class F_Matricular : Form
    {
        private int idAluno = -1;

        public F_Matricular()
        {
            InitializeComponent();
            cb_Turmas.Enabled = false; // desativa para não poder ser alterado caso não haja turmas
            CarregarTurmas();
        }

        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            mtb_CpfBuscar.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            string cpf = mtb_CpfBuscar.Text;

            if (!Funcoes.ValidarCPF(cpf)) return;

            BuscarAluno(cpf);
        }

        private void BuscarAluno(string cpf)
        {
            AlunoRepository a = new AlunoRepository();
            Aluno? aluno = a.BuscarAlunoPorCPF(cpf);
            if (aluno != null)
            {
                idAluno = aluno.id; // seta o ID do aluno na variavel global ao achar o aluno.
                lbl_NomeAluno.Text = aluno.nome;
                lbl_SexoAluno.Text = aluno.sexo;
                lbl_DataNascAluno.Text = Funcoes.FormatarData(aluno.dataNascimento);
            }
            else
            {
                MessageBox.Show("Aluno não encontrado!");
                return;
            }
        }

        private void CarregarTurmas()
        {
            TurmasRepository turmasRepository = new TurmasRepository();
            List<Turma>? turmas = turmasRepository.PegarTurmas();

            if (turmas == null || turmas.Count == 0)
            {
                MessageBox.Show("Não foram encontradas turmas.");
                return;
            }

            cb_Turmas.DataSource = turmas;

            cb_Turmas.DisplayMember = "id";
            cb_Turmas.Format += (sender, e) =>
            {
                if (e.Value != null)
                {
                    e.Value = "Turma: " + e.Value.ToString();  
                }
            };

            cb_Turmas.ValueMember = "id";
            cb_Turmas.SelectedIndex = 0;
            cb_Turmas.Enabled = true;
        }

        private void cb_Turmas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_Turmas.SelectedIndex >= 0)
            {
                Turma t = (Turma)cb_Turmas.SelectedItem;

                lbl_Turma.Text = t.id.ToString();

                lbl_Serie.Text = t.serie + "º Ano";
                lbl_Tipo.Text = t.tipo;
                lbl_Turno.Text = t.turno;
                lbl_MaxAlunos.Text = t.maxAlunos.ToString();
                lbl_QntAlunos.Text = t.quantidadeAlunos.ToString();
            }
        }

        private void btn_Matricular_Click(object sender, EventArgs e)
        {
            MatricularAluno();
        }

        private void MatricularAluno()
        {
            int turmaId = Convert.ToInt32(cb_Turmas.SelectedValue);
            mtb_CpfBuscar.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            string cpf = mtb_CpfBuscar.Text;

            if (!Funcoes.ValidarCPF(cpf)) return;
            
            if(idAluno == -1)
            {
                MessageBox.Show("Voce deve procurar o aluno antes de tentar matricular ele!");
                return;
            }

            int al, maxAl;
            al = Convert.ToInt32(lbl_QntAlunos.Text);
            maxAl = Convert.ToInt32(lbl_MaxAlunos.Text);
            if (al >= maxAl)
            {
                MessageBox.Show("Essa turma ja tem o maximo de alunos!");
                return;
            }

            Matricula m = new Matricula
            {
                aluno = new Aluno
                {
                    id = idAluno
                },
                turma = new Turma
                {
                    id = turmaId
                }
            };

            AlunoRepository alunoRepository = new AlunoRepository();
            if (!alunoRepository.VerificarAlunoMatriculado(m.aluno))
            {
                MessageBox.Show("Aluno ja está matriculado!");
                return;
            }

            MatriculaRepository matriculaRepository = new MatriculaRepository();
            matriculaRepository.MatricularAluno(m);

            this.Close();
        }
    }
}
