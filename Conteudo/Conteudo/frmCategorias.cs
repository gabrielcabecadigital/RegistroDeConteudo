﻿using System;
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
    public partial class frmCategorias : MetroForm
    {
        public frmCategorias()
        {
            InitializeComponent();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            frmCategoria novo = new frmCategoria();
            novo.Show();
        }

        private void frmCategorias_Load(object sender, EventArgs e)
        {
           
        }
    }
}
