using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLASES
{
    public class MENU
    {
        public int id_menu { get; set; }
        public string producto1 { get; set; }
        public string producto2 { get; set; }
        public string producto3 { get; set; }
        public string producto4 { get; set; }
        public string producto5 { get; set; }
        public int valor { get; set; }

        public MENU(int id_menu, string producto1, string producto2, string producto3, string producto4, string producto5, int valor)
        {
            this.id_menu = id_menu;
            this.producto1 = producto1;
            this.producto2 = producto2;
            this.producto3 = producto3;
            this.producto4 = producto4;
            this.producto5 = producto5;
            this.valor = valor;
        }


    }
}
