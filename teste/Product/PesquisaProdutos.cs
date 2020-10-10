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
        /* Consulta produtos */

        public  List<ProdutosBD> ConsultProd()
        {

            #region Consulta todos os produtos

            List<ProdutosBD> ProductList = new List<ProdutosBD>();
            ConexaoBanco con = new ConexaoBanco();
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = @"USE ProMAil 
            SELECT Referencia"+
                 ",IdItem"+
                 ",DescricaoProduto"+
                 ",DescricaoDetalhada"+
                 ",CodigoLoja"+
                 ",CodigoCategoria"+
                 ",Peso"+
                 ",Altura"+
                 ",Largura"+
                 ",Comprimento"+
                 ",Estoque"+
                 ",Preco"+
                 ",PrecoPromocional"+
                 ",Modelo" +
                 ",Marca" +
                 ",CodigoBarras " +
              "FROM dbo.Produtos ";
            cmd.Connection = con.Conectar();
            SqlDataReader prod = cmd.ExecuteReader();
            while (prod.Read() == true)
            {
                ProdutosBD Produtos = new ProdutosBD();
                Produtos.Referencia = prod["Referencia"].ToString();
                Produtos.IdItem = prod["IdItem"].ToString();
                Produtos.DescricaoProduto = prod["DescricaoProduto"].ToString();
                Produtos.DescricaoDetalhada = prod["DescricaoDetalhada"].ToString();
                Produtos.CodLoja = Convert.ToInt32(prod["CodigoLoja"].ToString());
                Produtos.CodCategoria = Convert.ToInt32(prod["CodigoCategoria"].ToString());
                Produtos.Peso = Convert.ToInt32 (prod["Peso"].ToString());
                Produtos.Altura = Convert.ToInt32(prod["Altura"].ToString());
                Produtos.Largura = Convert.ToInt32(prod["Largura"].ToString());
                Produtos.Comprimento = Convert.ToInt32(prod["Comprimento"].ToString());
                Produtos.Preco = Convert.ToInt32(prod["Preco"].ToString());
                Produtos.PrecoPromocional = Convert.ToInt32(prod["PrecoPromocional"].ToString());
                Produtos.Modelo = prod["Modelo"].ToString();
                Produtos.Marca = prod["Marca"].ToString();
                Produtos.CodigoBarras = prod["CodigoBarras"].ToString();
                ProductList.Add(Produtos);   
            }
             return ProductList;
        }
        #endregion

        #region Consulta produto específico
        public List<ProdutosBD> ConsultaProduto(string Referencia) {
            // Pesquisa Produto específico
            List<ProdutosBD> ProductList = new List<ProdutosBD>();
            ConexaoBanco con = new ConexaoBanco();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "USE ProMAil " +
             "SELECT Referencia" +
                  ",IdItem" +
                  ",DescricaoProduto" +
                  ",DescricaoDetalhada" +
                  ",CodigoLoja" +
                  ",CodigoCategoria" +
                  ",Peso" +
                  ",Altura" +
                  ",Largura" +
                  ",Comprimento" +
                  ",Estoque" +
                  ",Preco" +
                  ",PrecoPromocional" +
                  ",Modelo" +
                  ",Marca" +
                  ",CodigoBarras " +
               "FROM dbo.Produtos WHERE Referencia = @referencia";
            cmd.Parameters.AddWithValue("@referencia", Referencia);
            cmd.Connection = con.Conectar();
            SqlDataReader prod = cmd.ExecuteReader();
            while (prod.Read() == true)
            {
                ProdutosBD Produtos = new ProdutosBD();
                Produtos.Referencia = prod["Referencia"].ToString();
                Produtos.IdItem = prod["IdItem"].ToString();
                Produtos.DescricaoProduto = prod["DescricaoProduto"].ToString();
                Produtos.DescricaoDetalhada = prod["DescricaoDetalhada"].ToString();
                Produtos.CodLoja = Convert.ToInt32(prod["CodigoLoja"].ToString());
                Produtos.CodCategoria = Convert.ToInt32(prod["CodigoCategoria"].ToString());
                Produtos.Peso = Convert.ToInt32(prod["Peso"].ToString());
                Produtos.Altura = Convert.ToInt32(prod["Altura"].ToString());
                Produtos.Largura = Convert.ToInt32(prod["Largura"].ToString());
                Produtos.Comprimento = Convert.ToInt32(prod["Comprimento"].ToString());
                Produtos.Preco = Convert.ToInt32(prod["Preco"].ToString());
                Produtos.PrecoPromocional = Convert.ToInt32(prod["PrecoPromocional"].ToString());
                Produtos.Modelo = prod["Modelo"].ToString();
                Produtos.Marca = prod["Marca"].ToString();
                Produtos.CodigoBarras = prod["CodigoBarras"].ToString();
                ProductList.Add(Produtos);
            }
            return ProductList;
        }
        #endregion

    }
}
