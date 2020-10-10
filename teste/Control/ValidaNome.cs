using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teste.Controle
{
    public class ValidaNome
    {
        bool retorno = false; 
        public bool RetornaNome(string nome) {
            if (string.IsNullOrEmpty(nome) || nome.Length <= 4 == true) {

                retorno = true;
            
            }


            return retorno;
        }

    }
}
