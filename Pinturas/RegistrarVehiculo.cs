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
            bool v_crearVehiculo = m_iniciar_vehiculo();
            Conexion c_conexion = new Conexion();
            c_conexion.llenarGridViewVehiculos(dgvVehiculos);
        }

        public bool m_iniciar_vehiculo()
        {
            Vehiculos c_vehiculo = new Vehiculos();
            bool v_iniciarVehiculo = c_vehiculo.m_validar_campos(Convert.ToString(comboMarca.Text), Convert.ToString(comboModelo.Text),
                                     Convert.ToString(comboTipo.Text));
            comboMarca.Text = "";
            comboModelo.Text = "";
            comboTipo.Text = "";
           
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
