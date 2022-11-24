using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatosDAO;
using Entidades;
using System.Data.SqlClient;
using System.Data;
namespace Datos
{
    public class RepositorioVehiculos : ConexionBD, ICRUDVehiculo<Vehiculo>
    {
        public string Actualizar(Vehiculo objs)
        {
            try
            {
                string _sql = string.Format("UPDATE [dbo].[Vehiculos] SET [idcliente] = '{0}'   ,[Marca] = '{1}' ,[modelo] = '{2}', [color] = '{3}',  [fechallegada] = '{4}' WHERE [Placa] = '{5}'", objs.cedula, objs.Marca, objs.modelo,objs.color, objs.fechallegada,objs.PlacaVehiculo);

                var cmd = new SqlCommand(_sql, conexion);
                AbrirConnexion();
                int filas = cmd.ExecuteNonQuery();
                CerrarConnexion();
                if (filas == 1)
                {
                    return "se Actualizo el registro del vehiculo con placa = :" + objs.PlacaVehiculo;
                }
                return "Imposible actualizar el registro del vehiculo con placa = :" + objs.PlacaVehiculo;
            }
            catch (Exception ex)
            {

                return ex.Message;
            }
        }


        public Vehiculo BuscarPlaca(string placa)
        {
            try
            {
                string _sql = string.Format("select * from Vehiculos where idcliente='{0}'", placa);
                var cmd = new SqlCommand(_sql, conexion);
                AbrirConnexion();
                var reader = cmd.ExecuteReader();
                reader.Read();
                var vehiculo = new Vehiculo(reader.GetString(0),reader.GetString(1), reader.GetString(2), reader.GetString(3),reader.GetString(4),reader.GetDateTime(5));
                CerrarConnexion();
                return vehiculo;
            }
            catch (Exception)
            {

                return null;
            }
        }

        public string Eliminar(Vehiculo objs)
        {
            try
            {
                string _sql = string.Format("DELETE FROM [dbo].[Vehiculos] WHERE Placa='{0}'", objs.PlacaVehiculo);

                var cmd = new SqlCommand(_sql, conexion);
                AbrirConnexion();
                int filas = cmd.ExecuteNonQuery();
                CerrarConnexion();
                if (filas == 1)
                {
                    return "se elimino el registro del vehiculo con placa = :" + objs.PlacaVehiculo;
                }
                return "Imposible se eliminar el registro del vehiculo con placa= :" + objs.PlacaVehiculo;
            }
            catch (Exception ex)
            {

                return ex.Message;
            }
        }

        public string Insertar(Vehiculo objs)
        {
            try
            {
                string _sql = string.Format("INSERT INTO[dbo].[Vehiculos] VALUES('" + objs.cedula + "','" + objs.PlacaVehiculo + "','" + objs.Marca + "','" + objs.modelo + "','" + objs.color + "','" + objs.fechallegada + "')");
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
                    return "El cliente ya tiene un vehiculo asignado";     
                }
                return e.Message;
            }
        }

        public List<Vehiculo> Todos(string condicion)
        {
            string _sql = string.Format("select * from Vehiculos where Placa like '{0}%' or Marca like '{1}%'", condicion, condicion);
            DataTable tabla = new DataTable("vehiculos");
            SqlDataAdapter adapter = new SqlDataAdapter(_sql, conexion);

            adapter.Fill(tabla);

            List<Vehiculo> lista = new List<Vehiculo>();

            foreach (var fila in tabla.Rows)
            {

                lista.Add(map((DataRow)fila));
            }
            return lista;
        }

        Vehiculo map(DataRow fila)
        {
            Vehiculo vehiculo = new Vehiculo();
            vehiculo.cedula = (string)fila[0];
            vehiculo.PlacaVehiculo = (string)fila[1];
            vehiculo.Marca = (string)fila[2];
            vehiculo.modelo = (string)fila[3];
            vehiculo.color = (string)fila[4];
            vehiculo.fechallegada = (DateTime)fila[5];
         
            return vehiculo;
        }

        public DataTable cargarclientes()
        {
            SqlDataAdapter dt = new SqlDataAdapter("SP_CARGARCLIENTES", conexion);
            dt.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable tabla = new DataTable();
            dt.Fill(tabla);
            return tabla;
        }

    }
}
