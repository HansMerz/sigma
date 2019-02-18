using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoMantenimiento
{
    class PrestarClass
    {
        //Se declaran 4 variables de tipo String
        public String idpersona { get; set; }
        public String idherramienta { get; set; }
        public String fecha { get; set; }
        public String cantidad { get; set; }

        public int Insertar()
        {
            //Este método inserta en la base de datos las herramientas prestadas a las personas
            String sql = String.Format("INSERT INTO herramientas_has_persona VALUES(null, {0}, {1}, {2}, '{3}')", 
                idherramienta, idpersona, cantidad, fecha);
            int result = Conexion.SQL(sql);
            return result;
        }
        public int InsertarInsumo()
        {
            //Este método inserta los insumos prestados a las personas
            String sql = String.Format("INSERT INTO insumos_has_persona VALUES(null, {0}, {1}, {2}, '{3}')",
                idherramienta, idpersona, cantidad, fecha);
            int result = Conexion.SQL(sql);
            return result;
        }
        public int ActualizarInsumo(String id, String cantidad)
        {
            //Este método actualiza los insumos prestados a las personas
            String sql = String.Format("UPDATE insumos_has_persona SET cantidad = {0} WHERE id = {1}", cantidad, id);
            int result = Conexion.SQL(sql);
            return result;
        }
        public void AsignarDatos(String idherramienta, String idpersona, String cantidad)
        {
            //Se establece valor a las variables dependiendo de los valores pasados por parámetro
            fecha = DateTime.Now.Year + "-" + DateTime.Now.Month + "-" + DateTime.Now.Day + "T" + DateTime.Now.ToString("hh:mm:ss");
            this.idherramienta = idherramienta;
            this.idpersona = idpersona;
            this.cantidad = cantidad;
        }
        public int Actualizar(String id, String cantidad)
        {
            //Se actualiza las herramientas prestadas a cierta persona
            String sql = String.Format("UPDATE herramientas_has_persona SET cantidad = {0} WHERE id = {1}", cantidad, id);
            int result = Conexion.SQL(sql);
            return result;
        }
        public DataTable ConsultarPersona(String val)
        {
            //Se consulta las personas que tienen herramientas prestadas
            String sql = String.Format("SELECT p.id, p.nombres FROM herramientas_has_persona hhp INNER JOIN persona p ON hhp.persona_id = p.id WHERE CONCAT(p.nombres) " +
                "LIKE '%"+val+"%' AND hhp.cantidad > 0" +
                " GROUP BY p.id");                                       
            DataTable tb = Conexion.Data(sql);
            return tb;
        }
        public DataTable ConsultarPersonaInsumo(String val)
        {
            //Se consulta las personas que tienen insumos asignados
            String sql = String.Format("SELECT p.id, p.nombres FROM insumos_has_persona ihp INNER JOIN persona p ON ihp.persona_id = p.id WHERE CONCAT(p.nombres) " +
                "LIKE '%" + val + "%' AND ihp.cantidad > 0" +
                " GROUP BY p.id");
            DataTable tb = Conexion.Data(sql);
            return tb;
        }
        public DataTable ConsultarHerramientas()
        {
            //Se consulta las herramientas y cantidad prestadas a cierta persona
            String sql = String.Format("SELECT hhp.id, h.nombre, hhp.cantidad, hhp.fecha FROM herramientas_has_persona hhp INNER JOIN herramientas h ON hhp.herramientas_id = h.id"
                                        +" WHERE hhp.persona_id = {0} AND cantidad > 0", idpersona);
            DataTable tb = Conexion.Data(sql);
            return tb;
        }
        public DataTable ConsultarInsumos()
        {
            //Se consulta los insumos y cantidad prestada a ciera persona
            String sql = String.Format("SELECT ihp.id, i.nombre, i.ref, ihp.cantidad, ihp.fecha FROM insumos_has_persona ihp INNER JOIN insumos i ON ihp.insumos_id = i.id"
                                        + " WHERE ihp.persona_id = {0} AND cantidad > 0", idpersona);
            DataTable tb = Conexion.Data(sql);
            return tb;
        }
    }
}
