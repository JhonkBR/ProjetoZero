using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using teste.DAO;
using System.Collections.Generic;
using System.Data.SqlClient;
using teste.ProdutosClass;
using System.Windows.Forms;

namespace teste.Produtos
{
    public class AtualizaProduto
    {
        String ProdAtualizado;

        public String AtualizarProd(string Idproduto, string ItemProduto, string DescricaoDetalhada, string DescricaoProduto, string CodCategoria) {
            ConexaoBanco con = new ConexaoBanco();
            SqlCommand cmd = new SqlCommand();
            cmd.Parameters.AddWithValue("@Idproduto", Idproduto);
            cmd.Parameters.AddWithValue("@ItemProduto", ItemProduto);
            cmd.Parameters.AddWithValue("@DescricaoDetalhada", DescricaoDetalhada);
            cmd.Parameters.AddWithValue("@DescricaoProduto", DescricaoProduto);
            cmd.Parameters.AddWithValue("@CodCategoria", CodCategoria);
            cmd.CommandText = "UPDATE TPRODUTO SET DESCRICAOPRODUTO = @DescricaoProduto,DESCRICAODETALHADA = @DescricaoDetalhada where IDPRODUTO = @Idproduto";
            cmd.Connection = con.Conectar();
            try 
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Atualizado");
            }
            catch(SqlException e) { MessageBox.Show("Erro ao atualizar" + e); }


            return ProdAtualizado;
        }



    }
}
