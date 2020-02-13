using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using teste.DAO;

namespace teste.DAO
{
    public class RetornaBanco
    {
        public bool tem;
        ManipulaBanco log = new ManipulaBanco();
        public bool Possui(string usuario, string senha)
        {

            tem = log.RetornaLogin(usuario, senha);
            // ! = nega a informação
            if (!log.mensagemRetorna == true)
            {
                /*
                CASO O RETORNO FOR DIFERENTE DE TRUE, ELE RETORNA COMO FALSO PARA QUE APRESENTE COMO USUÁRIO INCORRETO
                */
                this.tem = log.mensagemRetorna;
            }


            return tem;//RRETORNO O VALOR, SE TIVER TEM = TRUE, CASO CONTRÁRIO = FALSE
        }
        public bool PossuiUser(string usuario)
        {
            tem = log.RetornaLoginUser(usuario);
            // ! = nega a informação
            if (!log.mensagemRetorna == true)
            {
                /*
                CASO O RETORNO FOR DIFERENTE DE TRUE, ELE RETORNA COMO FALSO PARA QUE APRESENTE COMO USUÁRIO INCORRETO
                */
                this.tem = log.mensagemRetorna;
            }
            return tem;//RRETORNO O VALOR, SE TIVER TEM = TRUE, CASO CONTRÁRIO = FALSE
        }
        public bool Possuiemail(string email)
        {

            if (log.RetornaEmailValido(email) == true)
            {
                this.tem = log.mensagemRetorna;

            }

            return tem;
        }


    }
}
