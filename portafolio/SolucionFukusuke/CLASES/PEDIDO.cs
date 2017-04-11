using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLASES
{
    public class PEDIDO
    {
        public int id_pedido { get; set; }
        public string cliente_run { get; set; }
        public string num_mesa { get; set; }
        public int total_compra { get; set; }
        public char anulado { get; set; }
        public string descripcion { get; set; }
        public int producto_id_producto { get; set; }
        public int boleta_id_boleta { get; set; }
        public int producto_id_menu { get; set; }
        public string funcionario_run { get; set; }
        public int menu_id_menu { get; set; }
        public PEDIDO(int id_pedido, string cliente_run, string num_mesa, int total_compra, char anulado, string descripcion, int producto_id_producto, int boleta_id_boleta, int producto_id_menu, string funcionario_run, int menu_id_menu)
        {
            this.id_pedido = id_pedido;
            this.cliente_run = cliente_run;
            this.num_mesa = num_mesa;
            this.total_compra = total_compra;
            this.anulado = anulado;
            this.descripcion = descripcion;
            this.producto_id_producto = producto_id_producto;
            this.boleta_id_boleta = boleta_id_boleta;
            this.producto_id_menu = producto_id_menu;
            this.funcionario_run = funcionario_run;
            this.menu_id_menu = menu_id_menu;
        }
    }
}
