using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace Conteudo
{
    public partial class frmConsultaConteudos : MetroForm
    {
        public frmConsultaConteudos()
        {
            InitializeComponent();
        }

        private void mbtnNovo_Click(object sender, EventArgs e)
        {
            frmCadastroConteudo novoform = new frmCadastroConteudo();
            novoform.Show();
        }

        private void mbtnSair_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
