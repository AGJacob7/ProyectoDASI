using AccesoDatos;
using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class LogicaFactura
    {
        DatosFactura op=new DatosFactura();
        public List<FACTURA> seleccionarFactura()
        {
            return op.seleccionarFactura();
        }
        public int InsertarFactura(FACTURA facturaNuevop)
        {
            return op.InsertarFactura(facturaNuevop);
        }
        public bool ActualizarFactura(FACTURA CuentaActualizado)
        {
            return op.ActualizarFactura(CuentaActualizado);
        }
        public bool EliminarFactura(int id)
        {
            return op.EliminarFactura(id);
        }
    }
}
