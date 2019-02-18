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
    class HerramientaClass
    {
        //Se declaran tres variables una de tipo Int64 y dos de tipo String
        public String nombre {get;set;}        
        public String pos { get; set; }
        public String codigo { get; set; }
        public Int64 minimo { get; set; }

        public String InsertarHerramienta()
        {
            //Este método se encarga de insertar la herramienta en la base de datos
            String sql = String.Format("INSERT INTO herramientas VALUES(null, '{0}', '{1}', {2})", nombre, 
                 pos, minimo);
            int result = Conexion.SQL(sql);
            if (result == 1)
            {
                MessageBox.Show("Herramienta Insertada", "Registro Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return TraerUltimo();
            }
            else
            {
                MessageBox.Show("Error al registrar los datos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return "";
            }
        }
        public void ActualizarHerramienta(String id)
        {
            //Este método se encarga de actualizar la herramienta
            String sql = String.Format("UPDATE herramientas SET nombre = '{0}', pos = '{1}', minimo = {2} WHERE id = {3}", nombre,
                 pos, minimo, id);
            int result = Conexion.SQL(sql);
            if (result == 1)
            {
                MessageBox.Show("Herramienta Actualizada", "Actualización Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);                
            }
            else
            {
                MessageBox.Show("Error al actualizar los datos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);                
            }
        }
        public void EliminarHerramienta(String id)
        {
            //Este método elimina la herramienta de la base de datos
            String sql = String.Format("DELETE FROM herramientas WHERE id = {0}", id);
            int result = Conexion.SQL(sql);
            if (result == 1)
            {
                MessageBox.Show("Herramienta Eliminada", "Eliminación Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Error al eliminar la herramienta", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void AsignarDatos(String nombre, String pos, int minimo)
        {                   
            //Este método se encarga de darle valor a las variables dependiendo de los datos que le pasemos por parámetro
            this.nombre = nombre;            
            this.pos = pos;           
            this.minimo = minimo;           
        }
        public String TraerUltimo()
        {
            //Este método nos trae el id del último registro insertado en las herramientas
            String sql = "SELECT MAX(id) ide FROM herramientas";
            DataRow row = Conexion.Data(sql).Rows[0];            
            return row["ide"].ToString();
        }
        public void CargarTabla(DataGridView dg, String val)
        {
            dg.Rows.Clear();
            //Este método se encarga de cargar la tabla pasada por parámetro
            String sql = "SELECT h.* FROM herramientas h INNER JOIN inventario i ON h.id = i.herramientas_id " +
                "WHERE CONCAT(h.nombre, ' ', h.id) LIKE '%"+val+"%' GROUP BY h.id ORDER BY h.id DESC";
            MySqlDataReader reader = Conexion.Data2(sql);            
            while (reader.Read())
            {
               dg.Rows.Add(reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3));
            }           
        }
       public void CargarCantidad(DataGridView dg)
        {
            //Este método llama al procedimiento que carga la candidad de herramienta que hay en el inventario
            int j = 0;
            for (int i = 0; i < dg.Rows.Count; i++)
            {                
                String sql = String.Format("CALL InventarioHe({0})", dg[0,i].Value.ToString());
                MySqlDataReader read = Conexion.Data2(sql);          
                while (read.Read())
                {                    
                    dg[4, j].Value = read.GetString(0);
                    j++;
                }
            }            
        }
        public DataTable Consultar(String id)
        {
            //Este método consulta la herramienta seleccionada
            String sql = String.Format("SELECT h.*, i.cantidad, i.descripcion FROM herramientas h INNER JOIN inventario i ON h.id = i.herramientas_id " +
                "WHERE h.id = {0}", id);
            DataTable tabla = Conexion.Data(sql);
            return tabla;
        }
        public DataTable ConsultarInventario(String id)
        {
            //Este método consulta a la tabla inventarios dependiendo de la herramienta seleccionada
            String sql = String.Format("SELECT i.descripcion, i.cantidad, i.fecha FROM herramientas h INNER JOIN inventario i ON h.id = i.herramientas_id " +
                "WHERE h.id = {0}", id);
            DataTable tabla = Conexion.Data(sql);
            return tabla;
        }
        public DataTable ConsultarTodo(String val)
        {
            //Este método consulta todos los campos de la tabla herramientas
            String sql = "SELECT * FROM herramientas h WHERE CONCAT(h.nombre, ' ', h.id) LIKE '%" + val + "%'";
            DataTable tabla = Conexion.Data(sql);
            return tabla;
        }
        public DataTable TraerMinimo(String id)
        {
            //Se trae la cantidad mínima que puede haber en las herramientas, dependiendo de la herramienta seleccionada
            String sql = String.Format("SELECT minimo FROM herramientas WHERE id = {0}", id);
            DataTable tb = Conexion.Data(sql);
            return tb;
        }
    }
}
