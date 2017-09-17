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
            bool registro = registrar_Tinte(Convert.ToString(txtcodigo.Text), Convert.ToString(txtnombre.Text),
                                           Convert.ToString(txtmonocapa.Text), Convert.ToString(textrgb.Text),Convert.ToString(textPrecio.Text));
        }

        public bool registrar_Tinte(string codigo, string nombre, string mono_capa, string rgb, string Precio)
        {
            bool respuesta = false;
            Conexion nueva = new Conexion();
            try
            {
                if (txtcodigo.Text.Trim() != "" && txtnombre.Text.Trim() != "")
                {
                    nueva.EjecutarQuery("INSERT INTO TINTE(Codigo_Tinte,Nombre,MonoCapa,RGB,Precio)" +
                                     " values('" + codigo + "','" + nombre + "','" + mono_capa + "','" + rgb + "','" + Precio + "')");
                    txtcodigo.Text = "";
                    txtnombre.Text = "";
                    txtmonocapa.Text = "";
                    MessageBox.Show("Tinte Registrado");
                    txtcodigo.Select();
                    respuesta = true;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo realizar la insercion " + ex.ToString());
                txtcodigo.Select();
                respuesta = false;
            }
            return respuesta;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
