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
    /// Descripción breve de SWFactura
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class SWFactura : System.Web.Services.WebService
    {
        LogicaFactura op=new LogicaFactura();
        [WebMethod]
        public List<FACTURA> seleccionarFactura()
        {
            return op.seleccionarFactura();
        }
        [WebMethod]
        public int InsertarFactura(FACTURA facturaNuevop)
        {
            return op.InsertarFactura(facturaNuevop);
        }
        [WebMethod]
        public bool ActualizarFactura(FACTURA CuentaActualizado)
        {
            return op.ActualizarFactura(CuentaActualizado);
        }
        [WebMethod]
        public bool EliminarFactura(FACTURA id)
        {
            return op.EliminarFactura(id.IDFACTURA);
        }
    }
}
