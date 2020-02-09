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
        login login = new login();
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
                                label1.Visible = true;
                                lineShape1.Visible = true;
                                textBoxPin.Visible = true;
                          
                        }
                        else
                        {
                            MessageBox.Show("Erro ao enviar mensagem.");
                        }
                    }
                    if (textBoxPin.Text != "" && textBoxPin.Visible == true)
                    {
                        login lg = new login();
                        try
                        {
                            if (login.PesquisaPin(TextLoginRecuperar.Text, Convert.ToInt32(textBoxPin.Text)) == true)
                            {
                                MessageBox.Show("Recuperando senha");
                                TelaRecup.Show();
                                this.Dispose();

                            }


                            else
                            {
                                MessageBox.Show("Erro ao encontrar o PIN favor verifique!");
                            }
                        }
                        catch
                        {
                            MessageBox.Show("PIN inválido!");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("E-mail inválido ou não cadastrado, favor verifique!");

                }
            }

            else
            {
                MessageBox.Show("E-mail inválido ou não cadastrado, favor verifique!");

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
    }
}

