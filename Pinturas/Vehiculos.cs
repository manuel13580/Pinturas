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
        public bool validar_campos(string marca, string modelo, string tipo)
        {
            if (marca == "" || modelo == "" || tipo == "" )
            {
                MessageBox.Show("Faltan campos obligatorios");
                return false;
            }
            else
            {
                registrar_Vehiculo(marca,modelo,tipo);
                
                return true;
            }

        }

        public bool registrar_Vehiculo(string marca, string modelo, string tipo)
        {
            bool respuesta = false;
            Conexion nueva = new Conexion();
            try
            {
                if (marca.Trim() != "" && modelo.Trim() != "" && tipo.Trim() != "")
                {
                    nueva.EjecutarQuery("INSERT INTO Automovil(Marca,Modelo,Tipo)" +
                                     " values('" + marca + "','" + modelo + "','" + tipo +  "')");

                    MessageBox.Show("Vehiculo Registrado");
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
