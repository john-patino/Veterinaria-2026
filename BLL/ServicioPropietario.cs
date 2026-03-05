using ENTITY;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ServicioPropietario : ICrudGenerico<Propietario>
    {
        List<Propietario> lista;
        public ServicioPropietario()
        {
            lista = new List<Propietario>();
        }
        public bool Actualizar(Propietario entidad)
        {
            throw new NotImplementedException();
        }

        public List<Propietario> Consultar()
        {
            return lista;
        }

        public bool Eliminar(Propietario entidad)
        {
            throw new NotImplementedException();
        }

        public string Guardar(Propietario entidad)
        {
            try
            {
                lista.Add(entidad);
                return $"se agrego el propietario {entidad.Nombres}";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}
