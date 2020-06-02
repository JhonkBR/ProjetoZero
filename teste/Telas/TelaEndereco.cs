using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RestSharp;
using RestSharp.Deserializers;
using RestSharp.Serialization.Json;
using teste.Busca_Correios;

namespace teste.Telas
{
    public partial class TelaEndereco : Form
    {
        public TelaEndereco()
        {
            InitializeComponent();
        }

        private void buttonPesquisar_Click(object sender, EventArgs e)
        {
            if (textBoxCep.TextLength == 8)
            {
                IRestClient restClient = new RestClient(string.Format("https://viacep.com.br/ws/{0}/json/",textBoxCep.Text));
                RestRequest restRequest = new RestRequest(Method.GET);
                IRestResponse restResponse = restClient.Execute(restRequest);

                if (restResponse.ContentLength < -1 || restResponse.StatusCode == System.Net.HttpStatusCode.BadRequest)
                {
                    MessageBox.Show("Houve um problema com sua requisição: " + restResponse.Content, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    BuscaApiCorreios buscaApiCorreios = new JsonDeserializer().Deserialize<BuscaApiCorreios>(restResponse);
                    // Pega o Json e deserializa

                    if ((textBoxCep.Text = buscaApiCorreios.Cep) is null)
                    {
                        MessageBox.Show("Cep não encontrado!" + restResponse.Content, "Atenção! \n", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }
                    else
                    {

                        textBoxBairro.Text = buscaApiCorreios.Bairro;
                        textBoxComplemento.Text = buscaApiCorreios.Complemento;
                        textBoxLogradouro.Text = buscaApiCorreios.Logradouro;
                        textBoxCidade.Text = buscaApiCorreios.Localidade;
                        textBoxUf.Text = buscaApiCorreios.Uf;
                        textBoxCodIbje.Text = buscaApiCorreios.Ibge;
                        textBoxUnidade.Text = buscaApiCorreios.Unidade;
                    }
                }
            }
            else { MessageBox.Show("CEP Inválido"); }
        }

        private void TelaEndereco_Load(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
