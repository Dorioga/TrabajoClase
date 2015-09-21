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
        [WebInvoke(Method = "GET", UriTemplate = "mostrarusuarios", ResponseFormat = WebMessageFormat.Json)]
        List<Usuario> Consultarusuarios();

        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "mostrarusuario/{nombre}", ResponseFormat = WebMessageFormat.Json)]
        Usuario Consultarusuario(string nombre);
            
        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "agregarusuarios/{nombre}/{pass}", ResponseFormat = WebMessageFormat.Json)]
        string Agregarusuarios(string nombre,string pass);

        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "eliminarusuarios/{nombre}", ResponseFormat = WebMessageFormat.Json)]
        string Eliminarusuarios(string nombre);

        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "modificarusuarios/{nombre}/{nomarr}/{passarr}", ResponseFormat = WebMessageFormat.Json)]
        string Modificarusuarios(string nombre,string nomarr,string passarr);

        // TODO: agregue aquí sus operaciones de servicio
    }


    // Utilice un contrato de datos, como se ilustra en el ejemplo siguiente, para agregar tipos compuestos a las operaciones de servicio.
    
}
