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
    class MantenimientoClass
    {
        //Se declaran 11 variables de tipo String
        public String tipo_mantenimiento { get; set; }
        public String fecha_dano { get; set; }
        public String fecha_hora_inicio { get; set; }
        public String fecha_hora_fin { get; set; }
        public String observacion { get; set; }
        public String equipo_codigo { get; set; }
        public String numero_orden { get; set; }
        public String fecha_ultimo_mantenimiento { get; set; }
        public String fecha_prevista { get; set; }
        public String solicita { get; set; }
        public String fecha_solicitada { get; set; }

        public DataTable insertar(String frec)
        {
            //Este método se encarga de insertar en la tabla mantenimiento los campos que no están nulos
            String sql = String.Format("INSERT INTO mantenimiento VALUES(null, '{0}', null, null, null, null, '{1}', '{2}', null, '{3}', '{4}', '{5}', '0')",
                tipo_mantenimiento, equipo_codigo, numero_orden, fecha_prevista, solicita, fecha_solicitada);
            Conexion.SQL(sql);
            String arregleFecha = frec + "-12-31T23:59:59";
            String consult = String.Format("SELECT timestampdiff(month, fecha_prevista, '" + arregleFecha + "') as op, fecha_prevista " +
                "FROM mantenimiento WHERE id = (SELECT MAX(id) FROM mantenimiento)");
            DataTable res = Conexion.Data(consult);
            return res;
        }

        public DataTable traerFechaPrevista()
        {
            String consult = String.Format("SELECT DATE_FORMAT(fecha_prevista,'%Y-%m-%d') as fecha_Prevista, YEAR(fecha_prevista) as anio FROM mantenimiento WHERE id = (SELECT MAX(id) FROM mantenimiento)");
            DataTable res = Conexion.Data(consult);
            return res;
        }
        public int ObtenerFrecuencia(String id)
        {
            String sql = String.Format("SELECT frecuencia FROM equipo WHERE codigo = '{0}'", id);
            DataRow row = Conexion.Data(sql).Rows[0];
            return int.Parse(row["frecuencia"].ToString());
        }
        public DataTable operacionFechaPrev(int frec, String fecha)
        {
            String consult = String.Format("SELECT DATE_FORMAT(DATE(DATE_ADD('" + fecha + "', INTERVAL " + frec + " DAY)),'%Y-%m-%d') as fecha, YEAR(DATE(DATE_ADD('" + fecha + "', INTERVAL " + frec + " DAY))) as fecha_prev");
            DataTable res = Conexion.Data(consult);
            return res;
        }

        public void insertarTodo()
        {
            //Este método se encarga de insertar en la tabla mantenimiento todos los campos
            String sql = "";
            if (fecha_dano == "")
            {
                sql = String.Format("INSERT INTO mantenimiento VALUES(null, '{0}', null, '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', null, '{7}', '{8}', '1')",
                tipo_mantenimiento, fecha_hora_inicio, fecha_hora_fin, observacion, equipo_codigo, numero_orden, fecha_ultimo_mantenimiento, solicita, fecha_solicitada);
            }
            else
            {
                sql = String.Format("INSERT INTO mantenimiento VALUES(null, '{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', null, '{8}', '{9}', '1')",
                tipo_mantenimiento, fecha_dano, fecha_hora_inicio, fecha_hora_fin, observacion, equipo_codigo, numero_orden, fecha_ultimo_mantenimiento, solicita, fecha_solicitada);
            }
            int result = Conexion.SQL(sql);
            if (result == 1)
            {
                MessageBox.Show("Mantenimiento Correctivo Ejecutado", "Ejecución Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Error al crear el ejecutar el mantenimiento Correctivo", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void actualizar(String codigo)
        {
            //Este método actualiza el tipo de mantenimiento, el equipo, la fecha prevista y la persona que lo solicita de la tabla mantenimiento
            String sql = String.Format("UPDATE mantenimiento SET tipo_mantenimiento = '{0}', equipo_codigo = '{1}', " +
                "fecha_prevista = '{2}', solicita = '{3}' WHERE id = '{4}'", tipo_mantenimiento, equipo_codigo, fecha_prevista, solicita, codigo);
            int result = Conexion.SQL(sql);
            if (result == 1)
            {
                MessageBox.Show("Plan de mantenimiento actualizado correctamente", "Actualizado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Error al actualizar el plan de mantenimiento", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void actualizarEjecucion(String codigo)
        {
            //Este método lo que hace es ejecutar el mantenimiento actualizando los campos faltantes
            String sql = "";
            if (fecha_dano == null)
            {
                sql = String.Format("UPDATE mantenimiento SET fecha_dano = null, " +
                "fecha_hora_inicio = '{0}', fecha_hora_fin = '{1}', observacion = '{2}', fecha_ultimo_mantenimiento = '{3}', estado = '1' WHERE id = '{4}'", fecha_hora_inicio, fecha_hora_fin,
                observacion, fecha_ultimo_mantenimiento, codigo);
            }
            else
            {
                sql = String.Format("UPDATE mantenimiento SET fecha_dano = '{0}', " +
                "fecha_hora_inicio = '{1}', fecha_hora_fin = '{2}', observacion = '{3}', fecha_ultimo_mantenimiento = '{4}', estado = '1' WHERE id = '{5}'", fecha_dano, fecha_hora_inicio, fecha_hora_fin,
                observacion, fecha_ultimo_mantenimiento, codigo);
            }
            int result = Conexion.SQL(sql);
            if (result == 1)
            {
                MessageBox.Show("Plan de mantenimiento ejecutado correctamente", "Actualizado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Error al ejecutar el plan de mantenimiento", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void eliminar(String codigo)
        {
            //Este método se encarga de eliminar el mantenimiento seleccionado
            String sql = String.Format("DELETE FROM mantenimiento WHERE id = {0}", codigo);
            int result = Conexion.SQL(sql);

            if (result == 1)
            {
                MessageBox.Show("Plan de mantenimiento eliminado correctamente", "Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Error al eliminar el plan de mantenimiento", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void agarrarDatosAct(String fecha_hora_inicio,
            String fecha_hora_fin, String observacion)
        {
            //Ete método lo que hace es pasarle valor a las variables por medio de los parámetros
            this.fecha_hora_inicio = fecha_hora_inicio;
            this.fecha_hora_fin = fecha_hora_fin;
            this.observacion = observacion;

            fecha_ultimo_mantenimiento = DateTime.Now.Year + "-" + DateTime.Now.Month + "-" + DateTime.Now.Day + "T" + DateTime.Now.ToString("HH:mm:ss");
        }
        public void agarrarDatos(String equipo_codigo, String numero_orden,
            String fecha_prevista, String solicita, Boolean fecha)
        {
            //Este método le pasa valor a las variables por parámetros
            tipo_mantenimiento = "Preventivo";
            this.equipo_codigo = equipo_codigo;
            this.numero_orden = numero_orden;
            this.fecha_prevista = fecha_prevista;
            this.solicita = solicita;
            if (fecha)
            {
                fecha_solicitada = DateTime.Now.Year + "-" + DateTime.Now.Month + "-" + DateTime.Now.Day + "T" + DateTime.Now.ToString("HH:mm:ss");
            }

        }

        public void agarrarDatosTodos(String tipo_mantenimiento, String fecha_dano, String fecha_hora_inicio, String fecha_hora_fin, String observacion,
            String equipo_codigo, String numero_orden, String solicita, String fecha_solicitada)
        {
            //Este método le pasa valor a todas las variables
            this.tipo_mantenimiento = tipo_mantenimiento;
            this.fecha_dano = fecha_dano;
            this.fecha_hora_inicio = fecha_hora_inicio;
            this.fecha_hora_fin = fecha_hora_fin;
            this.observacion = observacion;
            this.equipo_codigo = equipo_codigo;
            this.numero_orden = numero_orden;
            this.solicita = solicita;
            this.fecha_solicitada = fecha_solicitada;
            fecha_ultimo_mantenimiento = DateTime.Now.Year + "-" + DateTime.Now.Month + "-" + DateTime.Now.Day + "T" + DateTime.Now.ToString("HH:mm:ss");
        }

        public DataTable consultarPorId(String id)
        {
            //Selecciona el id, numero de orden, tipo de mantenimiento, fecha prevista, nombre de equipo, persona quién solicita, 
            //y la fecha solicitada dependiendo del mantenimiento seleccionado
            String sql = String.Format("SELECT m.id, m.numero_orden, m.tipo_mantenimiento, m.fecha_prevista, e.nombre, a.localizacion, m.solicita , m.fecha_solicitada FROM mantenimiento m" +
                " INNER JOIN equipo e ON m.equipo_codigo = e.codigo INNER JOIN area a ON e.area_id = a.id WHERE m.id = '{0}'", id);
            DataTable tb = Conexion.Data(sql);
            return tb;
        }
        public DataTable consultarTodo(String id)
        {
            //Este método lo que hace es seleccionar todos los campos de la tabla mantenimiento dependiendo del mantenimiento seleccionado
            String sql = String.Format("SELECT * FROM seleccionarmantenimiento WHERE id = '{0}'", id);
            DataTable tb = Conexion.Data(sql);
            return tb;
        }

        public DataTable consultar(String val)
        {
            //Este método consulta todos los equipos
            String sql = "SELECT e.*, CONCAT(e.nombre, ' - ', a.localizacion) NombreArea FROM equipo e " +
                "INNER JOIN area a ON e.area_id = a.id WHERE CONCAT(codigo, ' ', nombre) LIKE '%" + val + "%'";
            DataTable tb = Conexion.Data(sql);
            return tb;
        }
        public MySqlDataReader cargarTabla(String val)
        {
            //Este método carga la tabla de mantenimiento
            String sql = "SELECT m.id as Codigo, numero_orden as Num_Orden, e.codigo as Codigo, e.nombre as Equipo, g.nombre as Grupo, a.localizacion as Localizacion, DATE_FORMAT(fecha_prevista,'%Y-%m-%d') as Fecha_Prevista, solicita as Solicita, fecha_solicitada as Fecha_Solicitud, TIMESTAMPDIFF(DAY, CURDATE(), fecha_prevista) Horas_Faltantes FROM mantenimiento m " +
                "INNER JOIN equipo e ON m.equipo_codigo = e.codigo INNER JOIN area a ON e.area_id = a.id INNER JOIN grupo g ON e.grupo_id = g.id WHERE CONCAT(m.id, ' ', numero_orden, ' ', e.nombre, ' ', Fecha_Prevista, ' ', g.nombre, ' ', a.localizacion, ' ', e.codigo, ' ', solicita) LIKE '%" + val + "%' AND tipo_mantenimiento = 'Preventivo' AND observacion is NULL AND m.estado = 1 ORDER BY Fecha_Prevista";
            MySqlDataReader read = Conexion.Data2(sql);
            return read;
        }
        public MySqlDataReader cargarTabla2(String val, String val2)
        {
            //Este método carga la tabla de mantenimiento
            String sql = "SELECT m.id as Codigo, numero_orden as Num_Orden, e.codigo as Codigo, e.nombre as Equipo, g.nombre as Grupo, a.localizacion as Localizacion, DATE_FORMAT(fecha_prevista,'%Y-%m-%d') as Fecha_Prevista, solicita as Solicita, fecha_solicitada as Fecha_Solicitud, TIMESTAMPDIFF(DAY, CURDATE(), fecha_prevista) Horas_Faltantes FROM mantenimiento m " +
                "INNER JOIN equipo e ON m.equipo_codigo = e.codigo INNER JOIN area a ON e.area_id = a.id INNER JOIN grupo g ON e.grupo_id = g.id WHERE CONCAT(m.id, ' ', numero_orden, ' ', e.nombre, ' ', Fecha_Prevista, ' ', g.nombre, ' ', a.localizacion, ' ', e.codigo, ' ', solicita) LIKE '%" + val + "%' AND tipo = '" + val2 + "'  AND tipo_mantenimiento = 'Preventivo' AND observacion is NULL ORDER BY Fecha_Prevista";
            MySqlDataReader read = Conexion.Data2(sql);
            return read;
        }
        public DataRow traerUltimo(String col)
        {
            //Este método trae el ultimo campo pasado por parámetro de la tabla mantenimiento
            String sql = "SELECT MAX(" + col + ") ultimo FROM mantenimiento";
            DataRow row = Conexion.Data(sql).Rows[0];
            return row;
        }
        public DataTable cargarEjecutados(String val)
        {
            //Se traen todos los mantenimientos ejecutados
            String sql = String.Format("SELECT m.id as Codigo, m.numero_orden as Num_Orden, m.tipo_mantenimiento as Tipo_Mantenimiento, " +
                "DATE_FORMAT(m.fecha_dano,'%Y-%m-%d') as Fecha_Dano, DATE_FORMAT(m.fecha_hora_inicio,'%Y-%m-%d %H:%i:%s') as Fecha_Hora_Inicio, DATE_FORMAT(m.fecha_hora_fin,'%Y-%m-%d %H:%i:%s') as Fecha_Hora_Fin, " +
                "TIMESTAMPDIFF(HOUR, fecha_hora_inicio, fecha_hora_fin) Tiempo_Horas, " +
                "e.codigo as Cod, e.nombre as Equipo_Area_Locativa, g.nombre as Nombre_Grupo, a.localizacion as Localizacion, " +
                "DATE_FORMAT(m.fecha_prevista,'%Y-%m-%d') as Fecha_Prevista, m.solicita as Solicita, DATE_FORMAT(m.fecha_solicitada,'%Y-%m-%d') as Fecha_Solicitada " +
                " FROM mantenimiento m " +
                "INNER JOIN equipo e ON m.equipo_codigo = e.codigo INNER JOIN area a ON e.area_id = a.id INNER JOIN grupo g ON e.grupo_id = g.id WHERE CONCAT(numero_orden, ' ', m.tipo_mantenimiento, ' ', e.nombre, ' ', e.codigo, " +
                "' ', m.fecha_hora_fin, ' ', g.nombre, ' ', a.localizacion) LIKE '%" + val + "%' AND m.estado = '1' " +
                "AND m.observacion IS NOT NULL ORDER BY m.id DESC");
            DataTable tb = Conexion.Data(sql);
            return tb;

        }
        public String cargarPrecios(String id)
        {
            //Se carga el costo de los mantenimientos ejecutados
            String sql = String.Format("SELECT SUM(ins.precio * ihm.cantidad) Costo FROM insumos ins INNER JOIN insumos_has_mantenimiento ihm ON ins.id = ihm.insumos_id" +
            " WHERE ihm.mantenimiento_id = {0}", id);
            DataRow row = Conexion.Data(sql).Rows[0];
            return row["Costo"].ToString();
        }
        public String operacionFecha(String id)
        {
            //Se calcula las horas faltantes para ejecutar el plan de mantenimiento preventivo
            String fecha_actual = DateTime.Now.Year + "-" + DateTime.Now.Month + "-" + DateTime.Now.Day + "T" + DateTime.Now.ToString("HH:mm:ss");
            String sql = String.Format("SELECT TIMESTAMPDIFF(DAY, '{0}', fecha_prevista) Horas_Faltantes FROM mantenimiento WHERE id = {1} GROUP BY id", fecha_actual, id);
            DataRow row = Conexion.Data(sql).Rows[0];
            return row["Horas_faltantes"].ToString();
        }
        public String contarpreventivos()
        {
            //Se cuenta cuantos mantenimientos preventivos hay
            String sql = String.Format("SELECT COUNT(*) cantidad FROM mantenimiento WHERE observacion IS NULL AND tipo_mantenimiento = 'Preventivo'");
            DataRow row = Conexion.Data(sql).Rows[0];
            return row["cantidad"].ToString();
        }
        public DataTable vistaEjecutados()
        {
            String sql = String.Format("SELECT id, tipo_mantenimiento, numero_orden, NombreEquipo " +
                "FROM mantenimientosejecutados GROUP BY id");
            DataTable tb = Conexion.Data(sql);
            return tb;
        }
        public DataTable tipoMantenimiento(String id)
        {
            String sql = String.Format("SELECT tipo_mantenimiento, observacion FROM mantenimiento WHERE id = {0}", id);
            DataTable row = Conexion.Data(sql);
            return row;
        }
        public void cambiarEstado(String id)
        {
            String sql = String.Format("UPDATE mantenimiento SET estado = '0' WHERE id = '{0}'",  id);

            int result = Conexion.SQL(sql);
            if (result == 1)
            {
                MessageBox.Show("Plan de mantenimiento cerrado", "Cerrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Error al cerrar el plan de mantenimiento", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }        
    }
}
