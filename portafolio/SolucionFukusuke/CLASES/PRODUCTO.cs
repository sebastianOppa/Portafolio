using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLASES
{
    public class PRODUCTO
    {
        public int id_producto { get; set; }
        public string nom_producto { get; set; }
        public string descripcion { get; set; }
        public int precio { get; set; }
        public int stock { get; set; }
        public int menu_id_menu { get; set; }

        public PRODUCTO(int id_producto, string nom_producto, string descripcion, int precio, int stock, int menu_id_menu)
        {
            this.id_producto = id_producto;
            this.nom_producto = nom_producto;
            this.descripcion = descripcion;
            this.precio = precio;
            this.stock = stock;
            this.menu_id_menu = menu_id_menu;
        }

    }
}
