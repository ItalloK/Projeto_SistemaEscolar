using System;
using System.Windows.Forms;

namespace Escola
{
    public partial class Configuracoes : Form
    {
        private Config.AppSettings _settings = new Config.AppSettings();
        public event Action OnConfiguracoesConfirmadas = delegate { };

        public Configuracoes()
        {
            InitializeComponent();
            _settings = Config.CarregarConfiguracoes();
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
                Config.SalvarConfiguracoes(_settings);
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
