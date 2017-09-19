using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pinturas
{
    public partial class Tintes : Form
    {
       
        SqlCommand cmd;
        SqlDataReader dr;
        public Tintes()
        {
            InitializeComponent();





        }

        private void button1_Click(object sender, EventArgs e)
        {
           bool v_verificacion = iniciar_verificacion();
            Conexion c_conexion = new Conexion();
            c_conexion.llenarGridViewTintes(dgvTintes);
        }


        public bool iniciar_verificacion() {
            Tinte c_tintes = new Tinte();
            bool v_creacionTinte = c_tintes.m_validar_campos(Convert.ToString(txtcodigo.Text), Convert.ToString(txtnombre.Text),
                       Convert.ToString(txtmonocapa.Text), Convert.ToString(textrgb.Text), Convert.ToString(textPrecio.Text));
            txtcodigo.Text = "";
            txtnombre.Text = "";
            txtmonocapa.Text = "";
            textPrecio.Text = "";
            textrgb.Text = "";
            txtcodigo.Select();
            return true;


        }


        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void comboTipoBusqueda_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void txtnombre_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
