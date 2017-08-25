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
    public partial class Form1 : Form
    {
        public static bool EsAdmin=true;
        public Form1()
        {
            InitializeComponent();
            TxtTipoBusqueda.Visible = false;
            Conexion nueva = new Conexion();
            string consulta = "select p.Id_presentacion as \"Numero\", a.Marca as \"Tipo de Auto\", p.Codigo_color as \"Codigo de Color\", p.Descripcion as \"Descripcion\", p.Tamaño_Medida as \"Cantidad de Formula\",  p.Completo as \"Estado de Formula\", p.Año_Inicial as \"Año Inicial \", p.Año_Final as \"Año Final \"  from Automovil a, Presentacion p where p.Id_auto=a.Id_auto;";
            nueva.LlenarGrid(consulta, dataGridView1, "Automovil");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            inicio();
           
        }

        public bool inicio() {

            System.Globalization.CultureInfo.CreateSpecificCulture("en-US");
            opcionesToolStripMenuItem.Enabled = true;
            mostrarToolStripMenuItem.Enabled = true;
            opcionesToolStripMenuItem.Visible = true;
            mostrarToolStripMenuItem.Visible = true;
            llenarCombo();
            TxtBusqueda2.Visible = false;
            TxtTipoBusqueda.Text = "Tipo de Auto";
            TxtTipoBusqueda.Visible = false;
            return true;
        }

        private void presentacionToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CrearFormula form=new CrearFormula();
            form.Show();
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            llenarCombo();
            Conexion nueva = new Conexion();
            string consulta = "select p.Id_presentacion as \"Numero\", a.Marca as \"Tipo de Auto\", p.Codigo_color as \"Codigo de Color\", p.Descripcion as \"Descripcion\", p.Tamaño_Medida as \"Cantidad de Formula\", p.Completo as \"Estado de Formula\", p.Año_Inicial as \"Año Inicial \", p.Año_Final as \"Año Final \"  from Automovil a, Presentacion p where p.Id_auto=a.Id_auto;";
            nueva.LlenarGrid(consulta, dataGridView1, "Automovil");
        }
        public bool llenarCombo()
        {
            ComboAutos.Items.Clear();
            ComboAutos.Items.Add("");
            Conexion nueva = new Conexion();
            SqlDataReader autos = nueva.Consulta("select * from Automovil;");
            while (autos.Read())
                ComboAutos.Items.Add(autos[1].ToString());

            return true;
        }
        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                rellenar();
            }
        }
        public bool rellenar()
        {
            FormulaPresentacion nuevo = new FormulaPresentacion();
            nuevo.valor = Int32.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            nuevo.cod_color = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            nuevo.auto = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            nuevo.descripcion = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            nuevo.Tamaño = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            nuevo.Estado = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            nuevo.Show();
            return true;
        }
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            { rellenar(); }
            catch (Exception ex)
            { }

        }
        private void dataGridView1_CellMouseMove(object sender, DataGridViewCellMouseEventArgs e)
        {
            dataGridView1.Select();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Conexion nueva = new Conexion();
            string consulta = "";

            consulta = "select p.Id_presentacion as \"Numero\",  a.Marca as \"Tipo de Auto\", p.Codigo_color as \"Codigo de Color\", p.Descripcion as \"Descripcion\", p.Tamaño_Medida as \"Cantidad de Formula\", p.Completo as \"Estado de Formula\", p.Año_Inicial as \"Año Inicial \", p.Año_Final as \"Año Final \"  from Automovil a, Presentacion p where p.Id_auto=a.Id_auto and a.Marca like '%" + ComboAutos.Text + "%' and p.Codigo_color like '%" + TxtBusqueda.Text + "%' and p.Descripcion like '%" + txtdescr.Text + "%' and p.Año_Inicial like '%" + txtaño.Text + "%'";

            nueva.LlenarGrid(consulta, dataGridView1, "Automovil");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtaño.Text = "";
            TxtBusqueda.Text = "";
            txtdescr.Text = "";
            ComboAutos.Text = "";
        }

        private void presentacionesTerminadasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Conexion nueva = new Conexion();
            string consulta = "select p.Id_presentacion as \"Numero\", a.Marca as \"Tipo de Auto\", p.Codigo_color as \"Codigo de Color\", p.Descripcion as \"Descripcion\", p.Tamaño_Medida as \"Cantidad de Formula\", p.Completo as \"Estado de Formula\", p.Año_Inicial as \"Año Inicial \", p.Año_Final as \"Año Final \"  from Automovil a, Presentacion p where p.Id_auto=a.Id_auto and p.Completo='Completa';";
            nueva.LlenarGrid(consulta, dataGridView1, "Automovil");
        }

        private void presentacionesNoTerminadasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Conexion nueva = new Conexion();
            string consulta = "select p.Id_presentacion as \"Numero\", a.Marca as \"Tipo de Auto\", p.Codigo_color as \"Codigo de Color\", p.Descripcion as \"Descripcion\", p.Tamaño_Medida as \"Cantidad de Formula\", p.Completo as \"Estado de Formula\", p.Año_Inicial as \"Año Inicial \", p.Año_Final as \"Año Final \"  from Automovil a, Presentacion p where p.Id_auto=a.Id_auto and p.Completo='Incompleta';";
            nueva.LlenarGrid(consulta, dataGridView1, "Automovil");
        }

        private void faltanDetallesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Conexion nueva = new Conexion();
            string consulta = "select p.Id_presentacion as \"Numero\", a.Marca as \"Tipo de Auto\", p.Codigo_color as \"Codigo de Color\", p.Descripcion as \"Descripcion\", p.Tamaño_Medida as \"Cantidad de Formula\", p.Completo as \"Estado de Formula\", p.Año_Inicial as \"Año Inicial \", p.Año_Final as \"Año Final \"  from Automovil a, Presentacion p where p.Id_auto=a.Id_auto and p.Completo='Sin datos';";
            nueva.LlenarGrid(consulta, dataGridView1, "Automovil");
        }

        private void tinteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Tintes nuevo = new Tintes();
            nuevo.Show();
        }
    }
}
