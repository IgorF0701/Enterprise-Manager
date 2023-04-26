namespace Enterprise_Manager
{
    partial class storage
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.listaEstoque = new System.Windows.Forms.DataGridView();
            this.IDESTOQUE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOMEPRODUTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VALORINICIAL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VALORVENDA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VALIDADE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CATEGORIA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GRAMAS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.rb_Produto = new System.Windows.Forms.RadioButton();
            this.rb_Categoria = new System.Windows.Forms.RadioButton();
            this.txt_Pesquisar = new System.Windows.Forms.TextBox();
            this.btn_Pesquisar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.listaEstoque)).BeginInit();
            this.SuspendLayout();
            // 
            // listaEstoque
            // 
            this.listaEstoque.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.listaEstoque.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listaEstoque.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDESTOQUE,
            this.NOMEPRODUTO,
            this.VALORINICIAL,
            this.VALORVENDA,
            this.VALIDADE,
            this.CATEGORIA,
            this.GRAMAS});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.NullValue = null;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.listaEstoque.DefaultCellStyle = dataGridViewCellStyle4;
            this.listaEstoque.Location = new System.Drawing.Point(12, 137);
            this.listaEstoque.Name = "listaEstoque";
            this.listaEstoque.ReadOnly = true;
            this.listaEstoque.Size = new System.Drawing.Size(1139, 282);
            this.listaEstoque.TabIndex = 0;
            // 
            // IDESTOQUE
            // 
            this.IDESTOQUE.FillWeight = 20F;
            this.IDESTOQUE.HeaderText = "ID";
            this.IDESTOQUE.Name = "IDESTOQUE";
            this.IDESTOQUE.ReadOnly = true;
            // 
            // NOMEPRODUTO
            // 
            this.NOMEPRODUTO.HeaderText = "Produto";
            this.NOMEPRODUTO.Name = "NOMEPRODUTO";
            this.NOMEPRODUTO.ReadOnly = true;
            // 
            // VALORINICIAL
            // 
            dataGridViewCellStyle1.Format = "C2";
            dataGridViewCellStyle1.NullValue = null;
            this.VALORINICIAL.DefaultCellStyle = dataGridViewCellStyle1;
            this.VALORINICIAL.FillWeight = 30F;
            this.VALORINICIAL.HeaderText = "Valor Inicial";
            this.VALORINICIAL.Name = "VALORINICIAL";
            this.VALORINICIAL.ReadOnly = true;
            // 
            // VALORVENDA
            // 
            dataGridViewCellStyle2.Format = "C2";
            dataGridViewCellStyle2.NullValue = null;
            this.VALORVENDA.DefaultCellStyle = dataGridViewCellStyle2;
            this.VALORVENDA.FillWeight = 30F;
            this.VALORVENDA.HeaderText = "Valor Venda";
            this.VALORVENDA.Name = "VALORVENDA";
            this.VALORVENDA.ReadOnly = true;
            // 
            // VALIDADE
            // 
            this.VALIDADE.FillWeight = 50F;
            this.VALIDADE.HeaderText = "Validade";
            this.VALIDADE.Name = "VALIDADE";
            this.VALIDADE.ReadOnly = true;
            // 
            // CATEGORIA
            // 
            this.CATEGORIA.HeaderText = "Categoria";
            this.CATEGORIA.Name = "CATEGORIA";
            this.CATEGORIA.ReadOnly = true;
            // 
            // GRAMAS
            // 
            dataGridViewCellStyle3.Format = "000g";
            dataGridViewCellStyle3.NullValue = null;
            this.GRAMAS.DefaultCellStyle = dataGridViewCellStyle3;
            this.GRAMAS.FillWeight = 40F;
            this.GRAMAS.HeaderText = "Gramas";
            this.GRAMAS.Name = "GRAMAS";
            this.GRAMAS.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Pesquisar por:";
            // 
            // rb_Produto
            // 
            this.rb_Produto.AutoSize = true;
            this.rb_Produto.Checked = true;
            this.rb_Produto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_Produto.Location = new System.Drawing.Point(128, 21);
            this.rb_Produto.Name = "rb_Produto";
            this.rb_Produto.Size = new System.Drawing.Size(83, 24);
            this.rb_Produto.TabIndex = 2;
            this.rb_Produto.TabStop = true;
            this.rb_Produto.Text = "Produto";
            this.rb_Produto.UseVisualStyleBackColor = true;
            // 
            // rb_Categoria
            // 
            this.rb_Categoria.AutoSize = true;
            this.rb_Categoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_Categoria.Location = new System.Drawing.Point(235, 21);
            this.rb_Categoria.Name = "rb_Categoria";
            this.rb_Categoria.Size = new System.Drawing.Size(96, 24);
            this.rb_Categoria.TabIndex = 3;
            this.rb_Categoria.Text = "Categoria";
            this.rb_Categoria.UseVisualStyleBackColor = true;
            // 
            // txt_Pesquisar
            // 
            this.txt_Pesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Pesquisar.Location = new System.Drawing.Point(16, 51);
            this.txt_Pesquisar.Name = "txt_Pesquisar";
            this.txt_Pesquisar.Size = new System.Drawing.Size(243, 26);
            this.txt_Pesquisar.TabIndex = 4;
            // 
            // btn_Pesquisar
            // 
            this.btn_Pesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Pesquisar.Location = new System.Drawing.Point(16, 83);
            this.btn_Pesquisar.Name = "btn_Pesquisar";
            this.btn_Pesquisar.Size = new System.Drawing.Size(97, 29);
            this.btn_Pesquisar.TabIndex = 5;
            this.btn_Pesquisar.Text = "Pesquisar";
            this.btn_Pesquisar.UseVisualStyleBackColor = true;
            this.btn_Pesquisar.Click += new System.EventHandler(this.btn_Pesquisar_Click);
            // 
            // storage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1163, 457);
            this.Controls.Add(this.btn_Pesquisar);
            this.Controls.Add(this.txt_Pesquisar);
            this.Controls.Add(this.rb_Categoria);
            this.Controls.Add(this.rb_Produto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listaEstoque);
            this.Name = "storage";
            this.Text = "Storage";
            this.Load += new System.EventHandler(this.storage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.listaEstoque)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rb_Produto;
        private System.Windows.Forms.RadioButton rb_Categoria;
        private System.Windows.Forms.TextBox txt_Pesquisar;
        private System.Windows.Forms.Button btn_Pesquisar;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDESTOQUE;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOMEPRODUTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn VALORINICIAL;
        private System.Windows.Forms.DataGridViewTextBoxColumn VALORVENDA;
        private System.Windows.Forms.DataGridViewTextBoxColumn VALIDADE;
        private System.Windows.Forms.DataGridViewTextBoxColumn CATEGORIA;
        private System.Windows.Forms.DataGridViewTextBoxColumn GRAMAS;
        public System.Windows.Forms.DataGridView listaEstoque;
    }
}