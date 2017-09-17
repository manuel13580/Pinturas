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
            nueva.LlenarGrid("select Codigo_tinte as \"Codigo\", Nombre as \"Nombre\", RGB as \"RGB\"  from Tinte;", dataGridView1, "Tinte");
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
        private void txtbusqueda_TextChanged(object sender, EventArgs e)
        {
            Conexion nueva = new Conexion();
            if (combotinte.Text.Equals("Por Nombre"))
            {
                nueva.LlenarGrid("select Codigo_tinte as \"Codigo\", Nombre as \"Nombre\"  from Tinte where Nombre like '%" + txtbusqueda.Text + "%';", dataGridView1, "Tinte");
            }
            else if (combotinte.Text.Equals("Por Codigo"))
            {
                nueva.LlenarGrid("select Codigo_tinte as \"Codigo\", Nombre as \"Nombre\"  from Tinte where Codigo_tinte like '%" + txtbusqueda.Text + "%';", dataGridView1, "Tinte");
            }

        }

        private void combotinte_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void combotinte_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtbusqueda.Select();
            }
        }

        private void txtbusqueda_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                dataGridView1.Select();
            }
        }

        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                txtcantidad.Select();
                lblcodigo.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                lblnombre.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            }
        }

        private void combocantidad_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1.Select();
            }
        }

        private void txtcantidad_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1.Select();
            }

        }
        private void txtcantidad_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (char.IsNumber(e.KeyChar) || e.KeyChar.ToString() == "." || e.KeyChar == (char)Keys.Back)
                e.Handled = false;
            else
                e.Handled = true;
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                lblcodigo.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                lblnombre.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            }
            catch (Exception ex)
            {
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                lblcodigo.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                lblnombre.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            }
            catch (Exception ex)
            {
            }
        }

        private void combotinte_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
