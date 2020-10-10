using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teste.ProdutosClass
{
    public class ProdutosBD
    {
        public string Referencia { get; set; }
        public string IdItem { get; set; }
        public string DescricaoProduto { get; set; }
        public string DescricaoDetalhada { get; set; }
        public int CodCategoria { get; set; }
        public int CodLoja { get; set; }
        public int Peso { get; set; }
        public int Altura { get; set; }
        public int Largura { get; set; }
        public int Comprimento { get; set; }
        public int Estoque { get; set; }
        public int Preco { get; set; }
        public int PrecoPromocional { get; set; }
        public string Modelo { get; set; }
        public string Marca { get; set; }
        public string CodigoBarras { get; set; }
    }
}
