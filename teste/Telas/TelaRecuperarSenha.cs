using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using teste.Controle;
using teste.DAO;

namespace teste.Telas
{
    public partial class TelaRecuperarSenha : Form
    {
        ManipulaBanco login = new ManipulaBanco();
        Email enviar = new Email();
        public TelaRecuperarSenha()
        {
            InitializeComponent();
        }
        TelaMudarSenha TelaRecup = new TelaMudarSenha();
        GeraPin gera = new GeraPin();

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void buttonRecuperarSenha_Click(object sender, EventArgs e)
        {

            if (TextLoginRecuperar.Text == "j") 
                TextLoginRecuperar.Text = "jhoocandido@gmail.com";
            Email vl = new Email();
            if (vl.ValidaEmailValido(TextLoginRecuperar.Text) == true)
            {
                RetornaBanco ps = new RetornaBanco();
                //

                if (ps.Possuiemail(TextLoginRecuperar.Text) == true)
                {
                    if (textBoxPin.Visible == false)
                    {

                        int guid = Convert.ToInt32(gera.RetornaGuid());

                        if (enviar.EnviaEmail(TextLoginRecuperar.Text, guid) == true)
                        {
                           
                                login.CadastraPinSenha(TextLoginRecuperar.Text, guid);
                                MessageBox.Show("Mensagem enviada com Êxito");
                                TextLoginRecuperar.Enabled = false;
                                label1.Visible = true;
                                lineShape1.Visible = true;
                                textBoxPin.Visible = true;
                            labelMensagemUsuario.Text = "Usuário encontrado!";
                            labelMensagemUsuario.ForeColor = Color.Green;

                        }
                        else
                        {
                            MessageBox.Show("Erro ao enviar mensagem.");
                        }
                    }
                    try
                    {
                        if (textBoxPin.Text != "" && textBoxPin.Visible == true)
                        {
                            ManipulaBanco lg = new ManipulaBanco();
                                if (login.PesquisaPin(TextLoginRecuperar.Text, Convert.ToInt32(textBoxPin.Text)) == true)
                                {
                                    TelaMudarSenha.Credencial = TextLoginRecuperar.Text;
                                    MessageBox.Show("PIN enviado por E-mail!");
                                    TelaRecup.Show();
                                    this.Dispose();

                                }


                                else
                                {
                                    labelMensagemPin.Text = ("PIN não encontrado!");
                                    labelMensagemPin.ForeColor = Color.Red;
                                    textBoxPin.Clear();
                                }

                        }
                    }
                    finally { 
                        labelMensagemPin.Text = ("PIN inválido!");
                    }
                }
                else
                {
                   // MessageBox.Show("E-mail inválido ou não cadastrado, favor verifique!");
                    labelMensagemUsuario.ForeColor = Color.Red;
                    labelMensagemUsuario.Text = ("E-mail inválido ou não cadastrado, favor verifique!");

                }
            }

            else
            {
                labelMensagemUsuario.ForeColor = Color.Red;
                labelMensagemUsuario.Text = ("E-mail inválido ou não cadastrado, favor verifique!");
                TextLoginRecuperar.Clear();
            }
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Form1 telaLogin = new Form1();
            telaLogin.Show();
        }

        private void TelaRecuperarSenha_Load(object sender, EventArgs e)
        {

        }

        private void textBoxPin_TextChanged(object sender, EventArgs e)
        {

        }

        public void TextLoginRecuperar_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

