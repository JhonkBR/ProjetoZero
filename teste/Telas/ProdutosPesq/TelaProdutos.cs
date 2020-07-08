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
            List<ProdutosBD> ListProdutos = new List<ProdutosBD>();
            ListProdutos = RetornaProd.ConsultProd();
            //corrigindo informação de produto na ferramenta
            int qtdeProd;
            qtdeProd = RetornaProd.ConsultProd().Count();
            labelQtdProdutos.Text = (qtdeProd - 1).ToString();
            ListProdutos = RetornaProd.ConsultProd();
            if (index < ListProdutos.Count - 1)
            {
                index += 1;
                textBoxReferencia.Text = ListProdutos[index].Referencia;
                textBoxIdItem.Text = ListProdutos[index].IdItem;
                textBoxDescProduto.Text = ListProdutos[index].DescricaoProduto;
                textBoxDescDetalhada.Text = ListProdutos[index].DescricaoDetalhada;
                textBoxAltura.Text = Convert.ToString(ListProdutos[index].Altura);
                textBoxLargura.Text = Convert.ToString(ListProdutos[index].Largura);
                textBoxComprimento.Text = Convert.ToString(ListProdutos[index].Comprimento);
                textBoxModelo.Text = ListProdutos[index].Modelo;
                textBoxPeso.Text = Convert.ToString( ListProdutos[index].Peso);
                textBoxPrecoPromotion.Text = Convert.ToString(ListProdutos[index].PrecoPromocional);
                textBox_Marca.Text = ListProdutos[index].Marca;
                comboBoxCategorias.Text = Convert.ToString(ListProdutos[index].CodLoja);
                labelProdAtual.Text = Convert.ToString(index);
                comboBoxCategorias.Text = Convert.ToString(ListProdutos[index].CodCategoria);
                textBoxCodBarras.Text = ListProdutos[index].CodigoBarras;
                textBoxEstoque.Text = Convert.ToString(ListProdutos[index].Estoque);

            }
        }

        private void buttonLimpar_Click(object sender, EventArgs e)
        {
            labelQtdProdutos.Text = "0";
            labelProdAtual.Text = "0";
            textBoxReferencia.Text = "";
            textBoxIdItem.Text = "";
            textBoxDescProduto.Text = "";
            textBoxDescDetalhada.Text = "";
            textBoxAltura.Text = "";
            textBoxLargura.Text = "";
            textBoxComprimento.Text = "";
            textBoxModelo.Text = "";
            textBoxPeso.Text = "";
            textBoxPrecoPromotion.Text = "";
            textBox_Marca.Text = "";
            comboBoxCategorias.Text = "";
            labelProdAtual.Text = "";
            comboBoxCategorias.Text = "";
            textBoxCodBarras.Text = "";
            textBoxEstoque.Text = "";
            index = 0;

        }
 

        private void pictureBox3_Click(object sender, EventArgs e)
        {

            if (textBoxReferencia.Text == "")
            {
                int qtdeProd;
                PesquisaProdutos RetornaProd = new PesquisaProdutos();
                qtdeProd = RetornaProd.ConsultProd().Count();
                labelQtdProdutos.Text = (qtdeProd - 1).ToString();
                foreach (ProdutosBD produtos in RetornaProd.ConsultProd())
                {
                    labelProdAtual.Text = "1";
                    index = 1;

                    textBoxReferencia.Text = produtos.Referencia;
                    textBoxIdItem.Text = produtos.IdItem;
                    textBoxDescProduto.Text = produtos.DescricaoProduto;
                    textBoxDescDetalhada.Text = produtos.DescricaoDetalhada;
                    textBoxAltura.Text = Convert.ToString(produtos.Altura);
                    textBoxLargura.Text = Convert.ToString(produtos.Largura);
                    textBoxComprimento.Text = Convert.ToString(produtos.Comprimento);
                    textBoxModelo.Text = produtos.Modelo;
                    textBoxPeso.Text = Convert.ToString(produtos.Peso);
                    textBoxPrecoPromotion.Text = Convert.ToString(produtos.PrecoPromocional);
                    textBox_Marca.Text = produtos.Marca;
                    comboBoxCategorias.Text = Convert.ToString(produtos.CodLoja);
                    labelProdAtual.Text = Convert.ToString(index);
                    comboBoxCategorias.Text = Convert.ToString(produtos.CodCategoria);
                    textBoxCodBarras.Text = produtos.CodigoBarras;
                    textBoxEstoque.Text = Convert.ToString(produtos.Estoque);
                    textBoxCodigoLoja.Text = Convert.ToString(produtos.CodLoja);
                }
            }

            else
            {

                PesquisaProdutos RetornaProd1 = new PesquisaProdutos();
                labelQtdProdutos.Text = RetornaProd1.ConsultaProduto(textBoxReferencia.Text).Count.ToString();
                foreach (ProdutosBD produtos in RetornaProd1.ConsultaProduto(textBoxReferencia.Text))
                {
                    textBoxReferencia.Text = produtos.Referencia;
                    textBoxIdItem.Text = produtos.IdItem;
                    textBoxDescProduto.Text = produtos.DescricaoProduto;
                    textBoxDescDetalhada.Text = produtos.DescricaoDetalhada;
                    textBoxAltura.Text = Convert.ToString(produtos.Altura);
                    textBoxLargura.Text = Convert.ToString(produtos.Largura);
                    textBoxComprimento.Text = Convert.ToString(produtos.Comprimento);
                    textBoxModelo.Text = produtos.Modelo;
                    textBoxPeso.Text = Convert.ToString(produtos.Peso);
                    textBoxPrecoPromotion.Text = Convert.ToString(produtos.PrecoPromocional);
                    textBox_Marca.Text = produtos.Marca;
                    comboBoxCategorias.Text = Convert.ToString(produtos.CodLoja);
                    labelProdAtual.Text = Convert.ToString(index);
                    comboBoxCategorias.Text = Convert.ToString(produtos.CodCategoria);
                    textBoxCodBarras.Text = produtos.CodigoBarras;
                    textBoxEstoque.Text = Convert.ToString(produtos.Estoque);
                    textBoxCodigoLoja.Text = Convert.ToString(produtos.CodLoja);
                }
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            ManuseiaProduto AtualizadaProd = new ManuseiaProduto();
            //SqlException exception;
            try 
            {
                AtualizadaProd.AtualizarProd(textBoxReferencia.Text, textBoxDescProduto.Text, textBoxDescDetalhada.Text,textBoxCodigoLoja.Text,comboBoxCategorias.Text,textBoxPeso.Text,
                    textBoxAltura.Text,textBoxLargura.Text,textBoxComprimento.Text,textBoxEstoque.Text,textBoxPreço.Text,textBoxPrecoPromotion.Text,textBoxModelo.Text,textBox_Marca.Text,textBoxCodBarras.Text) ;
                MessageBox.Show("Produto Atualizado");
            }

            catch
            {
                MessageBox.Show("Erro ao atualizar"+e);
            }
        }

   

        private void button_Edit_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            labelQtdProdutos.Text = "0";
            labelProdAtual.Text = "0";
            textBoxReferencia.Text = "";
            textBoxIdItem.Text = "";
            textBoxDescProduto.Text = "";
            textBoxDescDetalhada.Text = "";
            textBoxAltura.Text = "";
            textBoxLargura.Text = "";
            textBoxComprimento.Text = "";
            textBoxModelo.Text = "";
            textBoxPeso.Text = "";
            textBoxPrecoPromotion.Text = "";
            textBox_Marca.Text = "";
            comboBoxCategorias.Text = "";
            labelProdAtual.Text = "";
            comboBoxCategorias.Text = "";
            textBoxCodBarras.Text = "";
            textBoxEstoque.Text = "";
            index = 0;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }
    }
}
