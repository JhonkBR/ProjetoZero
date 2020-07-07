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
using teste.Telas.Produtos;
using teste.Telas;

namespace teste.Telas
{
    public partial class TelaCentral : Form
    {
        public TelaCentral()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void Painel_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
     
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnEncerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

    

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            TelaProdutos TlProduto = new TelaProdutos();
            TlProduto.Show();

        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();//Aqui eu defino se o form é movido pelo usuário
            //digo no caso a tela
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();//Aqui eu defino se o form é movido pelo usuário
            //digo no caso a tela
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void TelaCentral_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();//Aqui eu defino se o form é movido pelo usuário
            //digo no caso a tela
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btn_VoltarLogin_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 telaLogin = new Form1();
            telaLogin.Show();

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            TelaEndereco FrontEnd = new TelaEndereco();
            FrontEnd.Show();
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {




































































































































































































































































































































































































































































































        }
    }
}
