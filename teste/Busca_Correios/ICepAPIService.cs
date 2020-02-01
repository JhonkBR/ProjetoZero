using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teste.Busca_Correios
{
    public interface ICepAPIService
    {
        [Get("/ws/{cep}/json")]
        Task<BuscaApiCorreios> GetAddressAsync(string cep);

    }
}
