using AccesoDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DatosProductos
    {
        EntitiesVehiculos entities;
        public DatosProductos()
        {
            entities = new EntitiesVehiculos();
            entities.Configuration.ProxyCreationEnabled = false;
        }
        public List<PRODUCTO> seleccionarProductos()
        {
            return entities.PRODUCTO.ToList();
        }
        public int InsertarProductos(PRODUCTO productitemNuevop)
        {
            entities.PRODUCTO.Add(productitemNuevop);
            entities.SaveChanges();
            return productitemNuevop.IDPRODUCTO;
        }
        public bool ActualizarProductos(PRODUCTO producActualizado)
        {
            PRODUCTO produc = entities.PRODUCTO.Where(p => p.IDPRODUCTO == producActualizado.IDPRODUCTO).SingleOrDefault();
            if (produc != null)
            {
                produc.IDPROVEEDOR = producActualizado.IDPROVEEDOR;
                produc.IDCATEGORIA = producActualizado.IDCATEGORIA;
                produc.CODPRODUCTO= producActualizado.CODPRODUCTO;
                produc.NOMPRODUCTO = producActualizado.NOMPRODUCTO;
                produc.MARCAPRODUCTO = producActualizado.MARCAPRODUCTO;
                produc.IMAGENPRODUCTO = producActualizado.IMAGENPRODUCTO;
                produc.ACTIVOPRODUCTO = producActualizado.ACTIVOPRODUCTO;
                produc.STROCKPRODCUTO = producActualizado.STROCKPRODCUTO;
                produc.DESCRIPPRODUCTO = producActualizado.DESCRIPPRODUCTO;
                produc.PCOMPRAPRODUCTO= producActualizado.PCOMPRAPRODUCTO;
                produc.PVENTAPRODUCTO = producActualizado.PVENTAPRODUCTO;
                produc.FECHAREGIDTROPRODUCTO = producActualizado.FECHAREGIDTROPRODUCTO;
                entities.SaveChanges();
                return true;
            }
            else
                return false;
        }
        public bool EliminarProductos(int id)
        {
            PRODUCTO cuenta = entities.PRODUCTO.Where(p => p.IDPRODUCTO == id).SingleOrDefault();
            if (cuenta != null)
            {
                entities.PRODUCTO.Remove(cuenta);
                entities.SaveChanges();
                return true;
            }
            else
                return false;
        }
    }
}
