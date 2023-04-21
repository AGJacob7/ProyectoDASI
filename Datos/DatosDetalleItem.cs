using AccesoDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DatosDetalleItem
    {
        EntitiesVehiculos entities;
        public DatosDetalleItem()
        {
            entities = new EntitiesVehiculos();
            entities.Configuration.ProxyCreationEnabled = false;
        }
        public List<DETALLEITEM> seleccionarDetalleItem()
        {
            return entities.DETALLEITEM.ToList();
        }
        public bool ActualizarDetalleItem(DETALLEITEM detalleActualizado)
        {
            DETALLEITEM detalle = entities.DETALLEITEM.Where(p => p.IDDETALLEITEM == detalleActualizado.IDDETALLEITEM).SingleOrDefault();
            if (detalle != null)
            {
                detalle.CANTIITEM = detalleActualizado.CANTIITEM;
                detalle.DESCRIPITEM= detalleActualizado.DESCRIPITEM;
                detalle.PTOTALITEM = detalleActualizado.PTOTALITEM;
                detalle.PUNITITEM = detalleActualizado.PUNITITEM;
                entities.SaveChanges();
                return true;
            }
            else
                return false;


        }
        public int InsertarDetalleItem(DETALLEITEM detalleitemNuevop)
        {
            entities.DETALLEITEM.Add(detalleitemNuevop);
            entities.SaveChanges();
            return detalleitemNuevop.IDDETALLEITEM;
        }
        public bool EliminarDetalleItem(int id)
        {
            DETALLEITEM cuenta = entities.DETALLEITEM.Where(p => p.IDDETALLEITEM == id).SingleOrDefault();
            if (cuenta != null)
            {
                entities.DETALLEITEM.Remove(cuenta);
                entities.SaveChanges();
                return true;
            }
            else
                return false;
        }
    }
}
