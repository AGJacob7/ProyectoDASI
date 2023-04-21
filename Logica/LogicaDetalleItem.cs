using AccesoDatos;
using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class LogicaDetalleItem
    {
        DatosDetalleItem op = new DatosDetalleItem();
        public List<DETALLEITEM> seleccionarDetalleItem()
        {
            return op.seleccionarDetalleItem();
        }
        public int InsertarDetalleItem(DETALLEITEM ditemNuevop)
        {
            return op.InsertarDetalleItem(ditemNuevop);
        }
        public bool ActualizarDetalleItem(DETALLEITEM CuentaActualizado)
        {
            return op.ActualizarDetalleItem(CuentaActualizado);
        }
        public bool EliminarDetalleItem(int id)
        {
            return op.EliminarDetalleItem(id);
        }
    }
}
