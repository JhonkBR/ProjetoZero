using RestSharp;
using RestSharp.Serialization.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using teste.Telas;

namespace teste.Placas
{
    public partial class TelaConsultaPlaca : Form
    {
        public TelaConsultaPlaca()
        {
            InitializeComponent();
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            if (textBoxBuscarPlaca.Text != "") {

                IRestClient restClient = new RestClient(string.Format("https://apicarros.com/v1/consulta/{0}/json", textBoxBuscarPlaca.Text));
                RestRequest restRequest = new RestRequest(Method.GET);
                IRestResponse restResponse = restClient.Execute(restRequest);
                if (restResponse.ContentLength < -1 || restResponse.StatusCode == System.Net.HttpStatusCode.BadRequest)
                {
                    MessageBox.Show("Houve um problema com sua requisição: " + restResponse.Content, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    Placas  placa = new JsonDeserializer().Deserialize<Placas>(restResponse);
                    // Pega o Json e deserializa

                    if ((textBoxBuscarPlaca.Text = placa.Placa) is null)
                    {
                        MessageBox.Show("Placa não encontrado!" + restResponse.Content, "Atenção! \n", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }
                    else
                    {

                        textBoxAno.Text = placa.Ano;
                        textBoxAnoModelo.Text = placa.AnoModelo;
                        textBoxChassi.Text = placa.Chassi;
                        textBoxData.Text = placa.Data;
                        textBoxDataRoubo.Text = placa.DataAtualizacaoRouboFurto;
                        textBoxMarca.Text = placa.Marca;
                        textBoxModelo.Text = placa.Modelo;
                        textBoxMunicipio.Text = placa.Municipio;
                        textBoxPlaca.Text = placa.Placa;
                        textBoxCor.Text = placa.Cor;
                        textBoxSituacao.Text = placa.Situacao;
                        textBoxUF.Text = placa.Uf; 
                    }
                }
            }
            else { MessageBox.Show("Placa Inválida"); }



        }

        private void button1_Click(object sender, EventArgs e)
        {
            TelaCentral Tela = new TelaCentral();
            Tela.Show();
            this.Dispose();
        }
    }
    }

