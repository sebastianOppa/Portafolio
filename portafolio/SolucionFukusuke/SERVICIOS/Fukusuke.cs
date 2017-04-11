using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using BD;

namespace SERVICIOS
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Fukusuke" en el código y en el archivo de configuración a la vez.
    public class Fukusuke : IFukusuke
    {
        private CLASES.PRODUCTO prod = new CLASES.PRODUCTO();
        private CLASES.PERSONA pers = new CLASES.PERSONA();

        
        
        public bool MantenedorMaestroProducto(int id, string nombre, string descripcion, int precio, int stock)
        {
            return prod.MantenedorMaestroProducto(id,nombre,descripcion,precio,stock);
        }

        public bool MantenedorMaestroPersona(string rut, string nombre, string direcion, DateTime fec_nac, string email, int telefono, string contrasena, int niv_acceso, string genero)
        {
            return pers.MantenedorMaestroPersona(rut,nombre,direcion,fec_nac,email,telefono,contrasena,niv_acceso,genero);
        }
    }
}
