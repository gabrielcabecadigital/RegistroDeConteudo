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
    public partial class frmCategoria : MetroForm
    {
        public frmCategoria()
        {
            InitializeComponent();
        }

        private void Categoria_Load(object sender, EventArgs e)
        {
            txtCategoria.Enabled = false;
            btnSalvar.Enabled = false;
            txtCodigo.Focus();
        }

        private void txtCodigo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                int id;
                try
                {
                    id = int.Parse(txtCodigo.ToString());
                }
                catch
                {
                    id = 0;
                }
                if (id <= 0)
                {
                    MessageBox.Show("Código Inválido!");
                    txtCodigo.Clear();
                    txtCodigo.Focus();
                }
                else
                {
                    txtCategoria.Enabled = true;
                    txtCategoria.Focus();
                }
            }
        }

        private void txtCategoria_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                if (string.IsNullOrEmpty(txtCategoria.Text.Trim()))
                {
                    MessageBox.Show("Informar alguma descrição!");
                }
                else
                {
                    btnSalvar.Enabled = true;
                    btnSalvar.Focus();
                }
            }
        }
    }
}
