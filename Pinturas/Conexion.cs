﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
namespace Pinturas
{
    public class Conexion
    {
        public bool conectar()
        {
            SqlConnection conex;
            SqlCommand comm;
            SqlDataReader rs;
            conex = new SqlConnection();
            comm = new SqlCommand();
            conex.ConnectionString = "Data Source=.;Initial Catalog=BDLineaPinturas;Integrated Security=True;MultipleActiveResultSets=true;";

            //conex.ConnectionString = "Data Source=FABIOLA-PC" + "\\" + "SQLEXPRESS;Initial Catalog=BDLineaPinturas;Integrated Security=True";
            comm.Connection = conex;
            string sql = "select Id_auto as Codigo, Marca as Marca from Automovil;";
            comm.CommandText = sql;
            conex.Open();
            comm.ExecuteNonQuery();
            conex.Close();

            comm.CommandText = "select Id_auto as 'Codigo', Marca as 'Marca' from Automovil;";

            conex.Open();
            rs = comm.ExecuteReader();
            if (rs.Read())
            {
                //ComboAutos.Text = rs[1].ToString();
            }

            SqlDataAdapter data = new SqlDataAdapter(sql, conex);
            DataSet ds = new DataSet();

            //data.Fill(ds, "Automovil");
            conex.Close();
            //dataGridView1.DataSource = ds;
            //dataGridView1.DataMember = "Automovil";
            return true;
        }


        public SqlDataReader Consulta(string consulta)
        {
            SqlConnection conex = new SqlConnection();
            SqlCommand comm = new SqlCommand();
            SqlDataReader rs;
            conex.ConnectionString = "Data Source=.;Initial Catalog=BDLineaPinturas;Integrated Security=True;MultipleActiveResultSets=true;";
            //conex.ConnectionString = "Data Source=FABIOLA-PC" + "\\" + "SQLEXPRESS;Initial Catalog=BDLineaPinturas;Integrated Security=True";
            comm.Connection = conex;
            comm.CommandText = consulta;
            conex.Open();
            rs = comm.ExecuteReader();
            // conex.Close();
            return rs;
        }



        public bool EjecutarQuery(string consulta)
        {
            SqlConnection conex = new SqlConnection();
            SqlCommand comm = new SqlCommand();
            conex.ConnectionString = "Data Source=.;Initial Catalog=BDLineaPinturas;Integrated Security=True;MultipleActiveResultSets=true;";
            //conex.ConnectionString = "Data Source=FABIOLA-PC" + "\\" + "SQLEXPRESS;Initial Catalog=BDLineaPinturas;Integrated Security=True";
            comm.Connection = conex;
            comm.CommandText = consulta;
            conex.Open();
            comm.ExecuteNonQuery();
            conex.Close();
            return true;
        }



        public bool LlenarGrid(string consulta, DataGridView grid, string tabla)
        {
            try
            {
                SqlConnection conex = new SqlConnection();
                conex.ConnectionString = "Data Source=.;Initial Catalog=BDLineaPinturas;Integrated Security=True;MultipleActiveResultSets=true;";
                //conex.ConnectionString = "Data Source=FABIOLA-PC" + "\\" + "SQLEXPRESS;Initial Catalog=BDLineaPinturas;Integrated Security=True";
                conex.Open();
                SqlDataAdapter data = new SqlDataAdapter(consulta, conex);
                DataSet ds = new DataSet();
                data.Fill(ds, tabla);
                conex.Close();
                ds.AcceptChanges();
                grid.DataSource = ds;
                grid.DataMember = tabla;
                grid.Refresh();
                conex.Close();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo" + ex.Message);
                return false;
            }

        }


        public bool LlenarGridFormula(string consulta, DataGridView grid, string tabla, double val)
        {
            try
            {
                SqlConnection conex = new SqlConnection();
                conex.ConnectionString = "Data Source=.;Initial Catalog=BDLineaPinturas;Integrated Security=True;MultipleActiveResultSets=true;";
                //conex.ConnectionString = "Data Source=FABIOLA-PC" + "\\" + "SQLEXPRESS;Initial Catalog=BDLineaPinturas;Integrated Security=True";
                conex.Open();
                SqlDataAdapter data = new SqlDataAdapter(consulta, conex);
                DataSet ds = new DataSet();
                data.Fill(ds, tabla);
                conex.Close();
                ds.AcceptChanges();
                ds.Tables[0].Columns.Add("Acumulativo");
                grid.DataSource = ds;
                grid.DataMember = tabla;
                grid.Refresh();
                conex.Close();
                llenarCantidades(grid, val);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo" + ex.Message);
                return false;
            }
        }

        public bool llenarCantidades(DataGridView grid, double val)
        {
            try
            {
                //procedimiento para llenar las cantidades
                for (int i = 0; i < grid.Rows.Count; i++)
                {
                    double res = Convert.ToDouble(grid.Rows[i].Cells[2].Value) * val;
                    grid.Rows[i].Cells[2].Value = res;
                }

                double acumulativo = 0;
                for (int a = 0; a < grid.Rows.Count; a++)
                {
                    acumulativo += Convert.ToDouble(grid.Rows[a].Cells[2].Value);
                    grid.Rows[a].Cells[3].Value = acumulativo.ToString();
                }

                return true;
            }
            catch (Exception ex)
            {

                return false;
            }

        }


        public bool llenarGridViewVehiculos(DataGridView grid) {

            try
            {
                SqlConnection conex = new SqlConnection();
                conex.ConnectionString = "Data Source=.;Initial Catalog=BDLineaPinturas;Integrated Security=True;MultipleActiveResultSets=true;";
                //conex.ConnectionString = "Data Source=FABIOLA-PC" + "\\" + "SQLEXPRESS;Initial Catalog=BDLineaPinturas;Integrated Security=True";
                conex.Open();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter("Select * from Automovil", conex);
                da.Fill(dt);
                grid.DataSource = dt;
                return true;
            }

            catch (Exception ex)
            {
                MessageBox.Show("No se pudo llenar la informacion de vehiculos " + ex.Message);
                return false;
            }
            
        }

        public bool llenarGridViewTintes(DataGridView grid)
        {

            try
            {
                SqlConnection conex = new SqlConnection();
                conex.ConnectionString = "Data Source=.;Initial Catalog=BDLineaPinturas;Integrated Security=True;MultipleActiveResultSets=true;";
                //conex.ConnectionString = "Data Source=FABIOLA-PC" + "\\" + "SQLEXPRESS;Initial Catalog=BDLineaPinturas;Integrated Security=True";
                conex.Open();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter("Select * from Tinte", conex);
                da.Fill(dt);
                grid.DataSource = dt;
                return true;
            }

            catch (Exception ex)
            {
                MessageBox.Show("No se pudo llenar la informacion de Tintes " + ex.Message);
                return false;
            }

        }


    }
}
