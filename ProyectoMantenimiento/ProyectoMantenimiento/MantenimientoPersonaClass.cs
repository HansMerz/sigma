using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoMantenimiento
{
    class MantenimientoPersonaClass
    {
        //Se declaran dos variables de tipo String
        public String mantenimiento_id {get;set;}
        public String persona_id { get; set; }

        public void insertar()
        {
            //Este método inserta las personas encargadas del mantenimiento
            String sql = String.Format("INSERT INTO mantenimiento_has_persona VALUES(null, {0}, {1})", mantenimiento_id, persona_id);
            Conexion.SQL(sql);
        }
        public void actualizar(String id)
        {
            //Este método actualiza las personas encargadas del mantenimiento
            String sql = String.Format("UPDATE mantenimiento_has_persona SET mantenimiento_id = '{0}', persona_id = '{1}' WHERE id = '{2}'", mantenimiento_id, persona_id, id);
            Conexion.SQL(sql);
        }
        public void eliminar(String id)
        {
            //Este método elimina las personas encargadas del mantenimiento
            String sql = String.Format("DELETE FROM mantenimiento_has_persona WHERE id = {0}", id);
            Conexion.SQL(sql);
        }
        public void asignarValores(String mantenimiento_id, String persona_id)
        {
            //Este método asigna valores a las variables pasados por parámetro
            this.mantenimiento_id = mantenimiento_id;
            this.persona_id = persona_id;
        }
        public DataTable consultarEncargados(String id)
        {
            //Se consulta las personas encargadas de cierto mantenimiento
            String sql = String.Format("SELECT * FROM consultarencargadosmantenimientos WHERE mantenimiento_id = {0}", id);
            DataTable tb = Conexion.Data(sql);
            return tb;
        }
        public MySqlDataReader consultarEncargadosReader(String id)
        {
            //Se consulta las personas encargadas de cierto mantenimiento
            String sql = String.Format("SELECT * FROM consultarencargadosmantenimientos WHERE mantenimiento_id = {0}", id);
            MySqlDataReader tb = Conexion.Data2(sql);
            return tb;
        }
        public MySqlDataReader consultarEncargadosCantidad(String id)
        {
            //Se consulta las personas encargadas de cierto mantenimiento
            String sql = String.Format("SELECT COUNT(*) FROM consultarencargadosmantenimientos WHERE mantenimiento_id = {0}", id);
            MySqlDataReader read = Conexion.Data2(sql);
            return read;
        }
    }
}
