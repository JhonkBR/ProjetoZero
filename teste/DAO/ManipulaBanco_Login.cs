using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teste.DAO
{
    public class ManipulaBanco
    {

        //INSTANCIEI PARA USAR O SQL COMMAND
        ConexaoBanco con = new ConexaoBanco();
        public string mensagem; // A POHA DA MENSAGEM DE ERRO
        public bool mensagemRetorna = false; //RECEBE A MENSAGEM COMO TRUE OU FALSE, TRUE = POSSUI USUÁRIO
        SqlDataReader dr;//ESSA BOSTA CONTA QUANTAS LINHAS FORAM AFETAS NO SQL


        //MÉTODO DE CADASTRAR LOGIN
        public string CadastrarLogin(string usuario, string senha, String email)
        {
            SqlCommand cmd = new SqlCommand();
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
                this.mensagem = "Cadastrado com sucesso!!!!";
            }
            catch (SqlException e)
            {
                this.mensagem = "Erro ao conectar com o banco de dados, DEU MERDA" + e;
            }
            finally
            {
                con.Desconectar();
            }
            // Sair
            //Mostrar mensagem de erro ou 


            return mensagem;
        }

        //MÉTODO PARA VERIFICAR SE O USUÁRIO EXISTE 2.0 - IREI ANALISAR RSRS
        public bool RetornaLogin(string usuario, string senha)
        {
            SqlCommand cmd = new SqlCommand();
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
        
        /*MÉTODO PARA VERIFICAR A EXISTÊNCIA DO USUÁRIO*/
        public bool RetornaLoginUser(string usuario)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT USUARIO FROM LOGIN  WHERE USUARIO = @USUARIO";
            cmd.Parameters.AddWithValue("@USUARIO", usuario);
            try
            {
                cmd.Connection = con.Conectar();
                dr = cmd.ExecuteReader();//ARMAZENA O RESULTADO EM DR

                if (dr.HasRows/* CASO O RESULTADO RETORNE LINHAS AFETADAS, SETA O VALOR PARA TRUE */)
                {
                    mensagemRetorna = true;
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

        /*MÉTODO PARA VERIFICAR SE O E-MAIL EXISTE*/
        public bool RetornaEmailValido(string email)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT email FROM LOGIN  WHERE email = @email";
            cmd.Parameters.AddWithValue("@email", email);
            try
            {
                cmd.Connection = con.Conectar();
                dr = cmd.ExecuteReader();//ARMAZENA O RESULTADO EM DR

                if (dr.HasRows/* CASO O RESULTADO RETORNE LINHAS AFETADAS, SETA O VALOR PARA TRUE */)
                {
                    mensagemRetorna = true;
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

        /*MÉTODO PARA CADASTRAR O NOVO PIN PARA RECUPERAR A SENHA*/
        public bool CadastraPinSenha(string email, int pin)
        {
            SqlCommand cmd = new SqlCommand();
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
                }

            }
            catch (SqlException)
            {

                this.mensagem = "ERRO AO SALVAR O PIN NO BANCO DE DADOS";

            }
            finally
            {
                con.Desconectar();
            }

            return mensagemRetorna;
        }
        
        /*MÉTODO PARA VERIFICAR SE O PIN EXISTE NO BANCO*/
        public bool PesquisaPin(string email, int pin)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT PIN FROM LOGIN WHERE EMAIL = @email and PIN = @pin";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@pin", pin);
            try
            {
                cmd.Connection = con.Conectar();
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    mensagemRetorna = true;
                }

            }
            catch (SqlException e)
            {
                this.mensagem = "Erro ao encontrar o pin" + e;

            }
            finally
            {
                con.Desconectar();
            }

            return mensagemRetorna;
        }


        /*MÉTODO PARA ALTERAR A SENHA NO BANCO DE DADOS*/
        public bool AlteraSenha(string Senha, string email)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "UPDATE LOGIN SET SENHA = @SENHA WHERE email = @email";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@SENHA", Senha);
            cmd.Parameters.AddWithValue("@email", email);
            try
            {
                cmd.Connection = con.Conectar();
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    mensagemRetorna = true;
                }
            }
            catch (SqlException e)
            {
                this.mensagem = "Erro ao conectar ao banco de dados: " + e;
            }

            finally
            {
                con.Desconectar();
            }

            return mensagemRetorna;
        }



    }
}
