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
    public partial class AddStorage : Form
    {
        public AddStorage()
        {
            InitializeComponent();
        }

        private void btn_AddAoEstoque_Click(object sender, EventArgs e)
        {
            if (txt_CategoriaProd.Text == "GRANEL" && txtKg.Text == "0")
            {
                MessageBox.Show("É preciso preencher o campo KG em produtos a GRANEL");
                txtKg.Focus();
            }
            else if (txt_NomeProduto.Text == "" || txt_Validade.Text == "" || txt_CategoriaProd.Text == "SELECIONAR" || txt_Validade.Text == "")
            {
                MessageBox.Show("Preencha TODOS os campos!");
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

                    string nomeProduto = txt_NomeProduto.Text;
                    string Categoria = txt_CategoriaProd.Text;
                    string validade = txt_Validade.Text;
                    string precoInicial = (txt_precoInicial.Text.Replace(",", "."));
                    if (txt_CategoriaProd.Text == "GRANEL")
                    {
                        double KG = Convert.ToDouble(txtKg.Text);
                        double precoTotal = Convert.ToDouble(txt_precoInicial.Text);
                        double cemGramas = (precoTotal / KG) / 10;
                        precoInicial = cemGramas.ToString().Replace(",", ".");
                    }

                    string precoVenda = (txt_precoVenda.Text.Replace(",", "."));
                    if (txt_CategoriaProd.Text == "GRANEL")
                    {
                        double gramas = Convert.ToDouble(txtKg.Text) * 1000;
                        comandolite.CommandText = "INSERT INTO ESTOQUE(NOMEPRODUTO,VALORINICIAL, VALORVENDA, VALIDADE, CATEGORIA, GRAMAS) VALUES('" + nomeProduto + "', '" + precoInicial + "', '" + precoVenda + "', '" + validade + "', '" + Categoria + "', '" + gramas + "')";
                        comandolite.ExecuteNonQuery();
                    }
                    else
                    {
                        comandolite.CommandText = "INSERT INTO ESTOQUE(NOMEPRODUTO,VALORINICIAL, VALORVENDA, VALIDADE, CATEGORIA) VALUES('" + nomeProduto + "', '" + precoInicial + "', '" + precoVenda + "', '" + validade + "', '" + Categoria + "')";
                        comandolite.ExecuteNonQuery();
                    }

                    lblEstoqueStatus.Text = "Produto " + nomeProduto + "\ncadastrado com sucesso!";
                    comandolite.Dispose();
                    AtualizarEstoque();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                    lblEstoqueStatus.Text = "ERRO AO CADASTRAR PRODUTO";
                }
                finally
                {
                    conexaolite.Close();
                }
            }
        }

        private void btn_VisualizarEstoque_Click(object sender, EventArgs e)
        {
            storage storage = new storage();
            storage.ShowDialog();
        }

        private void btnLimparCampos_Click(object sender, EventArgs e)
        {
            LimparCampos();
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
                MessageBox.Show("Erro:\n" + ex);
            }
            finally
            {
                conexaosqlce.Close();
            }
        }

        private void LimparCampos()
        {
            txt_NomeProduto.Text = "";
            txt_Validade.Text = "";
            txt_precoInicial.Text = "";
            txt_precoVenda.Text = "";
            txtKg.Text = "";
            txt_NomeProduto.Focus();
        }

        private void txt_CategoriaProd_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txt_CategoriaProd.Text == "GRANEL")
            {
                txt100gAviso.Visible = true;
                txtKg.Enabled = true;
                lblPrecoInicial.Text = "Preço Total";
                lblValor100g.Visible = true;
                LimparCampos();

            }
            else
            {
                txt100gAviso.Visible = false;
                txtKg.Enabled = false;
                lblPrecoInicial.Text = "Preço Inicial";
                lblValor100g.Visible = false;
                LimparCampos();
            }
        }

        private void txt_precoInicial_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtKg.Text) || string.IsNullOrEmpty(txt_precoInicial.Text))
            {
                lblValor100g.Text = "Preencher o campo KG e Preco Total";
                txtKg.Focus();
            }
            else
            {
                double KG = Convert.ToDouble(txtKg.Text);
                double precoTotal = Convert.ToDouble(txt_precoInicial.Text);
                double cemGramas = (precoTotal / KG) / 10;
                lblValor100g.Text = "100g serão R$" + cemGramas.ToString("0.##");
            }
        }

        private void AddStorage_Load(object sender, EventArgs e)
        {
            AtualizarEstoque();
        }
    }

}
