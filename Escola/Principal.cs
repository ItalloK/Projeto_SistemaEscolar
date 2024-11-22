namespace Escola
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
            AtualizarTitulo();

            Global.NomeEscolaChanged += (s, e) => AtualizarTitulo();
        }

        private void AtualizarTitulo()
        {
            this.Text = $"Escola: {Global.NomeEscola}";
        }

        private void cadastrarAlunoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void gerenciarProfessoresToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void configuraçõesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Configuracoes config = new Configuracoes();
            config.ShowDialog();
        }
    }
}
