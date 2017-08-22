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
    public partial class Registro : Form
    {
        public int codigoP;
        public Registro()
        {
            InitializeComponent();
        }

        private void Registro_Load(object sender, EventArgs e)
        {
            combotinte.Text = "Por Nombre";
            combotinte.Select();
            Conexion nueva = new Conexion();
            nueva.LlenarGrid("select Codigo_tinte as \"Codigo\", Nombre as \"Nombre\"  from Tinte;", dataGridView1, "Tinte");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtcantidad.Text.Trim() != "" && lblcodigo.Text != "****" && lblnombre.Text != "****")
            {
                Conexion nueva = new Conexion();
                try
                {
                    nueva.EjecutarQuery("insert into Asignacion values (" + codigoP + ",'" + lblcodigo.Text + "'," + txtcantidad.Text.Trim() + ");");
                    txtcantidad.Text = "";
                    txtbusqueda.Text = "";
                    lblnombre.Text = "****";
                    lblcodigo.Text = "****";
                    nueva.LlenarGrid("select Codigo_tinte as \"Codigo\", Nombre as \"Nombre\"  from Tinte;", dataGridView1, "Tinte");
                    combotinte.Select();
                    MessageBox.Show("Tinte Registrado en Formula");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error en el ingreso de los datos");
                }

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
