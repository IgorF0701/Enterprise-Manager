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
    public partial class SalesLogForm : Form
    {
        
        public SalesLogForm()
        {
            InitializeComponent();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            string baseDados = Application.StartupPath + @"\db\DBSQLite.db";
            string strConection = @"Data Source = " + baseDados + "; Version = '3' ";

            SQLiteConnection conexaosqlce = new SQLiteConnection(strConection);
            string cpf = txtCPFPesquisa.Text;
            HistoricoVendas.Rows.Clear();
            try
            {
                string query = "SELECT * FROM VENDASREALIZADAS WHERE CPF = '"+ cpf +"'";


                DataTable dados = new DataTable();

                SQLiteDataAdapter adaptador = new SQLiteDataAdapter(query, strConection);

                conexaosqlce.Open();

                adaptador.Fill(dados);

                foreach (DataRow linha in dados.Rows)
                {
                    HistoricoVendas.Rows.Add(linha.ItemArray);
                }
            }
            catch (Exception ex)
            {
                HistoricoVendas.Rows.Clear();
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexaosqlce.Close();
            }

        }

        private void btnPesquisarData_Click(object sender, EventArgs e)
        {
            string baseDados = Application.StartupPath + @"\db\DBSQLite.db";
            string strConection = @"Data Source = " + baseDados + "; Version = '3' ";

            SQLiteConnection conexaosqlce = new SQLiteConnection(strConection);
            string data = txtDataPesquisa.Text;
            HistoricoVendas.Rows.Clear();
            try
            {
                string query = "SELECT * FROM VENDASREALIZADAS WHERE DATA LIKE '%" + data + "%' ORDER BY IDVENDA DESC";


                DataTable dados = new DataTable();

                SQLiteDataAdapter adaptador = new SQLiteDataAdapter(query, strConection);

                conexaosqlce.Open();

                adaptador.Fill(dados);

                foreach (DataRow linha in dados.Rows)
                {
                    HistoricoVendas.Rows.Add(linha.ItemArray);
                }
            }
            catch (Exception ex)
            {
                HistoricoVendas.Rows.Clear();
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexaosqlce.Close();
            }
        }

        private void SalesLogForm_Load(object sender, EventArgs e)
        {
            string baseDados = Application.StartupPath + @"\db\DBSQLite.db";
            string strConection = @"Data Source = " + baseDados + "; Version = '3' ";

            SQLiteConnection conexaosqlce = new SQLiteConnection(strConection);
            
            HistoricoVendas.Rows.Clear();
            try
            {
                string query = "SELECT * FROM VENDASREALIZADAS ORDER BY IDVENDA DESC";


                DataTable dados = new DataTable();

                SQLiteDataAdapter adaptador = new SQLiteDataAdapter(query, strConection);

                conexaosqlce.Open();

                adaptador.Fill(dados);

                foreach (DataRow linha in dados.Rows)
                {
                    HistoricoVendas.Rows.Add(linha.ItemArray);
                }
            }
            catch (Exception ex)
            {
                HistoricoVendas.Rows.Clear();
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexaosqlce.Close();
            }
        }

        private void btnMostrarLucro_Click(object sender, EventArgs e)
        {
            string baseDados = Application.StartupPath + @"\db\DBSQLite.db";
            string strConection = @"Data Source = " + baseDados + "; Version = '3' ";

            SQLiteConnection conexaosqlce = new SQLiteConnection(strConection);

            try
            {
                conexaosqlce.Open();
                SQLiteCommand command = new SQLiteCommand("SELECT SUM(PRECOLUC) FROM VENDASREALIZADAS WHERE DATA LIKE '%" + txtDataPesquisa.Text + "%'", conexaosqlce);
                string LucroNoMes = command.ExecuteScalar().ToString();

                lblLucroFaturamento.Text = "Mês: " + txtDataPesquisa.Text + "\nLucro: R$" + LucroNoMes;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexaosqlce.Close();
            }
        }

        private void btnVisualizarFaturamento_Click(object sender, EventArgs e)
        {
            string baseDados = Application.StartupPath + @"\db\DBSQLite.db";
            string strConection = @"Data Source = " + baseDados + "; Version = '3' ";

            SQLiteConnection conexaosqlce = new SQLiteConnection(strConection);

            try
            {
                conexaosqlce.Open();
                SQLiteCommand command = new SQLiteCommand("SELECT SUM(PRECOFAT) FROM VENDASREALIZADAS WHERE DATA LIKE '%" + txtDataPesquisa.Text + "%'", conexaosqlce);
                string FaturamentoNoMes = command.ExecuteScalar().ToString();

                lblLucroFaturamento.Text = "Mês: " + txtDataPesquisa.Text + "\nLucro: R$" + FaturamentoNoMes;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexaosqlce.Close();
            }
        }
    }
}
