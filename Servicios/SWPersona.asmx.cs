using AccesoDatos;
using Logica;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace Servicios
{
    /// <summary>
    /// Descripción breve de SWPersona
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class SWPersona : System.Web.Services.WebService
    {
        LogicaPersona op=new LogicaPersona();
        [WebMethod]
        public List<PERSONA> seleccionarPersona()
        {
            return op.seleccionarPersona();
        }
        [WebMethod]
        public int InsertarPersona(PERSONA personaNuevop)
        {
            return op.InsertarPersona(personaNuevop);
        }
        [WebMethod]
        public bool ActualizarPersona(PERSONA personaActualizado)
        {
            return op.ActualizarPersona(personaActualizado);
        }
        [WebMethod]
        public bool EliminarPersona(PERSONA id)
        {
            return op.EliminarPersona(id.IDPERSONA);
        }
    }
}
