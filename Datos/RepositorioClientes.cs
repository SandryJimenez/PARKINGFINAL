using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entidades;
using System.Data.SqlClient;
using System.Data;

namespace Datos

{
    public class RepositorioClientes : ConexionBD, DatosDAO.ICRUD<Cliente>
    {
        public string Actualizar(Cliente obj)
        {
            try
            {
                string _sql = string.Format("UPDATE [dbo].[Clientes] SET [Nombre] = '{0}' ,[apellido] ='{1}',[genero] = '{2}',[telefono] = '{3}' WHERE [IdCliente] = '{4}'", obj.Nombre, obj.Apellido, obj.Genero, obj.Telefono, obj.IDC);

                var cmd = new SqlCommand(_sql, conexion);
                AbrirConnexion();
                int filas = cmd.ExecuteNonQuery();
                CerrarConnexion();
                if (filas == 1)
                {
                    return "se Actualizo el registro del cliente cuyo id = :" + obj.IDC;
                }
                return "Imposible actualizar el registro del cliente cuyo id = :" + obj.IDC;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }

        }

        public Cliente BuscarID(string id)
        {
            try
            {
                string _sql = string.Format("select * from clientes where IdCliente='{0}'", id);
                var cmd = new SqlCommand(_sql, conexion);
                AbrirConnexion();
                var reader = cmd.ExecuteReader();
                reader.Read();
                var cliente = new Cliente(reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3),reader.GetString(4));
                CerrarConnexion();
                return cliente;
            }
            catch (Exception)
            {

                return null;
            }




        }

        public string Eliminar(Cliente obj)
        {
            try
            {
                string _sql = string.Format("DELETE FROM [dbo].[Clientes] WHERE IdCliente='{0}'", obj.IDC);

                var cmd = new SqlCommand(_sql, conexion);
                AbrirConnexion();
                int filas = cmd.ExecuteNonQuery();
                CerrarConnexion();
                if (filas == 1)
                {
                    return "se elimino el registro del cliente cuyo id = :" + obj.IDC;
                }
                else
                {
                    return "Imposible se eliminar el registro del cliente cuyo id = :" + obj.IDC;
                }
                
            }
            catch (Exception ex)
            {

                return "El cliente tiene un vehiculo registrado, Por favor revisar";
            }


        }

        public string Insertar(Cliente obj)
        {
            try
            {
                string _sql = string.Format("INSERT INTO[dbo].[Clientes] VALUES('" + obj.IDC + "','" + obj.Nombre + "','" + obj.Apellido + "','" + obj.Genero + "','" + obj.Telefono + "')");
                var cmd = new SqlCommand(_sql, conexion);
                AbrirConnexion();
                int filas = cmd.ExecuteNonQuery();
                CerrarConnexion();
                if (filas > 0)
                {
                    return "Datos guardados satisfactoriamente";
                }
                return "No se pudo guardar los datos";

            }
            catch (SqlException e)
            {
                if (e.Number == 2627)
                {
                    return "Error: El cliente ya existe, Por favor revisar";

                }

                return e.Message;
            }
            return null;

        }

        public List<Cliente> Todos(string condicion)
        {
            string _sql = string.Format("select * from clientes where IdCliente like '{0}%' or Nombre like '{1}%' or apellido like '{2}%'", condicion, condicion,condicion);
            System.Data.DataTable tabla = new DataTable("clientes");
            SqlDataAdapter adapter = new SqlDataAdapter(_sql, conexion);

            adapter.Fill(tabla);

            List<Cliente> lista = new List<Cliente>();

            foreach (var fila in tabla.Rows)
            {

                lista.Add(map((DataRow)fila));
            }
            return lista;
            return null;
        }

        Cliente map(DataRow fila)
        {
            Cliente cliente = new Cliente();
            cliente.IDC = (string)fila[0];
            cliente.Nombre = (string)fila[1];
            cliente.Apellido = (string)fila[2];
            cliente.Genero = (string)fila[3];
            cliente.Telefono = (string)fila[4];
            return cliente;
        }


    }
}