using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BD;

namespace CLASES
{
    public class CommonBC
    {
        private static BD.Entities _modelo;
        public static BD.Entities Modelo
        {
            get
            {
                if (_modelo == null)
                {
                    _modelo = new BD.Entities();
                }
                return _modelo;
            }
        }
        public CommonBC() { }
    }
}
