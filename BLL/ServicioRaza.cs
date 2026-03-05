using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using ENTITY;

namespace BLL
{
    public class ServicioRaza:ICrudGenerico<Raza>
    {
        List<Raza> listaRazas;
        public ServicioRaza()
        {
            listaRazas = new List<Raza>();
        }

        public string Guardar(Raza raza)
        {
            try
            {
                //validar
                listaRazas.Add(raza);
                return "se guardao";
            }
            catch (Exception)
            {

                return "error al guardar";
            }
        }

        public List<Raza> Consultar()
        {
            return listaRazas;
        }

        public bool Actualizar(Raza entidad)
        {
            throw new NotImplementedException();
        }

        public bool Eliminar(Raza entidad)
        {
            throw new NotImplementedException();
        }
    }
}
