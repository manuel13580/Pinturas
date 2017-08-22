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
using System.Data;
namespace Pinturas
{
    public partial class CrearFormula : Form
    {
        public List<int> ListaCodigosAuto = new List<int>();
        public static string codigo;
        public CrearFormula()
        {
            InitializeComponent();
        }

        private void CrearFormula_Load(object sender, EventArgs e)
        {
            Conexion nueva = new Conexion();
            SqlDataReader autos = nueva.Consulta("select * from Automovil;");
            while (autos.Read())
            {
                comboautos.Items.Add(autos[1].ToString());
                ListaCodigosAuto.Add(Int32.Parse(autos[0].ToString()));
                comboautos.Text = autos[1].ToString();
            }
            //MessageBox.Show(comboautos.SelectedIndex+"");

            SqlDataReader formula = nueva.Consulta("select * from Medida;");
            while (formula.Read())
            {
                comboformula.Items.Add(formula[0].ToString());
                comboformula.Text = formula[0].ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboautos.Text.Trim() != "" && comboformula.Text.Trim() != "" && txtdescripcion.Text.Trim() != "" && txtcodigo.Text != "Codigo Seleccionado")
            {
                Conexion nueva = new Conexion();
                if (comboautos.Text.Trim() != "" && comboformula.Text.Trim() != "")
                {
                    try
                    {
                        int id_auto = ListaCodigosAuto.ElementAt(comboautos.SelectedIndex);
                        string id_color = txtcodigo.Text;
                        string des = txtdescripcion.Text;
                        nueva.EjecutarQuery("insert into Presentacion(Id_auto,Codigo_color,Descripcion,Completo,Tamaño_Medida) values (" + id_auto + ",'" + id_color + "','" + des + "','Sin datos','" + comboformula.Text + "');");
                        MessageBox.Show("Nueva Formula Registrada Correctamente");
                        txtdescripcion.Text = "";
                        txtcodigo.Text = "";
                        comboautos.Select();
                    }
                    catch
                    {
                        MessageBox.Show("Error de Datos");
                    }

                }
                else
                {
                    MessageBox.Show("Asegurese de marcar los datos Correspondientes");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ListaCodigosAuto.Clear();
            this.Close();
        }
    }
}
