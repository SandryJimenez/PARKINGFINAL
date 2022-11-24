using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public interface ICRUDVehiculo<V> //cliente, cuentas, veh
    {
        string Insertar(V objs);
        string Eliminar(V objs);
        string Actualizar(V objs);
        V BuscarPlaca(string placa);
        List<V> Todos(string objs);
    }
}
