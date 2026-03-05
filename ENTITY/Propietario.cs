using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public class Propietario :Persona
    {
        public Propietario()
        {
            
        }
        public Propietario(int id, string nombres, string direccion, string telefono) : base(id, nombres, direccion, telefono)
        {
            
        }

        public string Correo { get; set; }
    }
}
