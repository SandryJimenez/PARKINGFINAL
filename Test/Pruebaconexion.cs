using Datos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test
{
    public partial class Pruebaconexion : Form
    {
        public Pruebaconexion()
        {
            InitializeComponent();
        }

        private void btnconexion_Click(object sender, EventArgs e)
        {
            Conexion conexion = new Conexion();
            conexion.AbrirConnexion();
        }
    }
}
