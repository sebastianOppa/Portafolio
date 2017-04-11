using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace SERVICIOS
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IFukusuke" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IFukusuke
    {
        [OperationContract]
        bool MantenedorMaestroProducto(int id, string nombre, string descripcion, int precio, int stock);
        [OperationContract]
        bool MantenedorMaestroPersona(string rut, string nombre, string direcion, DateTime fec_nac, string email, int telefono, string contrasena, int niv_acceso, string genero);
    }
}
