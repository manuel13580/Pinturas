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
            if (comboMarca.Text.Trim() != "" && comboModelo.Text.Trim() != "" && comboTipo.Text.Trim() != "")
            {
                try
                {
                    Conexion nueva = new Conexion();
                    EliminarVehiculo();
                    comboMarca.Text = "";
                    comboModelo.Text = "";
                    comboTipo.Text = "";


                    nueva.llenarGridViewVehiculos(dgvVehiculos);
                    MessageBox.Show("Vehiculo fue Eliminado con exito");
                    codactual = "";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error " + ex.ToString());
                }

            }
        }
        public bool EliminarVehiculo()
        {
            try {
                Conexion nueva = new Conexion();
                nueva.EjecutarQuery("delete from Presentacion  where Id_auto='" + codactual + "';");
                nueva.EjecutarQuery("delete from Automovil  where Id_auto='" + codactual + "';");
                return true;
            }
            catch (Exception ex) {
                return false;
            }
            
        }
        private void dgvVehiculos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public string codactual = "";
        private void dgvVehiculos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            comboMarca.Text = dgvVehiculos.CurrentRow.Cells[1].Value.ToString();
            comboModelo.Text = dgvVehiculos.CurrentRow.Cells[2].Value.ToString();
            comboTipo.Text = dgvVehiculos.CurrentRow.Cells[3].Value.ToString();
            codactual = dgvVehiculos.CurrentRow.Cells[0].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboMarca.Text.Trim() != "" && comboModelo.Text.Trim() != "" && comboTipo.Text.Trim() != "")
            {
                try
                {
                    Conexion nueva = new Conexion();
                    nueva.EjecutarQuery("update Automovil set Marca='" + comboMarca.Text.ToString() + "', Modelo='" + comboModelo.Text.ToString() + "', Tipo='" + comboTipo.Text + "' where Id_auto='" + codactual + "';");
                    comboMarca.Text = "";
                    comboModelo.Text = "";
                    comboTipo.Text = "";

                    
                    nueva.llenarGridViewVehiculos(dgvVehiculos);
                    MessageBox.Show("Vehiculo fue modificado con exito");
                    codactual = "";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error "+ex.ToString());
                }

            }
        }
        public bool ModificarAutomovil(String marca, String modelo,String tipo,String codactual)
        {
            try
            {
                Conexion nueva = new Conexion();
                nueva.EjecutarQuery("update Automovil set Marca='" + marca + "', Modelo='" + modelo + "', Tipo='" + tipo + "' where Id_auto='" + codactual + "';");
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        private void txtbusqueda_TextChanged(object sender, EventArgs e)
        {
            Conexion nueva = new Conexion();
            nueva.llenarGridViewTintesSQL(dgvVehiculos, "select * from Automovil where Marca like '%" + txtbusqueda.Text + "%';");
        }
       
    }
}
