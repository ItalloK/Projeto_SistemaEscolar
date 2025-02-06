using Escola.Classes;
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
    public partial class GerenciarAlunos : Form
    {

        private string fotoPath = string.Empty;

        public GerenciarAlunos()
        {
            InitializeComponent();
            AtivarPainel(Panel_Gerenciar);
        }


        private void AtivarPainel(Panel p)
        {
            Panel_Gerenciar.Visible = false;
            Panel_CadAluno.Visible = false;
            p.Visible = true;
            p.Location = new Point(0, 0);
        }

        private void btn_CadAlunoGerenciador_Click(object sender, EventArgs e)
        {
            AtivarPainel(Panel_CadAluno);
            cb_nacionalidade.SelectedIndex = 0;
            cb_CorAlunoCad.SelectedIndex = 0;
            cb_SexoAlunoCad.SelectedIndex = 0;
        }

        private void btn_CancelarCadastro_Click(object sender, EventArgs e)
        {
            AtivarPainel(Panel_Gerenciar);
        }

        private void btn_CarregarFoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Imagens|*.png;",
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

            if (string.IsNullOrWhiteSpace(cpf) || string.IsNullOrEmpty(dataNasc) || string.IsNullOrEmpty(nome)
                || string.IsNullOrWhiteSpace(naturalidade) || string.IsNullOrWhiteSpace(nacionalidade) || string.IsNullOrWhiteSpace(endereco)
                || string.IsNullOrWhiteSpace(sexo) || string.IsNullOrWhiteSpace(cor))
            {
                MessageBox.Show("Preencha todos os dados para poder cadastrar o ALUNO.");
                return;
            }

            /* por aqui uma verificação para ver se o responsavel ja esta cadastrado, se não tiver
               utilizar a função de cadastrar o responsavel*/

            if (!CadastrarResponsavel())
            {
                return;
            }

            Aluno aluno = new Aluno(nome, cpf, dataNasc, nacionalidade, naturalidade, sexo, cor, endereco);
            aluno.CadAluno();
            QrCode.GerarQRcode(cpf, Global.TIPO_ALUNO);
            SalvarFoto(cpf);

            this.Close();
        }

        private bool CadastrarResponsavel()
        {
            string nome = tb_NomeResponsavel.Text;
            mtb_CpfResponsavel.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            string cpf = mtb_CpfResponsavel.Text;
            mtb_TelResponsavel.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            string telefone = mtb_TelResponsavel.Text;
            if (nome == "" || cpf == "" || telefone == "")
            {
                MessageBox.Show("Não é possivel cadastrar um aluno sem responsavel, digite os dados!");
                return false;
            }
            if(cpf.Length != 11)
            {
                MessageBox.Show("Digite corretamente os 11 digitos do CPF do responsavel.");
                return false;
            }

            Responsavel r = new Responsavel(nome, cpf, telefone);
            r.CadResponsavel();
            return true;
        }

        private void SalvarFoto(string cpf)
        {
            if (string.IsNullOrWhiteSpace(fotoPath) || !File.Exists(fotoPath))
            {
                MessageBox.Show("Por favor, carregue uma foto antes de salvar.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string pastaDestino = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Fotos", "Alunos");
            if (!Directory.Exists(pastaDestino))
            {
                Directory.CreateDirectory(pastaDestino);
            }

            string extensao = Path.GetExtension(fotoPath);
            string novoCaminho = Path.Combine(pastaDestino, $"{cpf}{extensao}");
            try
            {
                File.Copy(fotoPath, novoCaminho, true);
                Console.WriteLine("Foto salva com sucesso!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao salvar a foto: {ex.Message}");
                return;
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
            if(cpf.Length != 11)
            {
                MessageBox.Show("Digite os 11 digitos do CPF do responsavel para poder pesquisar.");
                return;
            }



        }
    }
}
