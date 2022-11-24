using Datos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Presentacion
{

    public partial class Login : Form
    {

        ConexionBD conexiones = new ConexionBD();
        public Login()
        {
            InitializeComponent();
        }

        private SqlConnection conexion;
        private void btnlogin_Click(object sender, EventArgs e)
        {
            conexiones.AbrirConnexion();
            SqlCommand comando = new SqlCommand("SELECT USUARIO, PASSWORD FROM Usuario WHERE USUARIO =@vusuario and password= @vpassword",conexiones.AbrirConnexion());
            comando.Parameters.AddWithValue("@vusuario", txtuser.Text);
            comando.Parameters.AddWithValue("@vpassword", txtclave.Text);
            SqlDataReader lector = comando.ExecuteReader();
            comando.Parameters.Clear();


            if (lector.Read())
            {

                PaginaPrincipal frm = new PaginaPrincipal();
                frm.Show();
                lector.Close();
                limpiar();

            }
            else
            {
                MessageBox.Show("Credenciales Incorrectas, por favor verifique");
                lector.Close();
                limpiar();
            }
            void limpiar()
            {
                txtuser.Clear();
                txtclave.Clear();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
