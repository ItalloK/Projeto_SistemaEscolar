using System;
using System.Windows.Forms;

namespace Escola
{
    public partial class F_Configuracoes : Form
    {
        private Configs.AppSettings _settings = new Configs.AppSettings();
        public event Action OnConfiguracoesConfirmadas = delegate { };

        public F_Configuracoes()
        {
            InitializeComponent();
            _settings = Configs.CarregarConfiguracoes();
            tb_NomeEscola.Text = _settings.NomeEscola;
        }

        private void btn_ConfirmAlteracoes_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tb_NomeEscola.Text))
            {
                MessageBox.Show("O nome da escola não pode estar vazio.");
                return;
            }
            _settings.NomeEscola = tb_NomeEscola.Text;
            try
            {
                Configs.SalvarConfiguracoes(_settings);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao salvar configurações: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            OnConfiguracoesConfirmadas?.Invoke();
            MessageBox.Show("As configurações foram salvas com sucesso.", "Configuração Atualizada", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}
