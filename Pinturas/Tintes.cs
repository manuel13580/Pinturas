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
        SqlConnection cn;
        SqlCommand cmd;
        SqlDataReader dr;
        public Tintes()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool registro = registrar_Tinte(Convert.ToString(txtcodigo.Text), Convert.ToString(txtnombre.Text),
                                           Convert.ToString(txtmonocapa.Text), Convert.ToInt32(textrgb.Text));
        }
        public bool registrar_Tinte(string codigo, string nombre, string mono_capa, int rgb)
        {

            try

            {

                cmd = new SqlCommand("INSERT INTO TINTE(Codigo,Nombre,Mono_Capa,Rgb)" +
                                     " values('" + codigo + "','" + nombre + "','" + mono_capa + "'," + rgb + ")", cn);
                cmd.ExecuteNonQuery();
                cmd.ExecuteNonQuery();
                cn.Close();
                return true;



            }
            catch (Exception ex)
            {

                MessageBox.Show("No se inserto Por :  " + ex.ToString());
                return false;

            }

        }

    }
}
