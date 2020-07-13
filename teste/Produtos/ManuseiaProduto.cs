﻿using System;
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
        string ValorReferencia;
        string  ValorIditem;

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


        public String CadastraProduto(string Referencia,string Iditem,string DescricaoProduto, string DescricaoDetalhada, string CodigoLoja, string CodigoCategoria,
           string Peso, string Altura, string Largura, string Comprimento, string Estoque, string Preco, string PrecoPromocional, string Modelo,
           string Marca, string CodigoBarras)
        {
            ConexaoBanco con = new ConexaoBanco();
            SqlCommand cmd = new SqlCommand();
            cmd.Parameters.AddWithValue("@Referencia", Referencia);
            cmd.Parameters.AddWithValue("@Iditem", Iditem);
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
            cmd.CommandText = "USE ProMail                   "
+ "INSERT INTO dbo.Produtos      "
+ "           (Referencia"
+ "           ,IdItem"
+ "           ,DescricaoProduto"
+ "           ,DescricaoDetalhada"
+ "           ,CodigoLoja        "
+ "           ,CodigoCategoria   "
+ "           ,Peso              "
+ "           ,Altura            "
+ "           ,Largura           "
+ "           ,Comprimento       "
+ "           ,Estoque           "
+ "           ,Preco             "
+ "           ,PrecoPromocional  "
+ "           ,Modelo            "
+ "           ,Marca             "
+ "           ,CodigoBarras)     "
     + "VALUES"
           + "(@Referencia"
           + ",@Iditem"
           + ",@DescricaoProduto"
           + ",@DescricaoDetalhada"
           + ",@CodigoLoja"
           + ",@CodigoCategoria"
           + ",@Peso"
           + ",@Altura"
           + ",@Largura"
           + ",@Comprimento"
           + ",@Estoque"
           + ",@Preco"
           + ",@PrecoPromocional"
           + ",@Modelo"
           + ",@Marca"
           + ",@CodigoBarras)";
            cmd.Connection = con.Conectar();
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("CADASTRADO!");
            }
            catch (SqlException e) { MessageBox.Show("Erro ao CADASTRAR" + e); }


            return ProdAtualizado;
        }

        public string  ProdSeqReferencia()
        {
            ConexaoBanco con = new ConexaoBanco();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "USE ProMail SELECT (MAX(CAST(REFERENCIA AS INT))+10) AS 'REFERENCIA' FROM PRODUTOS";
            cmd.Connection = con.Conectar();
            SqlDataReader referencia = cmd.ExecuteReader();
            while (referencia.Read() == true)
            {
                ValorReferencia = referencia["Referencia"].ToString();
            }
            return ValorReferencia;

        }
        public string ProdSeqItem()
        {
            ConexaoBanco con = new ConexaoBanco();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "USE ProMail SELECT (MAX(CAST(IdItem AS INT))+10) AS 'IDITEM' FROM PRODUTOS";
            cmd.Connection = con.Conectar();
            SqlDataReader Iditem = cmd.ExecuteReader();
            while (Iditem.Read() == true)
            {
                ValorIditem = Iditem["Iditem"].ToString();
            }
            return ValorIditem;
        }

    }
}
