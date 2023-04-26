namespace Enterprise_Manager
{
    partial class SellFlour
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SellFlour));
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtFormaPagamento = new System.Windows.Forms.ComboBox();
            this.lblPrecoShow = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.listaCompraPrecos = new System.Windows.Forms.ListBox();
            this.listaComprasProdutos = new System.Windows.Forms.ListBox();
            this.lblValorDaCompra = new System.Windows.Forms.Label();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPesquisar = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtQtdGramasVenda = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.listaEstoque = new System.Windows.Forms.DataGridView();
            this.IDESTOQUE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOMEPRODUTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VALORVENDA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VALIDADE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CATEGORIA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GRAMAS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_CPFVenda = new System.Windows.Forms.MaskedTextBox();
            this.txtPrecoVenda = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnVenderGranel = new System.Windows.Forms.Button();
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
            this.groupBox3.Controls.Add(this.lblPrecoShow);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.listaCompraPrecos);
            this.groupBox3.Controls.Add(this.listaComprasProdutos);
            this.groupBox3.Controls.Add(this.lblValorDaCompra);
            this.groupBox3.Controls.Add(this.btnPesquisar);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.txtPesquisar);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.txtQtdGramasVenda);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.pictureBox1);
            this.groupBox3.Controls.Add(this.listaEstoque);
            this.groupBox3.Controls.Add(this.txt_CPFVenda);
            this.groupBox3.Controls.Add(this.txtPrecoVenda);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.btnVenderGranel);
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.txtCodProduto);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(12, 11);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1316, 593);
            this.groupBox3.TabIndex = 21;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Granel";
            // 
            // txtFormaPagamento
            // 
            this.txtFormaPagamento.FormattingEnabled = true;
            this.txtFormaPagamento.Items.AddRange(new object[] {
            "DINHEIRO",
            "DEBITO",
            "CREDITO",
            "PIX"});
            this.txtFormaPagamento.Location = new System.Drawing.Point(6, 284);
            this.txtFormaPagamento.Name = "txtFormaPagamento";
            this.txtFormaPagamento.Size = new System.Drawing.Size(277, 33);
            this.txtFormaPagamento.TabIndex = 37;
            this.txtFormaPagamento.Text = "FORMA DE PAGAMENTO";
            // 
            // lblPrecoShow
            // 
            this.lblPrecoShow.AutoSize = true;
            this.lblPrecoShow.Location = new System.Drawing.Point(102, 239);
            this.lblPrecoShow.Name = "lblPrecoShow";
            this.lblPrecoShow.Size = new System.Drawing.Size(24, 25);
            this.lblPrecoShow.TabIndex = 36;
            this.lblPrecoShow.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 239);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 25);
            this.label5.TabIndex = 35;
            this.label5.Text = "Preço:";
            // 
            // listaCompraPrecos
            // 
            this.listaCompraPrecos.FormattingEnabled = true;
            this.listaCompraPrecos.ItemHeight = 25;
            this.listaCompraPrecos.Items.AddRange(new object[] {
            "..:: PREÇO ::.."});
            this.listaCompraPrecos.Location = new System.Drawing.Point(1156, 138);
            this.listaCompraPrecos.Name = "listaCompraPrecos";
            this.listaCompraPrecos.Size = new System.Drawing.Size(153, 179);
            this.listaCompraPrecos.TabIndex = 34;
            // 
            // listaComprasProdutos
            // 
            this.listaComprasProdutos.FormattingEnabled = true;
            this.listaComprasProdutos.ItemHeight = 25;
            this.listaComprasProdutos.Items.AddRange(new object[] {
            "..:: PRODUTOS ::.."});
            this.listaComprasProdutos.Location = new System.Drawing.Point(864, 138);
            this.listaComprasProdutos.Name = "listaComprasProdutos";
            this.listaComprasProdutos.Size = new System.Drawing.Size(286, 179);
            this.listaComprasProdutos.TabIndex = 33;
            // 
            // lblValorDaCompra
            // 
            this.lblValorDaCompra.AutoSize = true;
            this.lblValorDaCompra.Location = new System.Drawing.Point(1197, 110);
            this.lblValorDaCompra.Name = "lblValorDaCompra";
            this.lblValorDaCompra.Size = new System.Drawing.Size(24, 25);
            this.lblValorDaCompra.TabIndex = 32;
            this.lblValorDaCompra.Text = "0";
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisar.Location = new System.Drawing.Point(1153, 54);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(157, 33);
            this.btnPesquisar.TabIndex = 7;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1011, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(179, 25);
            this.label4.TabIndex = 31;
            this.label4.Text = "Valor da Compra:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(280, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 25);
            this.label2.TabIndex = 28;
            this.label2.Text = "em gramas";
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesquisar.Location = new System.Drawing.Point(1101, 17);
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(209, 31);
            this.txtPesquisar.TabIndex = 6;
            this.txtPesquisar.TextChanged += new System.EventHandler(this.txtPesquisar_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1008, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 25);
            this.label3.TabIndex = 29;
            this.label3.Text = "Produto";
            // 
            // txtQtdGramasVenda
            // 
            this.txtQtdGramasVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQtdGramasVenda.Location = new System.Drawing.Point(208, 137);
            this.txtQtdGramasVenda.Name = "txtQtdGramasVenda";
            this.txtQtdGramasVenda.Size = new System.Drawing.Size(66, 31);
            this.txtQtdGramasVenda.TabIndex = 3;
            this.txtQtdGramasVenda.TextChanged += new System.EventHandler(this.txtQtdGramasVenda_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 25);
            this.label1.TabIndex = 26;
            this.label1.Text = "Quantidade";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.ImageLocation = "C:\\Curso\\Enterprise Manager\\Enterprise Manager\\images\\flour.png";
            this.pictureBox1.Location = new System.Drawing.Point(433, 87);
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
            this.CATEGORIA,
            this.GRAMAS});
            this.listaEstoque.Location = new System.Drawing.Point(5, 323);
            this.listaEstoque.Name = "listaEstoque";
            this.listaEstoque.ReadOnly = true;
            this.listaEstoque.Size = new System.Drawing.Size(1304, 197);
            this.listaEstoque.TabIndex = 8;
            // 
            // IDESTOQUE
            // 
            this.IDESTOQUE.FillWeight = 40F;
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
            this.VALORVENDA.FillWeight = 50F;
            this.VALORVENDA.HeaderText = "Preço";
            this.VALORVENDA.Name = "VALORVENDA";
            this.VALORVENDA.ReadOnly = true;
            // 
            // VALIDADE
            // 
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
            this.GRAMAS.HeaderText = "Gramas Disponiveis";
            this.GRAMAS.Name = "GRAMAS";
            this.GRAMAS.ReadOnly = true;
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
            this.txtPrecoVenda.Location = new System.Drawing.Point(208, 183);
            this.txtPrecoVenda.Name = "txtPrecoVenda";
            this.txtPrecoVenda.Size = new System.Drawing.Size(66, 31);
            this.txtPrecoVenda.TabIndex = 4;
            this.txtPrecoVenda.TextChanged += new System.EventHandler(this.txtPrecoVenda_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(13, 189);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(122, 25);
            this.label11.TabIndex = 9;
            this.label11.Text = "Preço 100g";
            // 
            // btnVenderGranel
            // 
            this.btnVenderGranel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVenderGranel.Location = new System.Drawing.Point(6, 526);
            this.btnVenderGranel.Name = "btnVenderGranel";
            this.btnVenderGranel.Size = new System.Drawing.Size(240, 64);
            this.btnVenderGranel.TabIndex = 5;
            this.btnVenderGranel.Text = "Vender Granel";
            this.btnVenderGranel.UseVisualStyleBackColor = true;
            this.btnVenderGranel.Click += new System.EventHandler(this.btnVenderGranel_Click);
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
            this.txtCodProduto.Size = new System.Drawing.Size(66, 31);
            this.txtCodProduto.TabIndex = 2;
            this.txtCodProduto.TextChanged += new System.EventHandler(this.txtCodProduto_TextChanged);
            // 
            // SellFlour
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1340, 612);
            this.Controls.Add(this.groupBox3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SellFlour";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Realizar Venda";
            this.Load += new System.EventHandler(this.SellFlour_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaEstoque)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView listaEstoque;
        private System.Windows.Forms.MaskedTextBox txt_CPFVenda;
        private System.Windows.Forms.TextBox txtPrecoVenda;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnVenderGranel;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtCodProduto;
        private System.Windows.Forms.TextBox txtQtdGramasVenda;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.TextBox txtPesquisar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDESTOQUE;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOMEPRODUTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn VALORVENDA;
        private System.Windows.Forms.DataGridViewTextBoxColumn VALIDADE;
        private System.Windows.Forms.DataGridViewTextBoxColumn CATEGORIA;
        private System.Windows.Forms.DataGridViewTextBoxColumn GRAMAS;
        private System.Windows.Forms.Label lblValorDaCompra;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox listaComprasProdutos;
        private System.Windows.Forms.ListBox listaCompraPrecos;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblPrecoShow;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox txtFormaPagamento;
    }
}