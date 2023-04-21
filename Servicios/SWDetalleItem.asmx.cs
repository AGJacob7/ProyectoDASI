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
    /// Descripción breve de SWDetalleItem
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class SWDetalleItem : System.Web.Services.WebService
    {
        LogicaDetalleItem op = new LogicaDetalleItem();
        [WebMethod]
        public List<DETALLEITEM> seleccionarDetalleItem()
        {
            return op.seleccionarDetalleItem();
        }
        [WebMethod]
        public int InsertarDetalleItem(DETALLEITEM ditemNuevop)
        {
            return op.InsertarDetalleItem(ditemNuevop);
        }
        [WebMethod]
        public bool ActualizarDetalleItem(DETALLEITEM CuentaActualizado)
        {
            return op.ActualizarDetalleItem(CuentaActualizado);
        }
        [WebMethod]
        public bool EliminarDetalleItem(DETALLEITEM id)
        {
            return op.EliminarDetalleItem(id.IDDETALLEITEM);
        }
    }
}
