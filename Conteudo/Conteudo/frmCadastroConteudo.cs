using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using Models;
using Newtonsoft.Json;

namespace Conteudo
{
    public partial class frmCadastroConteudo : MetroForm
    {
        public frmCadastroConteudo()
        {
            InitializeComponent();
        }

        private void mbtnSalvar_Click(object sender, EventArgs e)
        {
            if (!Consiste_String(mtxtId.Text))
            {
                MessageBox.Show("Informe o código do Conteúdo!");
                return;
            }

            if (!Consiste_String(mtxtTitulo.Text))
            {
                MessageBox.Show("Informe o título do Conteúdo!");
                return;
            }

            if (!Consiste_String(mcbxCategoria.Text))
            {
                MessageBox.Show("Informe a categoria do Conteúdo!");
                return;
            }

            Models.Conteudo conteudo = new Models.Conteudo();
            conteudo.Id = Convert.ToInt32(mtxtId.Text);
            conteudo.Titulo = mtxtTitulo.Text;
            conteudo.IdCat = Convert.ToInt32(mcbxCategoria.Text);
            conteudo.Texto = mtxtTexto.Text;

            string caminho = Path.Combine(Application.StartupPath, "arquivos");
            if (!Directory.Exists(caminho))
                Directory.CreateDirectory(caminho);
            caminho = Path.Combine(caminho, "conteudo.txt");
            string json = JsonConvert.SerializeObject(conteudo);
            var base64 = System.Text.Encoding.UTF8.GetBytes(json);
            json = System.Convert.ToBase64String(base64);
            File.WriteAllText(caminho, json);
            MessageBox.Show("Conteúdo incluído com sucesso!");
            limpar();
            mtxtId.Focus();
        }

        private void mtxtTitulo_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                if (!Consiste_String(mtxtTitulo.Text))
                {
                    MessageBox.Show("Informe o título do Conteúdo!");
                }
                else
                {
                    this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
                }
            }
        }

        public static bool Consiste_String(string titulo)
        {
            if(string.IsNullOrEmpty(titulo.Trim()))
            {
                return false;
            }
            return true;
        }

        private void mbtnSair_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void mbtnLimpar_Click(object sender, EventArgs e)
        {
            limpar();
            mtxtId.Focus();
        }

        public void limpar()
        {
            mtxtId.Text = "";
            mtxtTitulo.Text = "";
            mcbxCategoria.Text = "";
            mtxtTexto.Text = "";
            mcbxCategoria.Items.Clear();
        }

        private void mtxtId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (int)Keys.Enter)
            {
                try
                {
                    int id = Convert.ToInt32(mtxtId.Text);
                    if (id == 0)
                    {
                        MessageBox.Show("Informe um código maior do que zeros");
                    }
                    else
                    {
                        mcbxCategoria.Items.Add("1".ToString());
                    }
                }
                catch
                {
                    MessageBox.Show("Informe um código válido!");
                }
            }
        }

        private void frmCadastroConteudo_KeyPress(object sender, KeyPressEventArgs e)
        {
          if (e.KeyChar == (int)Keys.Enter)
            {
                this.SelectNextControl(this.ActiveControl, true, true, true, true);
            }
            if(e.KeyChar == (int)Keys.Escape)
            {
                this.SelectNextControl(this.ActiveControl, false, true, true, true);
            }
        }
    }
}
