using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Pinturas
{
    public partial class Formulario_Color : Form
    {
        public List<int> ListaCodigosFormula = new List<int>();
        public Formulario_Color()
        {
            InitializeComponent();
        }

        private void Formulario_Color_Load(object sender, EventArgs e)
        {
            Cargar_Formulas();
        }
        public void Cargar_Formulas() {
            Conexion nueva = new Conexion();
            SqlDataReader formula = nueva.Consulta("select * from Presentacion;");
            while (formula.Read())
            {
                comboBox1.Items.Add(formula[2].ToString());
                ListaCodigosFormula.Add(Int32.Parse(formula[0].ToString()));
                comboBox1.Text = formula[2].ToString();
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (Confirmacion_Color_Creado()) {
                Color nuevo = new Color();
                nuevo.Show();
                this.Hide();
            } 
        }
        public bool Confirmacion_Color_Creado() {
            bool respuesta =false;
            if (comboBox1.Text.Trim() != ""&&textBox1.Text.Trim()!=""){

                try {
                    Conexion nueva = new Conexion();
                    int id_formula = ListaCodigosFormula.ElementAt(comboBox1.SelectedIndex);
                    String Completo=Obtener_Tintes(id_formula);
                    if (Completo.Equals(""))
                    {
                        MessageBox.Show("Error Inesperado");
                    }
                    else {
                        nueva.EjecutarQuery("insert into Color(Id_presentacion,Nombre_Color,RGB) values (" + id_formula+",'"+textBox1.Text.ToString()+"','"+Completo+"');");
                        MessageBox.Show("Color Creado");
                        comboBox1.Select();
                        respuesta = true;
                    }
                } catch (Exception e) {
                    MessageBox.Show("Ocurrio un error inesperado");
                }
            }else {
                MessageBox.Show("Error, algun campo esta vacio");
            }
            return respuesta;
        }
        public String Obtener_Tintes(int indice) {
            String respuesta = "";
            List<int> r = new List<int>();
            List<int> g = new List<int>();
            List<int> b = new List<int>();
            Conexion nueva = new Conexion();
            SqlDataReader tintes = nueva.Consulta("Select T.RGB from Asignacion A, Tinte T where A.Codigo_tinte=T.Codigo_tinte and A.Id_presentacion='"+indice+"';");
            List<String> ListaHexadecimal = new List<String>();
            while (tintes.Read())
            {
                ListaHexadecimal.Add(tintes[0].ToString());
            }
            if (ListaHexadecimal.Count() > 0)
            {
                foreach (String hexa in ListaHexadecimal)
                {
                    String Completo=Convertir(hexa);
                    String[] substrings = Completo.Split(',');
                    r.Add(int.Parse(substrings[0]));
                    g.Add(int.Parse(substrings[1]));
                    b.Add(int.Parse(substrings[2]));
                }
                int R_completo = Suma_Valores(r);
                int G_completo = Suma_Valores(g);
                int B_completo = Suma_Valores(b);
                respuesta = R_completo.ToString() + "," + G_completo.ToString() + "," + B_completo.ToString();
            }
            else {
                MessageBox.Show("La formula no esta completa, le faltan tintes");
            }
            return respuesta;
        }
        public int Suma_Valores(List<int> lista) {
            int respuesta = 0;
            foreach (int valor in lista) {
                respuesta = respuesta + valor;
            }
            respuesta = respuesta / lista.Count();
            return respuesta;
        }
        public String Convertir(String hexa) {
            String respuesta="";
            try {
                if (hexa.IndexOf("#") != -1)
                    hexa = hexa.Replace("#", "");

                int R = int.Parse(hexa.Substring(0,2),System.Globalization.NumberStyles.HexNumber);
                int G = int.Parse(hexa.Substring(2,2), System.Globalization.NumberStyles.HexNumber);
                int B = int.Parse(hexa.Substring(4,2), System.Globalization.NumberStyles.HexNumber);
                respuesta = R.ToString() + "," + G.ToString() + "," + B.ToString();
            }
            catch (Exception e) {
                MessageBox.Show("Convertir "+e.ToString());
            }
            return respuesta;
        }
    }
}
