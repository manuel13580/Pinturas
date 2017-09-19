using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pinturas
{
    public class Vehiculos
    {
        public bool m_validar_campos(string v_marca, string v_modelo, string v_tipo)
        {
            bool r_respuesta = false;
            if (v_marca == "" || v_modelo == "" || v_tipo == "" )
            {
                MessageBox.Show("Faltan campos obligatorios");
                r_respuesta =false;
            }
            else
            {
                m_registrar_Vehiculo(v_marca,v_modelo,v_tipo);
                
                r_respuesta = true;
            }
            return r_respuesta;

        }

        public bool m_registrar_Vehiculo(string v_marca, string v_modelo, string v_tipo)
        {
            bool r_respuesta = false;
            Conexion nueva = new Conexion();
            try
            {
                if (v_marca.Trim() != "" && v_modelo.Trim() != "" && v_tipo.Trim() != "")
                {
                    nueva.EjecutarQuery("INSERT INTO Automovil(Marca,Modelo,Tipo)" +
                                     " values('" + v_marca + "','" + v_modelo + "','" + v_tipo +  "')");

                    MessageBox.Show("Vehiculo Registrado");
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
