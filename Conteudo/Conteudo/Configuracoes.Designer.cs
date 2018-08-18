namespace Conteudo
{
    partial class Configuracoes
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.informacao = new System.Windows.Forms.TextBox();
            this.data = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tabela = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.tabela)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(138, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Data";
            // 
            // informacao
            // 
            this.informacao.Location = new System.Drawing.Point(193, 81);
            this.informacao.Name = "informacao";
            this.informacao.Size = new System.Drawing.Size(292, 22);
            this.informacao.TabIndex = 1;
            // 
            // data
            // 
            this.data.Location = new System.Drawing.Point(193, 38);
            this.data.Mask = "00/00/0000";
            this.data.Name = "data";
            this.data.Size = new System.Drawing.Size(292, 22);
            this.data.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(98, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Informação";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(193, 123);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Salvar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabela
            // 
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.tabela.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.tabela.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabela.Location = new System.Drawing.Point(28, 203);
            this.tabela.Name = "tabela";
            this.tabela.RowTemplate.Height = 24;
            this.tabela.Size = new System.Drawing.Size(771, 344);
            this.tabela.TabIndex = 5;
            this.tabela.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tabela_CellContentClick);
            this.tabela.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tabela_KeyDown);
            // 
            // Configuracoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 574);
            this.Controls.Add(this.tabela);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.data);
            this.Controls.Add(this.informacao);
            this.Controls.Add(this.label1);
            this.Name = "Configuracoes";
            this.Text = "Configuracoes";
            this.Load += new System.EventHandler(this.Configuracoes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tabela)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox informacao;
        private System.Windows.Forms.MaskedTextBox data;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView tabela;
    }
}