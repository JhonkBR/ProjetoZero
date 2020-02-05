using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teste.DAO
{
    public class ConexaoBanco
    {

        SqlConnection con = new SqlConnection();

        /*
         -------- REGRAS -----------
        ABRIR UMA INSTÂNCIA 
        INSTÂNCIAR A CONEXÃO COM O BANCO DE DADOS
        MÉTODOS DE CONECTAR E DESCONECTAR
        ----------------------------
        */
        public ConexaoBanco()
        {
            //Construtor
            string serv = Properties.Settings.Default.Servidor;
            string banco = Properties.Settings.Default.Banco;
            string usuario = Properties.Settings.Default.Usuario;
            string senha = Properties.Settings.Default.Senha;
            string conect = string.Format("Data Source= {0}; Initial Catalog= {1}; User Id= {2};Password ={3}", serv, banco, usuario, senha);
            con.ConnectionString = conect;
            //INFORMAÇÕES DO BANCO SERVIDOR E 

        }
        public SqlConnection Conectar()
        {
            // MÉTODO DE CONECTAR, COLOQUEI VAZIO PARA TRAZER O ERRO DO SQL
            if (con.State == System.Data.ConnectionState.Closed) /* Comando para chamar a conexão e conecar no banco de dados.*/
            {
                con.Open();
            }
            return con;
        }

        public void Desconectar()
        {

            if (con.State == System.Data.ConnectionState.Open)
            {//Coloquei um IF caso a conexão estiver aberta
                //Fechar a conexão
                con.Close();

            }
        }
    }
}
