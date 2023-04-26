using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Enterprise_Manager
{
    public partial class storage : Form
    {
        
        public storage()
        {
            InitializeComponent();
            
        }

        private void storage_Load(object sender, EventArgs e)
        {
            AtualizarEstoqueTotal();

            #region lucro esperado (terminar)
            //Mostrar o valor do estoque e o lucro esperado

            //string baseDados = Application.StartupPath + @"\db\DBSQLite.db";
            //string strConection = @"Data Source = " + baseDados + "; Version = '3' ";


            //SQLiteConnection conexaosqlce = new SQLiteConnection(strConection);

            //try
            //{
            //    conexaosqlce.Open();
            //    SQLiteCommand command = new SQLiteCommand("SELECT SUM(VALORINICIAL) FROM ESTOQUE", conexaosqlce);
            //    string ValorEstoque = command.ExecuteScalar().ToString();

            //    command = new SQLiteCommand("SELECT SUM(VALORVENDA) FROM ESTOQUE", conexaosqlce);
            //    string LucroEsperado = command.ExecuteScalar().ToString();

            //    lblLucroEsperado.Text = LucroEsperado;
            //    lblValorEstoque.Text = ValorEstoque;
            //}
            //catch (Exception ex)
            //{

            //    MessageBox.Show("ERRO:\n" + ex);
            //}
            //finally
            //{
            //    conexaosqlce.Close();
            //}
            #endregion
        }

        private void btn_Pesquisar_Click(object sender, EventArgs e)
        {
            string baseDados = Application.StartupPath + @"\db\DBSQLite.db";
            string strConection = @"Data Source = " + baseDados + "; Version = '3' ";

            SQLiteConnection conexaosqlce = new SQLiteConnection(strConection);
            listaEstoque.Rows.Clear();
            string BoxPesquisa = txt_Pesquisar.Text;
            string query = "SELECT * FROM ESTOQUE;";
            if (rb_Produto.Checked)
            {
                 query = "SELECT * FROM ESTOQUE WHERE NOMEPRODUTO LIKE '%" + BoxPesquisa + "%'";
            }
            else if(rb_Categoria.Checked)
            {
                 query = "SELECT * FROM ESTOQUE WHERE CATEGORIA LIKE '%" + BoxPesquisa + "%'";
            }
            try
            {
           
                DataTable dados = new DataTable();

                SQLiteDataAdapter adaptador = new SQLiteDataAdapter(query, strConection);

                conexaosqlce.Open();

                adaptador.Fill(dados);

                foreach (DataRow linha in dados.Rows)
                {
                    listaEstoque.Rows.Add(linha.ItemArray);
                }
            }
            catch (Exception ex)
            {
                listaEstoque.Rows.Clear();
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexaosqlce.Close();
            }
        }

        public void AtualizarEstoqueTotal()
        {
            string baseDados = Application.StartupPath + @"\db\DBSQLite.db";
            string strConection = @"Data Source = " + baseDados + "; Version = '3' ";

            SQLiteConnection conexaosqlce = new SQLiteConnection(strConection);

            try
            {
                string query = "SELECT * FROM ESTOQUE;";


                DataTable dados = new DataTable();

                SQLiteDataAdapter adaptador = new SQLiteDataAdapter(query, strConection);

                conexaosqlce.Open();

                adaptador.Fill(dados);

                foreach (DataRow linha in dados.Rows)
                {
                    listaEstoque.Rows.Add(linha.ItemArray);
                }
            }
            catch (Exception ex)
            {
                listaEstoque.Rows.Clear();
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexaosqlce.Close();
            }
        }

    }
}
