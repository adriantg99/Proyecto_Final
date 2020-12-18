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


namespace Winerpest.Conexiones.ConexionesGps
{
    class ConexionesGps
    {
        SqlConnection cn;
        SqlCommand cmd;
        SqlDataReader dr;

        public ConexionesGps()
        {
            try
            {
                cn = new SqlConnection("server=127.0.0.1;user id=root;database=winnerpet");
                cn.Open();
            }
            catch(Exception ex)
            {
                MessageBox.Show("No se pudo conectar con la base de datos: "+ex.ToString());
            }
        }

        public string insertar(Int64 imei, string latitud, string longitud)
        {

            /*string salida = "Se inserto";
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

            return salida;*/
            string salida = "Se inserto correctamente los datos";

            string query = "INSERT INTO GPS(imei, latitud, longitud) values('" + imei + "', '" + latitud + "', '" + longitud + "');";
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

        public int GPSRegistrado(Int64 imei)
        {
            int contador = 0;
            try
            {
                cmd = new SqlCommand("Select * from GPS where imei='" + imei+"'", cn);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    contador++;
                }
                dr.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("No se pudo consultar correctamente: " + ex.ToString());
            }
            return contador;
        }

        public string EliminarGPS(Int64 imei)
        {
            string salida = "Se elimino el registro por id";
            try
            {
                cmd = new SqlCommand("delete from GPS where imei='" + imei + "'", cn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                salida = "No se elimino el registro: " + ex.ToString();

            }

            return salida;
        }

        public string ActualizarGPS(Int64 imei, string latitud, string longitud)
        {
            string salida = "Se actualizo el registro";
            try
            {
                cmd = new SqlCommand("update GPS SET latitud='"+latitud+"', longitud='"+longitud+"'"+"where imei='"+imei+"'",cn);
                ///("INSERT INTO GPS(imei, latitud, longitud) values('" + imei + "','" + latitud + "', '" + longitud+"')", cn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                salida = "No se Modifico el registro: " + ex.ToString();

            }

            return salida;
        }
    }
}
