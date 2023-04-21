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
    /// Descripción breve de SWVent_item
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class SWVent_item : System.Web.Services.WebService
    {
        LogicaVent_item op=new LogicaVent_item();
        [WebMethod]
        public List<VENT_ITEM> seleccionarVent_item()
        {
            return op.seleccionarVent_item();
        }
        [WebMethod]
        public int InsertarVent_item(VENT_ITEM ventitemNuevop)
        {
            return op.InsertarVent_item(ventitemNuevop);
        }
        [WebMethod]
        public bool ActualizarVentItem(VENT_ITEM ventitemActu)
        {
            return op.ActualizarVentItem(ventitemActu);
        }
        [WebMethod]
        public bool EliminarVent_item(VENT_ITEM id)
        {
            return op.EliminarVent_item(id.IDVENT_ITEM);
        }
    }
}
