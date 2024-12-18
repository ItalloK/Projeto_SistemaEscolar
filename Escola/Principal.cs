using Escola.Properties;
using System.Runtime;

namespace Escola
{
    public partial class Principal : Form
    {
        private Config.AppSettings _settings = new Config.AppSettings();

        public Principal()
        {
            InitializeComponent();
            SetarConfig(); // seta as configurações
        }

        private void SetarConfig()
        {
            _settings = Config.CarregarConfiguracoes();
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
    }
}
