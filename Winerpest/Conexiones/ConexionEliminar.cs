using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Winerpest.Conexiones
{
    class ConexionEliminar
    {
        SqlConnection cn;
        SqlCommand cmd;
        SqlDataReader dR;


        public static MySqlConnection obtenerConexion()
        {
            MySqlConnection conexion = new MySqlConnection("server = 127.0.0.1; user id = root; password=1234; persistsecurityinfo=True; database = winnerpet");
            conexion.Open();
            return conexion;
        }




        public string EliminarClienteId(int id)
        {

            /*
            string salida = "Se inserto";
            string query = "Delete from INTO CLIENTE(cve_cliente,nombre_cliente,telefono_cliente)VALUES(" + id + ",'" + nombre_Cliente + "','" + telefono_Cliente + "');";
            MySqlCommand sentencia = new MySqlCommand(string.Format(query), Conexion.obtenerConexion());
             
             
             */
            string salida = "Se elimino el registro por id";
            try
            {
                string query = "delete from Cliente where cve_cliente='" + id + "';";
                MySqlCommand sentencia = new MySqlCommand(string.Format(query), obtenerConexion());
                MySqlDataReader lector = sentencia.ExecuteReader();

                if (lector.RecordsAffected > 0)
                {
                    salida = "OK";
                }
                else
                {
                    salida = "No se elimino usuario";
                }

                return salida;
            }
            catch (Exception ex)
            {
                salida = "No se elimino el registro: " + ex.ToString();

            }

            return salida;
        }

        public string EliminarClienteNombre(string Nombre)
        {
            string salida = "Se elimino el registro por Nombre";
            try
            {
                string query = "delete from Cliente where nombre_cliente='" + Nombre + "';";
                MySqlCommand sentencia = new MySqlCommand(string.Format(query), obtenerConexion());
                MySqlDataReader lector = sentencia.ExecuteReader();

                if (lector.RecordsAffected > 0)
                {
                    salida = "OK";
                }
                else
                {
                    salida = "No se elimino usuario";
                }

                return salida;
            }
            catch (Exception ex)
            {
                salida = "No se elimino el registro: " + ex.ToString();

            }

            return salida;

        }

        public string EliminarClienteTelefono(string Telefono)
        {
            string salida = "Se elimino el registro por Nombre";
            try
            {
                string query = "delete from Cliente where telefono_cliente='" + Telefono + "';";
                MySqlCommand sentencia = new MySqlCommand(string.Format(query), obtenerConexion());
                MySqlDataReader lector = sentencia.ExecuteReader();

                if (lector.RecordsAffected > 0)
                {
                    salida = "OK";
                }
                else
                {
                    salida = "No se elimino usuario";
                }

                return salida;
            }
            catch (Exception ex)
            {
                salida = "No se elimino el registro: " + ex.ToString();

            }

            return salida;


           
        }

        /*
        public int personaRegistradaByID(int id)
        {
            int contador = 0;
            try
            {
                cmd = new SqlCommand("Select * from cliente where cve_cliente=" + id + "", cn);
                dR = cmd.ExecuteReader();
                while (dR.Read())
                {
                    contador++;
                }
                dR.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo consultar bien: " + ex.ToString());
            }
            return contador;
        }

        public int personaRegistradaByName(string name)
        {
            int contador = 0;
            try
            {
                cmd = new SqlCommand("Select * from cliente where nombre_cliente='" + name + "'", cn);
                dR = cmd.ExecuteReader();
                while (dR.Read())
                {
                    contador++;
                }
                dR.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo consultar bien: " + ex.ToString());
            }
            return contador;
        }

        public int personaRegistradaByphone(string Telefono)
        {
            int contador = 0;
            try
            {
                cmd = new SqlCommand("Select * from cliente where telefono_cliente='" + Telefono + "'", cn);
                dR = cmd.ExecuteReader();
                while (dR.Read())
                {
                    contador++;
                }
                dR.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo consultar bien: " + ex.ToString());
            }
            return contador;
        }
        */



    }
}
