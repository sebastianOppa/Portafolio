using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLASES
{
    public class BOLETA
    {
        public int id_boleta { get; set; }
        public int descuentos { get; set; }
        public int total_final { get; set; }
        public string tipo_pago { get; set; }
        public int propina { get; set; }
        public int pedido_id_pedido { get; set; }
        public int despacho_id_despacho { get; set; }

        public BOLETA(int id_boleta, int descuentos, int total_final, string tipo_pago, int propina, int pedido_id_pedido, int despacho_id_despacho)
        {
            this.id_boleta = id_boleta;
            this.descuentos = descuentos;
            this.total_final = total_final;
            this.tipo_pago = tipo_pago;
            this.propina = propina;
            this.pedido_id_pedido = pedido_id_pedido;
            this.despacho_id_despacho = despacho_id_despacho;

        }
    }
}
