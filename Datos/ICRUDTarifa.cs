using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public interface ICRUDTarifa<T>
    {
        string Insertar(T obj);
        string Eliminar(T obj);
        string Actualizar(T obj);
        T Buscartipo(string id);
        List<T> Todos(string obj);
    }
}
