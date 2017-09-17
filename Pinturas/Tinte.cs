using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Pinturas
{
    public class Tinte
    {

        public bool validar_campos(string codigo, string nombre, string mono_capa, string rgb, string precio)
        {
            if (codigo == "" || nombre == "" || mono_capa == "" || rgb == "" || precio == "")
            {
                MessageBox.Show("Faltan campos obligatorios");
                return false;
            }
            else {
                registrar_Tinte(codigo, nombre, mono_capa, rgb, precio);
                return true;
                }


           
            
        }

        public bool registrar_Tinte(string codigo, string nombre, string mono_capa, string rgb, string Precio)
        {
            bool respuesta = false;
            Conexion nueva = new Conexion();
            try
            {
                if (codigo.Trim() != "" && nombre.Trim() != "")
                {
                    nueva.EjecutarQuery("INSERT INTO TINTE(Codigo_Tinte,Nombre,MonoCapa,RGB,Precio)" +
                                     " values('" + codigo + "','" + nombre + "','" + mono_capa + "','" + rgb + "','" + Precio + "')");
                   
                    MessageBox.Show("Tinte Registrado");
                    respuesta = true;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo realizar la insercion " + ex.ToString());
                respuesta = false;

            }
            return respuesta;
        }



    }
}
