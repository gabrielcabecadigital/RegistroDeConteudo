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
            }

            if (!Consiste_String(mtxtTitulo.Text))
            {
                MessageBox.Show("Informe o título do Conteúdo!");
            }

            if (!Consiste_String(mcbxCategoria.Text))
            {
                MessageBox.Show("Informe a categoria do Conteúdo!");
            }

            Models.Conteudo conteudo = new Models.Conteudo();
            conteudo.Id = Convert.ToInt32(mtxtId.Text);
            conteudo.Titulo = mtxtTitulo.Text;
            conteudo.IdCat = Convert.ToInt32(mcbxCategoria.Text);
            conteudo.Texto = mtxtTexto.Text;     
        }

        private void mtxtId_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                mcbxCategoria.Items.Add("1".ToString());
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
            }
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

        private void frmCadastroConteudo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
            }
        }

        private void mbtnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mbtnLimpar_Click(object sender, EventArgs e)
        {
            mtxtId.Text = "";
            mtxtTitulo.Text = "";
            mcbxCategoria.Text = "";
            mtxtTexto.Text = "";
            mcbxCategoria.Items.Clear();
        }

    }
}
