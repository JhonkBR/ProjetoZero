using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using teste.DAO;

namespace teste.ProdutosClass
{
    public class PesquisaProdutos
    {
        public  List<ProdutosBD> ConsultProd()
        {
            // Busca todos os produtos   
            List<ProdutosBD> ProductList = new List<ProdutosBD>();
            ConexaoBanco con = new ConexaoBanco();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT IDPRODUTO " +
            " ,IDITEM" +
            " ,DESCRICAOPRODUTO" +
            " ,LINKSITE" +
            " ,DESCRICAODETALHADA" +
            " ,METATAG" +
            " ,PALAVRASSUB" +
            " ,CODSITE" +
            " ,CODCATEGORIA" +
            " ,CODLOJA" +
            " FROM [dbo].[TPRODUTO]";
            //" WHERE IDPRODUTO = @Idproduto";
            //cmd.Parameters.AddWithValue("@Idproduto", codProduto);
            cmd.Connection = con.Conectar();
            SqlDataReader prod = cmd.ExecuteReader();
            while (prod.Read() == true)
            {

                ProdutosBD TodosProdutos = new ProdutosBD();
                TodosProdutos.Idproduto = prod["IDPRODUTO"].ToString();
                TodosProdutos.ItemProduto = prod["IDITEM"].ToString();
                TodosProdutos.LinkSite = prod["LINKSITE"].ToString();
                TodosProdutos.DescricaoDetalhada = prod["DESCRICAODETALHADA"].ToString();
                TodosProdutos.MetaTag = prod["METATAG"].ToString();
                TodosProdutos.ItemProduto = prod["IDITEM"].ToString();
                TodosProdutos.DescricaoProduto = prod["DESCRICAOPRODUTO"].ToString();
                TodosProdutos.PalavrasSub = prod["PALAVRASSUB"].ToString();
                TodosProdutos.CodSite = prod["CODSITE"].ToString();
                TodosProdutos.CodCategoria = prod["CODCATEGORIA"].ToString();
                TodosProdutos.CodLoja = prod["CODLOJA"].ToString();
                ProductList.Add(TodosProdutos);
                
            }
             return ProductList;
        }


        public List<ProdutosBD> ConsultaProduto(string idproduto) {
            // Consulta de produtos por idproduto, para buscar produto específico.
            List<ProdutosBD> ProductList = new List<ProdutosBD>();
            ConexaoBanco con = new ConexaoBanco();
            SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "SELECT IDPRODUTO, IDITEM,DESCRICAOPRODUTO, LINKSITE, " +
                "DESCRICAODETALHADA,METATAG, PALAVRASSUB, CODSITE,CODCATEGORIA, CODLOJA " +
                "FROM TPRODUTO WHERE IDPRODUTO = @IDPRODUTO";
            cmd.Parameters.AddWithValue("@IDPRODUTO", idproduto);
            cmd.Connection = con.Conectar();
            SqlDataReader prod = cmd.ExecuteReader();
            while (prod.Read() == true)
            {
                ProdutosBD TodosProdutos = new ProdutosBD();
                TodosProdutos.Idproduto = prod["IDPRODUTO"].ToString();
                TodosProdutos.ItemProduto = prod["IDITEM"].ToString();
                TodosProdutos.LinkSite = prod["LINKSITE"].ToString();
                TodosProdutos.DescricaoDetalhada = prod["DESCRICAODETALHADA"].ToString();
                TodosProdutos.MetaTag = prod["METATAG"].ToString();
                TodosProdutos.ItemProduto = prod["IDITEM"].ToString();
                TodosProdutos.DescricaoProduto = prod["DESCRICAOPRODUTO"].ToString();
                TodosProdutos.PalavrasSub = prod["PALAVRASSUB"].ToString();
                TodosProdutos.CodSite = prod["CODSITE"].ToString();
                TodosProdutos.CodCategoria = prod["CODCATEGORIA"].ToString();
                TodosProdutos.CodLoja = prod["CODLOJA"].ToString();
                ProductList.Add(TodosProdutos);

            }


            return ProductList;
        }

    }
}
