using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using teste.Telas;
using teste.DAO;

namespace teste
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        login login1 = new login();
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        
        /// conteúdo acima é para deixar o painel móvel
        private void button1_Click(object sender, EventArgs e)
        {
        

        }
            
        private void btn_Cadastrar_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_Sair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textSenha_Enter(object sender, EventArgs e)
        {
            if (textSenha.Text == "SENHA")
            {
                textSenha.Text = "";
                textSenha.ForeColor = Color.DimGray;
                textSenha.UseSystemPasswordChar = true;
            }

        }

        private void textSenha_Leave(object sender, EventArgs e)
        {
           
            if (textSenha.Text == "")
            {
                textSenha.Text = "SENHA";
                textSenha.ForeColor = Color.LightGray;
                textSenha.UseSystemPasswordChar = false;
            }
        }

        private void textUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void textUsuario_Enter(object sender, EventArgs e)
        {
            if (textUsuario.Text == "USUARIO")
            {
                textUsuario.Text = "";
                textUsuario.ForeColor = Color.DimGray;
            }

        }

        private void textUsuario_Leave(object sender, EventArgs e)
        {

            if (textUsuario.Text == "")
            {
                textUsuario.Text = "USUARIO";
                textUsuario.ForeColor = Color.LightGray;
            }
            //aqui eu defino o visual no momento do clic no text para design
        }

        private void textSenha_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEncerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
          
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();//Aqui eu defino se o form é movido pelo usuário
            //digo no caso a tela
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void buttonEntrar_Click(object sender, EventArgs e)
        {

            RetornaBanco pesq = new RetornaBanco();
            pesq.Possui(textUsuario.Text, textSenha.Text);
            //fiz um comando comum para para mostrar o acesso e finalizar
            if (textUsuario.Text == "USUARIO" & textSenha.Text == "SENHA")
            {
                MessageBox.Show("CREDENCIAIS EM BRANCO!");
            }
            
            if (pesq.tem == true) {
                this.Hide();
                TelaCentral pai = new TelaCentral();
                pai.Visible = true;
                MessageBox.Show("Online!");
               
            }
            else
            {
                MessageBox.Show("USUÁRIO OU SENHA INVÁLIDO!");
            }

           

        }
       
        private void btn_cadastraruser_Click(object sender, EventArgs e)
        {
            CadastrarUser cad = new CadastrarUser();
            cad.Show();
            this.Hide();
        }

        private void btn_Banco_Click(object sender, EventArgs e)
        {
            TelaConfigBanco a = new TelaConfigBanco();
            a.Show();
            this.Hide();
        }

        private void linkLabelRecupSenha_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            TelaRecuperarSenha tel = new TelaRecuperarSenha();
            tel.Show();

            
        }
    }
        }
    

