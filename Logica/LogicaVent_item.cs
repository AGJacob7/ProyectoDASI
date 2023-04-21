using AccesoDatos;
using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class LogicaVent_item
    {
        DatosVent_item op=new DatosVent_item();
        public List<VENT_ITEM> seleccionarVent_item()
        {
            return op.seleccionarVent_item();
        }
        public int InsertarVent_item(VENT_ITEM ventitemNuevop)
        {
            return op.InsertarVent_item(ventitemNuevop);
        }
        public bool ActualizarVentItem(VENT_ITEM ventitemActu) 
        {
            return op.ActualizarVentItem(ventitemActu);
        }
        public bool EliminarVent_item(int id)
        {
            return op.EliminarVent_item(id);
        }

    }
}
