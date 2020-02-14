using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using teste.Controle;
using teste.DAO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static teste.Controle.ForcaSenha;

namespace teste.Telas
{
    public partial class CadastrarUser : Form
    {
        public CadastrarUser()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);


        private void CadastrarUser_Load(object sender, EventArgs e)
        {

        }

        private void buttonCadastrar_Click(object sender, EventArgs e)
        {
            Email mail = new Email();
            RetornaBanco ps = new RetornaBanco();
            ValidaSegurancaSenha Senha = new ValidaSegurancaSenha();
            ForcaDaSenha retorno = Senha.GetForcaDaSenha(textCadSenha.Text);

            if (textCadSenha.Text != textCadSenha1.Text)
            {
                MessageBox.Show("SENHA NÃO COINCIDEM!");

            }
            else if (textCadLogin.Text.Length < 5)
            {
                MessageBox.Show("O USUÁRIO DEVE POSSUIR NO MÍNIMO 5 CARACTERES!");

            }

            
            else if (mail.ValidaEmailValido(textEmail.Text) == false ||ps.Possuiemail(textEmail.Text) == true)
                { 
                MessageBox.Show("E-mail inválido! ou já cadastrado");
            }
            else {
                
                string retornoString = Convert.ToString(retorno);
                if (retornoString == "Aceitavel" || retornoString == "Forte" || retornoString == "Segura")
                {

                    ManipulaBanco login = new ManipulaBanco();
                    login.CadastrarLogin(textCadLogin.Text, textCadSenha1.Text, textEmail.Text);
                    MessageBox.Show(login.mensagem);
                    textCadSenha.Text = "";
                    textCadSenha1.Text = "";
                    textCadLogin.Text = "";
                    textEmail.Text = "";

                }
                else {
                    MessageBox.Show("Senha fraca");
                }

            }
            //else if (textCadSenha.Text.Length < 4)
            //{
            //    MessageBox.Show("A SENHA DEVE POSSUIR NO MÍNIMO 5 CARACTERES!");

                //}
                //else if (textCadSenha.Text == "")
                //{
                //    MessageBox.Show("SENHA EM BRANCO!");

                //}
            

            //else
            //{

            //}
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void CadastrarUser_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            Form1 a = new Form1();
            a.Visible = true;
            this.Close();
        }

        private void lineShape2_Click(object sender, EventArgs e)
        {


        }

        private void textCadLogin_Leave(object sender, EventArgs e)
        {
            RetornaBanco pesq = new RetornaBanco();
            pesq.PossuiUser(textCadLogin.Text);
            ValidaNome nome = new ValidaNome();
            //fiz um comando comum para para mostrar o acesso e finalizar
            string novologin = textCadLogin.Text;
            string[] novologin2 = novologin.Split(' ');


            if (nome.RetornaNome(textCadLogin.Text) == true)
            {
                MessageBox.Show("Usuário inválido, deve possuir mais de 5 caracteres");
                textCadLogin.Clear();

            }
            else if (novologin2.Length > 1) {

                MessageBox.Show("Usuário não pode conter espaços");
                textCadLogin.Clear();
            }

            else
            {
                if (pesq.tem == true)
                {

                    MessageBox.Show("USUÁRIO JÁ EXISTE! FAVOR INFORMAR UM NOVO USUÁRIO");
                    textCadSenha.Text = "";
                    textCadSenha1.Text = "";
                    textCadLogin.Text = "";
                    textEmail.Text = "";
                }
            }
        }

        private void textCadLogin_TextChanged(object sender, EventArgs e)
        {

        }



        private void textCadLogin_KeyPress(object sender, KeyPressEventArgs e)
         {


        }
    }
}
