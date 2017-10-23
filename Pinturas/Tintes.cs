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
        public string codactual = "";
        private void button2_Click(object sender, EventArgs e)
        {
           

            if (txtcodigo.Text.Trim() != "" && txtnombre.Text.Trim() != "")
            {
                try
                {
                    Conexion nueva = new Conexion();
                    nueva.EjecutarQuery("update Tinte set Codigo_tinte='" + txtcodigo.Text.ToString() + "', Nombre='" + txtnombre.Text.ToString() + "', MonoCapa='" + txtmonocapa.Text + "', RGB='"+textrgb.Text+"', Precio='"+textPrecio.Text+"' where Codigo_tinte='" + codactual + "';");
                    txtcodigo.Text = "";
                    txtnombre.Text = "";
                    txtmonocapa.Text = "";
                    textrgb.Text = "";
                    textPrecio.Text = "";
                    nueva.llenarGridViewTintes(dgvTintes);
                    MessageBox.Show("Tinte fue modificado con exito");
                    codactual = "";
                    button2.Enabled = false;
                    button3.Enabled = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error ese Codigo de tinte Ya existe");
                }

            }
        }

        private void txtnombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void Tintes_Load(object sender, EventArgs e)
        {
            Conexion c_conexion = new Conexion();
            c_conexion.llenarGridViewTintes(dgvTintes);
        }

        private void dgvTintes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvTintes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtcodigo.Text = dgvTintes.CurrentRow.Cells[0].Value.ToString();
            txtnombre.Text = dgvTintes.CurrentRow.Cells[1].Value.ToString();
            txtmonocapa.Text = dgvTintes.CurrentRow.Cells[2].Value.ToString();
            textrgb.Text = dgvTintes.CurrentRow.Cells[3].Value.ToString();
            textPrecio.Text = dgvTintes.CurrentRow.Cells[4].Value.ToString();
            codactual = txtcodigo.Text;
            button2.Enabled = true;
            button3.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (txtcodigo.Text.Trim() != "" && txtnombre.Text.Trim() != "")
            {
                try
                {
                    Conexion nueva = new Conexion();
                    DialogResult dialogResult = MessageBox.Show("¿Desea eliminar el Tinte " + codactual + " y todos sus registros?", "Aviso", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        nueva.EjecutarQuery("delete from Tinte where Codigo_tinte='" + codactual + "';");
                        txtcodigo.Text = "";
                        txtnombre.Text = "";
                        txtmonocapa.Text = "";
                        textrgb.Text = "";
                        textPrecio.Text = "";
                        nueva.llenarGridViewTintes(dgvTintes);
                        codactual = "";
                        button2.Enabled = false;
                        button3.Enabled = false;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error ese Codigo no Existe");
                }

            }
        }
    }
}
