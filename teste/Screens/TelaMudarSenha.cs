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
using teste.DAO;
using static teste.Controle.ForcaSenha;

namespace teste.Telas
{
    public partial class TelaMudarSenha : Form
    {
        public static string Credencial { get; set; }// Criado estático para pegar o usuário
        public TelaMudarSenha()
        {
            InitializeComponent();
        }
        ManipulaBanco Banco = new ManipulaBanco();

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
            if (TextBoxNewSenha.Text != null && TextBoxConfirmNewSenha != null)
            {

                if (TextBoxConfirmNewSenha.Text == TextBoxNewSenha.Text)
                {
                    ValidaSegurancaSenha vl = new ValidaSegurancaSenha();
                    ForcaDaSenha retorno = vl.GetForcaDaSenha(TextBoxNewSenha.Text);
                    string retornoString = Convert.ToString(retorno);
                    if (retornoString == "Aceitavel" || retornoString == "Forte" || retornoString == "Segura")
                    {
                        ManipulaBanco Atualiza = new ManipulaBanco();
                        try
                        {
                            Atualiza.AlteraSenha(TextBoxConfirmNewSenha.Text, Credencial);
                            labelErrorRecSenha.Text = ("Senha alterada com êxito!!");
                            labelErrorRecSenha.Visible = true;
                            labelErrorRecSenha.ForeColor = Color.Red;
                            this.Dispose();
                            Form1 login = new Form1();
                            login.Show();
                            
                        }
                        catch {
                            MessageBox.Show("Erro ao alterar a senha, favor verifique sua conexão com o banco de dados.");
                        }
                    }
                    else {
                        labelErrorRecSenha.Text = "Senha fraca!";
                        labelErrorRecSenha.ForeColor = Color.Red;
                        TextBoxConfirmNewSenha.Clear();
                        TextBoxNewSenha.Clear();
                    }

                }
                else {
                    labelErrorRecSenha.Text= ("Senhas não batem");
                    labelErrorRecSenha.ForeColor = Color.Red;
                    TextBoxConfirmNewSenha.Clear();
                    TextBoxNewSenha.Clear();
                }

            }
            else {
                labelErrorRecSenha.Text = ("Campo em branco!");
                labelErrorRecSenha.ForeColor = Color.Red;
            }

        }
            }
        }
    
