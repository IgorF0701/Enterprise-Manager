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
    public partial class SellFlour : Form
    {
        double ValorDaCompra;
        public SellFlour()
        {
            InitializeComponent();
        }
        private void SellFlour_Load(object sender, EventArgs e)
        {
            AtualizarEstoqueGranel();
        }

        private void btnVenderGranel_Click(object sender, EventArgs e)
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

                    //Obter quantidade de gramas disponiveis
                    command = new SQLiteCommand("SELECT GRAMAS FROM ESTOQUE WHERE IDESTOQUE = '" + txtCodProduto.Text + "'", conexaosqlce);
                    double GramasAtual = (double)command.ExecuteScalar();

                    //Obter quantidade de gramas a serem vendidas
                    double GramasVendidas = Convert.ToDouble(txtQtdGramasVenda.Text);

                    //Valor Final das gramas no estoque
                    double GramasFinal = GramasAtual - GramasVendidas;
                    

                    //Calcular O preço da venda
                    double PrecoKg = Convert.ToDouble(txtPrecoVenda.Text) * 10;
                    double ValorFinal = (PrecoKg * GramasVendidas) / 1000;
                    ValorDaCompra += ValorFinal;
                    lblValorDaCompra.Text = "R$" + ValorDaCompra.ToString();

                    //Inserir no estoque as gramas atualizadas ou Remover caso tenha 500g ou menos

                    if (GramasFinal < 500)
                    {
                        command.CommandText = ("DELETE FROM ESTOQUE WHERE IDESTOQUE = '"+ txtCodProduto.Text +"'");
                        command.ExecuteNonQuery();
                    }
                    else
                    {
                        command.CommandText = ("UPDATE ESTOQUE SET GRAMAS = '" + GramasFinal + "' WHERE IDESTOQUE = '" + txtCodProduto.Text + "'");
                        command.ExecuteNonQuery();
                    }
                    

                    //Lucro Liquido
                    double LucroLiquido = ValorFinal - (((valorInicial * 10) * GramasVendidas) / 1000);

                    //Obter data atual
                    string diaAtual = $"{DateTime.Now:dd/MM/yyyy}";

                    //Obter cpf
                    string CPF = txt_CPFVenda.Text;
                    NomeProduto += " " + GramasVendidas.ToString() +"g";

                    string ValorFinalProcessado = ValorFinal.ToString().Replace(",", ".");
                    string LucroLiquidoProcessado = LucroLiquido.ToString().Replace(",", ".");

                    listaComprasProdutos.Items.Add(NomeProduto);
                    listaCompraPrecos.Items.Add("R$" + ValorFinalProcessado);

                    //Inserir na tabela
                    command.CommandText = ("INSERT INTO VENDASREALIZADAS(NOMEPRODUTO, CPF,PRECOFAT, PRECOLUC, DATA, FORMPAGAMENTO) VALUES('" + NomeProduto + "','" + CPF + "', '" + ValorFinalProcessado + "', '" + LucroLiquidoProcessado + "', '" + diaAtual + "', '" +txtFormaPagamento.Text+ "')");
                    command.ExecuteNonQuery();

                    AtualizarEstoqueGranel();
                    txtCodProduto.Text = "";
                    txtQtdGramasVenda.Text = "";
                    txtPrecoVenda.Text = "";
                    txtCodProduto.Focus();

                    MessageBox.Show("Venda registrada com sucesso!\n Codigo do produto: " + txtCodProduto.Text + "\n Produto Vendido: " + NomeProduto.ToUpper() + "\nGramas vendidas: " + GramasVendidas);

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

        private void AtualizarEstoqueGranel()
        {
            string baseDados = Application.StartupPath + @"\db\DBSQLite.db";
            string strConection = @"Data Source = " + baseDados + "; Version = '3' ";

            SQLiteConnection conexaosqlce = new SQLiteConnection(strConection);

            try
            {
                string query = "SELECT IDESTOQUE, NOMEPRODUTO, VALORVENDA, VALIDADE, CATEGORIA,GRAMAS FROM ESTOQUE WHERE CATEGORIA = 'GRANEL'";


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



        private void txtCodProduto_TextChanged(object sender, EventArgs e)
        {
            if (txtCodProduto.Text != string.Empty)
            {
                string baseDados = Application.StartupPath + @"\db\DBSQLite.db";
                string strConection = @"Data Source = " + baseDados + "; Version = '3' ";

                SQLiteConnection conexaosqlce = new SQLiteConnection(strConection);

                try
                {
                    string query = "SELECT IDESTOQUE, NOMEPRODUTO, VALORVENDA, VALIDADE, CATEGORIA, GRAMAS FROM ESTOQUE WHERE IDESTOQUE LIKE '%" + txtCodProduto.Text + "%'";


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

        private void txtPrecoVenda_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtQtdGramasVenda.Text) && !string.IsNullOrEmpty(txtPrecoVenda.Text))
            {
                //Calcular O preço da venda
                double precoFinal = Convert.ToDouble(txtQtdGramasVenda.Text) / 100 * Convert.ToDouble(txtPrecoVenda.Text);
                

                lblPrecoShow.Text = "R$" + precoFinal.ToString();
            }
        }

        private void txtQtdGramasVenda_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtQtdGramasVenda.Text) && !string.IsNullOrEmpty(txtPrecoVenda.Text))
            {
                //Calcular O preço da venda
                double precoFinal = Convert.ToDouble(txtQtdGramasVenda.Text) / 100 * Convert.ToDouble(txtPrecoVenda.Text);


                lblPrecoShow.Text = "R$" + precoFinal.ToString();
            }
        }
    }
}
