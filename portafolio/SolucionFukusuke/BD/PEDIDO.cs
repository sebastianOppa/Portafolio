//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BD
{
    using System;
    using System.Collections.Generic;
    
    public partial class PEDIDO
    {
        public PEDIDO()
        {
            this.BOLETA = new HashSet<BOLETA>();
            this.DETALLE_PEDIDO1 = new HashSet<DETALLE_PEDIDO>();
        }
    
        public decimal ID_PEDIDO { get; set; }
        public string CLIENTE_RUN { get; set; }
        public string NUM_MESA { get; set; }
        public Nullable<decimal> TOTAL_COMPRA { get; set; }
        public string ANULADO { get; set; }
        public string DESCRIPCION { get; set; }
        public Nullable<decimal> PRODUCTO_ID_PRODUCTO { get; set; }
        public decimal BOLETA_ID_BOLETA { get; set; }
        public Nullable<decimal> PRODUCTO_ID_MENU { get; set; }
        public string FUNCIONARIO_RUN { get; set; }
        public Nullable<decimal> MENU_ID_MENU { get; set; }
        public string DETALLE_PEDIDO { get; set; }
    
        public virtual ICollection<BOLETA> BOLETA { get; set; }
        public virtual BOLETA BOLETA1 { get; set; }
        public virtual CLIENTE CLIENTE { get; set; }
        public virtual ICollection<DETALLE_PEDIDO> DETALLE_PEDIDO1 { get; set; }
        public virtual FUNCIONARIO FUNCIONARIO { get; set; }
        public virtual MENU MENU { get; set; }
        public virtual PRODUCTO PRODUCTO { get; set; }
    }
}
