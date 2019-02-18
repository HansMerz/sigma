using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoMantenimiento
{
    class InventarioClass
    {
        //Se declaran 6 variables de tipo String y una de tipo Int64
        public String fecha { get; set; }
        public String hora { get; set; }
        public Int64 cantidad { get; set; }
        public String descripcion { get; set; }
        public String herramientas_id { get; set; }
        public String equipo_codigo { get; set; }
        public String insumos_id { get; set; }

        public void InsertarInventarioH()
        {            
            //Este método lo que hace es insertar la herramienta en el inventario
            String sql = "INSERT INTO inventario VALUES(null, '"+fecha+"', "+cantidad+" , '"+descripcion+"', "+herramientas_id+", null, null)";
             Conexion.SQL(sql);            
        }        
        public void ActualizarInventarioH(String id)
        {
            //Este método actualiza el inventario dependiendo de la herramienta
            String sql = String.Format("UPDATE inventario SET descripcion = '{0}' WHERE herramientas_id = {1}", descripcion, id);
            Conexion.SQL(sql);
        }        
        public void ActualizarInventarioHFecha(String id)
        {
            //Este método actualiza el inventario dependiendo de la herramienta. Se actualiza la cantidad, descripción y fecha
            String sql = String.Format("UPDATE inventario SET cantidad = {0}, descripcion = '{1}', fecha = '{2}' WHERE herramientas_id = {3}", cantidad, descripcion, fecha, id);
            Conexion.SQL(sql);
        }
        public void EliminarInventarioH(String id)
        {
            //Este método elimina la herramienta seleccionada del inventario
            String sql = String.Format("DELETE FROM inventario WHERE herramientas_id = {0}", id);
            Conexion.SQL(sql);
        }
        public void InsertarInventarioI()
        {
            //Lo que hace este método es insertar el insumo en el inventario
            String sql = "INSERT INTO inventario VALUES(null, '" + fecha + "', " + cantidad + " , '" + descripcion + "', null, null, "+insumos_id+")";
            Conexion.SQL(sql);
        }
        public void ActualizarInventarioIFecha(String id)
        {
            //Este método actualiza el inventario dependiendo de la herramienta
            String sql = String.Format("UPDATE inventario SET cantidad = {0}, descripcion = '{1}', fecha = '{2}' WHERE insumos_id = {3}", cantidad, descripcion, fecha, id);
            Conexion.SQL(sql);
        }
        public void ActualizarInventarioI(String id)
        {
            //Este método actualiza el inventario dependiendo de la herramienta
            String sql = String.Format("UPDATE inventario SET descripcion = '{0}' WHERE insumos_id = {1}", descripcion, id);
            Conexion.SQL(sql);
        }
        public DataTable TraerCantidad(String id)
        {
            //Este método llama al procedimiento que trae la cantidad de herramientas existentes
            String sql = String.Format("CALL InventarioHe({0})", id);
            DataTable tabla = Conexion.Data(sql);
            return tabla;
        }
        public DataTable TraerCantidadIn(String id)
        {
            //Este método llama al procedimiento que trae la cantidad de insumos existentes
            String sql = String.Format("CALL InventarioIn({0})", id);
            DataTable tabla = Conexion.Data(sql);
            return tabla;
        }
        public void InsertarInventarioE()
        {
            //Este método inserta el equipo en el inventario
            String sql = "INSERT INTO inventario VALUES(null, '" + fecha + "', " + cantidad + " , '" + descripcion + "', null, "+equipo_codigo+", null)";
            Conexion.SQL(sql);
        }
        public void AsignarValores(int cantidad, String descripcion, String herramientas_id, String equipo_codigo, String insumos_id)
        {
            //Este método lo que hace es capturar los valores que se pasan por parámetro y asignarle valor a las variables
            fecha = DateTime.Now.Year + "-" + DateTime.Now.Month + "-" + DateTime.Now.Day + "T" + DateTime.Now.ToString("hh:mm:ss");            
            this.cantidad = cantidad;
            this.descripcion = descripcion;
            this.herramientas_id = herramientas_id;
            this.equipo_codigo = equipo_codigo;
            this.insumos_id = insumos_id;
        }
        
         
    }
}
