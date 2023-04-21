using AccesoDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DatosProduc_item
    {
        EntitiesVehiculos entities;
        public DatosProduc_item()
        {
            entities = new EntitiesVehiculos();
            entities.Configuration.ProxyCreationEnabled = false;
        }
        public List<PRODUC_ITEM> seleccionarProductItem()
        {
            return entities.PRODUC_ITEM.ToList();
        }
        public int InsertarProductItem(PRODUC_ITEM productitemNuevop)
        {
            entities.PRODUC_ITEM.Add(productitemNuevop);
            entities.SaveChanges();
            return productitemNuevop.IDPRODUC_ITEM;
        }
        public bool ActualizarProductItem(PRODUC_ITEM producActualizado)
        {
            PRODUC_ITEM produc = entities.PRODUC_ITEM.Where(p => p.IDPRODUC_ITEM == producActualizado.IDPRODUC_ITEM).SingleOrDefault();
            if (produc != null)
            {
                produc.IDDETALLEITEM = producActualizado.IDDETALLEITEM;
                produc.IDPRODUCTO = producActualizado.IDPRODUCTO;
                entities.SaveChanges();
                return true;
            }
            else
                return false;
        }
        public bool EliminarProducitem(int id)
        {
            PRODUC_ITEM cuenta = entities.PRODUC_ITEM.Where(p => p.IDPRODUC_ITEM == id).SingleOrDefault();
            if (cuenta != null)
            {
                entities.PRODUC_ITEM.Remove(cuenta);
                entities.SaveChanges();
                return true;
            }
            else
                return false;
        }
    }
}
