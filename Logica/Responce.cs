using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
namespace Logica
{
    public class Responce
    {
        public bool Error { get; set; }
        public string Message { get; set; }
        public Cliente Cliente { get; set; }
        public List<Cliente> Clientes { get; set; }
        public List<Parqueadero> Alquilers { get; set; }
        public Vehiculo Vehiculo { get; set; }
        public List<Vehiculo> Vehiculos { get; set; }
        public Responce(Cliente cliente)
        {
            Cliente = cliente;
            Error = false;
        }
        public Responce(List<Cliente> clientes)
        {
            Clientes = clientes;
            Error = false;
        }
        public Responce(List<Parqueadero> alquleres)
        {
            Alquilers = alquleres;
            Error = false;
        }
        public Responce(Vehiculo vehiculo)
        {
            Vehiculo = vehiculo;
            Error = false;
        }
        public Responce(List<Vehiculo> vehiculos)
        {
            Vehiculos = vehiculos;
            Error = false;
        }
        public Responce(string mensaje)
        {
            Error = true;
            Message = mensaje;
        }

        public Responce()
        {
        }
    }
}
