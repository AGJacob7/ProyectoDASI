using AccesoDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DatosDetalleVenta
    {
        EntitiesVehiculos entities;
        public DatosDetalleVenta()
        {
            entities = new EntitiesVehiculos();
            entities.Configuration.ProxyCreationEnabled = false;
        }
        public bool ActualizarDetalleVenta(DETALLEVENTA detalleActualizado)
        {
            DETALLEVENTA detalle = entities.DETALLEVENTA.Where(p => p.IDVENTA == detalleActualizado.IDVENTA).SingleOrDefault();
            if (detalle != null)
            {
                detalle.IDFACTURA = detalleActualizado.IDFACTURA;
                detalle.FECHAVENTA = detalleActualizado.FECHAVENTA;
                detalle.FORMAPAGOVENTA = detalleActualizado.FORMAPAGOVENTA;
                detalle.ESTADOPAGOVENTA = detalleActualizado.ESTADOPAGOVENTA;
                detalle.DESCUENTOVENTA = detalleActualizado.DESCUENTOVENTA;
                detalle.IVAVENTA = detalle.IVAVENTA;
                detalle.SUBTOTALVENTA= detalleActualizado.SUBTOTALVENTA;
                detalle.TOTALVENTA = detalleActualizado.TOTALVENTA;
                entities.SaveChanges();
                return true;
            }
            else
                return false;
        }
        public List<DETALLEVENTA> seleccionarDetalleVenta()
        {
            return entities.DETALLEVENTA.ToList();
        }
        public int InsertarDetalleVenta(DETALLEVENTA detalleVentap)
        {
            entities.DETALLEVENTA.Add(detalleVentap);
            entities.SaveChanges();
            return detalleVentap.IDVENTA;
        }
        public bool EliminarDetalleVenta(int id)
        {
            DETALLEVENTA cuenta = entities.DETALLEVENTA.Where(p => p.IDVENTA == id).SingleOrDefault();
            if (cuenta != null)
            {
                entities.DETALLEVENTA.Remove(cuenta);
                entities.SaveChanges();
                return true;
            }
            else
                return false;
        }
    }
}
