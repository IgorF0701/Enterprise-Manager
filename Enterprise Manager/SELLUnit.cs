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
    public partial class SELLUnit : Form
    {
        storage storage = new storage();
        double ValorDaCompra;
        public SELLUnit()
        {
            InitializeComponent();
        }
        private void SELL_Load(object sender, EventArgs e)
        {

            AtualizarEstoqueUnidade();
        }

        private void btnVenderUnidade_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCodProduto.Text) ||
               string.IsNullOrEmpty(txtPrecoVenda.Text) || 
               txtFormaPagamento.Text == "FORMA DE PAGAMENTO")
            {
                MessageBox.Show("Preencha TODOS os campos!");
            }
            else
            {
                string baseDados = Application.StartupPath + @"\db\DBSQLite.db";
                string strConection = @"Data Source = " + baseDados + "; Version = '3' ";

                SQLiteConnection conexaosqlce = new SQLiteConnection(strConection);

                try
                {
                    conexaosqlce.Open();
                    SQLiteCommand command = new SQLiteCommand("SELECT NOMEPRODUTO FROM ESTOQUE WHERE IDESTOQUE = '" + txtCodProduto.Text + "'", conexaosqlce);
                    string NomeProduto = command.ExecuteScalar().ToString();
                    

                    //Receber o valores de faturamento
                    command = new SQLiteCommand("SELECT VALORINICIAL FROM ESTOQUE WHERE IDESTOQUE = '" + txtCodProduto.Text + "'", conexaosqlce);
                    double valorInicial = (double)command.ExecuteScalar();

                    //Receber os valores da venda
                    double precoVenda = Convert.ToDouble(txtPrecoVenda.Text);
                    ValorDaCompra += precoVenda;
                    lblValorDaCompra.Text = "R$" + ValorDaCompra.ToString();

                    //Lucro Liquido
                    double LucroLiquido = precoVenda - valorInicial;

                    //Obter data atual
                    string diaAtual = $"{DateTime.Now:dd/MM/yyyy}";
                    //Obter cpf
                    string CPF = txt_CPFVenda.Text;

                    //Inserir na tabela
                    string precoVendaProcessado = precoVenda.ToString().Replace(",", ".");
                    string LucroLiquidoProcessado = LucroLiquido.ToString().Replace(",", ".");

                    listaComprasProdutos.Items.Add(NomeProduto);
                    listaCompraPrecos.Items.Add("R$" + precoVenda.ToString());

                    command.CommandText = ("INSERT INTO VENDASREALIZADAS(NOMEPRODUTO, CPF,PRECOFAT, PRECOLUC, DATA, FORMPAGAMENTO) VALUES('" + NomeProduto + "','" + CPF + "', '" + precoVendaProcessado + "', '" + LucroLiquidoProcessado + "', '" + diaAtual + "', '" +txtFormaPagamento.Text+ "')");
                    command.ExecuteNonQuery();
                    //Remover do estoque
                    command = new SQLiteCommand("DELETE FROM ESTOQUE WHERE IDESTOQUE = '" + txtCodProduto.Text + "'", conexaosqlce);
                    command.ExecuteNonQuery();

                    AtualizarEstoqueUnidade();
                    MessageBox.Show("Venda registrada com sucesso!\n Codigo do produto: "+ txtCodProduto.Text + "\n Produto Vendido: " +NomeProduto.ToUpper());

                    txtCodProduto.Text = "";
                    txtPrecoVenda.Text = "";
                    txtCodProduto.Focus();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Não foi localizado produtos no estoque com o Codigo:" + txtCodProduto.Text + "\n" + ex);
                    return;
                }
                finally
                {
                    conexaosqlce.Close();

                }
            }
        }

        private void AtualizarEstoqueUnidade()
        {
            string baseDados = Application.StartupPath + @"\db\DBSQLite.db";
            string strConection = @"Data Source = " + baseDados + "; Version = '3' ";

            SQLiteConnection conexaosqlce = new SQLiteConnection(strConection);
            
            try
            {
                string query = "SELECT IDESTOQUE, NOMEPRODUTO, VALORVENDA, VALIDADE, CATEGORIA FROM ESTOQUE WHERE CATEGORIA != 'GRANEL'";


                DataTable dados = new DataTable();

                SQLiteDataAdapter adaptador = new SQLiteDataAdapter(query, strConection);

                conexaosqlce.Open();

                adaptador.Fill(dados);
                listaEstoque.Rows.Clear();
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

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            string baseDados = Application.StartupPath + @"\db\DBSQLite.db";
            string strConection = @"Data Source = " + baseDados + "; Version = '3' ";

            SQLiteConnection conexaosqlce = new SQLiteConnection(strConection);

            try
            {
                string query = "SELECT IDESTOQUE, NOMEPRODUTO, VALORVENDA, VALIDADE, CATEGORIA FROM ESTOQUE WHERE NOMEPRODUTO LIKE '%"+txtPesquisar.Text+"%'";


                DataTable dados = new DataTable();

                SQLiteDataAdapter adaptador = new SQLiteDataAdapter(query, strConection);

                conexaosqlce.Open();

                adaptador.Fill(dados);
                listaEstoque.Rows.Clear();
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

        private void txtPesquisar_TextChanged(object sender, EventArgs e)
        {
            if (txtPesquisar.Text != string.Empty)
            {
                string baseDados = Application.StartupPath + @"\db\DBSQLite.db";
                string strConection = @"Data Source = " + baseDados + "; Version = '3' ";

                SQLiteConnection conexaosqlce = new SQLiteConnection(strConection);

                try
                {
                    string query = "SELECT IDESTOQUE, NOMEPRODUTO, VALORVENDA, VALIDADE, CATEGORIA, GRAMAS FROM ESTOQUE WHERE NOMEPRODUTO LIKE '%" + txtPesquisar.Text + "%'";


                    DataTable dados = new DataTable();

                    SQLiteDataAdapter adaptador = new SQLiteDataAdapter(query, strConection);

                    conexaosqlce.Open();

                    adaptador.Fill(dados);
                    listaEstoque.Rows.Clear();
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

        private void txtCodProduto_TextChanged(object sender, EventArgs e)
        {
            if (txtCodProduto.Text != string.Empty)
            {
                string baseDados = Application.StartupPath + @"\db\DBSQLite.db";
                string strConection = @"Data Source = " + baseDados + "; Version = '3' ";

                SQLiteConnection conexaosqlce = new SQLiteConnection(strConection);

                try
                {
                    string query = "SELECT IDESTOQUE, NOMEPRODUTO, VALORVENDA, VALIDADE, CATEGORIA FROM ESTOQUE WHERE IDESTOQUE LIKE '%" + txtCodProduto.Text + "%'";


                    DataTable dados = new DataTable();

                    SQLiteDataAdapter adaptador = new SQLiteDataAdapter(query, strConection);

                    conexaosqlce.Open();

                    adaptador.Fill(dados);
                    listaEstoque.Rows.Clear();
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
}
