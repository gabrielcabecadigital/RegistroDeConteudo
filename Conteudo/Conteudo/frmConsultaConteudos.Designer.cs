namespace Conteudo
{
    partial class frmConsultaConteudos
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
            this.mbtnNovo = new MetroFramework.Controls.MetroButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.mbtnSair = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // mbtnNovo
            // 
            this.mbtnNovo.Location = new System.Drawing.Point(603, 30);
            this.mbtnNovo.Name = "mbtnNovo";
            this.mbtnNovo.Size = new System.Drawing.Size(75, 23);
            this.mbtnNovo.TabIndex = 0;
            this.mbtnNovo.Text = "Novo";
            this.mbtnNovo.Click += new System.EventHandler(this.mbtnNovo_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(23, 74);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(754, 353);
            this.dataGridView1.TabIndex = 1;
            // 
            // mbtnSair
            // 
            this.mbtnSair.Location = new System.Drawing.Point(702, 30);
            this.mbtnSair.Name = "mbtnSair";
            this.mbtnSair.Size = new System.Drawing.Size(75, 23);
            this.mbtnSair.TabIndex = 2;
            this.mbtnSair.Text = "Sair";
            this.mbtnSair.Click += new System.EventHandler(this.mbtnSair_Click);
            // 
            // frmConsultaConteudos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mbtnSair);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.mbtnNovo);
            this.Name = "frmConsultaConteudos";
            this.Text = "Conteúdos";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton mbtnNovo;
        private System.Windows.Forms.DataGridView dataGridView1;
        private MetroFramework.Controls.MetroButton mbtnSair;
    }
}