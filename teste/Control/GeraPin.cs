using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teste.Controle
{
    public class GeraPin
    {
        string @guid;
        public string RetornaGuid()
        {
            Random rd = new Random();
            @guid = Convert.ToString((rd.Next(00000, 99999)));

            return @guid;
        }


    }
}
