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
    
    public partial class PERSONA
    {
        public PERSONA()
        {
            this.COMUNA = new HashSet<COMUNA>();
        }
    
        public string RUN { get; set; }
        public string FULLNAME { get; set; }
        public string DIRECCION { get; set; }
        public System.DateTime FEC_NAC { get; set; }
        public string EMAIL { get; set; }
        public decimal TELEFONO { get; set; }
        public string CONTRASENA { get; set; }
        public decimal NIV_ACCESO { get; set; }
        public string GENERO { get; set; }
    
        public virtual CLIENTE CLIENTE { get; set; }
        public virtual ICollection<COMUNA> COMUNA { get; set; }
        public virtual FUNCIONARIO FUNCIONARIO { get; set; }
    }
}
