using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pinturas
{
    public partial class RegistrarVehiculo : Form
    {
        public RegistrarVehiculo()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool v = iniciar_vehiculo();
            Conexion c = new Conexion();
            c.llenarGridViewVehiculos(dgvVehiculos);
        }

        public bool iniciar_vehiculo()
        {
            Vehiculos v = new Vehiculos();
            bool val = v.validar_campos(Convert.ToString(txtmarca.Text), Convert.ToString(txtmodelo.Text),
                       Convert.ToString(txttipo.Text));
            txtmarca.Text = "";
            txtmodelo.Text = "";
            txttipo.Text = "";
           
            return true;


        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void dgvVehiculos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
