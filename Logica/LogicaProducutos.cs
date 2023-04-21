using AccesoDatos;
using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class LogicaProducutos
    {
        DatosProductos op=new DatosProductos();
        public List<PRODUCTO> seleccionarProductos()
        {
            return op.seleccionarProductos();
        }
        public int InsertarProductos(PRODUCTO productitemNuevop)
        {
            return op.InsertarProductos(productitemNuevop);
        }
        public bool ActualizarProductos(PRODUCTO producido)
        {
            return op.ActualizarProductos(producido);
        }

        public bool EliminarProductos(int id)
        {
            return op.EliminarProductos(id);
        }
    }
}
