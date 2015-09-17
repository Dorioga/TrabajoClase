using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfService4
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {

        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "mostrarUsuarios", ResponseFormat=WebMessageFormat.Json)]
        List<Usuario> mostrarUsuarios();

        
        [OperationContract]

        [WebInvoke(Method = "GET", UriTemplate = "mostrarUsuario/{Id}", ResponseFormat = WebMessageFormat.Json)]
        Usuario mostrarUsuario(string Id);

        // TODO: Add your service operations here
    }


    // Use a data contract as illustrated in the sample below to add composite types to service operations.
   
}
