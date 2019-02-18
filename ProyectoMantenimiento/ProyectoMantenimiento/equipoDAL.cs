using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Data.Sql;
using MySql.Data.MySqlClient;
using System.IO;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace ProyectoMantenimiento
{
    public class EquipoDAL
    {
        public static int Agregar(equipos pequipos)
        {
            Equipo crear = new Equipo();

            int retorno = 0;
            String Comando = string.Format("Insert Into equipo (codigo, nombre, fecha_ingr_plant, fecha_ingr_sist, costo_equipo, modelo_equipo, serie_equipo, peso, altura, ancho, largo, fabricante, marca, realizado_por, caract_tecni, funcion, imagen, tipo, area_id, capacidad_produccion, voltaje, libra_presion, manual, tipo_aceite, tipo_grasa,  direccion_fabricante, telefono_fabricante, email_fabricante, ano_fabricante, Estado, grupo_id, frecuencia) values ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}','{12}','{13}','{14}','{15}','{16}','{17}', '{18}','{19}','{20}', '{21}', '{22}','{23}', '{24}', '{25}', '{26}', '{27}', '{28}', '{29}', '{30}', '{31}')",
            pequipos.codigo, pequipos.nombre, pequipos.fecha_ingreso_plant, pequipos.fecha_ingreso_siste, pequipos.costo_equipo, pequipos.modelo_equipo, pequipos.serie_equipo, pequipos.peso, pequipos.altura, pequipos.ancho, pequipos.largo, pequipos.fabricante, pequipos.marca, pequipos.realiza_por, pequipos.caracteristicas_tecn, pequipos.funcion, pequipos.Imagen, pequipos.tipo, pequipos.localizacion, pequipos.capacidad_produccion, pequipos.voltaje, pequipos.libra_presion, pequipos.manual, pequipos.tipo_aceite, pequipos.tipo_grasa,
            pequipos.direccion_fabricante, pequipos.telefono_fabricante, pequipos.email_fabricante, pequipos.ano_fabricante, pequipos.estado, pequipos.grupo, pequipos.frecuencia);

            int valor = Conexion.SQL(Comando);

            return retorno;
        }


        public static List<equipos> Buscar(string codigo)
        {
            List<equipos> listaBuscar = new List<equipos>();
            MySqlCommand comand = new MySqlCommand(string.Format("SELECT * FROM impresora where codigo = '{0}'", codigo));


            // int valor = Conexion.SQL(comand);

            MySqlDataReader reader = comand.ExecuteReader();
            equipos equipo = new equipos();

            while (reader.Read())
            {
                equipo.codigo = reader.GetString(0);
                equipo.nombre = reader.GetString(1);
                equipo.localizacion = reader.GetString(2);
                equipo.fecha_ingreso_plant = reader.GetString(3);
                equipo.fecha_ingreso_siste = reader.GetString(4);
                equipo.costo_equipo = reader.GetString(5);
                equipo.codigo_invetario = reader.GetString(6);
                equipo.peso = reader.GetString(7);
                equipo.altura = reader.GetString(8);
                equipo.ancho = reader.GetString(9);
                equipo.largo = reader.GetString(10);
                equipo.fabricante = reader.GetString(11);
                equipo.marca = reader.GetString(12);
                equipo.realiza_por = reader.GetString(13);
                equipo.caracteristicas_tecn = reader.GetString(14);
                equipo.funcion = reader.GetString(15);
                equipo.Imagen = reader.GetString(16);
                listaBuscar.Add(equipo);
            }
            return listaBuscar;
        }

        public static int Actualizar_equipo(equipos pequipos)
        {
            // Query para actualizar equipo
            
            String comd = String.Format("UPDATE equipo SET nombre = '{0}', fecha_ingr_plant = '{1}', costo_equipo = '{2}', modelo_equipo = '{3}',serie_equipo " +
                 "= '{4}', peso = '{5}', altura = '{6}', ancho = '{7}', largo = '{8}', fabricante = '{9}', marca = '{10}', caract_tecni = '{11}', funcion = '{12}', imagen = '{13}', area_id = '{14}', capacidad_produccion = '{15}',voltaje = '{16}', libra_presion = '{17}', manual = '{18}', tipo_aceite = '{19}', tipo_grasa='{20}',direccion_fabricante = '{21}', telefono_fabricante = '{22}', email_fabricante = '{23}', ano_fabricante = '{24}', Estado = '{25}', grupo_id = '{26}', frecuencia = '{27}' WHERE codigo = '{28}'", pequipos.nombre, pequipos.fecha_ingreso_plant, pequipos.costo_equipo, pequipos.modelo_equipo,
                 pequipos.serie_equipo, pequipos.peso, pequipos.altura, pequipos.ancho, pequipos.largo, pequipos.fabricante, pequipos.marca, pequipos.caracteristicas_tecn, pequipos.funcion, pequipos.Imagen, pequipos.localizacion, pequipos.capacidad_produccion, pequipos.voltaje, pequipos.libra_presion, pequipos.manual, pequipos.tipo_aceite, pequipos.tipo_grasa, pequipos.direccion_fabricante, pequipos.telefono_fabricante, pequipos.email_fabricante, pequipos.ano_fabricante, pequipos.estado, pequipos.grupo, pequipos.frecuencia, pequipos.codigo);

            // String comand = String.Format("UPDATE equipo SET  nombre = '{0}', ")

            int resultado = Conexion.SQL(comd);           

            return resultado;

        }

        public static int Eliminar_equipo(equipos pequipos)
        {
            String comd = String.Format("DELETE FROM equipo WHERE codigo = '{0}'", pequipos.codigo);

            int resultado = Conexion.SQL(comd);
            return resultado;
        }
        /* public static DataTable Ficha_tecnica(equipos pequipo)
         {
            // String comando = String.Format("SELECT e.codigo, e.nombre, e.fabricante, e.modelo_equipo, e.marca, e.peso, e.altura, e.ancho, e.largo, i.id, m.fecha_prevista, a.localizacion FROM equipo e INNER JOIN area a ON e.area_id = a.id INNER JOIN inventario i ON  e.codigo = i.equipo_codigo INNER JOIN mantenimiento m ON e.codigo = m.equipo_codigo where e.codigo = '{0}'", pequipo.codigo);

             //String comando  = 

            // DataTable resultado = Conexion.Data(comando);

             return resultado;
         }*/

        public static int insertar_area(Area_localizacion area)
        {
            String comando = String.Format("insert into area (centrocosto, localizacion) values ('{0}', '{1}')", area.Centro_costo, area.Localizacion);

            int resultado = Conexion.SQL(comando);
            return resultado;
        }

        public static int actualizar_area(Area_localizacion area)
        {
            String comando = String.Format("update area set centrocosto = '{0}', localizacion = '{1}' WHERE id = '{2}'", area.Centro_costo, area.Localizacion, area.id);

            int resultado = Conexion.SQL(comando);
            return resultado;

            // DataRow reader = Conexion.Data(comando).Rows[0];
            //DataTable dt = new DataTable();
        }

        public static int Borrar_area(Area_localizacion area)
        {
            String sql = String.Format("SELECT id FROM area WHERE centrocosto = '{0}'", area.Centro_costo);
            DataRow row = Conexion.Data(sql).Rows[0];
            String comando = String.Format("delete from area where id = '{0}'", row["id"].ToString());

            int resultado = Conexion.SQL(comando);

            return resultado;
        }

        public static int Consulta_fichas(equipos equipo)
        {

            String comando = string.Format("SELECT e.codigo, e.nombre, e.fabricante, e.modelo_equipo, e.marca, e.peso, e.altura, e.ancho, e.largo, i.id, m.fecha_prevista, a.localizacion FROM equipo e INNER JOIN area a ON e.area_id = a.id INNER JOIN inventario i ON  e.codigo = i.equipo_codigo INNER JOIN mantenimiento m ON e.codigo = m.equipo_codigo where e.codigo = '{0}'", equipo.codigo);

            int resultado = Conexion.SQL(comando);

            return resultado;
        }
        public DataTable cargarCombo()
        {
            String sql = String.Format("SELECT * FROM area");
            DataTable tb = Conexion.Data(sql);
            return tb;
        }
        public String consultarCantidadMantenimientos(String id)
        {
            String sql = string.Format("SELECT COUNT(*) as Cantidad FROM mantenimiento m WHERE m.observacion IS NOT NULL AND m.equipo_codigo = '{0}'", id);
            DataRow row = Conexion.Data(sql).Rows[0];
            return row["Cantidad"].ToString();
        }
        public DataTable cargarTablaHojaVida(String val)
        {
            String sql = String.Format("SELECT m.id as ID, m.tipo_mantenimiento as Tipo_Mantenimiento, m.numero_orden as Num_Orden,  " +
                "m.fecha_hora_inicio as Fecha_Hora_Inicio, m.fecha_hora_fin as Fecha_Hora_Fin, TIMESTAMPDIFF(HOUR, fecha_hora_inicio, fecha_hora_fin) Tiempo_Ejecucion, m.observacion as Observacion " +
                "FROM equipo e INNER JOIN mantenimiento m ON e.codigo = m.equipo_codigo WHERE e.codigo = '{0}' AND m.observacion IS NOT NULL", val);
            DataTable tb = Conexion.Data(sql);
            return tb;
        }
        public DataTable cargarTablaTodos()
        {
            String sql = String.Format("SELECT codigo as Codigo, e.nombre as Nombre, fecha_ingr_plant as Fecha_Ingreso_Planta, fecha_ingr_sist as Fecha_Ingreso_Sistema, " +
                "costo_equipo as Costo, modelo_equipo as Modelo, serie_equipo as Serie, peso as Peso, altura as Altura, ancho as Ancho, largo as Largo, " +
                "fabricante as Fabricante, marca as Marca, caract_tecni as Caracteristica, funcion as Funcion, a.localizacion as Localizacion " +
                "FROM equipo e INNER JOIN area a ON e.area_id = a.id");
            DataTable tb = Conexion.Data(sql);
            return tb;
        }
        public DataTable cargarTablaAreas()
        {
            String sql = String.Format("SELECT codigo as Codigo, nombre as Nombre, fecha_ingr_plant as Fecha_Ingreso_Planta, fecha_ingr_sist as Fecha_Ingreso_Sistema, " +
                "a.localizacion as Localizacion FROM equipo e INNER JOIN area a ON e.area_id = a.id WHERE e.tipo = 0");
            DataTable tb = Conexion.Data(sql);
            return tb;
        }
        public DataTable cargarTablaEquipos()
        {
            String sql = String.Format("SELECT codigo as Codigo, nombre as Nombre, fecha_ingr_plant as Fecha_Ingreso_Planta, fecha_ingr_sist as Fecha_Ingreso_Sistema, " +
                "costo_equipo as Costo, modelo_equipo as Modelo, serie_equipo as Serie, peso as Peso, altura as Altura, ancho as Ancho, largo as Largo, " +
                "fabricante as Fabricante, marca as Marca, caract_tecni as Caracteristica, funcion as Funcion, a.localizacion as Localizacion " +
                "FROM equipo e INNER JOIN area a ON e.area_id = a.id WHERE e.tipo = 1");
            DataTable tb = Conexion.Data(sql);
            return tb;
        }
        public MySqlDataReader verInsumos(String valor)
        {
            String sql = String.Format("SELECT i.id, i.nombre, ihm.cantidad, i.precio FROM equipo e INNER JOIN mantenimiento m ON e.codigo = m.equipo_codigo " +
                "INNER JOIN insumos_has_mantenimiento ihm ON m.id = ihm.mantenimiento_id INNER JOIN insumos i ON ihm.insumos_id = i.id WHERE m.id = '{0}'", valor);
            MySqlDataReader tb = Conexion.Data2(sql);
            return tb;
        }
        public DataTable verProceso(String valor)
        {
            String sql = String.Format("SELECT observacion FROM equipo e INNER JOIN mantenimiento m ON e.codigo = m.equipo_codigo " +
                "WHERE m.id = '{0}'", valor);
            DataTable tb = Conexion.Data(sql);
            return tb;
        }
        public DataTable costoTotalMantenimiento(String val)
        {
            String sql = String.Format("SELECT SUM(ins.precio * ihm.cantidad) Costo FROM insumos ins " +
                "INNER JOIN insumos_has_mantenimiento ihm ON ins.id = ihm.insumos_id " +
                "INNER JOIN mantenimiento m ON ihm.mantenimiento_id = m.id WHERE m.equipo_codigo = '{0}'", val);
            DataTable tb = Conexion.Data(sql);
            return tb;
        }

        public static DataTable Consulta_hoja_vida_equipo(equipos equipo)
        {
            String comando = string.Format("SELECT e.codigo, e.nombre, e.serial, a.localizacion, m.fecha_ultimo_mantenimiento FROM equipo e JOIN area a ON e.area_id = a.id" +
                "JOIN mantenimiento m ON e.codigo = m.equipo_codigo WHERE e.codigo = '{0}'", equipo.codigo);

            DataTable resultado = Conexion.Data(comando);

            return resultado;
        }

        public static DataTable Consuta_datagriview(equipos equipo)
        {
            // String comando = string.Format("SELECT * FROM mantenimiento where equipo_codigo = '{0}'", equipo.codigo);
            String comando = string.Format("SELECT tipo_mantenimiento, tiempo_fuera_servicio, repuestos, fecha_hora_inicio, fecha_hora_fin, observaciones, numero_aviso, fecha_prevista WHERE equipo_codigo = '{0}'", equipo.codigo);

            DataTable resultado = Conexion.Data(comando);
            return resultado;
        }
        public static String consultarExistente(String id)
        {
            String code;
            try
            {
                String sql = string.Format("SELECT * FROM equipo WHERE codigo = {0}", id);
                DataRow row = Conexion.Data(sql).Rows[0];
                code = row["codigo"].ToString();
            }
            catch (Exception)
            {
                code = "";                
            }
            return code;
        }
        public DataTable cargarGrupos()
        {
            String sql = string.Format("SELECT * FROM grupo");
            DataTable tb = Conexion.Data(sql);
            return tb;
        }
        public DataTable Combo_grupo()
        {
            String sql = String.Format("SELECT * FROM grupo");
            DataTable tb = Conexion.Data(sql);
            return tb;
        }

        public DataTable Llenar_grilla(String val, String fechaInicio, String fechaFin)
        {
            String sql = String.Format("SELECT e.codigo Codigo, e.nombre Equipo_Area_Locativa, g.nombre Grupo, a.localizacion Localizacion, COUNT(m.equipo_codigo) as Total_Mantenimientos, SUM(ins.precio * ihm.cantidad) as Costos FROM equipo e INNER JOIN grupo g ON e.grupo_id = g.id INNER JOIN area a ON e.area_id = a.id INNER JOIN mantenimiento m ON e.codigo = m.equipo_codigo LEFT JOIN insumos_has_mantenimiento ihm ON m.id = ihm.mantenimiento_id LEFT JOIN insumos ins ON ihm.insumos_id = ins.id WHERE CONCAT(e.codigo, ' ', e.nombre) LIKE '%{0}%' AND m.fecha_hora_fin BETWEEN '{1}' AND '{2}' AND m.observacion IS NOT NULL GROUP BY e.codigo ORDER BY Costos DESC", val, fechaInicio, fechaFin);

            DataTable tb = Conexion.Data(sql);
            return tb;
        }

        public DataTable Buscar_equipo_tipo(String val, String fecha_inicio, String fecha_fin)
        {
            String sql = String.Format("SELECT e.codigo Codigo, e.nombre Equipo_Area_Locativa, g.nombre Grupo, a.localizacion Localizacion, COUNT(m.equipo_codigo) as Total_Mantenimientos, SUM(ins.precio * ihm.cantidad) as Costos FROM equipo e INNER JOIN grupo g ON e.grupo_id = g.id INNER JOIN area a ON e.area_id = a.id INNER JOIN mantenimiento m ON e.codigo = m.equipo_codigo LEFT JOIN insumos_has_mantenimiento ihm ON m.id = ihm.mantenimiento_id LEFT JOIN insumos ins ON ihm.insumos_id = ins.id WHERE CONCAT(e.codigo, ' ', e.nombre) LIKE '%{0}%' AND m.fecha_hora_fin BETWEEN '{1}' AND '{2}' AND m.observacion IS NOT NULL AND e.tipo = '0' GROUP BY e.codigo ORDER BY Costos DESC", val, fecha_inicio, fecha_fin);

            DataTable tb = Conexion.Data(sql);
            return tb;
        }

        public DataTable Buscar_equipo_tipo_equipo(String val, String fecha_inicio, String fecha_fin)
        {
            String sql = String.Format("SELECT e.codigo Codigo, e.nombre Equipo_Area_Locativa, g.nombre Grupo, a.localizacion Localizacion, COUNT(m.equipo_codigo) as Total_Mantenimientos, SUM(ins.precio * ihm.cantidad) as Costos FROM equipo e INNER JOIN grupo g ON e.grupo_id = g.id INNER JOIN area a ON e.area_id = a.id INNER JOIN mantenimiento m ON e.codigo = m.equipo_codigo LEFT JOIN insumos_has_mantenimiento ihm ON m.id = ihm.mantenimiento_id LEFT JOIN insumos ins ON ihm.insumos_id = ins.id WHERE CONCAT(e.codigo, ' ', e.nombre) LIKE '%{0}%' AND m.fecha_hora_fin BETWEEN '{1}' AND '{2}' AND m.observacion IS NOT NULL AND e.tipo = '1' GROUP BY e.codigo ORDER BY Costos DESC", val, fecha_inicio, fecha_fin);

            DataTable tb = Conexion.Data(sql);
            return tb;
        }

        public DataTable Filtro_equipo_area_porcentrodecosto(String val, String fecha_inicio, String fecha_fin, String Localizacion)
        {
            String sql = String.Format("SELECT e.codigo Codigo, e.nombre Equipo_Area_Locativa, g.nombre Grupo, a.localizacion Localizacion, COUNT(m.equipo_codigo) as Total_Mantenimientos, SUM(ins.precio * ihm.cantidad) as Costos FROM equipo e INNER JOIN grupo g ON e.grupo_id = g.id INNER JOIN area a ON e.area_id = a.id INNER JOIN mantenimiento m ON e.codigo = m.equipo_codigo LEFT JOIN insumos_has_mantenimiento ihm ON m.id = ihm.mantenimiento_id LEFT JOIN insumos ins ON ihm.insumos_id = ins.id WHERE CONCAT(e.codigo, ' ', e.nombre) LIKE '%{0}%' AND m.observacion IS NOT NULL AND m.fecha_hora_fin BETWEEN '{1}' AND '{2}' AND a.localizacion = '{3}' AND e.tipo = '1' GROUP BY e.codigo ORDER BY Costos DESC", val, fecha_inicio, fecha_fin, Localizacion);

            DataTable tb = Conexion.Data(sql);
            return tb;
        }

        public DataTable Fltro_equipo_area_porcentrocosto1(String val, String Fecha_inicio, String Fecha_fin, String Localizacion)
        {
            String sql = String.Format("SELECT e.codigo Codigo, e.nombre Equipo_Area_Locativa, g.nombre Grupo, a.localizacion Localizacion, COUNT(m.equipo_codigo) as Total_Mantenimientos, SUM(ins.precio * ihm.cantidad) as Costos FROM equipo e INNER JOIN grupo g ON e.grupo_id = g.id INNER JOIN area a ON e.area_id = a.id INNER JOIN mantenimiento m ON e.codigo = m.equipo_codigo LEFT JOIN insumos_has_mantenimiento ihm ON m.id = ihm.mantenimiento_id LEFT JOIN insumos ins ON ihm.insumos_id = ins.id WHERE CONCAT(e.codigo, ' ', e.nombre) LIKE '%{0}%' AND m.observacion IS NOT NULL AND m.fecha_hora_fin BETWEEN '{1}' AND '{2}' AND a.localizacion = '{3}' AND e.tipo = '0' GROUP BY e.codigo ORDER BY Costos DESC", val, Fecha_inicio, Fecha_fin, Localizacion);

            DataTable tb = Conexion.Data(sql);
            return tb;
        }
        public DataTable FiltroTodoEquipoArea(String val, String Fecha_inicio, String Fecha_fin)
        {
            String sql = String.Format("SELECT e.codigo Codigo, e.nombre Equipo_Area_Locativa, g.nombre Grupo, a.localizacion Localizacion, COUNT(m.equipo_codigo) as Total_Mantenimientos, SUM(ins.precio * ihm.cantidad) as Costos FROM equipo e INNER JOIN grupo g ON e.grupo_id = g.id INNER JOIN area a ON e.area_id = a.id INNER JOIN mantenimiento m ON e.codigo = m.equipo_codigo LEFT JOIN insumos_has_mantenimiento ihm ON m.id = ihm.mantenimiento_id LEFT JOIN insumos ins ON ihm.insumos_id = ins.id WHERE CONCAT(e.codigo, ' ', e.nombre) LIKE '%{0}%' AND m.observacion IS NOT NULL AND m.fecha_hora_fin BETWEEN '{1}' AND '{2}' AND e.tipo = '1' GROUP BY e.codigo ORDER BY Costos DESC", val, Fecha_inicio, Fecha_fin);

            DataTable tb = Conexion.Data(sql);
            return tb;
        }
        public DataTable FiltroTodoEquipoArea1(String val, String Fecha_inicio, String Fecha_fin)
        {
            String sql = String.Format("SELECT e.codigo Codigo, e.nombre Equipo_Area_Locativa, g.nombre Grupo, a.localizacion Localizacion, COUNT(m.equipo_codigo) as Total_Mantenimientos, SUM(ins.precio * ihm.cantidad) as Costos FROM equipo e INNER JOIN grupo g ON e.grupo_id = g.id INNER JOIN area a ON e.area_id = a.id INNER JOIN mantenimiento m ON e.codigo = m.equipo_codigo LEFT JOIN insumos_has_mantenimiento ihm ON m.id = ihm.mantenimiento_id LEFT JOIN insumos ins ON ihm.insumos_id = ins.id WHERE CONCAT(e.codigo, ' ', e.nombre) LIKE '%{0}%' AND m.observacion IS NOT NULL AND m.fecha_hora_fin BETWEEN '{1}' AND '{2}' AND e.tipo = '0' GROUP BY e.codigo ORDER BY Costos DESC", val, Fecha_inicio, Fecha_fin);

            DataTable tb = Conexion.Data(sql);
            return tb;
        }    
        
        public DataTable FiltrarPorCodigoNombre(String val)
        {            
            String sql = String.Format("SELECT codigo as Codigo, e.nombre as Nombre, fecha_ingr_plant as Fecha_Ingreso_Planta, fecha_ingr_sist as Fecha_Ingreso_Sistema, " +
                "costo_equipo as Costo, modelo_equipo as Modelo, serie_equipo as Serie, peso as Peso, altura as Altura, ancho as Ancho, largo as Largo, " +
                "fabricante as Fabricante, marca as Marca, caract_tecni as Caracteristica, funcion as Funcion, a.localizacion as Localizacion " +
                "FROM equipo e INNER JOIN area a ON e.area_id = a.id WHERE CONCAT(e.nombre, ' ', a.localizacion, ' ', e.codigo) LIKE '%"+val+"%'");
            DataTable tb = Conexion.Data(sql);
            return tb;
        }
        public DataTable FiltrarPorGrupo(String val)
        {
            String sql = String.Format("SELECT codigo as Codigo, e.nombre as Nombre, fecha_ingr_plant as Fecha_Ingreso_Planta, fecha_ingr_sist as Fecha_Ingreso_Sistema, " +
                "costo_equipo as Costo, modelo_equipo as Modelo, serie_equipo as Serie, peso as Peso, altura as Altura, ancho as Ancho, largo as Largo, " +
                "fabricante as Fabricante, marca as Marca, caract_tecni as Caracteristica, funcion as Funcion, a.localizacion as Localizacion " +
                "FROM equipo e INNER JOIN area a ON e.area_id = a.id INNER JOIN grupo g ON e.grupo_id = g.id WHERE g.id = '{0}'", val);
            DataTable tb = Conexion.Data(sql);
            return tb;
        }
    }
}




