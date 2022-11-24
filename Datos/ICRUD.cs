using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entidades;
namespace DatosDAO
{
    public interface ICRUD<T> 
    {
        string Insertar(T obj);
        string Eliminar(T obj);
        string Actualizar(T obj);
        T BuscarID(string id);
        List<T> Todos(string obj);
    }
}