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

            if (textBoxIdProduto.Text =="")
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
                    textBoxLinkSite.Text = produtos.LinkSite;
                    textBoxDescDetalhada.Text = produtos.DescricaoDetalhada;
                    textBoxMetaTag.Text = produtos.MetaTag;
                    textBoxPalavrasSub.Text = produtos.PalavrasSub;
                    comboBoxSite.Text = produtos.CodSite;
                    comboBoxLoja.Text = produtos.CodLoja;
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
                    textBoxLinkSite.Text = produtos.LinkSite;
                    textBoxDescDetalhada.Text = produtos.DescricaoDetalhada;
                    textBoxMetaTag.Text = produtos.MetaTag;
                    textBoxPalavrasSub.Text = produtos.PalavrasSub;
                    comboBoxSite.Text = produtos.CodSite;
                    comboBoxLoja.Text = produtos.CodLoja;
                    comboBoxCategorias.Text = produtos.CodCategoria;
                }
            }
            
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
                textBoxLinkSite.Text = ListTest[index].LinkSite;
                textBoxDescDetalhada.Text = ListTest[index].DescricaoDetalhada;
                textBoxMetaTag.Text = ListTest[index].MetaTag;
                textBoxPalavrasSub.Text = ListTest[index].PalavrasSub;
                comboBoxSite.Text = ListTest[index].CodSite;
                comboBoxLoja.Text = ListTest[index].CodLoja;
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
            textBoxLinkSite.Text = "";
            textBoxDescDetalhada.Text = "";
            textBoxMetaTag.Text = "";
            textBoxPalavrasSub.Text = "";
            comboBoxSite.Text = "";
            comboBoxLoja.Text = "";
            comboBoxCategorias.Text = "";
            index = 0;

        }
    }
}
