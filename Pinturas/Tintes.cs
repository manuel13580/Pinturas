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
           bool ver = iniciar_verificacion();
            Conexion c = new Conexion();
            c.llenarGridViewTintes(dgvTintes);
        }


        public bool iniciar_verificacion() {
            Tinte t = new Tinte();
            bool val = t.validar_campos(Convert.ToString(txtcodigo.Text), Convert.ToString(txtnombre.Text),
                       Convert.ToString(txtmonocapa.Text), Convert.ToString(textrgb.Text), Convert.ToString(textPrecio.Text));
            txtcodigo.Text = "";
            txtnombre.Text = "";
            txtmonocapa.Text = "";
            textPrecio.Text = "";
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
