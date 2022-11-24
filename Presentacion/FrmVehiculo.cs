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
using Logica;
using Entidades;


namespace Presentacion
{
    public partial class FrmVehiculo : Form
    {
        private static FrmVehiculo instacias = null;
        public FrmVehiculo()
        {
            InitializeComponent();
        }

        public static FrmVehiculo GetInstancias()
        {
            if (instacias == null || instacias.IsDisposed)
            {
                instacias = new FrmVehiculo();
            }
            return instacias;
        }
        private void Listado_vehiculos(string cTexto)
        {
            listavehiculos.DataSource = servicioVehiculo.Listar_vehiculos(cTexto);
            this.CargarLista(cTexto);
        }

        public void cargarclientes()
        {
            cmbcedula.DataSource = rv.cargarclientes();
            cmbcedula.DisplayMember = "nombre";
            cmbcedula.ValueMember = "idcliente";
        }




        RepositorioVehiculos rv = new RepositorioVehiculos();
        private void FrmVehiculo_Load(object sender, EventArgs e)
        {
            
            CargarGrillaVehiculos("");
            CargarLista("");
            this.Listado_vehiculos("%");
            cargarclientes();

        }

        void CargarLista(string condicion)
        {
            listavehiculos.DataSource = new RepositorioVehiculos().Todos(condicion);
            listavehiculos.DisplayMember = "marca";
            listavehiculos.ValueMember = "cedula";
            if (listavehiculos.Items.Count > 0)
            {
                listavehiculos.SelectedIndex = 0;
                listavehiculos.Select();
            }
            
        }
        void CargarGrillaVehiculos(string condicion)
        {
            grillaVehiculos.DataSource = new RepositorioVehiculos().Todos(condicion);
           


        }

        private void listavehiculos_SelectedIndexChanged(object sender, EventArgs e)
        {
            string placa = listavehiculos.SelectedValue.ToString();
            Buscar(placa);
        }
        void Buscar(string placa)
        {
            try
            {
                var vehiculo = new RepositorioVehiculos().BuscarPlaca(placa);
                ver(vehiculo);
            }
            catch (Exception)
            {


            }
        }

        void ver(Entidades.Vehiculo vehiculo)
        {
           
            if (vehiculo == null)
            {
                return;
            }         
            cmbcedula.Text  = vehiculo.cedula;
            txtPlaca.Text = vehiculo.PlacaVehiculo;
            txtmarca.Text =vehiculo.Marca;
            txtmodelo.Text = vehiculo.modelo;
            comboxcolor.Text = vehiculo.color;
            datellegada.Text = Convert.ToString( vehiculo.fechallegada);
            //txtKilometraje.Text =Convert.ToString( vehiculo.KilometrajeActual);
            //numericmodelo.Text = Convert.ToString( vehiculo.modelo);
            //comboxestado.Text = vehiculo.estado;
            //comboxcolor.Text =vehiculo.color;

            
        }

        private void grillaVehiculos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            string placa = grillaVehiculos.Rows[e.RowIndex].Cells[0].Value.ToString();
            Buscar(placa);
            listavehiculos.SelectedIndex = e.RowIndex;
            this.tabControl1.TabPages[0].Show();
           
        }

        private void txtCondicion_TextChanged(object sender, EventArgs e)
        {
            string condicion = txtCondicion.Text.Trim();
            CargarGrillaVehiculos(condicion);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

            DialogResult cOpcion;
            cOpcion = MessageBox.Show("¿Esta seguro de eliminar el vehiculo?", "Aviso del sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (cOpcion == DialogResult.Yes)
            {
                if (txtPlaca.Text.Length == 0)
                {
                    return;
                }
                Eliminar(new RepositorioVehiculos().BuscarPlaca(cmbcedula.Text));
                this.Listado_vehiculos("%");
                CargarGrillaVehiculos("");
            }



            
        }
        void Eliminar(Vehiculo vehiculo)
        {

            MessageBox.Show(new RepositorioVehiculos().Eliminar(vehiculo));
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Buscar(txtPlaca.Text.Trim());
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            var vehiculo = new Vehiculo(Convert.ToString( cmbcedula.SelectedValue), txtPlaca.Text,txtmarca.Text, txtmodelo.Text, comboxcolor.Text, datellegada.Value);
            Actualizar(vehiculo);
            this.Listado_vehiculos("%");
            CargarGrillaVehiculos("");

        }
        void Actualizar(Vehiculo vehiculo)
        {
            MessageBox.Show(new RepositorioVehiculos().Actualizar(vehiculo));
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Nuevo(false);
            txtPlaca.Enabled = true;
            txtPlaca.Focus();
        }
        void Nuevo(bool soloLectura)
        {
            foreach (Control item in groupBox2.Controls)
            {
                if (item is TextBox)
                {
                    ((TextBox)item).Clear();
                    ((TextBox)item).ReadOnly = soloLectura;
                }
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //Vehiculo vh = new Vehiculo();
            //vh.PlacaVehiculo = txtPlaca.Text;
            //vh.Marca =Convert.ToString( comboxmarca.SelectedValue);
            //vh.KilometrajeActual =int.Parse( txtKilometraje.Text);
            //vh.KilometrajeActual =Convert.ToInt32( numericmodelo.Value);
            //vh.estado =comboxestado.Text;
            //vh.color =Convert.ToString( comboxcolor.SelectedValue);
            //Insertar(vh);
         

            var vehiculo = new Vehiculo(Convert.ToString(cmbcedula.SelectedValue), txtPlaca.Text, txtmarca.Text, txtmodelo.Text, comboxcolor.Text,datellegada.Value);
            Insertar(vehiculo);
            this.Listado_vehiculos("%");
            CargarGrillaVehiculos("");
        }
        void Insertar(Vehiculo vehiculo)
        {
            MessageBox.Show(new RepositorioVehiculos().Insertar(vehiculo));
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Form mv = new Form();
            this.Close();
        }

        #region
        //  Metodos para usar el evento keypress
        public void SoloLetras(KeyPressEventArgs e)
        {
            if ((e.KeyChar > 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo ingrese Caracteres", "ALERTA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        #endregion

        private void txtMarca_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloLetras(e);
        }

       
      
    }
}
