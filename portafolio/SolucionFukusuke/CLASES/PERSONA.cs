using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLASES
{
    public class PERSONA
    {
        public string run { get; set; }
        public string fullname { get; set; }
        public string direccion { get; set; }
        public DateTime fec_nac { get; set; }
        public string email { get; set; }
        public int telefono { get; set; }
        public string contrasena { get; set; }
        public int niv_acceso { get; set; }
        public char genero { get; set; }

        public PERSONA() { }
        public PERSONA(string run, string fullname, string direccion, DateTime fec_nac, string email, int telefono, string contrasena, int niv_acceso, char genero)
        {
            this.run = run;
            this.fullname = fullname;
            this.direccion = direccion;
            this.fec_nac = fec_nac;
            this.email = email;
            this.telefono = telefono;
            this.contrasena = contrasena;
            this.niv_acceso = niv_acceso;
            this.genero = genero;
        }

        private BD.PERSONA AccesoPersona(string rut)
        {
            try
            {
                return CommonBC.Modelo.PERSONA.FirstOrDefault(p => p.RUN == rut);
            }
            catch (Exception)
            {
                return null;
            }
        }

        public bool MantenedorMaestroPersona(string rut, string nombre, string direcion, DateTime fec_nac, string email, int telefono, string contrasena, int niv_acceso, string genero)
        {
            try
            {
                BD.PERSONA x = AccesoPersona(rut);
                x.FULLNAME = nombre;
                x.DIRECCION = direcion;
                x.FEC_NAC = fec_nac;
                x.EMAIL = email;
                x.TELEFONO = telefono;
                x.CONTRASENA = contrasena;
                x.NIV_ACCESO = niv_acceso;
                x.GENERO = genero;                
                CommonBC.Modelo.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
