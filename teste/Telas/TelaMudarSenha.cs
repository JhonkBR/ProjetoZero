using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using teste.Controle;
using static teste.Controle.ForcaSenha;

namespace teste.Telas
{
    public partial class TelaMudarSenha : Form
    {
        public TelaMudarSenha()
        {
            InitializeComponent();
        }

        private void labelTexto_Click(object sender, EventArgs e)
        {

        }

        private void TelaMudarSenha_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            Form1 telaLogin = new Form1();
            telaLogin.Show();
            this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ValidaSegurancaSenha vl = new ValidaSegurancaSenha();
            ForcaDaSenha retorno = vl.GetForcaDaSenha(TextBoxNewSenha.Text);
            string retornoString = Convert.ToString(retorno);
            MessageBox.Show(retornoString);


        }
            }
        }
    
