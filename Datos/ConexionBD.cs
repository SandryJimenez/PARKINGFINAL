using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace Datos
{
    public class ConexionBD
    {
        private static ConexionBD Con = null;
        protected SqlConnection conexion;
        protected string cadenaConexion;

        public ConexionBD()
        {
            cadenaConexion = string.Format("Server={0};Database={1};Trusted_Connection=True;", ".\\SQLEXPRESS", "PARKING");
            conexion = new SqlConnection(cadenaConexion);
        }
        public SqlConnection AbrirConnexion()
        {
            if (conexion.State == System.Data.ConnectionState.Open)
            {
                CerrarConnexion();
            }
            conexion.Open();
            return conexion;
        }
        public void CerrarConnexion()
        {
            conexion.Close();
        }

        public static ConexionBD GetInstancia()
        {
            if (Con == null)
            {
                Con = new ConexionBD();
            }
            return Con;
        }


      


    }
}

