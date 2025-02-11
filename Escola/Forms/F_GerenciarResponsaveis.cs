using Escola.Core.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Escola.Forms
{
    public partial class F_GerenciarResponsaveis : Form
    {
        public F_GerenciarResponsaveis()
        {
            InitializeComponent();
        }

        private void F_GerenciarResponsaveis_Load(object sender, EventArgs e)
        {
            Funcoes.AtivarPainel(this, panel_GerenciarResponsaveis);
        }

        private void btn_CancelarCadResponsavelP_Click(object sender, EventArgs e)
        {
            Funcoes.AtivarPainel(this, panel_GerenciarResponsaveis);
        }

        private void btn_CadResponsavel_Click(object sender, EventArgs e)
        {
            Funcoes.AtivarPainel(this, panel_CadastrarResponsavel);
        }
    }
}
