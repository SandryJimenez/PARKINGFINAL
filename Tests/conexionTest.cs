using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Datos;
using System.Data.OracleClient;
using System.Runtime.Remoting.Messaging;

namespace Tests
{
    public partial class conexionTest : Form
    {
        private static Conexion Con = null;
        protected OracleConnection conexion;
        protected string cadenaConexion;
        public conexionTest()
        {
            InitializeComponent();
        }

        private void btnconexion_Click(object sender, EventArgs e)
        {

            string cadenaConexion = String.Format("SERVER=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521))(CONNECT_DATA=(SERVICE_NAME=xe)));uid=Rentavehiculos;pwd=renta;");
            conexion = new OracleConnection(cadenaConexion);
            AbrirConnexion();

        }

        public string AbrirConnexion()
        {

            if (conexion.State == System.Data.ConnectionState.Open)
            {
                CerrarConnexion();
            }
            conexion.Open();
            MessageBox.Show("Conectado al usuario rentavehiculos");
            return conexion.State.ToString();

        }
        public void CerrarConnexion()
        {
            conexion.Close();
        }

        public static Conexion GetInstancia()
        {
            if (Con == null)
            {
                Con = new Conexion();
            }
            return Con;
        }

        private void btnvalores_Click(object sender, EventArgs e)
        {
            string numeros2 = "Sumando cosas en tres valores"
;            MessageBox.Show("Ha presiona el boton valores");
            txtbox.Text = btnvalores.Text;
            txtbox.Text = numeros2;
        }
    }
}

