using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;



namespace Winerpest.Conexiones
{
    class Conexion
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

        /*public Conexion()
        {
            try
            {
                cn = new SqlConnection("server = 127.0.0.1; user id = root; database = winnerpet");
                cn.Open();
            }catch(Exception ex)
            {
                MessageBox.Show("No se conecto con la base de datos: " + ex.ToString());
            }
        }*/

        public string insertarCliente(int id, string nombre_Cliente, string telefono_Cliente)
        {

            string salida = "Se inserto";
            string query = "INSERT INTO CLIENTE(cve_cliente,nombre_cliente,telefono_cliente)VALUES(" + id + ",'" + nombre_Cliente + "','" + telefono_Cliente + "');";
            MySqlCommand sentencia = new MySqlCommand(string.Format(query), Conexion.obtenerConexion());
            MySqlDataReader lector = sentencia.ExecuteReader();

            if (lector.RecordsAffected > 0)
            {
                salida = "OK";
            }
            else
            {
                salida = "No se registro usuario";
            }

            return salida;
        }

        public int personaRegistrada(int id)
        {
            int contador = 0;
            try
            {
                cmd = new SqlCommand("Select * from cliente where cve_cliente=" + id + "", cn);
                dR = cmd.ExecuteReader();
                while(dR.Read())
                {
                    contador++;
                }
                dR.Close();
            }catch(Exception ex)
            {
                MessageBox.Show("No se pudo consultar bien: " + ex.ToString());
            }
            return contador;
        }
    }
}
