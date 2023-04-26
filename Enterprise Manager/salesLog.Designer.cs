namespace Enterprise_Manager
{
    partial class SalesLogForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SalesLogForm));
            this.HistoricoVendas = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDataPesquisa = new System.Windows.Forms.MaskedTextBox();
            this.txtCPFPesquisa = new System.Windows.Forms.MaskedTextBox();
            this.btnPesquisarCPF = new System.Windows.Forms.Button();
            this.btnPesquisarData = new System.Windows.Forms.Button();
            this.btnMostrarLucro = new System.Windows.Forms.Button();
            this.btnVisualizarFaturamento = new System.Windows.Forms.Button();
            this.lblLucroFaturamento = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CPF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOMEPRODUTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRECOFAT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRECOLUC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DATA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FORMPAGAMENTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.HistoricoVendas)).BeginInit();
            this.SuspendLayout();
            // 
            // HistoricoVendas
            // 
            this.HistoricoVendas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.HistoricoVendas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.HistoricoVendas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.CPF,
            this.NOMEPRODUTO,
            this.PRECOFAT,
            this.PRECOLUC,
            this.DATA,
            this.FORMPAGAMENTO});
            this.HistoricoVendas.Location = new System.Drawing.Point(12, 156);
            this.HistoricoVendas.Name = "HistoricoVendas";
            this.HistoricoVendas.ReadOnly = true;
            this.HistoricoVendas.Size = new System.Drawing.Size(1130, 411);
            this.HistoricoVendas.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Pesquisar por Data:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(199, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Pesquisar por CPF:";
            // 
            // txtDataPesquisa
            // 
            this.txtDataPesquisa.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludePrompt;
            this.txtDataPesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDataPesquisa.Location = new System.Drawing.Point(215, 6);
            this.txtDataPesquisa.Mask = "00/00/0000";
            this.txtDataPesquisa.Name = "txtDataPesquisa";
            this.txtDataPesquisa.Size = new System.Drawing.Size(120, 31);
            this.txtDataPesquisa.TabIndex = 5;
            this.txtDataPesquisa.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
            this.txtDataPesquisa.ValidatingType = typeof(System.DateTime);
            // 
            // txtCPFPesquisa
            // 
            this.txtCPFPesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCPFPesquisa.Location = new System.Drawing.Point(215, 70);
            this.txtCPFPesquisa.Mask = "000.000.000-00";
            this.txtCPFPesquisa.Name = "txtCPFPesquisa";
            this.txtCPFPesquisa.Size = new System.Drawing.Size(159, 31);
            this.txtCPFPesquisa.TabIndex = 6;
            this.txtCPFPesquisa.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePrompt;
            this.txtCPFPesquisa.ValidatingType = typeof(System.DateTime);
            // 
            // btnPesquisarCPF
            // 
            this.btnPesquisarCPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisarCPF.Location = new System.Drawing.Point(380, 68);
            this.btnPesquisarCPF.Name = "btnPesquisarCPF";
            this.btnPesquisarCPF.Size = new System.Drawing.Size(214, 37);
            this.btnPesquisarCPF.TabIndex = 7;
            this.btnPesquisarCPF.Text = "Pesquisar por CPF";
            this.btnPesquisarCPF.UseVisualStyleBackColor = true;
            this.btnPesquisarCPF.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // btnPesquisarData
            // 
            this.btnPesquisarData.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisarData.Location = new System.Drawing.Point(380, 9);
            this.btnPesquisarData.Name = "btnPesquisarData";
            this.btnPesquisarData.Size = new System.Drawing.Size(214, 37);
            this.btnPesquisarData.TabIndex = 8;
            this.btnPesquisarData.Text = "Pesquisar por Data";
            this.btnPesquisarData.UseVisualStyleBackColor = true;
            this.btnPesquisarData.Click += new System.EventHandler(this.btnPesquisarData_Click);
            // 
            // btnMostrarLucro
            // 
            this.btnMostrarLucro.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrarLucro.Location = new System.Drawing.Point(689, 8);
            this.btnMostrarLucro.Name = "btnMostrarLucro";
            this.btnMostrarLucro.Size = new System.Drawing.Size(214, 37);
            this.btnMostrarLucro.TabIndex = 9;
            this.btnMostrarLucro.Text = "Visualizar Lucro";
            this.btnMostrarLucro.UseVisualStyleBackColor = true;
            this.btnMostrarLucro.Click += new System.EventHandler(this.btnMostrarLucro_Click);
            // 
            // btnVisualizarFaturamento
            // 
            this.btnVisualizarFaturamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVisualizarFaturamento.Location = new System.Drawing.Point(909, 8);
            this.btnVisualizarFaturamento.Name = "btnVisualizarFaturamento";
            this.btnVisualizarFaturamento.Size = new System.Drawing.Size(214, 37);
            this.btnVisualizarFaturamento.TabIndex = 10;
            this.btnVisualizarFaturamento.Text = "Visualizar Faturamento";
            this.btnVisualizarFaturamento.UseVisualStyleBackColor = true;
            this.btnVisualizarFaturamento.Click += new System.EventHandler(this.btnVisualizarFaturamento_Click);
            // 
            // lblLucroFaturamento
            // 
            this.lblLucroFaturamento.AutoSize = true;
            this.lblLucroFaturamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLucroFaturamento.Location = new System.Drawing.Point(684, 59);
            this.lblLucroFaturamento.Name = "lblLucroFaturamento";
            this.lblLucroFaturamento.Size = new System.Drawing.Size(0, 25);
            this.lblLucroFaturamento.TabIndex = 11;
            // 
            // ID
            // 
            this.ID.FillWeight = 20F;
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // CPF
            // 
            this.CPF.FillWeight = 60F;
            this.CPF.HeaderText = "CPF";
            this.CPF.Name = "CPF";
            this.CPF.ReadOnly = true;
            // 
            // NOMEPRODUTO
            // 
            this.NOMEPRODUTO.HeaderText = "Produto";
            this.NOMEPRODUTO.Name = "NOMEPRODUTO";
            this.NOMEPRODUTO.ReadOnly = true;
            // 
            // PRECOFAT
            // 
            dataGridViewCellStyle1.Format = "C2";
            dataGridViewCellStyle1.NullValue = null;
            this.PRECOFAT.DefaultCellStyle = dataGridViewCellStyle1;
            this.PRECOFAT.FillWeight = 30F;
            this.PRECOFAT.HeaderText = "Faturamento";
            this.PRECOFAT.Name = "PRECOFAT";
            this.PRECOFAT.ReadOnly = true;
            // 
            // PRECOLUC
            // 
            dataGridViewCellStyle2.Format = "C2";
            dataGridViewCellStyle2.NullValue = null;
            this.PRECOLUC.DefaultCellStyle = dataGridViewCellStyle2;
            this.PRECOLUC.FillWeight = 30F;
            this.PRECOLUC.HeaderText = "Lucro";
            this.PRECOLUC.Name = "PRECOLUC";
            this.PRECOLUC.ReadOnly = true;
            // 
            // DATA
            // 
            this.DATA.FillWeight = 50F;
            this.DATA.HeaderText = "Data da Compra";
            this.DATA.Name = "DATA";
            this.DATA.ReadOnly = true;
            // 
            // FORMPAGAMENTO
            // 
            this.FORMPAGAMENTO.FillWeight = 50F;
            this.FORMPAGAMENTO.HeaderText = "Pagamento";
            this.FORMPAGAMENTO.Name = "FORMPAGAMENTO";
            this.FORMPAGAMENTO.ReadOnly = true;
            // 
            // SalesLogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1154, 579);
            this.Controls.Add(this.lblLucroFaturamento);
            this.Controls.Add(this.btnVisualizarFaturamento);
            this.Controls.Add(this.btnMostrarLucro);
            this.Controls.Add(this.btnPesquisarData);
            this.Controls.Add(this.btnPesquisarCPF);
            this.Controls.Add(this.txtCPFPesquisa);
            this.Controls.Add(this.txtDataPesquisa);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.HistoricoVendas);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SalesLogForm";
            this.Text = "Historico de Vendas";
            this.Load += new System.EventHandler(this.SalesLogForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.HistoricoVendas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView HistoricoVendas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox txtDataPesquisa;
        private System.Windows.Forms.MaskedTextBox txtCPFPesquisa;
        private System.Windows.Forms.Button btnPesquisarCPF;
        private System.Windows.Forms.Button btnPesquisarData;
        private System.Windows.Forms.Button btnMostrarLucro;
        private System.Windows.Forms.Button btnVisualizarFaturamento;
        private System.Windows.Forms.Label lblLucroFaturamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPF;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOMEPRODUTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRECOFAT;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRECOLUC;
        private System.Windows.Forms.DataGridViewTextBoxColumn DATA;
        private System.Windows.Forms.DataGridViewTextBoxColumn FORMPAGAMENTO;
    }
}