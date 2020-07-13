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
                    textBoxDescDetalhada.Enabled = false;
                    textBoxAltura.Enabled = false;
                    textBoxCodBarras.Enabled = false;
                    textBoxCodigoLoja.Enabled = false;
                    textBoxComprimento.Enabled = false;
                    textBoxIdItem.Enabled = false;
                    textBoxEstoque.Enabled = false;
                    textBoxLargura.Enabled = false;
                    textBoxModelo.Enabled = false;
                    textBoxPeso.Enabled = false;
                    textBoxPeso.Enabled = false;
                    textBoxPrecoPromotion.Enabled = false;
                    textBoxPreço.Enabled = false;
                    textBox_Marca.Enabled = false;
                    comboBoxCategorias.Enabled = false;
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


            if (textBoxReferencia.Text == "" && textBoxIdItem.Text == "")
            {
                // cadastrando produto


                try
                {
                    ManuseiaProduto CadastrarProd = new ManuseiaProduto();
                    string Referencia = CadastrarProd.ProdSeqReferencia();
                    string Iditem = CadastrarProd.ProdSeqItem();
                    CadastrarProd.CadastraProduto(Referencia, Iditem, textBoxDescProduto.Text, textBoxDescDetalhada.Text, textBoxCodigoLoja.Text, comboBoxCategorias.Text, textBoxPeso.Text,
                    textBoxAltura.Text, textBoxLargura.Text, textBoxComprimento.Text, textBoxEstoque.Text, textBoxPreço.Text, textBoxPrecoPromotion.Text, textBoxModelo.Text, textBox_Marca.Text, textBoxCodBarras.Text);
                    textBoxDescDetalhada.Enabled = false;
                    textBoxAltura.Enabled = false;
                    textBoxCodBarras.Enabled = false;
                    textBoxCodigoLoja.Enabled = false;
                    textBoxComprimento.Enabled = false;
                    textBoxIdItem.Enabled = false;
                    textBoxEstoque.Enabled = false;
                    textBoxLargura.Enabled = false;
                    textBoxModelo.Enabled = false;
                    textBoxPeso.Enabled = false;
                    textBoxPeso.Enabled = false;
                    textBoxPrecoPromotion.Enabled = false;
                    textBoxPreço.Enabled = false;
                    textBox_Marca.Enabled = false;
                    comboBoxCategorias.Enabled = false;
                    textBoxReferencia.Enabled = true;
                    textBoxReferencia.BackColor = Color.FromArgb(236, 240, 241);
                    textBoxReferencia.Text = Referencia;
                    textBoxIdItem.BackColor = Color.FromArgb(236, 240, 241);
                    textBoxIdItem.Text = Iditem;
                    pictureBoxClean.Enabled = true;
                    pictureBoxEditar.Enabled = true;


                }


                catch(Exception error) {
                    MessageBox.Show("Falha ao cadastrar" + error);
                
                }
            }
            else
            {

                try
                {

                    //atualizando produto
                    ManuseiaProduto AtualizadaProd = new ManuseiaProduto();
                    //SqlException exception;

                    AtualizadaProd.AtualizarProd(textBoxReferencia.Text, textBoxDescProduto.Text, textBoxDescDetalhada.Text, textBoxCodigoLoja.Text, comboBoxCategorias.Text, textBoxPeso.Text,
                        textBoxAltura.Text, textBoxLargura.Text, textBoxComprimento.Text, textBoxEstoque.Text, textBoxPreço.Text, textBoxPrecoPromotion.Text, textBoxModelo.Text, textBox_Marca.Text, textBoxCodBarras.Text);
                    textBoxDescDetalhada.Enabled = false;
                    textBoxAltura.Enabled = false;
                    textBoxCodBarras.Enabled = false;
                    textBoxCodigoLoja.Enabled = false;
                    textBoxComprimento.Enabled = false;
                    textBoxIdItem.Enabled = false;
                    textBoxEstoque.Enabled = false;
                    textBoxLargura.Enabled = false;
                    textBoxModelo.Enabled = false;
                    textBoxPeso.Enabled = false;
                    textBoxPeso.Enabled = false;
                    textBoxPrecoPromotion.Enabled = false;
                    textBoxPreço.Enabled = false;
                    textBox_Marca.Enabled = false;
                    comboBoxCategorias.Enabled = false;



                }

                catch
                {
                    MessageBox.Show("Erro ao atualizar." + e);
                }

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
            textBoxAltura.Text = "0";
            textBoxLargura.Text = "0";
            textBoxComprimento.Text = "0";
            textBoxModelo.Text = "";
            textBoxPeso.Text = "0";
            textBoxPrecoPromotion.Text = "0";
            textBox_Marca.Text = "";
            comboBoxCategorias.Text = "";
            labelProdAtual.Text = "";
            comboBoxCategorias.Text = "";
            textBoxCodBarras.Text = "";
            textBoxEstoque.Text = "0";
            textBoxPreço.Text = "0";
            textBoxCodigoLoja.Text = "";
            index = 0;

            textBoxDescDetalhada.Enabled = false;
            textBoxDescDetalhada.BackColor = Color.Gainsboro;

            textBoxAltura.Enabled = false;
            textBoxAltura.BackColor = Color.Gainsboro;

            textBoxCodBarras.Enabled = false;
            textBoxCodBarras.BackColor = Color.Gainsboro;

            textBoxCodigoLoja.Enabled = false;
            textBoxCodigoLoja.BackColor = Color.Gainsboro;

            textBoxComprimento.Enabled = false;
            textBoxComprimento.BackColor = Color.Gainsboro;

            textBoxIdItem.Enabled = false;
            textBoxIdItem.BackColor = Color.Gainsboro;

            textBoxEstoque.Enabled = false;
            textBoxEstoque.BackColor = Color.Gainsboro;

            textBoxLargura.Enabled = false;
            textBoxLargura.BackColor = Color.Gainsboro;

            textBoxModelo.Enabled = false;
            textBoxModelo.BackColor = Color.Gainsboro;

            textBoxPeso.Enabled = false;
            textBoxPeso.BackColor = Color.Gainsboro;

            textBoxPeso.Enabled = false;
            textBoxPeso.BackColor = Color.Gainsboro;

            textBoxPrecoPromotion.Enabled = false;
            textBoxPrecoPromotion.BackColor = Color.Gainsboro;

            textBoxPreço.Enabled = false;
            textBoxPreço.BackColor = Color.Gainsboro;

            textBox_Marca.Enabled = false;
            textBox_Marca.BackColor = Color.Gainsboro;

            comboBoxCategorias.Enabled = false;
            comboBoxCategorias.BackColor = Color.Gainsboro;
            pictureBoxSalvar.Enabled = false;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            pictureBoxPesquisa.Enabled = false;
            pictureBoxClean.Enabled = false;
            pictureBoxEditar.Enabled = false;
            pictureBoxSalvar.Enabled = true;
            textBoxReferencia.Enabled = false;
            textBoxReferencia.BackColor = Color.Gainsboro;
            textBoxIdItem.Enabled = false;
            textBoxIdItem.BackColor =  Color.Gainsboro;
            labelQtdProdutos.Text = "0";
            labelProdAtual.Text = "0";
            textBoxReferencia.Text = "";
            textBoxIdItem.Text = "";
            textBoxDescProduto.Text = "";
            textBoxDescDetalhada.Text = "";
            textBoxAltura.Text = "0";
            textBoxLargura.Text = "0";
            textBoxComprimento.Text = "0";
            textBoxModelo.Text = "";
            textBoxPeso.Text = "0";
            textBoxPrecoPromotion.Text = "0";
            textBox_Marca.Text = "";
            comboBoxCategorias.Text = "";
            labelProdAtual.Text = "";
            comboBoxCategorias.Text = "";
            textBoxCodBarras.Text = "";
            textBoxEstoque.Text = "0";
            textBoxPreço.Text = "0";
            textBoxCodigoLoja.Text = "";
            // ativação
            textBoxDescDetalhada.Enabled = true;
            textBoxDescDetalhada.BackColor = Color.FromArgb(236, 240, 241);
            textBoxAltura.Enabled = true;
            textBoxAltura.BackColor = Color.FromArgb(236, 240, 241);
            textBoxCodBarras.Enabled = true;
            textBoxCodBarras.BackColor = Color.FromArgb(236, 240, 241);
            textBoxCodigoLoja.Enabled = true;
            textBoxCodigoLoja.BackColor = Color.FromArgb(236, 240, 241);
            textBoxComprimento.Enabled = true;
            textBoxComprimento.BackColor = Color.FromArgb(236, 240, 241);
            textBoxIdItem.Enabled = false;
            textBoxIdItem.BackColor = Color.Gainsboro;
            textBoxEstoque.Enabled = true;
            textBoxEstoque.BackColor = Color.FromArgb(236, 240, 241);
            textBoxLargura.Enabled = true;
            textBoxLargura.BackColor = Color.FromArgb(236, 240, 241);
            textBoxModelo.Enabled = true;
            textBoxModelo.BackColor = Color.FromArgb(236, 240, 241);
            textBoxPeso.Enabled = true;
            textBoxPeso.BackColor = Color.FromArgb(236, 240, 241);
            textBoxPeso.Enabled = true;
            textBoxPeso.BackColor = Color.FromArgb(236, 240, 241);
            textBoxPrecoPromotion.Enabled = true;
            textBoxPrecoPromotion.BackColor = Color.FromArgb(236, 240, 241);
            textBoxPreço.Enabled = true;
            textBoxPreço.BackColor = Color.FromArgb(236, 240, 241);
            textBox_Marca.Enabled = true;
            textBox_Marca.BackColor = Color.FromArgb(236, 240, 241);
            comboBoxCategorias.Enabled = true;
            comboBoxCategorias.BackColor = Color.White;
        }

        private void pictureBoxEditar_Click(object sender, EventArgs e)
        {
            if (textBoxReferencia.Text != null && textBoxReferencia.Text != "") {
                
                textBoxReferencia.Enabled = false;
                textBoxReferencia.BackColor = Color.Gainsboro;

                textBoxIdItem.Enabled = false;
                textBoxIdItem.BackColor = Color.Gainsboro;

                textBoxDescDetalhada.Enabled = true;
                textBoxDescDetalhada.BackColor = Color.FromArgb(236,240,241);

                textBoxAltura.Enabled = true;
                textBoxAltura.BackColor = Color.FromArgb(236, 240, 241);

                textBoxCodBarras.Enabled = true;
                textBoxCodBarras.BackColor = Color.FromArgb(236, 240, 241);

                textBoxCodigoLoja.Enabled = true;
                textBoxCodigoLoja.BackColor = Color.FromArgb(236, 240, 241);

                textBoxComprimento.Enabled = true;
                textBoxComprimento.BackColor = Color.FromArgb(236, 240, 241);

                textBoxEstoque.Enabled = true;
                textBoxEstoque.BackColor = Color.FromArgb(236, 240, 241);

                textBoxLargura.Enabled = true;
                textBoxLargura.BackColor = Color.FromArgb(236, 240, 241);

                textBoxModelo.Enabled = true;
                textBoxModelo.BackColor = Color.FromArgb(236, 240, 241);

                textBoxPeso.Enabled = true;
                textBoxPeso.BackColor = Color.FromArgb(236, 240, 241);

                textBoxPeso.Enabled = true;
                textBoxPeso.BackColor = Color.FromArgb(236, 240, 241);

                textBoxPrecoPromotion.Enabled = true;
                textBoxPrecoPromotion.BackColor = Color.FromArgb(236, 240, 241);
                
                textBoxPreço.Enabled = true;
                textBoxPreço.BackColor = Color.FromArgb(236, 240, 241);

                textBox_Marca.Enabled = true;
                textBox_Marca.BackColor = Color.FromArgb(236, 240, 241);

                comboBoxCategorias.Enabled = true;
                comboBoxCategorias.BackColor = Color.White;

                pictureBoxSalvar.Enabled = true;
            }
        }

        private void pictureBoxCancelar_Click(object sender, EventArgs e)
        {


            this.Dispose();


        }
    }
}
