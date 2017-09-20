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


        //Validaciones/s
        public bool m_validar_campos(string v_codigo, string v_nombre, string v_mono_capa, string v_rgb, string v_precio)
        {
            if (v_codigo == "" || v_nombre == "" || v_mono_capa == "" || v_rgb == "" || v_precio == "")
            {
                MessageBox.Show("Faltan campos obligatorios");
                return false;
            }
            else {
                m_registrar_Tinte(v_codigo, v_nombre, v_mono_capa, v_rgb, v_precio);
                return true;
                }


           
            
        }

        public bool m_registrar_Tinte(string v_codigo, string v_nombre, string v_mono_capa, string v_rgb, string v_Precio)
        {
            bool r_respuesta = false;
            Conexion nueva = new Conexion();
            try
            {
                if (v_codigo.Trim() != "" && v_nombre.Trim() != "")
                {
                    nueva.EjecutarQuery("INSERT INTO TINTE(Codigo_Tinte,Nombre,MonoCapa,RGB,Precio)" +
                                     " values('" + v_codigo + "','" + v_nombre + "','" + v_mono_capa + "','" + v_rgb + "','" + v_Precio + "')");
                   
                    MessageBox.Show("Tinte Registrado");
                    r_respuesta = true;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo realizar la insercion " + ex.ToString());
                r_respuesta = false;

            }
            return r_respuesta;
        }



    }
}
