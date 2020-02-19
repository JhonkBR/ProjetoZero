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

            PesquisaProdutos  RetornaProd = new PesquisaProdutos();
            textBoxIdProduto.Text = RetornaProd.ConsultProd(textBoxIdProduto.Text).Idproduto;
            textBoxIdItem.Text = RetornaProd.ConsultProd(textBoxIdProduto.Text).ItemProduto;
            textBoxDescProduto.Text = RetornaProd.ConsultProd(textBoxIdProduto.Text).DescricaoProduto;
            textBoxLinkSite.Text = RetornaProd.ConsultProd(textBoxIdProduto.Text).LinkSite;
            textBoxDescDetalhada.Text = RetornaProd.ConsultProd(textBoxIdProduto.Text).DescricaoDetalhada;
            textBoxMetaTag.Text = RetornaProd.ConsultProd(textBoxIdProduto.Text).MetaTag;
            textBoxPalavrasSub.Text = RetornaProd.ConsultProd(textBoxIdProduto.Text).PalavrasSub;
            comboBoxSite.Text = RetornaProd.ConsultProd(textBoxIdProduto.Text).CodSite;
            comboBoxCategorias.Text = RetornaProd.ConsultProd(textBoxIdProduto.Text).CodCategoria;
            comboBoxLoja.Text = RetornaProd.ConsultProd(textBoxIdProduto.Text).CodLoja;


            //textBoxDescProduto.Text=(TodosProdutos.DescricaoProduto);

            //ConexaoBanco con = new ConexaoBanco();
            //SqlCommand cmd = new SqlCommand();
            //cmd.CommandText = "SELECT IDPRODUTO " +
            //" ,IDITEM" +
            //" ,DESCRICAOPRODUTO" +
            //" ,LINKSITE" +
            //" ,DESCRICAODETALHADA" +
            //" ,METATAG" +
            //" ,PALAVRASSUB" +
            //" ,CODSITE" +
            //" ,CODCATEGORIA" +
            //" ,CODLOJA" +
            //" FROM [dbo].[TPRODUTO]" +
            //" WHERE IDPRODUTO = @Idproduto";
            //cmd.Parameters.AddWithValue("@Idproduto", "12345");
            //cmd.Connection = con.Conectar();
            //SqlDataReader prod = cmd.ExecuteReader();
            //while (prod.Read())
            //{
            //    textBoxIdProduto.Text = (Convert.ToString(prod["IDPRODUTO"]));
            //    textBoxIdItem.Text = (Convert.ToString((prod["IDITEM"])));
            //    textBoxDescProduto.Text = (Convert.ToString( prod["DESCRICAOPRODUTO"]));
            //    textBoxLinkSite.Text = (Convert.ToString((prod["LINKSITE"])));
            //    textBoxDescDetalhada.Text = (Convert.ToString((prod["DESCRICAODETALHADA"])));
            //    textBoxMetaTag.Text = (Convert.ToString((prod["METATAG"])));
            //    textBoxPalavrasSub.Text = (Convert.ToString((prod["PALAVRASSUB"])));
            //    comboBoxSite.Items.Add(prod["CODSITE"]);
            //    comboBoxSite.Text = Convert.ToString((prod["CODSITE"]));
            //    comboBoxCategorias.Items.Add(prod["CODCATEGORIA"]);
            //    comboBoxCategorias.Text = Convert.ToString(prod["CODCATEGORIA"]);
            //    comboBoxLoja.Items.Add(prod["CODLOJA"]); // Teste add itens combo box
            //    comboBoxLoja.Text = Convert.ToString(prod["CODLOJA"]);
            //}
        }
    }
}
