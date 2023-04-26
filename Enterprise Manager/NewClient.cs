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
    public partial class NewClient : Form
    {
        public NewClient()
        {
            InitializeComponent();
        }

        private void btnAddCliente_Click(object sender, EventArgs e)
        {
            if (txtNome.Text == "" || txtCPF.Text == "")
            {
                MessageBox.Show("NOME e CPF são obrigatórios!");
            }
            else
            {
                string baseDados = Application.StartupPath + @"\db\DBSQLite.db";
                string strConection = @"Data Source = " + baseDados + "; Version = '3' ";

                SQLiteConnection conexaolite = new SQLiteConnection(strConection);

                try
                {
                    conexaolite.Open();
                    SQLiteCommand comandolite = new SQLiteCommand();

                    comandolite.Connection = conexaolite;

                    string nome = txtNome.Text;
                    string cpf = txtCPF.Text;
                    string email = txtEmail.Text;
                    string sexo = txtSexo.Text;
                    string telefone = txtTelefone.Text;

                    comandolite.CommandText = "INSERT INTO CLIENTE(NOME, SEXO, EMAIL, CPF, TELEFONE) VALUES('" + nome + "', '" + sexo + "', '" + email + "', '" + cpf + "', '" + telefone + "')";
                    comandolite.ExecuteNonQuery();

                    lblResult.Text = "Cliente cadastrado com sucesso!";
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
        }
    }
}
