using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using System.IO;
namespace Pinturas
{

    public partial class FormulaPresentacion : Form
    {
        public List<double> Listamedidas = new List<double>();
        public int valor;
        public string cod_color;
        public string auto;
        public string descripcion;
        public string Estado;
        public string Tamaño;
        public List<int> ListaCodigosAuto = new List<int>();
        public FormulaPresentacion()
        {
            InitializeComponent();
        }

        private void FormulaPresentacion_Load(object sender, EventArgs e)
        {
            menuStrip1.Enabled = true;
            menuStrip1.Visible = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button3.Visible = true;
            button4.Visible = true;
            button5.Visible = true;
            Conexion c_nueva = new Conexion();
            SqlDataReader c_autos = c_nueva.Consulta("select * from Automovil;");
            while (c_autos.Read())
            {
                comboTipoAuto.Items.Add(c_autos[1].ToString());
                ListaCodigosAuto.Add(Int32.Parse(c_autos[0].ToString()));
            }
            comboTipoAuto.Text = this.auto;
            lblcodigo.Text = this.cod_color;
            lbldescripcion.Text = this.descripcion;
            comboestado.Text = this.Estado;
            txtvolumen.Select();
            comboTipoAuto.Enabled = false;
            combo_formula.Enabled = false;
            comboestado.Enabled = false;
            txtcodigo.Visible = false;
            txtdescripcion.Visible = false;

            m_Actualizar();
        }
        public bool m_Actualizar()
        {
            combomedidas.Items.Clear();
            combo_formula.Items.Clear();
            Listamedidas.Clear();
            Conexion c_nueva = new Conexion();
            SqlDataReader c_medidas = c_nueva.Consulta("select * from Medida;");
            while (c_medidas.Read())
            {
                combomedidas.Items.Add(c_medidas[0].ToString());
                Listamedidas.Add(Convert.ToDouble(c_medidas[1].ToString()));
                combo_formula.Items.Add(c_medidas[0].ToString());
            }
            combo_formula.Text = this.Tamaño;
            combomedidas.Text = this.Tamaño;
            c_nueva.LlenarGridFormula("select a.Codigo_tinte as \"Codigo\", t.Nombre as \"Nombre\", a.Cantidad as \"Cantidad (g)\", t.Precio as \"Precio\" from Asignacion a, Tinte t where a.Codigo_tinte=t.Codigo_tinte and a.Id_presentacion=" + valor + ";", dataGridView1, "Asignacion", 1);
            actualizarTotal();
            return true;
        }




        public bool actualizarTotal()
        {
            double v_total = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
                v_total = v_total + Convert.ToDouble(dataGridView1.Rows[i].Cells[2].Value.ToString());
            lbltotal.Text = "Total de la Formula: " + v_total + " (g).";
            return true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            m_NuevoRegistro();
        }
        void m_NuevoRegistro()
        {
            Registro nuevo = new Registro();
            nuevo.codigoP = valor;
            nuevo.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                int v_pos = dataGridView1.CurrentRow.Index;
                m_Actualizar();
                dataGridView1.Rows[v_pos].Selected = true;
                //m_ModificarRegistro(v_pos);
            }
            catch (Exception ex)
            { }
        }


