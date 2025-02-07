using Escola.Forms;
using Escola.Properties;
using System.Runtime;

namespace Escola
{
    public partial class F_Principal : Form
    {
        private Configs.AppSettings _settings = new Configs.AppSettings();

        public F_Principal()
        {
            InitializeComponent();
            SetarConfig(); // seta as configurações
        }

        private void SetarConfig()
        {
            _settings = Configs.CarregarConfiguracoes();
            this.Text = _settings.NomeEscola;
            if (!string.IsNullOrEmpty(_settings.FotoPrincipal) && File.Exists(_settings.FotoPrincipal))
            {
                pb_Principal.Image = Image.FromFile(_settings.FotoPrincipal);
            }
            else
            {
                pb_Principal.Image = null;
            }
        }

        private void cadastrarAlunoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_GerenciarAlunos ga = new F_GerenciarAlunos();
            ga.ShowDialog();
        }

        private void gerenciarProfessoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_GerenciarProfessores gp = new F_GerenciarProfessores();
            gp.ShowDialog();
        }

        private void configuraçõesToolStripMenuItem_Click(object sender, EventArgs e)
        {

            F_Configuracoes formConfiguracoes = new F_Configuracoes(pb_Principal);
            formConfiguracoes.ImagemAlterada += SetarConfig;
            formConfiguracoes.ShowDialog();
        }

        private void carteirinhaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_Carteirinha f_Carteirinha = new F_Carteirinha();
            f_Carteirinha.ShowDialog();
        }

        private void matricularToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_Matricular f_Matricular = new F_Matricular();
            f_Matricular.ShowDialog();
        }

        private void gerenciarTurmasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_GerenciarTurmas f_GerenciarTurmas = new F_GerenciarTurmas();
            f_GerenciarTurmas.ShowDialog();
        }
    }
}
