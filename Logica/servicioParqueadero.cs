using Datos;
using Entidades;
using System;
using System.Collections.Generic;

namespace Logica
{
    public class servicioParqueadero
    {
        RepositorioParqueadero repositorioparqueadero = new RepositorioParqueadero();
        List<Parqueadero> lista = new List<Parqueadero>();

        public string Guardar(Parqueadero alquiler)
        {
            string mensaje = string.Empty;
            try
            {
                mensaje = repositorioparqueadero.Insertar(alquiler);
                return mensaje;

            }
            catch (Exception e)
            {
                return "Error:" + e.Message;
            }
        }
        public Parqueadero Buscar(int id)
        {
            foreach (var item in lista)
            {
                if (item.IdParqueadero == id)
                {
                    return item;
                }

            }
            return null;

        }
    }
}
