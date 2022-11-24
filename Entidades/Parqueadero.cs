using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Parqueadero : Vehiculo
    {
        public int IdParqueadero { get; set; }
        public DateTime FechaSalida { get; set; }
        public int valorPorHora { get; set; }
        public string HoraSalida { get; set; }
        public Double Total { get; set; }
      

        public Parqueadero()
        {

        }

        public Parqueadero(string cedula, string placaVehiculo, string marca, string modelo, string color, DateTime fechallegada) : base(cedula, placaVehiculo, marca, modelo, color, fechallegada)
        {
        }

        public Parqueadero(int idParqueadero, DateTime fechaSalida, int valorPorHora, string horaSalida, double total)
        {
            IdParqueadero = idParqueadero;
            FechaSalida = fechaSalida;
            this.valorPorHora = valorPorHora;
            HoraSalida = horaSalida;
            Total = total;
        }
    }
}
