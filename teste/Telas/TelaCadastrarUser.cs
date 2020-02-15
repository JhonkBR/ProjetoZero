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
                labelErroSenha.Text = ("SENHA NÃO COINCIDEM!");
                labelErroSenha.ForeColor = Color.Red;

            }
            
            else if (mail.ValidaEmailValido(textEmail.Text) == false ||ps.Possuiemail(textEmail.Text) == true)
                { 
                labelErrorEmail.Text = ("E-MAIL INVÁLIDO!");
                labelErrorEmail.ForeColor = Color.Red;
            }
            else {
                
                string retornoString = Convert.ToString(retorno);
                if (retornoString == "Aceitavel" || retornoString == "Forte" || retornoString == "Segura")
                {

                    ManipulaBanco login = new ManipulaBanco();
                    login.CadastrarLogin(textCadLogin.Text, textCadSenha1.Text, textEmail.Text);
                    MessageBox.Show(login.mensagem);
                    textCadSenha.Clear();
                    textCadSenha1.Clear();
                    textCadLogin.Clear();
                    textEmail.Clear();
                    labelErroSenha.Text = ("SENHA FORTE!");
                    labelErroSenha.ForeColor = Color.Green;

                }
                else {
                    labelErroSenha.Text = ("SENHA FRACA!");
                    labelErroSenha.ForeColor = Color.Red;
                }


            }
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
                labelUsuario.Text = ("O USUÁRIO NO MÍNIMO 5 CARACTERES!");
                labelUsuario.ForeColor = Color.Red;
                textCadLogin.Clear();
            }
            else if (novologin2.Length > 1) {

                labelUsuario.Text = ("USUÁRIO NÃO PODE CONTER ESPAÇOS");
                labelUsuario.ForeColor = Color.Red;
                textCadLogin.Clear();
            }

            else
            {
                if (pesq.tem == true)
                {


                    labelUsuario.Text = ("USUÁRIO EXISTENTE!");
                    labelUsuario.ForeColor = Color.Red;
                    textCadSenha.Clear();
                    textCadSenha1.Clear();
                    textCadLogin.Clear();
                    textEmail.Clear();
                }
                else {
                    labelUsuario.Text = ("USUÁRIO VÁLIDO OU JÁ CADASTRADO!");
                    labelUsuario.ForeColor = Color.Green;
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
