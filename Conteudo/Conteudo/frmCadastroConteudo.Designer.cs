namespace Conteudo
{
    partial class frmCadastroConteudo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.mtxtId = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.mtxtTitulo = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.mcbxCategoria = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.mtxtTexto = new MetroFramework.Controls.MetroTextBox();
            this.mbtnSalvar = new MetroFramework.Controls.MetroButton();
            this.mbtnSair = new MetroFramework.Controls.MetroButton();
            this.mbtnLimpar = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(23, 87);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(21, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "ID";
            // 
            // mtxtId
            // 
            this.mtxtId.Location = new System.Drawing.Point(71, 87);
            this.mtxtId.Name = "mtxtId";
            this.mtxtId.Size = new System.Drawing.Size(75, 23);
            this.mtxtId.TabIndex = 1;
            this.mtxtId.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mtxtId_KeyDown);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(23, 125);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(41, 19);
            this.metroLabel2.TabIndex = 2;
            this.metroLabel2.Text = "Título";
            // 
            // mtxtTitulo
            // 
            this.mtxtTitulo.Location = new System.Drawing.Point(71, 120);
            this.mtxtTitulo.Name = "mtxtTitulo";
            this.mtxtTitulo.Size = new System.Drawing.Size(706, 23);
            this.mtxtTitulo.TabIndex = 3;
            this.mtxtTitulo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mtxtTitulo_KeyDown);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(23, 161);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(67, 19);
            this.metroLabel3.TabIndex = 4;
            this.metroLabel3.Text = "Categoria";
            // 
            // mcbxCategoria
            // 
            this.mcbxCategoria.FormattingEnabled = true;
            this.mcbxCategoria.ItemHeight = 23;
            this.mcbxCategoria.Location = new System.Drawing.Point(96, 151);
            this.mcbxCategoria.Name = "mcbxCategoria";
            this.mcbxCategoria.Size = new System.Drawing.Size(291, 29);
            this.mcbxCategoria.TabIndex = 5;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(23, 201);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(39, 19);
            this.metroLabel4.TabIndex = 6;
            this.metroLabel4.Text = "Texto";
            // 
            // mtxtTexto
            // 
            this.mtxtTexto.Location = new System.Drawing.Point(71, 197);
            this.mtxtTexto.Multiline = true;
            this.mtxtTexto.Name = "mtxtTexto";
            this.mtxtTexto.Size = new System.Drawing.Size(706, 132);
            this.mtxtTexto.TabIndex = 7;
            // 
            // mbtnSalvar
            // 
            this.mbtnSalvar.Location = new System.Drawing.Point(322, 404);
            this.mbtnSalvar.Name = "mbtnSalvar";
            this.mbtnSalvar.Size = new System.Drawing.Size(75, 23);
            this.mbtnSalvar.TabIndex = 8;
            this.mbtnSalvar.Text = "Salvar";
            this.mbtnSalvar.Click += new System.EventHandler(this.mbtnSalvar_Click);
            // 
            // mbtnSair
            // 
            this.mbtnSair.Location = new System.Drawing.Point(508, 404);
            this.mbtnSair.Name = "mbtnSair";
            this.mbtnSair.Size = new System.Drawing.Size(75, 23);
            this.mbtnSair.TabIndex = 10;
            this.mbtnSair.Text = "Sair";
            this.mbtnSair.Click += new System.EventHandler(this.mbtnSair_Click);
            // 
            // mbtnLimpar
            // 
            this.mbtnLimpar.Location = new System.Drawing.Point(414, 404);
            this.mbtnLimpar.Name = "mbtnLimpar";
            this.mbtnLimpar.Size = new System.Drawing.Size(75, 23);
            this.mbtnLimpar.TabIndex = 9;
            this.mbtnLimpar.Text = "Limpar";
            this.mbtnLimpar.Click += new System.EventHandler(this.mbtnLimpar_Click);
            // 
            // frmCadastroConteudo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mbtnLimpar);
            this.Controls.Add(this.mbtnSair);
            this.Controls.Add(this.mbtnSalvar);
            this.Controls.Add(this.mtxtTexto);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.mcbxCategoria);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.mtxtTitulo);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.mtxtId);
            this.Controls.Add(this.metroLabel1);
            this.Name = "frmCadastroConteudo";
            this.Text = "Conteúdo";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmCadastroConteudo_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox mtxtId;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox mtxtTitulo;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroComboBox mcbxCategoria;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox mtxtTexto;
        private MetroFramework.Controls.MetroButton mbtnSalvar;
        private MetroFramework.Controls.MetroButton mbtnSair;
        private MetroFramework.Controls.MetroButton mbtnLimpar;
    }
}