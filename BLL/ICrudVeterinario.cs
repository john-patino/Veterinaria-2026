using ENTITY;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public interface ICrudVeterinario
    {
        //CRUD
        string Guardar(Veterinario veterinario);
        List<Veterinario> Consultar();
        bool Actualizar(Veterinario veterinario);
        bool Eliminar(Veterinario veterinario);


    }
}
