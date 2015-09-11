using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Operaciones
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IService1" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IService1
    {

        [OperationContract]
        string Suma(int value, int value2);
        [OperationContract]
        string Resta(int value,int value2);
        [OperationContract]
        string Multiplicacion(int value, int value2);
        [OperationContract]
        string Division(float value, float value2);
        [OperationContract]
        Usuario Consultarusuarios(string nombre);
        [OperationContract]
        Boolean Agregarusuarios(string nombre,string pass);
        [OperationContract]
        Boolean Eliminarusuarios(string nombre);
        [OperationContract]
        Boolean Modificarusuarios(string nombre,string pass);

        // TODO: agregue aquí sus operaciones de servicio
    }


    // Utilice un contrato de datos, como se ilustra en el ejemplo siguiente, para agregar tipos compuestos a las operaciones de servicio.
    
}
