using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using teste.DAO;
using teste.Produtos;
using teste.ProdutosClass;

namespace teste.Telas.Produtos
{
    public partial class TelaProdutos : Form
    {
        public TelaProdutos()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        int index = 1;

        private void btnEncerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();//Aqui eu defino se o form é movido pelo usuário
            //digo no caso a tela
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void button1_Click(object sender, EventArgs e)
         {

            
        }


        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            PesquisaProdutos RetornaProd = new PesquisaProdutos();
            ProdutosBD TodosProdutos = new ProdutosBD();
            List<ProdutosBD> ListTest = new List<ProdutosBD>();
            ListTest = RetornaProd.ConsultProd();
            //corrigindo informação de produto na ferramenta
            int qtdeProd;
            qtdeProd = RetornaProd.ConsultProd().Count();
            labelQtdProdutos.Text = (qtdeProd - 1).ToString();
            ListTest = RetornaProd.ConsultProd();
            if (index < ListTest.Count - 1)
            {
                index += 1;
                textBoxIdProduto.Text = ListTest[index].Idproduto;
                textBoxIdItem.Text = ListTest[index].ItemProduto;
                textBoxDescProduto.Text = ListTest[index].DescricaoProduto;
                textBoxDescDetalhada.Text = ListTest[index].DescricaoDetalhada;
                comboBoxCategorias.Text = ListTest[index].CodCategoria;
                labelProdAtual.Text = Convert.ToString(index);


            }
        }

        private void buttonLimpar_Click(object sender, EventArgs e)
        {
            labelQtdProdutos.Text = "0";
            labelProdAtual.Text = "0";
            textBoxIdProduto.Text = "";
            textBoxIdItem.Text =  "";
            textBoxDescProduto.Text =  "";
            textBoxDescDetalhada.Text = "";
            comboBoxCategorias.Text = "";
            index = 0;

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void textBoxLargura_TextChanged(object sender, EventArgs e)
        {

        }

        private void label25_Click(object sender, EventArgs e)
        {

        }

        private void TelaProdutos_Load(object sender, EventArgs e)
        {


        }

        private void comboBoxCategorias_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

            if (textBoxIdProduto.Text == "")
            {
                int qtdeProd;
                PesquisaProdutos RetornaProd = new PesquisaProdutos();
                qtdeProd = RetornaProd.ConsultProd().Count();
                labelQtdProdutos.Text = (qtdeProd - 1).ToString();
                foreach (ProdutosBD produtos in RetornaProd.ConsultProd())
                {
                    labelProdAtual.Text = "1";
                    index = 1;

                    textBoxIdProduto.Text = produtos.Idproduto;
                    textBoxIdItem.Text = produtos.ItemProduto;
                    textBoxDescProduto.Text = produtos.DescricaoProduto;
                    textBoxDescDetalhada.Text = produtos.DescricaoDetalhada;
                    comboBoxCategorias.Text = produtos.CodCategoria;
                }
            }

            else
            {

                PesquisaProdutos RetornaProd1 = new PesquisaProdutos();
                labelQtdProdutos.Text = RetornaProd1.ConsultaProduto(textBoxIdProduto.Text).Count.ToString();
                foreach (ProdutosBD produtos in RetornaProd1.ConsultaProduto(textBoxIdProduto.Text))
                {
                    textBoxIdProduto.Text = produtos.Idproduto;
                    textBoxIdItem.Text = produtos.ItemProduto;
                    textBoxDescProduto.Text = produtos.DescricaoProduto;
                    textBoxDescDetalhada.Text = produtos.DescricaoDetalhada;
                    comboBoxCategorias.Text = produtos.CodCategoria;
                }
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            AtualizaProduto AtualizadaProd = new AtualizaProduto();
            //SqlException exception;
            try 
            {
                AtualizadaProd.AtualizarProd(textBoxIdProduto.Text, textBoxIdItem.Text, textBoxDescDetalhada.Text, textBoxDescProduto.Text, comboBoxCategorias.Text);
                MessageBox.Show("Produto Atualizado");
            }

            catch
            {
                MessageBox.Show("Erro ao atualizar"+e);
            }
        }

        private void pictureBox2_DoubleClick(object sender, EventArgs e)
        {
            AtualizaProduto AtualizadaProd = new AtualizaProduto();
            //SqlException exception;
            try
            {
                AtualizadaProd.AtualizarProd(textBoxIdProduto.Text, textBoxIdItem.Text, textBoxDescDetalhada.Text, textBoxDescProduto.Text, comboBoxCategorias.Text);
                MessageBox.Show("Erro ao atualizar");
            }

            catch
            {
                MessageBox.Show("Erro ao atualizar" + e);
            }
        }
    }
}
