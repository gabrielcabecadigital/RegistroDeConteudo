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
using Models;
using System.IO;
using Newtonsoft.Json;

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
            txtCodigo.Text = "0";
            txtCodigo.Focus();
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

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Categoria categor = new Categoria();
            categor.Id = Convert.ToInt32(txtCodigo.Text);
            categor.Titulo = txtCategoria.Text;
            string caminho = Path.Combine(Application.StartupPath, "arquivos");
            if (!Directory.Exists(caminho))
                Directory.CreateDirectory(caminho);
            caminho = Path.Combine(caminho, "categoria.txt");
            string json = JsonConvert.SerializeObject(categor);
            var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(json);
            json = System.Convert.ToBase64String(plainTextBytes);
            File.WriteAllText(caminho, json);
            this.Dispose();
        }

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (int) Keys.Enter)
            {
                int id;
                try
                {
                    id = int.Parse(txtCodigo.Text);
                }
                catch
                {
                    id = 0;
                }
                if (id <= 0)
                {

                    txtCategoria.Text = string.Empty;
                    txtCategoria.Enabled = false;
                    txtCodigo.Text = "0";
                    txtCodigo.Focus();
                }
                else
                {
                    txtCategoria.Enabled = true;
                    txtCategoria.Focus();
                }
            }
        }
    }
}
