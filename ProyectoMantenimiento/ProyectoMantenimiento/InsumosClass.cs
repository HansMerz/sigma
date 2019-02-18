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
    class InsumosClass
    {     
        //Se declaran tres variables de tipo String y una de tipo int
        public String nombre;
        public String marca;
        public int precio;
        public String pos;
        public String refer;

        public String InsertarInsumo()
        {
            //Este método inserta el insumo en la base de datos
            String sql = String.Format("INSERT INTO insumos VALUES(null, '{0}', '{1}', '{2}', '{3}', {4})", refer, nombre,
                 marca, pos, precio);
            int result = Conexion.SQL(sql);
            if (result == 1)
            {
                MessageBox.Show("Insumo Insertado", "Registro Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return TraerUltimo();
            }
            else
            {
                MessageBox.Show("Error al registrar los datos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return "";
            }
        }
        public void InsertarInsumosHasMantenimiento(String insumo, String mantenimiento, String cantidad)
        {
            //Este método inserta el insumo que se utilizó en el mantenimiento en la base de datos
            String sql = String.Format("INSERT INTO insumos_has_mantenimiento VALUES(null, '{0}', '{1}', {2})", insumo,
                 mantenimiento, cantidad);
            Conexion.SQL(sql);            
        }
        public void ActualizarInsumo(String id)
        {
            //Este método actualiza el insumo en la base de datos
            String sql = String.Format("UPDATE insumos SET nombre = '{0}', marca = '{1}', precio = '{2}', pos = '{3}', ref = '{4}' WHERE id = '{5}'", nombre,
                marca, precio, pos, refer, id);
            int result = Conexion.SQL(sql);
            if (result == 1)
            {
                MessageBox.Show("Insumo Actualizado", "Actualización Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Error al actualizar los datos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void EliminarInsumo(String id)
        {
            //Este método elimina el insumo en la base de datos
            String sql = String.Format("DELETE FROM insumos WHERE id = {0}", id);
            int result = Conexion.SQL(sql);
            if (result == 1)
            {
                MessageBox.Show("Insumo Eliminado", "Eliminación Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Error al eliminar la herramienta", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void AsignarDatos(String refer, String nombre, String marca, String pos, int precio)
        {
            //Este método agrega valor a las variables dependiendo a los parámetros que se le pasan
            this.nombre = nombre;
            this.marca = marca;
            this.precio = precio;
            this.pos = pos;
            this.refer = refer;
        }
        public String TraerUltimo()
        {
            //Este método trae el id del último insumo registrado
            String sql = "SELECT MAX(id) ide FROM insumos";
            DataRow row = Conexion.Data(sql).Rows[0];
            return row["ide"].ToString();
        }
        public void CargarTabla(DataGridView dg, String val)
        {
            //Este método carga la tabla que se le pasa por parámetro
            String sql = "SELECT ins.id, ins.ref, ins.nombre, ins.marca, ins.pos, ins.precio FROM insumos ins INNER JOIN inventario i ON ins.id = i.insumos_id " +
                "WHERE CONCAT(ins.nombre, ' ', ins.id, ' ', ins.ref)LIKE '%" + val + "%' GROUP BY ins.id ORDER BY ins.id DESC";
            MySqlDataReader reader = Conexion.Data2(sql);
            while (reader.Read())
            {
                dg.Rows.Add(reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(5));
            }          
        }
        public void CargarCantidad(DataGridView dg)
        {
            //Este método llama al procedimiento que nos trae la cantidad existente del insumo que pasemos por parámetro            
            int j = 0;
            for (int i = 0; i < dg.Rows.Count; i++)
            {
                String sql = String.Format("CALL InventarioIn({0})", dg[0, i].Value.ToString());
                MySqlDataReader read = Conexion.Data2(sql);
                while (read.Read())
                {
                    dg[6, j].Value = read.GetString(0);
                    j++;
                }
            }
        }
        public String cargarCantidadInsumos(String id)
        {
            String sql = String.Format("CALL InventarioIn({0})", id);
            DataRow row = Conexion.Data(sql).Rows[0];
            return row["CantidadStock"].ToString();
        }
        public DataTable ConsultarInventario(String id)
        {
            //Este método consulta en la tabla inventario los insumos que han entrado
            String sql = String.Format("SELECT i.descripcion, i.cantidad, i.fecha FROM insumos ins INNER JOIN inventario i ON ins.id = i.insumos_id " +
                "WHERE ins.id = {0}", id);
            DataTable tabla = Conexion.Data(sql);
            return tabla;
        }
        public DataTable Consultar(String id)
        {
            //Este método nos trae el insumo que esté en inventario
            String sql = String.Format("SELECT ins.*, i.cantidad, i.descripcion FROM insumos ins INNER JOIN inventario i ON ins.id = i.insumos_id " +
                "WHERE ins.id = {0}", id);
            DataTable tabla = Conexion.Data(sql);
            return tabla;
        }
        public DataTable ConsultarTodo(String val)
        {
            //Este método trae todos los campos de la tabla Insumos
            String sql = "SELECT * FROM insumos WHERE CONCAT(nombre, ' ', id, ' ', ref) LIKE '%" + val + "%'";
            DataTable tabla = Conexion.Data(sql);
            return tabla;
        }
        public DataRow ConsultarPrecio(String id)
        {
            //Este método trae todos los campos de la tabla Insumo, pero trae un insumo en especifico
            String sql = String.Format("SELECT * FROM insumos WHERE id = {0}", id);
            DataRow row = Conexion.Data(sql).Rows[0];
            return row;
        }
        public DataTable consultarInsumos(String id)
        {
            //Este método consulta los insumos utilizados en un mantenimiento
            String sql = String.Format("SELECT * FROM consultarinsumosmantenimientos WHERE mantenimiento_id = {0}", id);
            DataTable tabla = Conexion.Data(sql);
            return tabla;
        }
        public MySqlDataReader consultarInsumosCantidad(String id)
        {
            //Este método consulta los insumos utilizados en un mantenimiento
            String sql = String.Format("SELECT COUNT(*) FROM consultarinsumosmantenimientos WHERE mantenimiento_id = {0}", id);
            MySqlDataReader read = Conexion.Data2(sql);
            return read;
        }
    }
}
