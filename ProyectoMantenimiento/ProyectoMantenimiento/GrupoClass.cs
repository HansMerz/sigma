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
    class GrupoClass
    {
        public String nombre { get; set; }

        public void agarrarDatos(String nombre)
        {
            this.nombre = nombre;            
        }

        public void insertar()
        {
            String sql = String.Format("INSERT INTO grupo VALUES(null, '{0}')", nombre);
            try
            {            
                int result = Conexion.SQL(sql);
                if (result > 0)
                {
                    MessageBox.Show("El grupo fue creado correctamente", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);               
                }
                else
                {
                    MessageBox.Show("No se pudo crear el grupo", "Incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrió un error al crear el grupo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);                
            }
        }
        public void insertarCaracteristica(String carac, String tipo)
        {
            String sql = String.Format("INSERT INTO caracteristica VALUES(null, '{0}', '{1}')", carac, tipo);
            try
            {
                int result = Conexion.SQL(sql);
                if (result > 0)
                {
                    MessageBox.Show("La característica fue creada correctamente", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se pudo crear la característica", "Incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrió un error al agregar la característica", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public void actualizar(String id)
        {
            String sql = String.Format("UPDATE grupo SET nombre = '{0}' WHERE id = '{1}'", nombre, id);            

            try
            {
                int result = Conexion.SQL(sql);
                if (result > 0)
                {
                    MessageBox.Show("El grupo fue actualizado correctamente", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se pudo actualizar el grupo", "Incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrió un error al actualizar el grupo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void eliminar(String id)
        {
            String sql = String.Format("DELETE FROM grupo WHERE id = '{0}'", id);
            try
            {            
                int result = Conexion.SQL(sql);
                if (result > 0)
                {
                    MessageBox.Show("El grupo fue eliminado correctamente", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se pudo eliminar el grupo", "Incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrió un error al eliminar el grupo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public DataTable cargarTabla(String val)
        {
            String sql = String.Format("SELECT * FROM grupo WHERE CONCAT(id, ' ', nombre) LIKE '%"+val+"%'");
            DataTable tb = Conexion.Data(sql);
            return tb;
        }
        public MySqlDataReader cargarTablaFrec(String val)
        {
            String sql = String.Format("SELECT * FROM grupo WHERE CONCAT(id, ' ', nombre) LIKE '%" + val + "%'");
            MySqlDataReader tb = Conexion.Data2(sql);
            return tb;
        }
        public DataTable cargarTablaEquipo(String val, String id)
        {
            String sql = String.Format("SELECT m.id as Codigo, numero_orden as Num_Orden, e.codigo as Codigo_Equipo, e.nombre as Equipo, g.nombre as Grupo, " +
                "a.localizacion as Localizacion, e.frecuencia as Frecuencia, DATE_FORMAT(fecha_prevista,'%Y-%m-%d') as Fecha_Prevista, solicita as Solicita, fecha_solicitada as Fecha_Solicitud, " +
                "TIMESTAMPDIFF(DAY, CURDATE(), fecha_prevista) as Dias_Faltantes FROM mantenimiento m INNER JOIN equipo e ON m.equipo_codigo = e.codigo " +
                "INNER JOIN area a ON e.area_id = a.id INNER JOIN grupo g ON e.grupo_id = g.id " +
                "WHERE CONCAT(m.id, ' ', numero_orden, ' ', e.nombre, ' ', Fecha_Prevista, ' ', a.localizacion, ' ', e.codigo) LIKE '%"+val+"%' AND " +
                "tipo_mantenimiento = 'Preventivo' AND observacion is NULL AND g.id = '{0}' AND TIMESTAMPDIFF(DAY, CURDATE(), fecha_prevista) >= 0 ORDER BY Fecha_Prevista", id);
            DataTable tb = Conexion.Data(sql);
            return tb;
        }
        public MySqlDataReader cargarTablaCarac(String val)
        {
            String sql = String.Format("SELECT * FROM caracteristica WHERE CONCAT(id, ' ', descripcion, ' ', tipo) LIKE '%"+val+"%' ORDER BY id DESC");
            MySqlDataReader tb = Conexion.Data2(sql);
            return tb;
        }
        public MySqlDataReader cargarTablaGruCar(String val, String id)
        {
            String sql = String.Format("SELECT c.* FROM caracteristica c INNER JOIN carac_grupo cg ON c.id = cg.carac_id WHERE cg.grupo_id = {0} AND CONCAT(id, ' ', descripcion, ' ', tipo) LIKE '%" + val + "%' ORDER BY c.id", id);
            MySqlDataReader tb = Conexion.Data2(sql);
            return tb;
        }
        public String consultarCaracExist(String idGrupo, String idCarac)
        {
            try
            {
                String sql = String.Format("SELECT * FROM carac_grupo WHERE grupo_id = {0} AND carac_id = {1}", idGrupo, idCarac);
                DataRow tb = Conexion.Data(sql).Rows[0];
                return tb["carac_id"].ToString();
            }
            catch (Exception)
            {
                return "nada";
            }
        }
        public int insertarCaracGrupo(String idGrupo, String idCarac)
        {
            String sql = String.Format("INSERT INTO carac_grupo VALUES ({0}, {1}) ", idGrupo, idCarac);
            int result;            
            result = Conexion.SQL(sql);                            
            return result;
        }
        public void eliminarCaracteristica(String idGrupo, String idCarac)
        {
            String sql = String.Format("DELETE FROM carac_grupo WHERE grupo_id = {0} AND carac_id = {1}", idGrupo, idCarac);
            Conexion.SQL(sql);            
        }
    }    
}
