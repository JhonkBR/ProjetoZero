using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teste.DAO
{
    public class login
    {

        SqlCommand cmd = new SqlCommand();//INSTANCIEI PARA USAR O SQL COMMAND
        ConexaoBanco con = new ConexaoBanco();
        public string mensagem; // A POHA DA MENSAGEM DE ERRO
        public bool mensagemRetorna = false; //RECEBE A MENSAGEM COMO TRUE OU FALSE, TRUE = POSSUI USUÁRIO
        SqlDataReader dr;//ESSA BOSTA CONTA QUANTAS LINHAS FORAM AFETAS NO SQL


        //MÉTODO DE CADASTRAR LOGIN
        public string CadastrarLogin(string usuario, string senha, String email)
        {
            // Comando sql -- Insert -- Sqlcommand
            cmd.CommandText = "INSERT INTO LOGIN (USUARIO,SENHA,email) VALUES (@USUARIO,@SENHA,@EMAIL)";

            //Parametros
            cmd.Parameters.AddWithValue("@USUARIO", usuario);
            cmd.Parameters.AddWithValue("@SENHA", senha);
            cmd.Parameters.AddWithValue("@EMAIL", email);

            //conectar -- Conexao
            try
            {
                cmd.Connection = con.Conectar(); //executar
                cmd.ExecuteNonQuery();
                con.Desconectar();
                this.mensagem = "Cadastrado com sucesso!!!!";
            }
            catch (SqlException e)
            {
                this.mensagem = "Erro ao conectar com o banco de dados, DEU MERDA" + e;
            }

            // Sair
            //Mostrar mensagem de erro ou 


            return mensagem;
        }

        //MÉTODO DE PESQUISAR O LOGIN
        public bool RetornaLogin(string usuario, string senha)
        {
            cmd.CommandText = "SELECT USUARIO,SENHA FROM LOGIN  WHERE USUARIO = @USUARIO AND SENHA = @SENHA";
            cmd.Parameters.AddWithValue("@USUARIO", usuario);
            cmd.Parameters.AddWithValue("@SENHA", senha);
            try
            {
                cmd.Connection = con.Conectar();
                dr = cmd.ExecuteReader();//ARMAZENA O RESULTADO EM DR

                if (dr.HasRows/* CASO O RESULTADO RETORNE LINHAS AFETADAS, SETA O VALOR PARA TRUE */)
                {
                    mensagemRetorna = true;
                    con.Desconectar();// DESCONECTA DO BANCO
                }
            }
            catch (SqlException)
            {
                this.mensagem = "ERRO AO ACESSAR BANCO DE DADOS, FAVOR VERIFIQUE SUA CONEXÃO...";

            }
            finally
            {
                con.Desconectar();
            }

            return mensagemRetorna;

        }
        public bool RetornaLoginUser(string usuario)
        {
            cmd.CommandText = "SELECT USUARIO FROM LOGIN  WHERE USUARIO = @USUARIO";
            cmd.Parameters.AddWithValue("@USUARIO", usuario);
            try
            {
                cmd.Connection = con.Conectar();
                dr = cmd.ExecuteReader();//ARMAZENA O RESULTADO EM DR

                if (dr.HasRows/* CASO O RESULTADO RETORNE LINHAS AFETADAS, SETA O VALOR PARA TRUE */)
                {
                    mensagemRetorna = true;
                    con.Desconectar();// DESCONECTA DO BANCO
                }
            }
            catch (SqlException)
            {
                this.mensagem = "ERRO AO ACESSAR BANCO DE DADOS, FAVOR VERIFIQUE SUA CONEXÃO...";

            }

            return mensagemRetorna;
        }

        public bool RetornaEmailValido(string email)
        {
            cmd.CommandText = "SELECT email FROM LOGIN  WHERE email = @email";
            cmd.Parameters.AddWithValue("@email", email);
            try
            {
                cmd.Connection = con.Conectar();
                dr = cmd.ExecuteReader();//ARMAZENA O RESULTADO EM DR

                if (dr.HasRows/* CASO O RESULTADO RETORNE LINHAS AFETADAS, SETA O VALOR PARA TRUE */)
                {
                    mensagemRetorna = true;
                    con.Desconectar();// DESCONECTA DO BANCO
                }
            }
            catch (SqlException)
            {
                this.mensagem = "ERRO AO ACESSAR BANCO DE DADOS, FAVOR VERIFIQUE SUA CONEXÃO...";

            }

            return mensagemRetorna;
        }

        public bool CadastraPinSenha(string email, int pin)
        {
            cmd.CommandText = "UPDATE LOGIN SET PIN =@PIN WHERE EMAIL =@EMAIL";
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@pin", pin);
            try
            {
                cmd.Connection = con.Conectar();
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    mensagemRetorna = true;
                    con.Desconectar();
                }

            }
            catch (SqlException)
            {

                this.mensagem = "ERRO AO SALVAR O PIN NO BANCO DE DADOS";

            }

            return mensagemRetorna;
        }

        public bool PesquisaPin(string email, int pin)
        {
            cmd.CommandText = "SELECT PIN FROM LOGIN WHERE @email and @pin";
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@pin", pin);
            try
            {
                cmd.Connection = con.Conectar();
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    mensagemRetorna = true;
                    con.Desconectar();
                }

            }
            catch(SqlException) {
                this.mensagem = "Erro ao encontrar o pin";
                con.Desconectar();


            }

            return mensagemRetorna;
        }



    }
}
