using Datos;
using Entidades;
using Logica;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaS
{
    public class servicioTarifa
    {
        repositoriotarifas repositoriotarifas = new repositoriotarifas();
        List<Tarifas> lista = new List<Tarifas>();
        private string id;

        public string Guardar(Tarifas tarifa)
        {
            string mensaje = string.Empty;
            try
            {
                if (repositoriotarifas.Buscartipo(Convert.ToString(tarifa.idvehiculo)) == null)
                {
                    mensaje = repositoriotarifas.Insertar(tarifa);

                }
                return mensaje;
            }
            catch (Exception e)
            {
                return "Error:" + e.Message;
            }
        }

        public Tarifas Buscar(string placa)
        {
            foreach (var item in lista)
            {
                if (Convert.ToString(item.idvehiculo) == placa)
                {
                    return item;
                }

            }
            return null;

        }

        public string Eliminar(Tarifas tarifa)
        {
            Tarifas tarifas = Buscar(id);

            if (tarifa != null)
            {
                return "tarifa no existe";
            }
            else
            {
                lista.Remove(tarifas);
                repositoriotarifas.Eliminar(tarifas);

                return "tarifa eliminada";
            }
        }
        public string Actualizar(Tarifas tarifa)
        {
            Tarifas tarifas = Buscar(id);
            if (tarifa == null)
            {
                return Guardar(tarifa);

            }
            else
            {
                tarifa.idvehiculo = tarifa.idvehiculo;
                return repositoriotarifas.Actualizar(tarifa);
            }
        }
        public static List<Tarifas> Listar_vehiculos(string cTexto)
        {
            repositoriotarifas Datos = new repositoriotarifas();
            return Datos.Todos(cTexto);
        }


    }
}
