using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLASES
{
    public class DETALLE_PEDIDO
    {
        public string detalle_producto { get; set; }
        public int detalle_cantidad { get; set; }
        public int detalle_total { get; set; }
        public int id_detalle { get; set; }
        public int id_producto { get; set; }
        public int pedido_id_pedido { get; set; }

        public DETALLE_PEDIDO(string detalle_producto, int detalle_cantidad, int detalle_total, int id_detalle, int id_producto, int pedido_id_pedido) {
            this.detalle_producto = detalle_producto;
            this.detalle_cantidad = detalle_cantidad;
            this.detalle_total = detalle_total;
            this.id_detalle = id_detalle;
            this.id_producto = id_producto;
            this.pedido_id_pedido = pedido_id_pedido;
        }
    }
}
