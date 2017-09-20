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
    }
}
