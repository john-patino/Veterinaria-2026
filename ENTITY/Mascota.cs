using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public class Mascota
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public Raza Raza { get; private set; }

        public void AsignarRaza(Raza raza)
        {
            if (raza== null)
            {
                //hago algo con esta info
                raza = null;
            }
            Raza = raza;
        }

    }
}
