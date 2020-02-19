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

      
        public Produtos ConsultProd(string codProduto)
        {
            Produtos TodosProdutos = new Produtos();
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
            " FROM [dbo].[TPRODUTO]" +
            " WHERE IDPRODUTO = @Idproduto";
            cmd.Parameters.AddWithValue("@Idproduto", codProduto);
            cmd.Connection = con.Conectar();
            SqlDataReader prod = cmd.ExecuteReader();
            while (prod.Read())
            {

                TodosProdutos.Idproduto = prod["IDPRODUTO"].ToString();
                TodosProdutos.ItemProduto = prod["IDITEM"].ToString();
                TodosProdutos.LinkSite = (Convert.ToString((prod["LINKSITE"])));
                TodosProdutos.DescricaoDetalhada = (Convert.ToString((prod["DESCRICAODETALHADA"])));
                TodosProdutos.MetaTag = (Convert.ToString((prod["METATAG"])));
                TodosProdutos.ItemProduto = (Convert.ToString((prod["IDITEM"])));
                TodosProdutos.DescricaoProduto = (Convert.ToString(prod["DESCRICAOPRODUTO"]));
                TodosProdutos.PalavrasSub = (Convert.ToString((prod["PALAVRASSUB"])));
                TodosProdutos.CodSite = Convert.ToString((prod["CODSITE"]));
                TodosProdutos.CodCategoria = Convert.ToString(prod["CODCATEGORIA"]);
                TodosProdutos.CodLoja = Convert.ToString(prod["CODLOJA"]);
            }

            return TodosProdutos;
        }


    }
}
