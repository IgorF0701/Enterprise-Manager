using System;
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
    public partial class SearchCostumer : Form
    {
        public SearchCostumer()
        {
            InitializeComponent();
        }

        private void text_precoInicial_Click(object sender, EventArgs e)
        {
            string baseDados = Application.StartupPath + @"\db\DBSQLite.db";
            string strConection = @"Data Source = " + baseDados + "; Version = '3' ";

            SQLiteConnection conexaosqlce = new SQLiteConnection(strConection);

            lista.Rows.Clear();
            try
            {
                string query = "SELECT * FROM CLIENTE";

                if (txtNomeVenda.Text != "")
                {
                    query = "SELECT * FROM CLIENTE WHERE NOME LIKE '" + txtNomeVenda.Text + "%'";
                }
                else if (txtCPFVenda.Text != "")
                {
                    query = "SELECT * FROM CLIENTE WHERE CPF LIKE '%" + txtCPFVenda.Text + "%'";
                }

                DataTable dados = new DataTable();

                SQLiteDataAdapter adaptador = new SQLiteDataAdapter(query, strConection);

                conexaosqlce.Open();

                adaptador.Fill(dados);

                foreach (DataRow linha in dados.Rows)
                {
                    lista.Rows.Add(linha.ItemArray);
                }
            }
            catch (Exception ex)
            {
                lista.Rows.Clear();
                MessageBox.Show("Erro:\n" + ex);
            }
            finally
            {
                conexaosqlce.Close();
            }
        }        
    }
}
