namespace Enterprise_Manager
{
    partial class SearchCostumer
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.text_precoInicial = new System.Windows.Forms.Button();
            this.txtCPFVenda = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.lista = new System.Windows.Forms.DataGridView();
            this.IDCLIENTE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GEN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EMAIL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CPF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TELEFONE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtNomeVenda = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lista)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pictureBox3);
            this.groupBox2.Controls.Add(this.text_precoInicial);
            this.groupBox2.Controls.Add(this.txtCPFVenda);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.lista);
            this.groupBox2.Controls.Add(this.txtNomeVenda);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(998, 486);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pesquisar Cliente";
            // 
            // pictureBox3
            // 
            this.pictureBox3.ImageLocation = "C:\\Curso\\Enterprise Manager\\Enterprise Manager\\images\\searchcostumer.png";
            this.pictureBox3.Location = new System.Drawing.Point(825, 14);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(157, 174);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 19;
            this.pictureBox3.TabStop = false;
            // 
            // text_precoInicial
            // 
            this.text_precoInicial.Location = new System.Drawing.Point(308, 140);
            this.text_precoInicial.Name = "text_precoInicial";
            this.text_precoInicial.Size = new System.Drawing.Size(149, 26);
            this.text_precoInicial.TabIndex = 17;
            this.text_precoInicial.Text = "Procurar Cliente";
            this.text_precoInicial.UseVisualStyleBackColor = true;
            this.text_precoInicial.Click += new System.EventHandler(this.text_precoInicial_Click);
            // 
            // txtCPFVenda
            // 
            this.txtCPFVenda.Location = new System.Drawing.Point(156, 93);
            this.txtCPFVenda.Name = "txtCPFVenda";
            this.txtCPFVenda.Size = new System.Drawing.Size(255, 26);
            this.txtCPFVenda.TabIndex = 16;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 99);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(40, 20);
            this.label14.TabIndex = 17;
            this.label14.Text = "CPF";
            // 
            // lista
            // 
            this.lista.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.lista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDCLIENTE,
            this.NOME,
            this.GEN,
            this.EMAIL,
            this.CPF,
            this.TELEFONE});
            this.lista.Location = new System.Drawing.Point(10, 194);
            this.lista.Name = "lista";
            this.lista.Size = new System.Drawing.Size(982, 261);
            this.lista.TabIndex = 16;
            // 
            // IDCLIENTE
            // 
            this.IDCLIENTE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.IDCLIENTE.HeaderText = "ID";
            this.IDCLIENTE.Name = "IDCLIENTE";
            this.IDCLIENTE.Width = 51;
            // 
            // NOME
            // 
            this.NOME.FillWeight = 108.7662F;
            this.NOME.HeaderText = "NOME";
            this.NOME.Name = "NOME";
            // 
            // GEN
            // 
            this.GEN.FillWeight = 64.93507F;
            this.GEN.HeaderText = "SEXO";
            this.GEN.Name = "GEN";
            // 
            // EMAIL
            // 
            this.EMAIL.FillWeight = 108.7662F;
            this.EMAIL.HeaderText = "EMAIL";
            this.EMAIL.Name = "EMAIL";
            // 
            // CPF
            // 
            this.CPF.FillWeight = 108.7662F;
            this.CPF.HeaderText = "CPF";
            this.CPF.Name = "CPF";
            // 
            // TELEFONE
            // 
            this.TELEFONE.FillWeight = 108.7662F;
            this.TELEFONE.HeaderText = "TELEFONE";
            this.TELEFONE.Name = "TELEFONE";
            // 
            // txtNomeVenda
            // 
            this.txtNomeVenda.Location = new System.Drawing.Point(156, 48);
            this.txtNomeVenda.Name = "txtNomeVenda";
            this.txtNomeVenda.Size = new System.Drawing.Size(255, 26);
            this.txtNomeVenda.TabIndex = 15;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 54);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(126, 20);
            this.label12.TabIndex = 2;
            this.label12.Text = "Nome do Cliente";
            // 
            // SearchCostumer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1035, 513);
            this.Controls.Add(this.groupBox2);
            this.Name = "SearchCostumer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Procurar Cliente";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lista)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button text_precoInicial;
        private System.Windows.Forms.TextBox txtCPFVenda;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DataGridView lista;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDCLIENTE;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOME;
        private System.Windows.Forms.DataGridViewTextBoxColumn GEN;
        private System.Windows.Forms.DataGridViewTextBoxColumn EMAIL;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPF;
        private System.Windows.Forms.DataGridViewTextBoxColumn TELEFONE;
        private System.Windows.Forms.TextBox txtNomeVenda;
        private System.Windows.Forms.Label label12;
    }
}