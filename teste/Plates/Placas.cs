using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace teste.Placas
{
    public class Placas
    {

        [JsonProperty("ano")]
        public string Ano { get; set; }
        
        [JsonProperty ("anoModelo")]
        public string AnoModelo { get; set; }

        [JsonProperty("chassi")]
        public string Chassi { get; set; }

        [JsonProperty("codigoRetorno")]
        public string CodigoRetorno { get; set; }
        
        [JsonProperty("codigoSituacao")]
        public string CodigoSituacao { get; set; }

        [JsonProperty("cor")]
        public string Cor { get; set; }

        [JsonProperty("data")]
        public string Data { get; set; }

        [JsonProperty("dataAtualizacaoAlarme")]
        public string DataAtualizacaoAlarme { get; set; }
        [JsonProperty("dataAtualizacaoCaracteristicasVeiculo")]
        public string DataAtualizacaoCaracteristicasVeiculo { get; set; }
        [JsonProperty("dataAtualizacaoRouboFurto")]
        public string DataAtualizacaoRouboFurto { get; set; }
        [JsonProperty("marca")]
        public string Marca { get; set; }
        [JsonProperty("mensagemRetorno")]
        public string MensagemRetorno { get; set; }
        [JsonProperty("modelo")]
        public string Modelo { get; set; }
        [JsonProperty("municipio")]
        public string Municipio { get; set; }
        [JsonProperty("placa")]
        public string Placa { get; set; }
        [JsonProperty("situacao")]
        public string Situacao { get; set; }
        [JsonProperty("uf")]
        public string Uf { get; set; }

    }
}
