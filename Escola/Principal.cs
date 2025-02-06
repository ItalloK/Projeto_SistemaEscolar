using Escola.Properties;
using System.Runtime;

namespace Escola
{
    public partial class Principal : Form
    {
        private Configs.AppSettings _settings = new Configs.AppSettings();

        public Principal()
        {
            InitializeComponent();
            SetarConfig(); // seta as configurações
        }

        private void SetarConfig()
        {
            _settings = Configs.CarregarConfiguracoes();
            this.Text = _settings.NomeEscola;
        }

        private void cadastrarAlunoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GerenciarAlunos ga = new GerenciarAlunos();
            ga.ShowDialog();
        }

        private void gerenciarProfessoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GerenciarProfessores gp = new GerenciarProfessores();
            gp.ShowDialog();
        }

        private void configuraçõesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Configuracoes config = new Configuracoes();
            config.OnConfiguracoesConfirmadas += SetarConfig;
            config.ShowDialog();
        }

        private void carteirinhaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_Carteirinha f_Carteirinha = new F_Carteirinha();
            f_Carteirinha.ShowDialog();
        }
    }
}
