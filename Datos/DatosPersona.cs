using AccesoDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DatosPersona
    {
        EntitiesVehiculos entities;
        public DatosPersona()
        {
            entities = new EntitiesVehiculos();
            entities.Configuration.ProxyCreationEnabled = false;
        }
        public List<PERSONA> seleccionarPersona()
        {
            return entities.PERSONA.ToList();
        }
        public int InsertarPersona(PERSONA personaNuevop)
        {
            entities.PERSONA.Add(personaNuevop);
            entities.SaveChanges();
            return personaNuevop.IDPERSONA;
        }
        public bool ActualizarPersona(PERSONA personaActualizado)
        {
            PERSONA persona = entities.PERSONA.Where(p => p.IDPERSONA == personaActualizado.IDPERSONA).SingleOrDefault();
            if (persona != null)
            {
                persona.NOMPERSONA = personaActualizado.NOMPERSONA;
                persona.APEPERSONA=personaActualizado.APEPERSONA;
                persona.IDENTIPERSONA=personaActualizado.IDENTIPERSONA;
                persona.TELPERSONA = personaActualizado.TELPERSONA;
                persona.DIRREPERSONA = personaActualizado.DIRREPERSONA;
                persona.PAISPERSONA = personaActualizado.PAISPERSONA;
                persona.CIUPERSONA = personaActualizado.CIUPERSONA;
                entities.SaveChanges();
                return true;
            }
            else
                return false;
        }
        public bool EliminarPersona(int id)
        {
            PERSONA cuenta = entities.PERSONA.Where(p => p.IDPERSONA == id).SingleOrDefault();
            if (cuenta != null)
            {
                entities.PERSONA.Remove(cuenta);
                entities.SaveChanges();
                return true;
            }
            else
                return false;
        }
    }
}
