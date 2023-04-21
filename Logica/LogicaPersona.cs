using AccesoDatos;
using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class LogicaPersona
    {
        DatosPersona op=new DatosPersona();
        public List<PERSONA> seleccionarPersona()
        {
            return op.seleccionarPersona();
        }
        public int InsertarPersona(PERSONA personaNuevop)
        {
            return op.InsertarPersona(personaNuevop);
        }
        public bool ActualizarPersona(PERSONA personaActualizado) 
        {
            return op.ActualizarPersona(personaActualizado);
        }
        public bool EliminarPersona(int id)
        {
            return op.EliminarPersona(id);
        }
    }
}
