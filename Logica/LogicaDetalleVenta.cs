using AccesoDatos;
using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class LogicaDetalleVenta
    {
        DatosDetalleVenta op = new DatosDetalleVenta();
        public List<DETALLEVENTA> seleccionarDetalleVenta()
        {
            return op.seleccionarDetalleVenta();
        }
        public int InsertarDetalleVenta(DETALLEVENTA ditemNuevop)
        {
            return op.InsertarDetalleVenta(ditemNuevop);
        }
        public bool ActualizarDetalleVenta(DETALLEVENTA CuentaActualizado)
        {
            return op.ActualizarDetalleVenta(CuentaActualizado);
        }
        public bool EliminarDetalleVenta(int id)
        {
            return op.EliminarDetalleVenta(id);
        }
    }
}
