using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SQLite;
using System.Collections;
using System.Globalization;

namespace Enterprise_Manager
{
    public partial class Main : Form
    {
        
        public Main()
        {
            InitializeComponent();
        }

        private void EnManager_Main_Load(object sender, EventArgs e)
        {
            //Atualizar itens no estoque
            AtualizarEstoque();
        }

        private void criarBancoDeDadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string baseDados = Application.StartupPath + @"\db\DBSQLite.db";
            string strConection = @"Data Source = " + baseDados + "; Version = '3' ";



            if (!File.Exists(baseDados))
            {
                SQLiteConnection.CreateFile(baseDados);
            }


            SQLiteConnection conexaolite = new SQLiteConnection(strConection);

            try
            {
                conexaolite.Open();
                lblResult.Text = "Conectado SQLite";
            }
            catch (Exception ex)
            {

                lblResult.Text = "Erro ao conectar SQLite \n" + ex;
            }
            finally
            {
                conexaolite.Close();
            }
        }

        private void criarTabelaClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string baseDados = Application.StartupPath + @"\db\DBSQLite.db";
            string strConection = @"Data Source = " + baseDados + "; Version = '3' ";

            SQLiteConnection conexaolite = new SQLiteConnection(strConection);

            try
            {
                conexaolite.Open();
                SQLiteCommand comandolite = new SQLiteCommand();

                comandolite.Connection = conexaolite;

                comandolite.CommandText = "CREATE TABLE CLIENTE(IDCLIENTE INTEGER PRIMARY KEY AUTOINCREMENT,NOME VARCHAR(30) NOT NULL,SEXO CHAR(1) NOT NULL,EMAIL VARCHAR(50) UNIQUE,CPF VARCHAR(15) UNIQUE,TELEFONE VARCHAR (11))";
                comandolite.ExecuteNonQuery();

                lblResult.Text = "Tabela CLIENTE criada SQLite";
                comandolite.Dispose();
            }
            catch (Exception ex)
            {

                lblResult.Text = ex.Message;
            }
            finally
            {
                conexaolite.Close();
            }
        }

        private void criarTabelaEstoqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string baseDados = Application.StartupPath + @"\db\DBSQLite.db";
            string strConection = @"Data Source = " + baseDados + "; Version = '3' ";

            SQLiteConnection conexaolite = new SQLiteConnection(strConection);

            try
            {
                conexaolite.Open();
                SQLiteCommand comandolite = new SQLiteCommand();

                comandolite.Connection = conexaolite;

                comandolite.CommandText = "CREATE TABLE ESTOQUE(IDESTOQUE INTEGER PRIMARY KEY AUTOINCREMENT,NOMEPRODUTO VARCHAR(50) NOT NULL,VALORINICIAL FLOAT(10,2) NOT NULL,VALORVENDA FLOAT(10,2) NOT NULL, VALIDADE VARCHAR (10), CATEGORIA VARCHAR (25) NOT NULL, GRAMAS FLOAT(10,2))";
                comandolite.ExecuteNonQuery();

                lblResult.Text = "Tabela Estoque criada SQLite";
                comandolite.Dispose();
            }
            catch (Exception ex)
            {

                lblResult.Text = ex.Message;
            }
            finally
            {
                conexaolite.Close();
            }
        }

        private void criarTabelaVendasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string baseDados = Application.StartupPath + @"\db\DBSQLite.db";
            string strConection = @"Data Source = " + baseDados + "; Version = '3' ";

            SQLiteConnection conexaolite = new SQLiteConnection(strConection);

            try
            {
                conexaolite.Open();
                SQLiteCommand comandolite = new SQLiteCommand();

                comandolite.Connection = conexaolite;

                comandolite.CommandText = "CREATE TABLE VENDASREALIZADAS(IDVENDA INTEGER PRIMARY KEY AUTOINCREMENT,CPF CHAR(11),NOMEPRODUTO VARCHAR(30) NOT NULL,PRECOFAT FLOAT(8,2) NOT NULL,PRECOLUC FLOAT(8,2) NOT NULL, DATA CHAR(10))";
                comandolite.ExecuteNonQuery();

                lblResult.Text = "Tabela VENDAS criada SQLite";
                comandolite.Dispose();
            }
            catch (Exception ex)
            {

                lblResult.Text = ex.Message;
            }
            finally
            {
                conexaolite.Close();
            }
        }


        private void txt_VisualizarEstoque_Click(object sender, EventArgs e)
        {
            storage storage = new storage();
            storage.ShowDialog();
        }

        public void AtualizarEstoque()
        {
            string baseDados = Application.StartupPath + @"\db\DBSQLite.db";
            string strConection = @"Data Source = " + baseDados + "; Version = '3' ";

            SQLiteConnection conexaosqlce = new SQLiteConnection(strConection);

            try
            {
                conexaosqlce.Open();
                SQLiteCommand command = new SQLiteCommand("SELECT COUNT(*) FROM ESTOQUE", conexaosqlce);
                Int32 count = Convert.ToInt32(command.ExecuteScalar());
                if (count > 0)
                {
                    lbl_ItensNoEstoque.Text = Convert.ToString(count.ToString());
                }
                else
                {
                    lbl_ItensNoEstoque.Text = "Sem itens no estoque";
                }

                conexaosqlce.Close();
            }
            catch (Exception ex)
            {
                lblResult.Text = ex.Message;
            }
            finally
            {
                conexaosqlce.Close();
            }
        }

        private void btnRealizarVendas_Click(object sender, EventArgs e)
        {
            SELLUnit realizarVenda = new SELLUnit();
            realizarVenda.Show();
            AtualizarEstoque();
        }

        private void btnVisualizarHistorico_Click(object sender, EventArgs e)
        {
            SalesLogForm sales = new SalesLogForm();
            sales.Show();
        }

        private void btnVendaAgranel_Click(object sender, EventArgs e)
        {
            SellFlour sellFlour = new SellFlour();
            sellFlour.Show();
        }


        private void btnHelp_Click(object sender, EventArgs e)
        {
            if (menubar.Visible == true)
            {
                menubar.Visible = false;
            }
            else
            {
                menubar.Visible = true;
            }
        }

        private void btnAddStorage_Click(object sender, EventArgs e)
        {
            AddStorage addStorage = new AddStorage();
            addStorage.Show();
        }

        private void btnAddNewCostumer_Click(object sender, EventArgs e)
        {
            NewClient newClient = new NewClient();
            newClient.Show();
        }

        

        private void btnSearchCostumer_Click(object sender, EventArgs e)
        {
            SearchCostumer searchCostumer = new SearchCostumer();
            searchCostumer.Show();
        }
    }
}


