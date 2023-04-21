using AccesoDatos;
using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class LogicaProduc_item
    {
        DatosProduc_item op=new DatosProduc_item();
        public List<PRODUC_ITEM> seleccionarProductItem()
        {
            return op.seleccionarProductItem();
        }
        public int InsertarProductItem(PRODUC_ITEM productitemNuevop)
        {
            return op.InsertarProductItem(productitemNuevop);
        }
        public bool ActualizarProductItem(PRODUC_ITEM prod) 
        {
            return op.ActualizarProductItem(prod);
        }
        public bool EliminarProducitem(int id)
        {
            return op.EliminarProducitem(id);
        }
    }
}
