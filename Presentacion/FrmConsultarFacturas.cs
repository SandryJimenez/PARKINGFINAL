using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using Logica;
using Entidades;
using Datos;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class FrmConsultarFacturas : Form
    {
        public FrmConsultarFacturas()
        {
            InitializeComponent();
            
        }

        void CargarGrillaFacturas(string condicion)
        {
            dataGridView1.DataSource = new RepositorioParqueadero().ConsultarTodasFacturas(condicion);

        }

        private void FrmConsultarFacturas_Load(object sender, EventArgs e)
        {
            CargarGrillaFacturas("");
        }

        private void txtCondicion_TextChanged(object sender, EventArgs e)
        {
            string condicion = txtCondicion.Text.Trim();
            CargarGrillaFacturas(condicion);
        }
    }
}
