using ENTITY;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ServicioVeterinario : ICrudGenerico<Veterinario>
    {
        List<Veterinario> lista=null;
        public ServicioVeterinario()
        {
            lista = new List<Veterinario>();
        }

        public bool Actualizar(Veterinario veterinario)
        {
            throw new NotImplementedException();
        }

        public List<Veterinario> Consultar()
        {
            return lista;
        }

        public bool Eliminar(Veterinario veterinario)
        {
            throw new NotImplementedException();
        }

        public string Guardar(Veterinario veterinario)
        {
            try
            {
                // validar
                lista.Add(veterinario);
                return $"se guardo el veterinario {veterinario.Nombres}";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}
