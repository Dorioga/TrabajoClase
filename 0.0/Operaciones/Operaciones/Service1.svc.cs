using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Data.SqlClient;

namespace Operaciones
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service1" en el código, en svc y en el archivo de configuración.
    // NOTE: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione Service1.svc o Service1.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class Service1 : IService1
    {
        Model1Container12 db = new Model1Container12();


        public List<Usuario> Consultarusuarios()
        {
            return db.UsuarioConjunto.ToList();
        }

        public Usuario Consultarusuario(string nombre)
        {
            var usuariocon = db.UsuarioConjunto.Where(usuario => usuario.Login == nombre).First();
            return usuariocon;
        }

        public string Agregarusuarios(string nombre, string pass)
        {
            try
            {
                Usuario nuevo = new Usuario()
                {
                    Login = nombre,
                    Pass = pass
                };
                db.UsuarioConjunto.Add(nuevo);
                db.SaveChanges();
                return ("Datos ingresados correctamente");
            }
            catch (Exception ex)
            {
                return ("Datos no ingresados error: "+ex);
            }
        }

        public string Eliminarusuarios(string nombre)
        {
            try
            {
                db.UsuarioConjunto.Remove(Consultarusuario(nombre));
                db.SaveChanges();
                return ("Datos ingresados correctamente");
            }
            catch (Exception e)
            {
                return ("Datos no ingresados error: " + e);
            }
        }




        public string Modificarusuarios(string nombre, string nomarr, string passarr)
        {
            try
            {
                var consulta = db.UsuarioConjunto.Where(Usuario => Usuario.Login.StartsWith(nombre));
                foreach (var Usuario in consulta)
                {
                    Usuario.Login = Usuario.Login.Replace(Usuario.Login,nomarr);
                    Usuario.Pass = Usuario.Pass.Replace(Usuario.Pass,passarr);
                }
                db.SaveChanges();

                return ("Datos Modificados Correctamente");
            }
            catch (Exception e)
            {
                return ("Error: "+e);
            }
        }
    }
}
