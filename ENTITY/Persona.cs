using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    abstract public class Persona
    {
        protected Persona()
        {
            
        }
        protected Persona(int id, string nombres, string direccion,  string telefono)
        {
            Id = id;
            Nombres = nombres;
            Direccion = direccion;
            Telefono = telefono;
            //FechaNacimiento = fechaNacimiento;
            
        }

        public int Id { get; set; }
        public string Nombres { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        
        //public DateTime FechaNacimiento { get; set; }
       

        //public int Edad()
        //{
        //    return DateTime.Now.Year - FechaNacimiento.Year;
        //}
    }
}
