using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Escola
{
    public partial class Configuracoes : Form
    {
        public Configuracoes()
        {
            InitializeComponent();
            tb_NomeEscola.Text = Global.NomeEscola;
        }

        private void btn_ConfirmAlteracoes_Click(object sender, EventArgs e)
        {
            Global.NomeEscola = tb_NomeEscola.Text;
            MessageBox.Show("Configurações alteradas!");
            this.Close();
        }
    }
}
