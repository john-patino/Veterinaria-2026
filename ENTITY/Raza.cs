using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public class Raza
    {
        public int Id { get; set; }
        public string Nombre { get; set; }

        public Raza()
        {
            
        }

        public Raza(int id, string nombre)
        {
            Id = id;
            Nombre = nombre;
        }


    }
}
