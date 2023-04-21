using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatos;
using Datos;

namespace Logica
{
    public class LogicaCuenta
    {
        DatosCuenta op=new DatosCuenta();
        public List<CUENTA> seleccionarCuentas()
        {
            return op.seleccionarCuentas();
        }
        public int InsertarCuentas(CUENTA cuentaNuevop)
        {
            return op.InsertarCuentas(cuentaNuevop);
        }
        public bool ActualizarCuenta(CUENTA CuentaActualizado)
        {
            return op.ActualizarCuenta(CuentaActualizado);
        }

        public bool EliminarCuenta(int id)
        {
            return op.EliminarCuenta(id);
        }
    }
}
