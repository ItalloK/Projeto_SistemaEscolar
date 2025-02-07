using Escola.Core;
using Escola.Core.Utils;
using System;
using System.Windows.Forms;

namespace Escola
{
    public partial class F_Configuracoes : Form
    {
        private string fotoPath = string.Empty;
        private string fundoCarteirinha = string.Empty;

        private Configs.AppSettings _settings = new Configs.AppSettings();
        public event Action OnConfiguracoesConfirmadas = delegate { };

        PictureBox pbb;
        public event Action ImagemAlterada;

        public F_Configuracoes(PictureBox pb)
        {
            InitializeComponent();
            _settings = Configs.CarregarConfiguracoes();
            tb_NomeEscola.Text = _settings.NomeEscola;
            pbb = pb;
        }

        private void btn_ConfirmAlteracoes_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tb_NomeEscola.Text))
            {
                MessageBox.Show("O nome da escola não pode estar vazio.");
                return;
            }

            if (pbb.Image != null)
            {
                pbb.Image.Dispose(); // Libera a imagem de fundo
                pbb.Image = null;    // Define a imagem como null
            }

            if (fotoPath != "")
            {
                Funcoes.SalvarFoto("Config", fotoPath, Global.TIPO_CONFIG);
                string extensao = Path.GetExtension(fotoPath);
                string pastaDestino = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Configuracoes", "Principal");
                string novoCaminho = Path.Combine(pastaDestino, $"Config{extensao}");
                _settings.FotoPrincipal = novoCaminho;
            }

            if (fundoCarteirinha != "")
            {
                Funcoes.SalvarFoto("Carteirinha", fundoCarteirinha, Global.TIPO_CARTEIRINHA);
                string extensao = Path.GetExtension(fundoCarteirinha);
                string pastaDestino = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Configuracoes", "Carteirinha");
                string novoCaminho = Path.Combine(pastaDestino, $"Carteirinha{extensao}");
                _settings.FundoCarteirinha = novoCaminho;
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
            ImagemAlterada?.Invoke();
            this.Close();
        }

        private void btn_CarregarTelaPrincipal_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Imagens|*.png; *.jpg; *.jpeg;",
                Title = "Selecione uma foto"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                fotoPath = openFileDialog.FileName;
                using (Image img = Image.FromFile(fotoPath))
                {
                    int minWidth = 800;  // largura minima
                    int minHeight = 400; // altura minima

                    if (img.Width >= minWidth && img.Height >= minHeight)
                    {
                        //MessageBox.Show("Imagem valida!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show($"A imagem deve ter pelo menos {minWidth} x {minHeight} pixels.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        fotoPath = "";
                    }
                }
            }
        }

        private void btn_FundoCarteirinha_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Imagens|*.png; *.jpg; *.jpeg;",
                Title = "Selecione uma foto"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                fundoCarteirinha = openFileDialog.FileName;
                using (Image img = Image.FromFile(fundoCarteirinha))
                {
                    int minWidth = 550;  // largura minima
                    int minHeight = 230; // altura minima

                    if (img.Width >= minWidth && img.Height >= minHeight)
                    {
                        //MessageBox.Show("Imagem valida!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show($"A imagem deve ter pelo menos {minWidth} x {minHeight} pixels.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        fundoCarteirinha = "";
                    }
                }
            }
        }
    }
}
