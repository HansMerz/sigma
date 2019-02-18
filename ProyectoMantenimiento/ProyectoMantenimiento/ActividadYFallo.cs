using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoMantenimiento
{
    class ActividadYFallo
    {
        public String cod { get; set; }
        public String desc { get; set; }
        public String tipo { get; set; }
        public String mantenimiento_id { get; set; }
        
        public void agarraFallo(String cod, String desc, String tipo)
        {
            this.cod = cod;
            this.desc = desc;
            this.tipo = tipo;            
        }
        public void agarraActividad(String cod, String desc)
        {
            this.cod = cod;
            this.desc = desc;            
        }
        public DataTable cargarTablaActividad(String val)
        {
            String sql = String.Format("SELECT * FROM actividad WHERE CONCAT(cod, ' ', descripcion) LIKE '%{0}%'", val);
            DataTable tb = Conexion.Data(sql);
            return tb;
        }
        public void agarrarMantenimiento(String cod, String mantenimiento_id)
        {
            this.cod = cod;
            this.mantenimiento_id = mantenimiento_id;            
        }
        public DataTable cargarTablaFallo(String val)
        {
            String sql = String.Format("SELECT * FROM fallo WHERE CONCAT(cod, ' ', descripcion, ' ', tipo) LIKE '%{0}%'", val);
            DataTable tb = Conexion.Data(sql);
            return tb;
        }
        public int insertarFallo()
        {
            String sql = String.Format("INSERT INTO fallo VALUES('{0}', '{1}', '{2}')", cod, desc, tipo);
            int result = Conexion.SQL(sql);
            return result;
        }
        public int actualizarFallo()
        {
            String sql = String.Format("UPDATE fallo SET descripcion = '{0}', tipo = '{1}' WHERE cod = '{2}'", desc, tipo, cod);
            int result = Conexion.SQL(sql);
            return result;
        }
        public int actualizarActividad()
        {
            String sql = String.Format("UPDATE actividad SET descripcion = '{0}' WHERE cod = '{1}'", desc, cod);
            int result = Conexion.SQL(sql);
            return result;
        }
        public void insertarFalloMantenimiento()
        {
            String sql = String.Format("INSERT INTO fallo_mantenimiento VALUES('{0}', '{1}')", cod, mantenimiento_id);
            int result = Conexion.SQL(sql);            
        }
        public int insertarActividad()
        {
            String sql = String.Format("INSERT INTO actividad VALUES('{0}', '{1}')", cod, desc);
            int result = Conexion.SQL(sql);
            return result;            
        }
        public void insertarActividadMantenimiento()
        {
            String sql = String.Format("INSERT INTO actividad_mantenimiento VALUES('{0}', '{1}')", cod, mantenimiento_id);
            int result = Conexion.SQL(sql);            
        }
        public MySqlDataReader consultarFallosMantenimiento(String id)
        {
            String sql = String.Format("SELECT f.cod, f.descripcion FROM fallo f INNER JOIN fallo_mantenimiento fm ON f.cod = fm.fallo_cod WHERE fm.mantenimiento_id = '{0}'", id);
            MySqlDataReader tb = Conexion.Data2(sql);
            return tb;
        }
        public MySqlDataReader consultarActividadesMantenimiento(String id)
        {
            String sql = String.Format("SELECT a.cod, a.descripcion FROM actividad a INNER JOIN actividad_mantenimiento am ON a.cod = am.actividad_cod WHERE am.mantenimiento_id = '{0}'", id);
            MySqlDataReader tb = Conexion.Data2(sql);
            return tb;
        }
        public String conteoFallas(String id)
        {
            String sql = String.Format("SELECT COUNT(*) as Cantidad FROM fallo_mantenimiento WHERE mantenimiento_id = '{0}'", id);
            DataRow row = Conexion.Data(sql).Rows[0];
            return row["Cantidad"].ToString();
        }
        public String conteoActividades(String id)
        {
            String sql = String.Format("SELECT COUNT(*) as Cantidad FROM actividad_mantenimiento WHERE mantenimiento_id = '{0}'", id);
            DataRow row = Conexion.Data(sql).Rows[0];
            return row["Cantidad"].ToString();
        }
    }
}
