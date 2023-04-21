using AccesoDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DatosCuenta
    {
        EntitiesVehiculos entities;
        public DatosCuenta()
        {
            entities = new EntitiesVehiculos();
            entities.Configuration.ProxyCreationEnabled = false;
        }
        public List<CUENTA> seleccionarCuentas()
        {
            return entities.CUENTA.ToList();
        }
        public int InsertarCuentas(CUENTA cuentaNuevop)
        {
            entities.CUENTA.Add(cuentaNuevop);
            entities.SaveChanges();
            return cuentaNuevop.IDCUENTA;
        }
        public bool ActualizarCuenta(CUENTA CuentaActualizado)
        {
            CUENTA cuenta = entities.CUENTA.Where(p => p.IDCUENTA == CuentaActualizado.IDCUENTA).SingleOrDefault();
            if (cuenta != null)
            {
                cuenta.IDPERSONA = CuentaActualizado.IDPERSONA;
                cuenta.IDROL = CuentaActualizado.IDROL;
                cuenta.EMAILCUENTA = CuentaActualizado.EMAILCUENTA;
                cuenta.USUACUENTA = CuentaActualizado.USUACUENTA;
                cuenta.CONTRACUENTA = CuentaActualizado.CONTRACUENTA;
                cuenta.FECHARESGISTROCUENTA = CuentaActualizado.FECHARESGISTROCUENTA;
                cuenta.ACTIVOCUENTA = cuenta.ACTIVOCUENTA;
                entities.SaveChanges();
                return true;
            }
            else
                return false;


        }

        public bool EliminarCuenta(int id)
        {
            CUENTA cuenta = entities.CUENTA.Where(p => p.IDCUENTA == id).SingleOrDefault();
            if ( cuenta != null)
            {
                entities.CUENTA.Remove(cuenta);
                entities.SaveChanges();
                return true;
            }
            else
                return false;
        }
    }
}
