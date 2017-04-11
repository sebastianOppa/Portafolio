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

        private BD.PERSONA accesoAdm(string pass)
        {
            try
            {
                return CommonBC.Modelo.PERSONA.FirstOrDefault(p => p.CONTRASENA == pass);
            }
            catch (Exception)
            {
                return null;
            }
        }

        public bool AutenticarUsuario(string rut, string password)
        {
            try
            {
                return accesoAdm(rut).Password == password;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
