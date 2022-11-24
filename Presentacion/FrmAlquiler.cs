using Entidades;
using Logica;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Presentacion
{
    public partial class FrmAlquiler : Form
    {
        servicioCliente servicioCliente;
        servicioVehiculo servicioVehiculo;
        servicioParqueadero servicioAlquiler;
        public FrmAlquiler()
        {
            InitializeComponent();
            servicioCliente = new servicioCliente();
            servicioVehiculo = new servicioVehiculo();
            servicioAlquiler = new servicioParqueadero();
        }
        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            var respuesta = servicioVehiculo.BuscarPorid(txtcedula.Text);
            ver2(respuesta.Vehiculo);
        }

        void ver2(Vehiculo veh)
        {
            if (veh == null)
            {
                return;
            }
            txtplaca.Text = veh.PlacaVehiculo;
            txtcedula.Text = veh.cedula;
            txtmarca.Text = veh.Marca;
            txtmodelo.Text = veh.modelo;
            txtColor.Text = veh.color;
            fechallegada.Text =Convert.ToString(veh.fechallegada);
        }
        private Parqueadero CrearPago()
        {
            //DateTime fechauno = Convert.ToDateTime(fechallegada.Value);
            fechasalida.CustomFormat = ("hh:mm:ss tt");
            DateTime fechauno = Convert.ToDateTime( DateTime.Now.ToString("yyyy-MM-dd"));
            DateTime fechados = Convert.ToDateTime(DateTime.Now.ToString("yyyy-MM-dd"));
            //DateTime fechados = Convert.ToDateTime(fechasalida.Value);
            TimeSpan diffechas = fechados - fechauno;
            Double horas = diffechas.TotalHours;
            horasalida.CustomFormat = ("hh:mm:ss tt");
            string calhora = DateTime.Now.ToString("hh:mm:ss tt");
            Random rnd = new Random();
            string random = txtcodfactura.Text = Convert.ToString(rnd.Next(0, 25000));
            Double Total1 =Convert.ToInt32(datevalorhora.Value) * horas;
            double resultado = Math.Round(Total1);
            DateTime formatohora = DateTime.Now;
        

            Parqueadero parqueo = new Parqueadero
            {
                IdParqueadero = Convert.ToInt32(random),
                cedula = txtcedula.Text,
                PlacaVehiculo = txtplaca.Text,
                Marca = txtmarca.Text,
                modelo = txtmodelo.Text,
                color = txtColor.Text,
                fechallegada =Convert.ToDateTime( fechasalida.Text),
                valorPorHora = (int)datevalorhora.Value,
                FechaSalida = Convert.ToDateTime(fechasalida.Text),
                HoraSalida = Convert.ToString(calhora),
                Total = resultado,
            };
            txttotal.Text = parqueo.Total.ToString();
        
            return parqueo;
        }
       
        private void BtnGuardar_Click_1(object sender, EventArgs e)
        {
            string message = servicioAlquiler.Guardar(CrearPago());

            MessageBox.Show(message);
        }
    }
}
