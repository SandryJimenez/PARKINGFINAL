using Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Datos
{
    public class RepositorioParqueadero : ConexionBD, ICRUDParqueadero<Parqueadero>
    {
        public Parqueadero BuscarFactura(int id)
        {
            throw new NotImplementedException();
        }

        public List<Parqueadero> ConsultarTodasFacturas(string condicion)
        {
            string _sql = string.Format("select * from parqueadero where idparqueadero like '{0}%'", condicion);
            System.Data.DataTable tabla = new DataTable("parqueadero");
            SqlDataAdapter adapter = new SqlDataAdapter(_sql, conexion);

            adapter.Fill(tabla);

            List<Parqueadero> lista = new List<Parqueadero>();

            foreach (var fila in tabla.Rows)
            {

                lista.Add(map((DataRow)fila));
            }
            return lista;

        }
        Parqueadero map(DataRow fila)
        {
            Parqueadero alquiler = new Parqueadero();
            alquiler.IdParqueadero = (int)fila[0];
            alquiler.cedula = (string)fila[1];
            alquiler.PlacaVehiculo = (string)fila[2];         
            alquiler.Marca = (string)fila[3];         
            alquiler.modelo = (string)fila[4];
            alquiler.color = (string)fila[5];
            alquiler.fechallegada = Convert.ToDateTime( (string)fila[6]);
            alquiler.valorPorHora = (int)fila[7];
            alquiler.FechaSalida = Convert.ToDateTime((string)fila[8]);   
            alquiler.HoraSalida = (string)fila[9];   
            alquiler.Total = Convert.ToDouble((string)fila[10]);
            return alquiler;
        }

        public string Insertar(Parqueadero parqueaderos)
        {
            try
            {
                string _sql = string.Format("INSERT INTO[dbo].[Parqueadero] VALUES('" +parqueaderos.IdParqueadero + "','" +
                    parqueaderos.cedula + "','" + parqueaderos.PlacaVehiculo + "','" + 
                    parqueaderos.Marca + "','" + parqueaderos.modelo + "','" + parqueaderos.color + "','" + 
                    parqueaderos.fechallegada + "','" + parqueaderos.valorPorHora + "','" + parqueaderos.FechaSalida + "','" +
                    parqueaderos.HoraSalida + "','" + parqueaderos.Total + "')"); 
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
            catch (Exception e)
            {

                return e.Message;
            }
        }

      
    }
}
