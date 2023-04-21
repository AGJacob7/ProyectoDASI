using AccesoDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DatosVent_item
    {
        EntitiesVehiculos entities;
        public DatosVent_item()
        {
            entities = new EntitiesVehiculos();
            entities.Configuration.ProxyCreationEnabled = false;
        }
        public List<VENT_ITEM> seleccionarVent_item()
        {
            return entities.VENT_ITEM.ToList();
        }
        public int InsertarVent_item(VENT_ITEM ventitemNuevop)
        {
            entities.VENT_ITEM.Add(ventitemNuevop);
            entities.SaveChanges();
            return ventitemNuevop.IDVENT_ITEM;
        }
        public bool ActualizarVentItem(VENT_ITEM ventActualizado)
        {
            VENT_ITEM vent = entities.VENT_ITEM.Where(p => p.IDVENT_ITEM== ventActualizado.IDVENT_ITEM).SingleOrDefault();
            if (vent != null)
            {
                vent.IDDETALLEITEM = ventActualizado.IDDETALLEITEM;
                vent.IDVENTA=ventActualizado.IDVENTA;
                entities.SaveChanges();
                return true;
            }
            else
                return false;
        }
        public bool EliminarVent_item(int id)
        {
            VENT_ITEM cuenta = entities.VENT_ITEM.Where(p => p.IDVENT_ITEM == id).SingleOrDefault();
            if (cuenta != null)
            {
                entities.VENT_ITEM.Remove(cuenta);
                entities.SaveChanges();
                return true;
            }
            else
                return false;
        }
    }
}