        public bool m_ModificarRegistro(int pos)
        {
            try
            {
                string v_Nuevo = "";
                v_Nuevo = Microsoft.VisualBasic.Interaction.InputBox("La cantidad actual es de " + dataGridView1.Rows[pos].Cells[2].Value.ToString() + " (g) para una formula de " + combo_formula.Text + ", Ingrese la nueva cantidad (g)", "Nueva Cantidad", dataGridView1.Rows[pos].Cells[2].Value.ToString());
                double v_NuevaCant = 0;
                if (!v_Nuevo.Trim().Equals(""))
                {
                    try
                    {
                        v_NuevaCant = Convert.ToDouble(v_Nuevo);
                        try
                        {
                            Conexion c_nueva = new Conexion();
                            if (v_Nuevo.Trim() != "")
                                c_nueva.EjecutarQuery("update Asignacion set Cantidad=" + v_NuevaCant + " where Id_presentacion=" + valor + " and Codigo_tinte='" + dataGridView1.Rows[pos].Cells[0].Value.ToString() + "' and Cantidad=" + dataGridView1.Rows[pos].Cells[2].Value.ToString() + ";");
                            m_Actualizar();
                            return true;
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                            return false;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error, Cantidad invalida");
                        return false;
                    }
                }

                return true;
            }
            catch (Exception q)
            {
                return false;
            }


        }
        private void dataGridView1_CellMouseMove(object sender, DataGridViewCellMouseEventArgs e)
        {
            dataGridView1.Select();
        }
        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
            }
            else if (e.KeyCode == Keys.F1)
            {
                if (Form1.EsAdmin)
                    m_NuevoRegistro();
            }
            else if (e.KeyCode == Keys.F2)
            {
                if (Form1.EsAdmin)
                {
                    try
                    {
                        int pos = dataGridView1.CurrentRow.Index;
                        m_Actualizar();
                        dataGridView1.Rows[pos].Selected = true;
                        m_ModificarRegistro(pos);
                    }
                    catch (Exception ex)
                    { }

                }

            }
            else if (e.KeyCode == Keys.F3)
            {
                if (Form1.EsAdmin)
                {
                    try
                    {
                        int pos = dataGridView1.CurrentRow.Index;
                        m_Actualizar();
                        dataGridView1.Rows[pos].Selected = true;
                        EliminarRegistro(pos);
                    }
                    catch (Exception ex)
                    { }
                }

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                int v_pos = dataGridView1.CurrentRow.Index;
                m_Actualizar();
                dataGridView1.Rows[v_pos].Selected = true;
                EliminarRegistro(v_pos);
            }
            catch (Exception ex)
            { }
        }
        public bool EliminarRegistro(int pos)
        {
            try
            {
                DialogResult c_dialogResult = MessageBox.Show("¿Desea eliminar el Tinte (codigo " + dataGridView1.Rows[pos].Cells[0].Value.ToString() + ") seleccionado?", "Aviso", MessageBoxButtons.YesNo);
                try
                {
                    if (c_dialogResult == DialogResult.Yes)
                    {
                        Conexion nueva = new Conexion();
                        nueva.EjecutarQuery("delete from Asignacion where Id_presentacion=" + valor + " and Codigo_tinte='" + dataGridView1.Rows[pos].Cells[0].Value.ToString() + "' and Cantidad=" + dataGridView1.Rows[pos].Cells[2].Value.ToString());
                        m_Actualizar();
                    }


                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error en la eliminacion del tinte");
                    return false;
                }
                return true;
            }
            catch (Exception q)
            {
                return false;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            calc();
        }
        public bool calc()
        {

            bool respuesta = true;
            Conexion nueva = new Conexion();
            double v_factor = 1;
            double v_val = 1;
            SqlDataReader valorN = nueva.Consulta("select Cantidad from Medida where Nombre='" + combo_formula.Text + "';");
            if (valorN.Read())
                v_val = Convert.ToDouble(valorN[0]);
            double v_volumen = Convert.ToDouble(txtvolumen.Text);
            v_factor = v_volumen / v_val;
            nueva.LlenarGridFormula("select a.Codigo_tinte as \"Codigo\", t.Nombre as \"Nombre\", a.Cantidad as \"Cantidad (g)\" , t.Precio as \"Precio\"  from Asignacion a, Tinte t where a.Codigo_tinte=t.Codigo_tinte and a.Id_presentacion=" + valor + ";", dataGridView1, "Asignacion", v_factor);

            actualizarTotal();
            return respuesta;
        }

        private void actualizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            m_Actualizar();
            actualizarTotal();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}

