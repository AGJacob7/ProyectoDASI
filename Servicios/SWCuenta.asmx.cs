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
    /// Descripción breve de SWCuenta
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class SWCuenta : System.Web.Services.WebService
    {
        LogicaCuenta op=new LogicaCuenta();
        [WebMethod]
        public List<CUENTA> seleccionarCuentas()
        {
            return op.seleccionarCuentas();
        }
        [WebMethod]
        public int InsertarCuentas(CUENTA cuentaNuevop)
        {
            return op.InsertarCuentas(cuentaNuevop);
        }
        [WebMethod]
        public bool ActualizarCuenta(CUENTA CuentaActualizado)
        {
            return op.ActualizarCuenta(CuentaActualizado);
        }
        [WebMethod]
        public bool EliminarCuenta(CUENTA id)
        {
            return op.EliminarCuenta(id.IDCUENTA);
        }
    }
}
