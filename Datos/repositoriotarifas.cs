using Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class repositoriotarifas : ConexionBD, ICRUDTarifa<Tarifas>
    {
        public string Actualizar(Tarifas obj)
        {
            try
            {
                string _sql = string.Format("UPDATE [dbo].[Tipos_vehiculos] SET [tipo] = '{0}' ,[valorhora] = '{1}'  WHERE [id] = '{2}'", obj.tipovehiculo, obj.precioxhora, obj.idvehiculo);

                var cmd = new SqlCommand(_sql, conexion);
                AbrirConnexion();
                int filas = cmd.ExecuteNonQuery();
                CerrarConnexion();
                if (filas == 1)
                {
                    return "se Actualizo la tarifa de los vehiculos tipo = :" + obj.tipovehiculo;
                }
                return "No se pudo actualizar el tipo de vehiculo = :" + obj.tipovehiculo;
            }
            catch (Exception ex)
            {

                return ex.Message;
            }
        }

        public Tarifas Buscartipo(string id)
        {
            try
            {
                string _sql = string.Format("select * from Tipos_vehiculos where id='{0}'", id);
                var cmd = new SqlCommand(_sql, conexion);
                AbrirConnexion();
                var reader = cmd.ExecuteReader();
                reader.Read();
                var vehiculo = new Tarifas(reader.GetInt32(0), reader.GetString(1), reader.GetString(2));
                CerrarConnexion();
                return vehiculo;
            }
            catch (Exception)
            {

                return null;
            }
        }

        public string Eliminar(Tarifas obj)
        {
            try
            {
                string _sql = string.Format("DELETE FROM [dbo].[Tipos_vehiculos] WHERE id='{0}'", obj.idvehiculo);

                var cmd = new SqlCommand(_sql, conexion);
                AbrirConnexion();
                int filas = cmd.ExecuteNonQuery();
                CerrarConnexion();
                if (filas == 1)
                {
                    return "se elimino la tarifa del vehiculo de tipo = :" + obj.tipovehiculo;
                }
                return "Imposible se eliminar la tarifa del vehiculo tipo= :" + obj.tipovehiculo;
            }
            catch (Exception ex)
            {

                return ex.Message;
            }
        }

        public string Insertar(Tarifas obj)
        {
            try
            {
                string _sql = string.Format("INSERT INTO[dbo].[Tipos_vehiculos] VALUES('" + obj.idvehiculo + "','" + obj.tipovehiculo + "','" + obj.precioxhora +  "')");
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

        public List<Tarifas> Todos(string condicion)
        {
            string _sql = string.Format("select * from Tipos_vehiculos where id like '{0}%' or tipo like '{1}%'", condicion, condicion);
            DataTable tabla = new DataTable("vehiculos");
            SqlDataAdapter adapter = new SqlDataAdapter(_sql, conexion);

            adapter.Fill(tabla);

            List<Tarifas> lista = new List<Tarifas>();

            foreach (var fila in tabla.Rows)
            {

                lista.Add(map((DataRow)fila));
            }
            return lista;
        }
        Tarifas map(DataRow fila)
        {
            Tarifas tarifa = new Tarifas();
            tarifa.idvehiculo = (int)fila[0];
            tarifa.tipovehiculo = (string)fila[1];
            tarifa.precioxhora = (string)fila[2];

            return tarifa;
        }

    }
}
