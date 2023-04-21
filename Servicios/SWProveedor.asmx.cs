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
    /// Descripción breve de SWProveedor
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class SWProveedor : System.Web.Services.WebService
    {

        LogicaProveedor op=new LogicaProveedor();
        [WebMethod]
        public List<PROVEEDOR> seleccionarProveedor()
        {
            return op.seleccionarProveedor();
        }
        [WebMethod]
        public int InsertarProveedor(PROVEEDOR proveedorNuevop)
        {
            return op.InsertarProveedor(proveedorNuevop);
        }
        [WebMethod]
        public bool ActualizarProveedor(PROVEEDOR provActu)
        {
            return op.ActualizarProveedor(provActu);
        }
        [WebMethod]
        public bool EliminarProveedor(PROVEEDOR id)
        {
            return op.EliminarProveedor(id.IDPROVEEDOR);
        }
    }
}
