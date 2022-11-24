using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public interface ICRUDParqueadero<Parqueadero>
    {
        string Insertar(Parqueadero parqueo);
        Parqueadero BuscarFactura(int placa);
        List<Parqueadero> ConsultarTodasFacturas(string parqueo);
    }
}
