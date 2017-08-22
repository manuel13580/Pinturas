﻿using System;
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
            menuStrip1.Enabled = false;
            menuStrip1.Visible = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button3.Visible = false;
            button4.Visible = false;
            button5.Visible = false;
            Conexion nueva = new Conexion();
            SqlDataReader autos = nueva.Consulta("select * from Automovil;");
            while (autos.Read())
            {
                comboTipoAuto.Items.Add(autos[1].ToString());
                ListaCodigosAuto.Add(Int32.Parse(autos[0].ToString()));
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

            Actualizar();
        }
        void Actualizar()
        {
            combomedidas.Items.Clear();
            combo_formula.Items.Clear();
            Listamedidas.Clear();
            Conexion nueva = new Conexion();
            SqlDataReader medidas = nueva.Consulta("select * from Medida;");
            while (medidas.Read())
            {
                combomedidas.Items.Add(medidas[0].ToString());
                Listamedidas.Add(Convert.ToDouble(medidas[1].ToString()));
                combo_formula.Items.Add(medidas[0].ToString());
            }
            combo_formula.Text = this.Tamaño;
            combomedidas.Text = this.Tamaño;
            nueva.LlenarGridFormula("select a.Codigo_tinte as \"Codigo\", t.Nombre as \"Nombre\", a.Cantidad as \"Cantidad (g)\"  from Asignacion a, Tinte t where a.Codigo_tinte=t.Codigo_tinte and a.Id_presentacion=" + valor + ";", dataGridView1, "Asignacion", 1);
            actualizarTotal();
        }
        void actualizarTotal()
        {
            double total = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
                total = total + Convert.ToDouble(dataGridView1.Rows[i].Cells[2].Value.ToString());
            lbltotal.Text = "Total de la Formula: " + total + " (g).";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            NuevoRegistro();
        }
        void NuevoRegistro()
        {
            Registro nuevo = new Registro();
            nuevo.codigoP = valor;
            nuevo.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                int pos = dataGridView1.CurrentRow.Index;
                Actualizar();
                dataGridView1.Rows[pos].Selected = true;
                ModificarRegistro(pos);
            }
            catch (Exception ex)
            { }
        }
        void ModificarRegistro(int pos)
        {
            try
            {
                string Nuevo = "";
                Nuevo = Microsoft.VisualBasic.Interaction.InputBox("La cantidad actual es de " + dataGridView1.Rows[pos].Cells[2].Value.ToString() + " (g) para una formula de " + combo_formula.Text + ", Ingrese la nueva cantidad (g)", "Nueva Cantidad", dataGridView1.Rows[pos].Cells[2].Value.ToString());
                double NuevaCant = 0;
                if (!Nuevo.Trim().Equals(""))
                {
                    try
                    {
                        NuevaCant = Convert.ToDouble(Nuevo);

                        try
                        {
                            Conexion nueva = new Conexion();
                            if (Nuevo.Trim() != "")
                                nueva.EjecutarQuery("update Asignacion set Cantidad=" + NuevaCant + " where Id_presentacion=" + valor + " and Codigo_tinte='" + dataGridView1.Rows[pos].Cells[0].Value.ToString() + "' and Cantidad=" + dataGridView1.Rows[pos].Cells[2].Value.ToString() + ";");
                            Actualizar();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error, Cantidad invalida");
                    }
                }

            }
            catch (Exception q)
            { }


        }
    }
}

namespace Microsoft.VisualBasic
{
    class Interaction
    {
        internal static string InputBox(string v1, string v2, string v3)
        {
            throw new NotImplementedException();
        }
    }
}