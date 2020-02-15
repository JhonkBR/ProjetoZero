using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using teste.DAO;
using System.Data.SqlClient;
namespace teste.Telas
{
    public partial class TelaConfigBanco : Form
    {
        public TelaConfigBanco()
        {
            InitializeComponent();
        }
        // Força o recarregamento de uma seção alterada.
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 login = new Form1();
            login.Show();
        }

        private void buttonVoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 a = new Form1();
            a.Show();

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                Properties.Settings.Default.Servidor = textServ.Text;
                Properties.Settings.Default.Usuario = textUser.Text;
                Properties.Settings.Default.Senha = textSenhaBanco.Text;
                Properties.Settings.Default.Banco = textBanco.Text;
                Properties.Settings.Default.Save();
                labelErrorBanco.Text = ("");
                MessageBox.Show("SALVO COM ÊXITO!");
                lineShape1.Visible = true;
            }
            catch (Exception)
            {
                MessageBox.Show("ERRO AO SALVAR!");
            }
        }


        private void TelaConfigBanco_Load(object sender, EventArgs e)
        {
            textServ.Text = Properties.Settings.Default.Servidor;
            textUser.Text = Properties.Settings.Default.Usuario;
            textSenhaBanco.Text = Properties.Settings.Default.Senha;
            textBanco.Text = Properties.Settings.Default.Banco;
        }

        private void textServ_TextChanged(object sender, EventArgs e)
        {
        }

        private void TesteConex_Click(object sender, EventArgs e)
        {
            //Verifica se está conectado com no banco
            ConexaoBanco con = new ConexaoBanco();
            try
            {
                con.Conectar();
                labelErrorBanco.Text = ("LOGADO COM ÊXITO!");
                labelErrorBanco.ForeColor = Color.Green;
                //MessageBox.Show("Logado com êxito");
                con.Desconectar();
            }
            catch (SqlException)
            {
                MessageBox.Show("Erro ao conectar no banco de dados, favor verificar suas credenciais");
                labelErrorBanco.Text = ("ERRO AO CONECTAR!");
                labelErrorBanco.ForeColor = Color.Red;
            }
        }

        private void textSenhaBanco_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
