using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using Logica;
using Datos;
namespace Presentacion
{
   
    public partial class FrmClientes : Form
    {
  
        private static FrmClientes instacia = null;
        public FrmClientes()
        {
            InitializeComponent();


        }
        public static FrmClientes GetInstancia()
        {
            if (instacia == null || instacia.IsDisposed)
            {
                instacia = new FrmClientes();
            }
            return instacia;
        }
        private void Listado_ca(string cTexto)
        {
            listaClientes.DataSource = servicioCliente.Listar_ca(cTexto);
            this.CargarLista(cTexto);
            CargarGrillaClientes("");
        }


        private void FrmClientes_Load(object sender, EventArgs e)
        {
            CargarLista("");
            CargarGrillaClientes("");
            this.Listado_ca("%");
           

        }
        void CargarLista(string condicion)
        {
            listaClientes.DataSource = new RepositorioClientes().Todos(condicion);
            listaClientes.DisplayMember = "Nombre";
            listaClientes.ValueMember = "IDC";
            if (listaClientes.Items.Count > 0)
            {
                listaClientes.SelectedIndex = 0;
                listaClientes.Select();
            }
        }
        void CargarGrillaClientes(string condicion)
        {
            grillaClientes.DataSource = new RepositorioClientes().Todos(condicion);

        }

        private void listaClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            string id = listaClientes.SelectedValue.ToString();
            Buscar(id);
        }
        void Buscar(string id)
        {
            try
            {
                var cliente = new RepositorioClientes().BuscarID(id);
                ver(cliente);
            }
            catch (Exception)
            {


            }
        }
        void ver(Entidades.Cliente cliente)
        {
            if (cliente == null)
            {
                return;
            }
            txtIdCliente.Text = cliente.IDC;
            txtNombre.Text = cliente.Nombre;
            txtapellido.Text = cliente.Apellido;
            comboxgenero.Text = cliente.Genero;
            txttelefono.Text = Convert.ToString( cliente.Telefono);
            
            
        }

        private void grillaClientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string id = grillaClientes.Rows[e.RowIndex].Cells[0].Value.ToString();
            Buscar(id);
            listaClientes.SelectedIndex = e.RowIndex;
            this.tabControl1.TabPages[0].Show();
        }

        private void txtCondicion_TextChanged(object sender, EventArgs e)
        {

            string condicion = txtCondicion.Text.Trim();
            CargarGrillaClientes(condicion);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult cOpcion;
            cOpcion = MessageBox.Show("¿estas seguro de eliminar el registro?", "Aviso del sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (cOpcion == DialogResult.Yes)
            {
                if (txtIdCliente.Text.Length == 0)
                {
                    return;
                }
                Eliminar(new RepositorioClientes().BuscarID(txtIdCliente.Text));
                this.Listado_ca("%");
            }
               
        }
        void Eliminar(Cliente cliente)
        {

            MessageBox.Show(new RepositorioClientes().Eliminar(cliente));

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Buscar(txtIdCliente.Text.Trim());

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            var cliente = new Cliente(txtIdCliente.Text, txtNombre.Text, txtapellido.Text,comboxgenero.Text,txttelefono.Text);
            Actualizar(cliente);
            this.Listado_ca("%");
        }
        void Actualizar(Cliente cliente)
        {
            MessageBox.Show(new RepositorioClientes().Actualizar(cliente));

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Nuevo(false);
            txtIdCliente.Enabled = true;
            txtIdCliente.Focus();

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

        private void txtTipo_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

                var cliente = new Cliente(txtIdCliente.Text, txtNombre.Text, txtapellido.Text, comboxgenero.Text,txttelefono.Text);
                Insertar(cliente);
                this.Listado_ca("%");
 
        }

        void Insertar(Cliente cliente)
        {
            MessageBox.Show(new RepositorioClientes().Insertar(cliente));
        }

        private void tabControl1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                if (txtIdCliente.Text.Length == 0)
                {
                    return;
                }
                Eliminar(new RepositorioClientes().BuscarID(txtIdCliente.Text));
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Form mv = new Form();
            this.Close();
        }

        private void grillaClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }
        public void SoloNumero(KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo ingrese numeros", "ALERTA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }

        }

        public void SoloLetras(KeyPressEventArgs e)
        {
            if ((e.KeyChar > 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo ingrese letras", "ALERTA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
            private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
             {
            SoloLetras(e);
          
        }

        private void txtIdCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloNumero(e);
        }

  
    }
}