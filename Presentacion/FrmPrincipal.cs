using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void gestionDeClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmClientes frm = FrmClientes.GetInstancia();
            
            frm.MdiParent = this;
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.BringToFront();
            frm.Show();
        }

        private void gestionDeVehiculosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmVehiculo frm = FrmVehiculo.GetInstancias();

            frm.MdiParent = this;
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.BringToFront();
            frm.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void facturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAlquiler frm = new FrmAlquiler();
            frm.Show();
        }

        private void consultarFacturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmConsultarFacturas frmConsultarFacturas = new FrmConsultarFacturas();
            frmConsultarFacturas.Show();
        }
    }
}
