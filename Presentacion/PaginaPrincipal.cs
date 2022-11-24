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
    public partial class PaginaPrincipal : Form
    {

        #region

        public PaginaPrincipal()
        {
            InitializeComponent();
            hiddenDiseño();
        }
        private void hiddenDiseño()
        {
            submenuOpciones.Visible = false;

        }
        private void mostrarsubmenu(Panel submenu)
        {
            if (submenu.Visible == false)
            {
                hiddenDiseño();
                submenu.Visible = true;
            }
            else
            {
                submenu.Visible = false;
            }
        }

        private void btnImagen_Click(object sender, EventArgs e)
        {
            mostrarsubmenu(submenuOpciones);
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {

            openChildFormInPanel(new FrmClientes());
            hiddenDiseño();

        }
        private Form activeForm = null;
        private void openChildFormInPanel(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            paneleshijos.Controls.Add(childForm);
            paneleshijos.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new FrmVehiculo());
            hiddenDiseño();
        }

        private void btnParqueadero_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new FrmAlquiler());
            hiddenDiseño();

        }

        private void btnconsultar_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new FrmConsultarFacturas());
            hiddenDiseño();
        }


        #endregion

    }
}

