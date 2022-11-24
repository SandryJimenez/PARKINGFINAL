using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Entidades;
namespace Logica
{
    public class servicioCliente
    {
        RepositorioClientes repositorioclientes = new RepositorioClientes();
        List<Cliente> lista = new List<Cliente>();
        private string id;

        public string Guardar(Cliente cliente)
        {
            string mensaje = string.Empty;
            try
            {

                if (repositorioclientes.BuscarID(cliente.IDC) == null)
                {
                    mensaje = repositorioclientes.Insertar(cliente);
                    return mensaje;

                }
                return mensaje;
            }
            catch (Exception e)
            {
                return "Error:" + e.Message;
            }
        }


       


        public Responce BuscarPorid(string id)
        {
            try
            {
                return new Responce(repositorioclientes.BuscarID(id));
            }
            catch (Exception exception)
            {
                return new Responce("Se presentó el siguiente error:" + exception.Message);
            }
        }
        public Cliente Buscar(string id)
        {
            foreach (var item in lista)
            {
                if (item.IDC == id)
                {
                    return item;
                }

            }
            return null;

        }

        public string Eliminar(Cliente cliente)
        {
            Cliente clientes = Buscar(id);

            if (cliente != null)
            {
                return "cliente no existe";
            }
            else
            {
                lista.Remove(cliente);
                repositorioclientes.Eliminar(clientes);

                return "cliente eliminado";
            }
        }
        public string Actualizar(Cliente cliente)
        {
            Cliente clientes = Buscar(id);
            if (cliente == null)
            {
                return Guardar(cliente);

            }
            else
            {
                cliente.IDC = cliente.IDC;
                return repositorioclientes.Actualizar(cliente);
            }
        }
        public static List<Cliente> Listar_ca(string cTexto)
        {
            RepositorioClientes Datos = new RepositorioClientes();
            return Datos.Todos(cTexto);
        }
    }
}
