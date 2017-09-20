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
    public partial class Color : Form
    {
        public Color()
        {
            InitializeComponent();
        }

        private void cREARCOLORToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formulario_Color nuevo = new Formulario_Color();
            nuevo.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Color_Load(object sender, EventArgs e)
        {
            cargar_colores();
        }
        public void cargar_colores() {
            Conexion c_conexion = new Conexion();
            c_conexion.llenarGridViewColores(dataGridView1);
            for (int i=0;i< dataGridView1.RowCount-1;i++) {
                String[] rgb = dataGridView1.Rows[i].Cells[2].Value.ToString().Split(',');
                dataGridView1.Rows[i].Cells[2].Style.BackColor = System.Drawing.Color.FromArgb(int.Parse(rgb[0]), int.Parse(rgb[1]), int.Parse(rgb[2]));
                dataGridView1.Rows[i].Cells[2].Value = "";

            }

        }
    }
}
