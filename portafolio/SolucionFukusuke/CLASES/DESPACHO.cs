using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLASES
{
    public class DESPACHO
    {
        public int id_despacho { get; set; }
        public string forma_pago { get; set; }
        public string observaciones { get; set; }
        public int boleta_id_boleta { get; set; }

        public DESPACHO(int id_despacho, string forma_pega, string observaciones, int boleta_id_boleta)
        {
            this.id_despacho = id_despacho;
            this.forma_pago = forma_pago;
            this.observaciones = observaciones;
            this.boleta_id_boleta = boleta_id_boleta;
        }
    }
}
