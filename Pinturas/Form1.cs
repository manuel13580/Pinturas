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
    public partial class Form1 : Form
    {
        public static bool EsAdmin=true;
        public Form1()
        {
            InitializeComponent();
            Conexion nueva = new Conexion();
            string consulta = "select p.Id_presentacion as \"Numero\", a.Marca as \"Tipo de Auto\", p.Codigo_color as \"Codigo de Color\", p.Descripcion as \"Descripcion\", p.Tamaño_Medida as \"Cantidad de Formula\",  p.Completo as \"Estado de Formula\", p.Año_Inicial as \"Año Inicial \", p.Año_Final as \"Año Final \"  from Automovil a, Presentacion p where p.Id_auto=a.Id_auto;";
            nueva.LlenarGrid(consulta, dataGridView1, "Automovil");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            System.Globalization.CultureInfo.CreateSpecificCulture("en-US");
            System.Globalization.CultureInfo.CreateSpecificCulture("en-US");
            if (!Form1.EsAdmin)
            {
                opcionesToolStripMenuItem.Enabled = false;
                mostrarToolStripMenuItem.Enabled = false;
                opcionesToolStripMenuItem.Visible = false;
                mostrarToolStripMenuItem.Visible = false;
            }
        }

        private void presentacionToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CrearFormula form=new CrearFormula();
            form.Show();
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Conexion nueva = new Conexion();
            string consulta = "select p.Id_presentacion as \"Numero\", a.Marca as \"Tipo de Auto\", p.Codigo_color as \"Codigo de Color\", p.Descripcion as \"Descripcion\", p.Tamaño_Medida as \"Cantidad de Formula\", p.Completo as \"Estado de Formula\", p.Año_Inicial as \"Año Inicial \", p.Año_Final as \"Año Final \"  from Automovil a, Presentacion p where p.Id_auto=a.Id_auto;";
            nueva.LlenarGrid(consulta, dataGridView1, "Automovil");
        }
        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                rellenar();
            }
        }
        void rellenar()
        {
            FormulaPresentacion nuevo = new FormulaPresentacion();
            nuevo.valor = Int32.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            nuevo.cod_color = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            nuevo.auto = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            nuevo.descripcion = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            nuevo.Tamaño = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            nuevo.Estado = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            nuevo.Show();
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
    }
}
