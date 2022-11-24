using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Entidades;
namespace Logica
{
    public class servicioVehiculo
    {
        RepositorioVehiculos repositoriovehiculos = new RepositorioVehiculos();
        List<Vehiculo> lista = new List<Vehiculo>();
        private string placa;

        public string Guardar(Vehiculo vehiculo)
        {
            string mensaje = string.Empty;
            try
            {
                if (repositoriovehiculos.BuscarPlaca(vehiculo.PlacaVehiculo) == null)
                {
                    mensaje = repositoriovehiculos.Insertar(vehiculo);
              
                }
                return mensaje;
            }
            catch (Exception e)
            {
                return "Error:" + e.Message;
            }
        }

        //private void Actualizar()
        //{
        //    Vehiculo = repositoriovehiculos.ConsultarTodos();
        //}
        //public string BuscarPlaca(string placa)
        //{
        //    if (repositoriovehiculos.BuscarPlaca == placa)
        //    {

        //    }
        //    return clientes;
        //}
        public Responce BuscarPorid(string id)
        {
            try
            {
                return new Responce(repositoriovehiculos.BuscarPlaca(id));
            }
            catch (Exception exception)
            {
                return new Responce("Se presentó el siguiente error:" + exception.Message);
            }
        }
        public Vehiculo Buscar(string placa)
        {
            foreach (var item in lista)
            {
                if (item.PlacaVehiculo == placa)
                {
                    return item;
                }

            }
            return null;

        }

        public string Eliminar(Vehiculo vehiculo)
        {
            Vehiculo vehiculos = Buscar(placa);

            if (vehiculo != null)
            {
                return "vehiculo no existe";
            }
            else
            {
                lista.Remove(vehiculos);
                repositoriovehiculos.Eliminar(vehiculos);

                return "vehiculo eliminado";
            }
        }
        public string Actualizar(Vehiculo vehiculo)
        {
            Vehiculo vehiculos = Buscar(placa);
            if (vehiculo == null)
            {
                return Guardar(vehiculo);

            }
            else
            {
                vehiculo.PlacaVehiculo = vehiculo.PlacaVehiculo;
                return repositoriovehiculos.Actualizar(vehiculo);
            }
        }
        public static List<Vehiculo> Listar_vehiculos(string cTexto)
        {
            RepositorioVehiculos Datos = new RepositorioVehiculos();
            return Datos.Todos(cTexto);
        }

    }
}
    
