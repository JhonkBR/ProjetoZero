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
        public TelaRecuperarSenha()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
 
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void buttonRecuperarSenha_Click(object sender, EventArgs e)
        {
            Email vl = new Email();
            if (vl.ValidaEmailValido(TextLoginRecuperar.Text) == true)
            {
                RetornaBanco ps = new RetornaBanco();

                if (ps.Possuiemail(TextLoginRecuperar.Text) == true)
                {

                    GeraPin gera = new GeraPin();
                    int guid = Convert.ToInt32(gera.RetornaGuid());
                    login login = new login();
                    login.CadastraPinSenha(TextLoginRecuperar.Text, guid);
                    Email enviar = new Email();
                    if (textBoxPin.Visible == false)
                    {


                        if (enviar.EnviaEmail(TextLoginRecuperar.Text, guid) == true)
                        {

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
                    if (textBoxPin.Text != "" && textBoxPin.Visible == false)
                    {
                        login lg = new login();
                        if (login.PesquisaPin(TextLoginRecuperar.Text, guid) == true)
                        {
                            MessageBox.Show("Recuperando senha");
                        }
                        else {
                            MessageBox.Show("Erro ao encontrar o PIN favor verifique!");
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
            //conso
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

