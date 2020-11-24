using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teste.Product
{
    public class UpdateProduct
    {
       

        public string Updateproduct(){
            string query;

            query = @"USE ProMAil
                           UPDATE dbo.Produtos SET
                           DescricaoProduto = @DescricaoProduto 
                           ,DescricaoDetalhada = @DescricaoDetalhada 
                           ,CodigoLoja = @CodigoLoja 
                           ,CodigoCategoria = @CodigoCategoria 
                           ,Peso = @Peso 
                           ,Altura = @Altura 
                           ,Largura = @Largura 
                           ,Comprimento = @Comprimento 
                           ,Estoque = @Estoque 
                           ,Preco = @Preco 
                           ,PrecoPromocional = @PrecoPromocional 
                           ,Modelo = @Modelo 
                           ,Marca = @Marca 
                           ,CodigoBarras = @CodigoBarras 
                          WHERE REFERENCIA = @Referencia";


            return query;
        }


    }
}
