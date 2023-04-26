namespace Enterprise_Manager
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.btnRealizarVendas = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.sellLog = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.btnVisualizarHistorico = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.btnVendaAgranel = new System.Windows.Forms.Button();
            this.menubar = new System.Windows.Forms.MenuStrip();
            this.addTabelaClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.criarBancoDeDadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.criarTabelaClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.criarTabelaEstoqueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.criarTabelaVendasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.executarComandoSQLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label25 = new System.Windows.Forms.Label();
            this.lbl_ItensNoEstoque = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnHelp = new System.Windows.Forms.Button();
            this.btnAddStorage = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnAddNewCostumer = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.btnSearchCostumer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sellLog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.menubar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRealizarVendas
            // 
            this.btnRealizarVendas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRealizarVendas.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnRealizarVendas.Location = new System.Drawing.Point(6, 174);
            this.btnRealizarVendas.Name = "btnRealizarVendas";
            this.btnRealizarVendas.Size = new System.Drawing.Size(240, 64);
            this.btnRealizarVendas.TabIndex = 18;
            this.btnRealizarVendas.Text = "Venda Unitaria";
            this.btnRealizarVendas.UseVisualStyleBackColor = true;
            this.btnRealizarVendas.Click += new System.EventHandler(this.btnRealizarVendas_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.ImageLocation = "C:\\Curso\\Enterprise Manager\\Enterprise Manager\\images\\new_costumer.png";
            this.pictureBox1.Location = new System.Drawing.Point(12, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(67, 67);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.ImageLocation = "C:\\Curso\\Enterprise Manager\\Enterprise Manager\\images\\search.png";
            this.pictureBox3.Location = new System.Drawing.Point(12, 329);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(67, 67);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 19;
            this.pictureBox3.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.pictureBox6);
            this.groupBox3.Controls.Add(this.sellLog);
            this.groupBox3.Controls.Add(this.pictureBox5);
            this.groupBox3.Controls.Add(this.btnVisualizarHistorico);
            this.groupBox3.Controls.Add(this.pictureBox4);
            this.groupBox3.Controls.Add(this.btnVendaAgranel);
            this.groupBox3.Controls.Add(this.btnRealizarVendas);
            this.groupBox3.Location = new System.Drawing.Point(347, 26);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(555, 369);
            this.groupBox3.TabIndex = 19;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "                 Realizar Venda";
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox6.ImageLocation = "C:\\Curso\\Enterprise Manager\\Enterprise Manager\\images\\money.png";
            this.pictureBox6.Location = new System.Drawing.Point(6, 0);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(49, 43);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 29;
            this.pictureBox6.TabStop = false;
            // 
            // sellLog
            // 
            this.sellLog.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.sellLog.ImageLocation = "C:\\Curso\\Enterprise Manager\\Enterprise Manager\\images\\selllog.png";
            this.sellLog.Location = new System.Drawing.Point(99, 289);
            this.sellLog.Name = "sellLog";
            this.sellLog.Size = new System.Drawing.Size(67, 67);
            this.sellLog.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.sellLog.TabIndex = 28;
            this.sellLog.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox5.ImageLocation = "C:\\Curso\\Enterprise Manager\\Enterprise Manager\\images\\flour.png";
            this.pictureBox5.Location = new System.Drawing.Point(458, 105);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(67, 67);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 27;
            this.pictureBox5.TabStop = false;
            // 
            // btnVisualizarHistorico
            // 
            this.btnVisualizarHistorico.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVisualizarHistorico.Location = new System.Drawing.Point(172, 292);
            this.btnVisualizarHistorico.Name = "btnVisualizarHistorico";
            this.btnVisualizarHistorico.Size = new System.Drawing.Size(240, 64);
            this.btnVisualizarHistorico.TabIndex = 20;
            this.btnVisualizarHistorico.Text = "Historico de Vendas";
            this.btnVisualizarHistorico.UseVisualStyleBackColor = true;
            this.btnVisualizarHistorico.Click += new System.EventHandler(this.btnVisualizarHistorico_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox4.ImageLocation = "C:\\Curso\\Enterprise Manager\\Enterprise Manager\\images\\whey.png";
            this.pictureBox4.Location = new System.Drawing.Point(6, 105);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(67, 67);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 26;
            this.pictureBox4.TabStop = false;
            // 
            // btnVendaAgranel
            // 
            this.btnVendaAgranel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVendaAgranel.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnVendaAgranel.Location = new System.Drawing.Point(285, 174);
            this.btnVendaAgranel.Name = "btnVendaAgranel";
            this.btnVendaAgranel.Size = new System.Drawing.Size(240, 64);
            this.btnVendaAgranel.TabIndex = 19;
            this.btnVendaAgranel.Text = "Venda Granel";
            this.btnVendaAgranel.UseVisualStyleBackColor = true;
            this.btnVendaAgranel.Click += new System.EventHandler(this.btnVendaAgranel_Click);
            // 
            // menubar
            // 
            this.menubar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addTabelaClientesToolStripMenuItem,
            this.executarComandoSQLToolStripMenuItem});
            this.menubar.Location = new System.Drawing.Point(0, 0);
            this.menubar.Name = "menubar";
            this.menubar.Size = new System.Drawing.Size(1604, 24);
            this.menubar.TabIndex = 16;
            this.menubar.Text = "menuStrip1";
            this.menubar.Visible = false;
            // 
            // addTabelaClientesToolStripMenuItem
            // 
            this.addTabelaClientesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.criarBancoDeDadosToolStripMenuItem,
            this.criarTabelaClientesToolStripMenuItem,
            this.criarTabelaEstoqueToolStripMenuItem,
            this.criarTabelaVendasToolStripMenuItem});
            this.addTabelaClientesToolStripMenuItem.Name = "addTabelaClientesToolStripMenuItem";
            this.addTabelaClientesToolStripMenuItem.Size = new System.Drawing.Size(103, 20);
            this.addTabelaClientesToolStripMenuItem.Text = "Banco de dados";
            // 
            // criarBancoDeDadosToolStripMenuItem
            // 
            this.criarBancoDeDadosToolStripMenuItem.Name = "criarBancoDeDadosToolStripMenuItem";
            this.criarBancoDeDadosToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.criarBancoDeDadosToolStripMenuItem.Text = "Criar Banco de dados";
            this.criarBancoDeDadosToolStripMenuItem.Click += new System.EventHandler(this.criarBancoDeDadosToolStripMenuItem_Click);
            // 
            // criarTabelaClientesToolStripMenuItem
            // 
            this.criarTabelaClientesToolStripMenuItem.Name = "criarTabelaClientesToolStripMenuItem";
            this.criarTabelaClientesToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.criarTabelaClientesToolStripMenuItem.Text = "Criar Tabela Clientes";
            this.criarTabelaClientesToolStripMenuItem.Click += new System.EventHandler(this.criarTabelaClientesToolStripMenuItem_Click);
            // 
            // criarTabelaEstoqueToolStripMenuItem
            // 
            this.criarTabelaEstoqueToolStripMenuItem.Name = "criarTabelaEstoqueToolStripMenuItem";
            this.criarTabelaEstoqueToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.criarTabelaEstoqueToolStripMenuItem.Text = "Criar Tabela Estoque";
            this.criarTabelaEstoqueToolStripMenuItem.Click += new System.EventHandler(this.criarTabelaEstoqueToolStripMenuItem_Click);
            // 
            // criarTabelaVendasToolStripMenuItem
            // 
            this.criarTabelaVendasToolStripMenuItem.Name = "criarTabelaVendasToolStripMenuItem";
            this.criarTabelaVendasToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.criarTabelaVendasToolStripMenuItem.Text = "Criar Tabela Vendas";
            this.criarTabelaVendasToolStripMenuItem.Click += new System.EventHandler(this.criarTabelaVendasToolStripMenuItem_Click);
            // 
            // executarComandoSQLToolStripMenuItem
            // 
            this.executarComandoSQLToolStripMenuItem.Name = "executarComandoSQLToolStripMenuItem";
            this.executarComandoSQLToolStripMenuItem.Size = new System.Drawing.Size(12, 20);
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(12, 429);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(133, 20);
            this.label25.TabIndex = 17;
            this.label25.Text = "Itens no estoque:";
            // 
            // lbl_ItensNoEstoque
            // 
            this.lbl_ItensNoEstoque.AutoSize = true;
            this.lbl_ItensNoEstoque.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ItensNoEstoque.Location = new System.Drawing.Point(151, 428);
            this.lbl_ItensNoEstoque.Name = "lbl_ItensNoEstoque";
            this.lbl_ItensNoEstoque.Size = new System.Drawing.Size(150, 20);
            this.lbl_ItensNoEstoque.TabIndex = 18;
            this.lbl_ItensNoEstoque.Text = "Sem Informações";
            // 
            // btnHelp
            // 
            this.btnHelp.Location = new System.Drawing.Point(856, 1);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(64, 23);
            this.btnHelp.TabIndex = 19;
            this.btnHelp.Text = "Debug";
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // btnAddStorage
            // 
            this.btnAddStorage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAddStorage.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddStorage.Location = new System.Drawing.Point(85, 177);
            this.btnAddStorage.Name = "btnAddStorage";
            this.btnAddStorage.Size = new System.Drawing.Size(216, 67);
            this.btnAddStorage.TabIndex = 20;
            this.btnAddStorage.Text = "Adicionar/Ver Estoque";
            this.btnAddStorage.UseVisualStyleBackColor = true;
            this.btnAddStorage.Click += new System.EventHandler(this.btnAddStorage_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.ImageLocation = "C:\\Curso\\Enterprise Manager\\Enterprise Manager\\images\\storage.png";
            this.pictureBox2.Location = new System.Drawing.Point(12, 178);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(67, 67);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
            // 
            // btnAddNewCostumer
            // 
            this.btnAddNewCostumer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAddNewCostumer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewCostumer.Location = new System.Drawing.Point(85, 26);
            this.btnAddNewCostumer.Name = "btnAddNewCostumer";
            this.btnAddNewCostumer.Size = new System.Drawing.Size(216, 67);
            this.btnAddNewCostumer.TabIndex = 21;
            this.btnAddNewCostumer.Text = "Cadastrar Cliente";
            this.btnAddNewCostumer.UseVisualStyleBackColor = true;
            this.btnAddNewCostumer.Click += new System.EventHandler(this.btnAddNewCostumer_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.Location = new System.Drawing.Point(391, 424);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 24);
            this.lblResult.TabIndex = 17;
            // 
            // btnSearchCostumer
            // 
            this.btnSearchCostumer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSearchCostumer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchCostumer.Location = new System.Drawing.Point(85, 328);
            this.btnSearchCostumer.Name = "btnSearchCostumer";
            this.btnSearchCostumer.Size = new System.Drawing.Size(216, 67);
            this.btnSearchCostumer.TabIndex = 22;
            this.btnSearchCostumer.Text = "Procurar Cliente";
            this.btnSearchCostumer.UseVisualStyleBackColor = true;
            this.btnSearchCostumer.Click += new System.EventHandler(this.btnSearchCostumer_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 463);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.btnSearchCostumer);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnAddNewCostumer);
            this.Controls.Add(this.btnAddStorage);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.lbl_ItensNoEstoque);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menubar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menubar;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "In Natura Gerenciador";
            this.Load += new System.EventHandler(this.EnManager_Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sellLog)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.menubar.ResumeLayout(false);
            this.menubar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnRealizarVendas;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menubar;
        private System.Windows.Forms.ToolStripMenuItem addTabelaClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem criarBancoDeDadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem criarTabelaClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem criarTabelaEstoqueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem executarComandoSQLToolStripMenuItem;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label lbl_ItensNoEstoque;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ToolStripMenuItem criarTabelaVendasToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button btnVisualizarHistorico;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnVendaAgranel;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox sellLog;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.TextBox txt_precoIniciall;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.Button btnAddStorage;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnAddNewCostumer;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button btnSearchCostumer;
    }
}

