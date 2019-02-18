using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoMantenimiento
{
    public class DatosCorrectivoGeneral
    {
        public String cod { get; set; }
        public String desc { get; set; }

        public MySqlDataReader traerPrimeros()
        {
            String sql = "SELECT * FROM fallo WHERE tipo = 'GENERAL' LIMIT 0,10";
            MySqlDataReader read = Conexion.Data2(sql);
            return read;
        }
        public MySqlDataReader traerSegundos()
        {
            String sql = "SELECT * FROM fallo WHERE tipo = 'GENERAL' LIMIT 10,10";
            MySqlDataReader read = Conexion.Data2(sql);
            return read;
        }
        public MySqlDataReader traerTerceros()
        {
            String sql = "SELECT * FROM fallo WHERE tipo = 'GENERAL' LIMIT 20,10";
            MySqlDataReader read = Conexion.Data2(sql);
            return read;
        }
        public MySqlDataReader traerCuartos()
        {
            String sql = "SELECT * FROM fallo WHERE tipo = 'GENERAL' LIMIT 30,10";
            MySqlDataReader read = Conexion.Data2(sql);
            return read;
        }
    }
}
