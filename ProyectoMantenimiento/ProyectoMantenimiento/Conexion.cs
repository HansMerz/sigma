using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoMantenimiento
{
    public static class Conexion
    {   
        //Se abre la conexión a la base de datos
        static MySqlConnection Conectar()
        {
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
            MySqlConnection connect;
            builder.Server = "172.16.5.8";
            builder.UserID = "admin";
            builder.Password = "";
            builder.Database = "bd_sigma";
            builder.MaximumPoolSize = 10000;
            builder.SslMode = MySqlSslMode.None;
            builder.AllowZeroDateTime = true;
            builder.ConvertZeroDateTime = true;

            connect = new MySqlConnection(builder.ToString());
            connect.Open();                        
            
            return connect;
        }
        //Este método sirve para ejecutar sentencias como INSERT, UPDATE, DELETE
        public static int SQL(String sql)
        {
            MySqlCommand command = new MySqlCommand(sql, Conectar());
            Conectar().Close();
            return command.ExecuteNonQuery();
        }
        // Este método ejecuta las consultas a la base de datos pero devolviendolo en un DataTable
        public static DataTable Data(String sql)
        {
            MySqlDataAdapter oAdap = new MySqlDataAdapter(sql, Conectar());
            DataTable result = new DataTable();
            oAdap.Fill(result);
            Conectar().Close();
            return result;
        }
        // Este método ejecuta consultas a la base de datos también
        public static MySqlDataReader Data2(String sql)
        {
            MySqlCommand command = new MySqlCommand(sql, Conectar());
            MySqlDataReader reader = command.ExecuteReader();
            Conectar().Close();
            return reader;
        }        
    }
}
