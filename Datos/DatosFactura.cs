using AccesoDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DatosFactura
    {
        EntitiesVehiculos entities;
        public DatosFactura()
        {
            entities = new EntitiesVehiculos();
            entities.Configuration.ProxyCreationEnabled = false;
        }
        public List<FACTURA> seleccionarFactura()
        {
            return entities.FACTURA.ToList();
        }
        public int InsertarFactura(FACTURA facturaNuevop)
        {
            entities.FACTURA.Add(facturaNuevop);
            entities.SaveChanges();
            return facturaNuevop.IDFACTURA;
        }
        public bool ActualizarFactura(FACTURA facturaActualizado)
        {
            FACTURA factura = entities.FACTURA.Where(p => p.IDFACTURA == facturaActualizado.IDFACTURA).SingleOrDefault();
            if (factura != null)
            {
                factura.IDCUENTA = factura.IDCUENTA;
                factura.FECHAFACTURA= facturaActualizado.FECHAFACTURA;
                entities.SaveChanges();
                return true;
            }
            else
                return false;
        }
        public bool EliminarFactura(int id)
        {
            FACTURA cuenta = entities.FACTURA.Where(p => p.IDFACTURA == id).SingleOrDefault();
            if (cuenta != null)
            {
                entities.FACTURA.Remove(cuenta);
                entities.SaveChanges();
                return true;
            }
            else
                return false;
        }
    }
}
