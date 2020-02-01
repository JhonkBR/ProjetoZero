using System;
using System.Web;

namespace teste.Controle
{
    public class IISHandler1 : IHttpHandler
    {
        /// <summary>
        /// Será necessário configurar este manipulador no arquivo Web.config de sua 
        /// web e registrá-lo no IIS para que ele possa ser usado. Para obter mais informações,
        /// consulte o seguinte link: https://go.microsoft.com/?linkid=8101007
        /// </summary>
        #region Membros IHttpHandler

        public bool IsReusable
        {
            // Retorne falso caso o Manipulador gerenciado não possa ser reutilizado por outra solicitação.
            // Geralmente ele seria falso, caso você tivesse alguma informação sobre o estado preservado por solicitação.
            get { return true; }
        }

        public void ProcessRequest(HttpContext context)
        {
            //grave a implementação do seu manipulador aqui.
        }

        #endregion
    }
}
