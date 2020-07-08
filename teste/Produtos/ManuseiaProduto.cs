using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using teste.DAO;
using System.Data.SqlClient;
using teste.ProdutosClass;
using System.Windows.Forms;

namespace teste.Produtos
{
    public class ManuseiaProduto
    {
        String ProdAtualizado;

        public String AtualizarProd(string Referencia, string DescricaoProduto, string DescricaoDetalhada, string CodigoLoja,string CodigoCategoria, 
            string Peso,string Altura, string Largura,string Comprimento,string Estoque,string Preco,string PrecoPromocional,string Modelo,
            string Marca,string CodigoBarras) 
        {
            ConexaoBanco con = new ConexaoBanco();
            SqlCommand cmd = new SqlCommand();
            cmd.Parameters.AddWithValue("@Referencia", Referencia);
            cmd.Parameters.AddWithValue("@DescricaoProduto", DescricaoProduto);
            cmd.Parameters.AddWithValue("@DescricaoDetalhada", DescricaoDetalhada);
            cmd.Parameters.AddWithValue("@CodigoLoja", CodigoLoja);
            cmd.Parameters.AddWithValue("@CodigoCategoria", CodigoCategoria);
            cmd.Parameters.AddWithValue("@Peso", Peso);
            cmd.Parameters.AddWithValue("@Altura", Altura);
            cmd.Parameters.AddWithValue("@Largura", Largura);
            cmd.Parameters.AddWithValue("@Comprimento", Comprimento);
            cmd.Parameters.AddWithValue("@Estoque", Estoque);
            cmd.Parameters.AddWithValue("@Preco", Preco);
            cmd.Parameters.AddWithValue("@PrecoPromocional", PrecoPromocional);
            cmd.Parameters.AddWithValue("@Modelo", Modelo);
            cmd.Parameters.AddWithValue("@Marca", Marca);
            cmd.Parameters.AddWithValue("@CodigoBarras", CodigoBarras);
            cmd.CommandText =
                            "USE ProMAil" +
                            "  UPDATE dbo.Produtos SET" +
                            "  DescricaoProduto = @DescricaoProduto" +
                            "  ,DescricaoDetalhada = @DescricaoDetalhada" +
                            "  ,CodigoLoja = @CodigoLoja" +
                            "  ,CodigoCategoria = @CodigoCategoria" +
                            "  ,Peso = @Peso" +
                            "  ,Altura = @Altura" +
                            "  ,Largura = @Largura" +
                            "  ,Comprimento = @Comprimento" +
                            "  ,Estoque = @Estoque" +
                            "  ,Preco = @Preco" +
                            "  ,PrecoPromocional = @PrecoPromocional" +
                            "  ,Modelo = @Modelo" +
                            "  ,Marca = @Marca" +
                            "  ,CodigoBarras = @CodigoBarras" +
                            " WHERE REFERENCIA = @Referencia";
            cmd.Connection = con.Conectar();
            try 
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Atualizado");
            }
            catch(SqlException e) { MessageBox.Show("Erro ao atualizar" + e); }


            return ProdAtualizado;
        }


        //public string CadastraProduto (string Descricao,string DescricaoDetalhada,string Categoria,string Marca,string Peso,string Altura,string largura,string estoque,string preco)
        //{


        //    ConexaoBanco con = new ConexaoBanco();
        //    SqlCommand cmd = new SqlCommand();
        //    cmd.Parameters.AddWithValue("@Idproduto", Idproduto);
        //    cmd.Parameters.AddWithValue("@ItemProduto", ItemProduto);
        //    cmd.Parameters.AddWithValue("@DescricaoDetalhada", DescricaoDetalhada);
        //    cmd.Parameters.AddWithValue("@DescricaoProduto", DescricaoProduto);
        //    cmd.Parameters.AddWithValue("@CodCategoria", CodCategoria);
        //    cmd.CommandText = "UPDATE TPRODUTO SET DESCRICAOPRODUTO = @DescricaoProduto,DESCRICAODETALHADA = @DescricaoDetalhada where IDPRODUTO = @Idproduto";
        //    cmd.Connection = con.Conectar();
        //    try
        //    {
        //        cmd.ExecuteNonQuery();
        //        MessageBox.Show("Atualizado");
        //    }
        //    catch (SqlException e) { MessageBox.Show("Erro ao atualizar" + e); }



        //    return ProdAtualizado;

        //}


    }
}
