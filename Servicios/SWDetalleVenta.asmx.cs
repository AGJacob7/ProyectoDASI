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
    /// Descripción breve de SWDetalleVenta
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class SWDetalleVenta : System.Web.Services.WebService
    {

        LogicaDetalleVenta op = new LogicaDetalleVenta();
        [WebMethod]
        public List<DETALLEVENTA> seleccionarDetalleVenta()
        {
            return op.seleccionarDetalleVenta();
        }
        [WebMethod]
        public int InsertarDetalleVenta(DETALLEVENTA ditemNuevop)
        {
            return op.InsertarDetalleVenta(ditemNuevop);
        }
        [WebMethod]
        public bool ActualizarDetalleVenta(DETALLEVENTA CuentaActualizado)
        {
            return op.ActualizarDetalleVenta(CuentaActualizado);
        }
        [WebMethod]
        public bool EliminarDetalleVenta(DETALLEVENTA id)
        {
            return op.EliminarDetalleVenta(id.IDVENTA);
        }
    }
}
