namespace Enterprise_Manager
{
    partial class SELLUnit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SELLUnit));
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtFormaPagamento = new System.Windows.Forms.ComboBox();
            this.listaCompraPrecos = new System.Windows.Forms.ListBox();
            this.listaComprasProdutos = new System.Windows.Forms.ListBox();
            this.lblValorDaCompra = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.txtPesquisar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.listaEstoque = new System.Windows.Forms.DataGridView();
            this.IDESTOQUE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOMEPRODUTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VALORVENDA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VALIDADE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CATEGORIA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_CPFVenda = new System.Windows.Forms.MaskedTextBox();
            this.txtPrecoVenda = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnVenderUnidade = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCodProduto = new System.Windows.Forms.TextBox();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaEstoque)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtFormaPagamento);
            this.groupBox3.Controls.Add(this.listaCompraPrecos);
            this.groupBox3.Controls.Add(this.listaComprasProdutos);
            this.groupBox3.Controls.Add(this.lblValorDaCompra);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.btnPesquisar);
            this.groupBox3.Controls.Add(this.txtPesquisar);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.pictureBox1);
            this.groupBox3.Controls.Add(this.listaEstoque);
            this.groupBox3.Controls.Add(this.txt_CPFVenda);
            this.groupBox3.Controls.Add(this.txtPrecoVenda);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.btnVenderUnidade);
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.txtCodProduto);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(12, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1316, 637);
            this.groupBox3.TabIndex = 20;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Unidade";
            // 
            // txtFormaPagamento
            // 
            this.txtFormaPagamento.FormattingEnabled = true;
            this.txtFormaPagamento.Items.AddRange(new object[] {
            "DINHEIRO",
            "DEBITO",
            "CREDITO",
            "PIX"});
            this.txtFormaPagamento.Location = new System.Drawing.Point(6, 269);
            this.txtFormaPagamento.Name = "txtFormaPagamento";
            this.txtFormaPagamento.Size = new System.Drawing.Size(277, 33);
            this.txtFormaPagamento.TabIndex = 38;
            this.txtFormaPagamento.Text = "FORMA DE PAGAMENTO";
            // 
            // listaCompraPrecos
            // 
            this.listaCompraPrecos.FormattingEnabled = true;
            this.listaCompraPrecos.ItemHeight = 25;
            this.listaCompraPrecos.Items.AddRange(new object[] {
            "..:: PREÇO ::.."});
            this.listaCompraPrecos.Location = new System.Drawing.Point(1151, 123);
            this.listaCompraPrecos.Name = "listaCompraPrecos";
            this.listaCompraPrecos.Size = new System.Drawing.Size(153, 179);
            this.listaCompraPrecos.TabIndex = 36;
            // 
            // listaComprasProdutos
            // 
            this.listaComprasProdutos.FormattingEnabled = true;
            this.listaComprasProdutos.ItemHeight = 25;
            this.listaComprasProdutos.Items.AddRange(new object[] {
            "..:: PRODUTOS ::.."});
            this.listaComprasProdutos.Location = new System.Drawing.Point(859, 123);
            this.listaComprasProdutos.Name = "listaComprasProdutos";
            this.listaComprasProdutos.Size = new System.Drawing.Size(286, 179);
            this.listaComprasProdutos.TabIndex = 35;
            // 
            // lblValorDaCompra
            // 
            this.lblValorDaCompra.AutoSize = true;
            this.lblValorDaCompra.Location = new System.Drawing.Point(1187, 92);
            this.lblValorDaCompra.Name = "lblValorDaCompra";
            this.lblValorDaCompra.Size = new System.Drawing.Size(24, 25);
            this.lblValorDaCompra.TabIndex = 30;
            this.lblValorDaCompra.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1000, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 25);
            this.label2.TabIndex = 29;
            this.label2.Text = "Valor da Compra:";
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisar.Location = new System.Drawing.Point(1151, 54);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(157, 33);
            this.btnPesquisar.TabIndex = 6;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesquisar.Location = new System.Drawing.Point(1099, 17);
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(209, 31);
            this.txtPesquisar.TabIndex = 5;
            this.txtPesquisar.TextChanged += new System.EventHandler(this.txtPesquisar_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1006, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 25);
            this.label1.TabIndex = 26;
            this.label1.Text = "Produto";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.ImageLocation = "C:\\Curso\\Enterprise Manager\\Enterprise Manager\\images\\whey.png";
            this.pictureBox1.Location = new System.Drawing.Point(352, 87);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(84, 81);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // listaEstoque
            // 
            this.listaEstoque.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.listaEstoque.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listaEstoque.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDESTOQUE,
            this.NOMEPRODUTO,
            this.VALORVENDA,
            this.VALIDADE,
            this.CATEGORIA});
            this.listaEstoque.Location = new System.Drawing.Point(15, 322);
            this.listaEstoque.Name = "listaEstoque";
            this.listaEstoque.ReadOnly = true;
            this.listaEstoque.Size = new System.Drawing.Size(1286, 237);
            this.listaEstoque.TabIndex = 21;
            // 
            // IDESTOQUE
            // 
            this.IDESTOQUE.FillWeight = 20F;
            this.IDESTOQUE.HeaderText = "Cod";
            this.IDESTOQUE.Name = "IDESTOQUE";
            this.IDESTOQUE.ReadOnly = true;
            // 
            // NOMEPRODUTO
            // 
            this.NOMEPRODUTO.HeaderText = "Produto";
            this.NOMEPRODUTO.Name = "NOMEPRODUTO";
            this.NOMEPRODUTO.ReadOnly = true;
            // 
            // VALORVENDA
            // 
            dataGridViewCellStyle1.Format = "C2";
            dataGridViewCellStyle1.NullValue = null;
            this.VALORVENDA.DefaultCellStyle = dataGridViewCellStyle1;
            this.VALORVENDA.FillWeight = 30F;
            this.VALORVENDA.HeaderText = "Preço";
            this.VALORVENDA.Name = "VALORVENDA";
            this.VALORVENDA.ReadOnly = true;
            // 
            // VALIDADE
            // 
            this.VALIDADE.FillWeight = 45F;
            this.VALIDADE.HeaderText = "Validade";
            this.VALIDADE.Name = "VALIDADE";
            this.VALIDADE.ReadOnly = true;
            // 
            // CATEGORIA
            // 
            this.CATEGORIA.FillWeight = 50F;
            this.CATEGORIA.HeaderText = "Categoria";
            this.CATEGORIA.Name = "CATEGORIA";
            this.CATEGORIA.ReadOnly = true;
            // 
            // txt_CPFVenda
            // 
            this.txt_CPFVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_CPFVenda.Location = new System.Drawing.Point(208, 39);
            this.txt_CPFVenda.Mask = "000.000.000-00";
            this.txt_CPFVenda.Name = "txt_CPFVenda";
            this.txt_CPFVenda.Size = new System.Drawing.Size(156, 31);
            this.txt_CPFVenda.TabIndex = 1;
            this.txt_CPFVenda.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePrompt;
            // 
            // txtPrecoVenda
            // 
            this.txtPrecoVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecoVenda.Location = new System.Drawing.Point(208, 137);
            this.txtPrecoVenda.Name = "txtPrecoVenda";
            this.txtPrecoVenda.Size = new System.Drawing.Size(92, 31);
            this.txtPrecoVenda.TabIndex = 3;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(13, 143);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(68, 25);
            this.label11.TabIndex = 9;
            this.label11.Text = "Preço";
            // 
            // btnVenderUnidade
            // 
            this.btnVenderUnidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVenderUnidade.Location = new System.Drawing.Point(6, 565);
            this.btnVenderUnidade.Name = "btnVenderUnidade";
            this.btnVenderUnidade.Size = new System.Drawing.Size(240, 64);
            this.btnVenderUnidade.TabIndex = 4;
            this.btnVenderUnidade.Text = "Vender Unidade";
            this.btnVenderUnidade.UseVisualStyleBackColor = true;
            this.btnVenderUnidade.Click += new System.EventHandler(this.btnVenderUnidade_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(10, 42);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(157, 25);
            this.label17.TabIndex = 20;
            this.label17.Text = "CPF do Cliente";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(10, 91);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(191, 25);
            this.label9.TabIndex = 13;
            this.label9.Text = "Codigo do Produto";
            // 
            // txtCodProduto
            // 
            this.txtCodProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodProduto.Location = new System.Drawing.Point(208, 89);
            this.txtCodProduto.Name = "txtCodProduto";
            this.txtCodProduto.Size = new System.Drawing.Size(92, 31);
            this.txtCodProduto.TabIndex = 2;
            this.txtCodProduto.TextChanged += new System.EventHandler(this.txtCodProduto_TextChanged);
            // 
            // SELLUnit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1340, 652);
            this.Controls.Add(this.groupBox3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SELLUnit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Realizar Venda";
            this.Load += new System.EventHandler(this.SELL_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaEstoque)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.MaskedTextBox txt_CPFVenda;
        private System.Windows.Forms.TextBox txtPrecoVenda;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnVenderUnidade;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtCodProduto;
        private System.Windows.Forms.DataGridView listaEstoque;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.TextBox txtPesquisar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblValorDaCompra;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listaCompraPrecos;
        private System.Windows.Forms.ListBox listaComprasProdutos;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDESTOQUE;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOMEPRODUTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn VALORVENDA;
        private System.Windows.Forms.DataGridViewTextBoxColumn VALIDADE;
        private System.Windows.Forms.DataGridViewTextBoxColumn CATEGORIA;
        private System.Windows.Forms.ComboBox txtFormaPagamento;
    }
}