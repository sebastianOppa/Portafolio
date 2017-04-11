using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLASES
{
    public class CLIENTE
    {
        public string run { get; set; }
        public string direccion2 { get; set; }
        public char validado { get; set; }

        public CLIENTE(string run, string direccion, char validado)
        {
            this.run = run;
            this.direccion2 = direccion;
            this.validado = validado;
        }
    }
}
