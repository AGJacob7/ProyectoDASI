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
    /// Descripción breve de SWProduc_item
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class SWProduc_item : System.Web.Services.WebService
    {
        LogicaProduc_item op=new LogicaProduc_item();
        [WebMethod]
        public List<PRODUC_ITEM> seleccionarProductItem()
        {
            return op.seleccionarProductItem();
        }
        [WebMethod]
        public int InsertarProductItem(PRODUC_ITEM productitemNuevop)
        {
            return op.InsertarProductItem(productitemNuevop);
        }
        [WebMethod]
        public bool ActualizarProductItem(PRODUC_ITEM prod)
        {
            return op.ActualizarProductItem(prod);
        }
        [WebMethod]
        public bool EliminarProducitem(PRODUC_ITEM id)
        {
            return op.EliminarProducitem(id.IDPRODUC_ITEM);
        }
    }
}
