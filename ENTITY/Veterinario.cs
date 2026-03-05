using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ENTITY
{
    public class Veterinario : Persona
    {
        public Veterinario()
        {
            
        }
        public Veterinario(int id, string nombres, string direccion,  string telefono) : base(id, nombres, direccion, telefono)
        {
        }
    }
}