using AccesoDatos;
using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class LogicaProveedor
    {
        DatosProveedor op=new DatosProveedor();
        public List<PROVEEDOR> seleccionarProveedor()
        {
            return op.seleccionarProveedor();
        }
        public int InsertarProveedor(PROVEEDOR proveedorNuevop)
        {
            return op.InsertarProveedor(proveedorNuevop);
        }
        public bool ActualizarProveedor(PROVEEDOR provActu) 
        {
            return op.ActualizarProveedor(provActu);
        }
        public bool EliminarProveedor(int id)
        {
            return op.EliminarProveedor(id);
        }
    }
}
