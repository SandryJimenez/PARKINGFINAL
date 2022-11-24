using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Vehiculo
    {
        public string cedula { get; set; }
        public string PlacaVehiculo { get; set; }
        public string Marca { get; set; } 
        public string modelo { get; set; }
        public string color { get; set; }
        public DateTime fechallegada { get; set; }

        public Vehiculo()
        {

        }

        public Vehiculo(string cedula, string placaVehiculo, string marca, string modelo, string color, DateTime fechallegada)
        {
            this.cedula = cedula;
            PlacaVehiculo = placaVehiculo;
            Marca = marca;
            this.modelo = modelo;
            this.color = color;
            this.fechallegada = fechallegada;
        }




    }
}
