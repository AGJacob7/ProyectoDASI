using AccesoDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DatosProveedor
    {
        EntitiesVehiculos entities;
        public DatosProveedor()
        {
            entities = new EntitiesVehiculos();
            entities.Configuration.ProxyCreationEnabled = false;
        }
        public List<PROVEEDOR> seleccionarProveedor()
        {
            return entities.PROVEEDOR.ToList();
        }
        public int InsertarProveedor(PROVEEDOR proveedorNuevop)
        {
            entities.PROVEEDOR.Add(proveedorNuevop);
            entities.SaveChanges();
            return proveedorNuevop.IDPROVEEDOR;
        }
        public bool ActualizarProveedor(PROVEEDOR proActualizado)
        {
            PROVEEDOR provedor = entities.PROVEEDOR.Where(p => p.IDPROVEEDOR == proActualizado.IDPROVEEDOR).SingleOrDefault();
            if (provedor != null)
            {
                provedor.RUCPROVEEDOR=proActualizado.RUCPROVEEDOR;
                provedor.NOMPROVEEDOR=proActualizado.NOMPROVEEDOR;
                provedor.EMAILPROVEEDOR = proActualizado.EMAILPROVEEDOR;
                provedor.TELPROVEEDOR = proActualizado.TELPROVEEDOR;
                provedor.PAISPROVEEDOR = proActualizado.PAISPROVEEDOR;
                provedor.CIUPROVEEDOR = proActualizado.CIUPROVEEDOR;
                entities.SaveChanges();
                return true;
            }
            else
                return false;
        }
        public bool EliminarProveedor(int id)
        {
            PROVEEDOR cuenta = entities.PROVEEDOR.Where(p => p.IDPROVEEDOR == id).SingleOrDefault();
            if (cuenta != null)
            {
                entities.PROVEEDOR.Remove(cuenta);
                entities.SaveChanges();
                return true;
            }
            else
                return false;
        }
    }
}
