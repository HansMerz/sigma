using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoMantenimiento
{
    class ConexionSQL
    {
        
        static SqlConnection Conectar()
        {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            SqlConnection connect;
            builder.DataSource = "PRACTICANTETI";
            builder.IntegratedSecurity = true;
            builder.InitialCatalog = "bd_sigma";
            builder.MaxPoolSize = 1000;            
            connect = new SqlConnection(builder.ToString());
            connect.Open();

            return connect;
        }
        //Este método sirve para ejecutar sentencias como INSERT, UPDATE, DELETE
        public static int SQL(String sql)
        {
            SqlCommand command = new SqlCommand(sql, Conectar());
            return command.ExecuteNonQuery();
        }
        // Este método ejecuta las consultas a la base de datos pero devolviendolo en un DataTable
        public static DataTable Data(String sql)
        {
            SqlDataAdapter oAdap = new SqlDataAdapter(sql, Conectar());
            DataTable result = new DataTable();
            oAdap.Fill(result);
            return result;
        }
        // Este método ejecuta consultas a la base de datos también
        public static SqlDataReader Data2(String sql)
        {
            SqlCommand command = new SqlCommand(sql, Conectar());
            SqlDataReader reader = command.ExecuteReader();
            return reader;
        }
    }
}
