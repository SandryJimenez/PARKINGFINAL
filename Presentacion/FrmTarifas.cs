using Datos;
using Entidades;
using Logica;
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
    public partial class FrmTarifas : Form
    {
        public FrmTarifas()
        {
            InitializeComponent();
        }
        string Operacion = "Insertar";
        private static FrmClientes instacia = null;
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
            //listaClientes.DataSource = servicioCliente.Listar_ca(cTexto);
            //this.CargarLista(cTexto);
            CargarGrillatarifas("");
        }
        void CargarGrillatarifas(string condicion)
        {
            grillatarifas.DataSource = new repositoriotarifas().Todos(condicion);

        }

        private void grillatarifas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (grillatarifas.SelectedRows.Count > 0)
            {
                Operacion = "Editar";
                txtcodigo.Text = grillatarifas.CurrentRow.Cells["ID"].Value.ToString();
                cmbtipovehiculo.Text = grillatarifas.CurrentRow.Cells["TIPO"].Value.ToString();
                txtprecio.Text = grillatarifas.CurrentRow.Cells[3].Value.ToString();
            }
            else
            {
                MessageBox.Show("Debe seleccionar una fila");
            }
        }


        void Buscar(string id)
        {
            try
            {
                var tarifa = new repositoriotarifas().Buscartipo(id);
                ver(tarifa);
            }
            catch (Exception)
            {


            }
        }
        void ver(Entidades.Tarifas tarifa)
        {
            if (tarifa == null)
            {
                return;
            }
            txtcodigo.Text = Convert.ToString(tarifa.idvehiculo);
            cmbtipovehiculo.Text = tarifa.tipovehiculo;
            txtprecio.Text = tarifa.precioxhora;
        }

        private void txtbuscartarifa_TextChanged(object sender, EventArgs e)
        {

            string condicion = txtbuscartarifa.Text.Trim();
            CargarGrillatarifas(condicion);
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            var tarifa = new Tarifas(Convert.ToInt32(txtcodigo.Text), cmbtipovehiculo.Text, txtprecio.Text);
            Insertar(tarifa);
            this.Listado_ca("%");
        }

        void Insertar(Tarifas tarifa)
        {
            MessageBox.Show(new repositoriotarifas().Insertar(tarifa));
        }

        private void btnactualizar_Click(object sender, EventArgs e)
        {
            var tarifa = new Tarifas(Convert.ToInt32(txtcodigo.Text), cmbtipovehiculo.Text, txtprecio.Text);
            Actualizar(tarifa);
            this.Listado_ca("%");
        }
        void Actualizar(Tarifas tarifa)
        {
            MessageBox.Show(new repositoriotarifas().Actualizar(tarifa));

        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            DialogResult cOpcion;
            cOpcion = MessageBox.Show("¿estas seguro de eliminar el registro?", "Aviso del sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (cOpcion == DialogResult.Yes)
            {
                if (txtcodigo.Text.Length == 0)
                {
                    return;
                }
                Eliminar(new repositoriotarifas().Buscartipo(txtcodigo.Text));
                this.Listado_ca("%");
            }
        }
        void Eliminar(Tarifas tarifa)
        {

            MessageBox.Show(new repositoriotarifas().Eliminar(tarifa));

        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
