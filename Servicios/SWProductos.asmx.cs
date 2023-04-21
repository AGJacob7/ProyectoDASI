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
    /// Descripción breve de SWProductos
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class SWProductos : System.Web.Services.WebService
    {
        LogicaProducutos op=new LogicaProducutos();
        [WebMethod]
        public List<PRODUCTO> seleccionarProductos()
        {
            return op.seleccionarProductos();
        }
        [WebMethod]
        public int InsertarProductos(PRODUCTO productitemNuevop)
        {
            return op.InsertarProductos(productitemNuevop);
        }
        [WebMethod]
        public bool ActualizarProductos(PRODUCTO producido)
        {
            return op.ActualizarProductos(producido);
        }
        [WebMethod]
        public bool EliminarProductos(PRODUCTO id)
        {
            return op.EliminarProductos(id.IDPRODUCTO);
        }
    }
}
