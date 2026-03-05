using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public interface ICrudGenerico<T>
    {
        //CRUD
        string Guardar(T entidad);
        List<T> Consultar();
        bool Actualizar(T entidad);
        bool Eliminar(T entidad);
    }
}
