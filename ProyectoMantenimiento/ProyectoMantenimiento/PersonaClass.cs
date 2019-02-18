using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoMantenimiento
{
    class PersonaClass
    {
        //Se declaran 3 variables de tipo String
        public String cc { get; set; }
        public String nombre { get; set; }
        public String puesto { get; set; }

        public void Insertar()
        {
            //Este método inserta en la tabla personas
            String sql = String.Format("INSERT INTO persona VALUES(null, '{0}', '{1}', '{2}')", nombre, cc, puesto);
            int result = Conexion.SQL(sql);
            if(result == 1)
            {
                MessageBox.Show("Trabajador registrado exitosamente", "Registrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("El trabajador no fue registrado con éxito", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Actualizar(String id)
        {
            //Este método actualiza las personas
            String sql = String.Format("UPDATE persona SET nombres = '{0}', cc = '{1}', puesto = '{2}' WHERE id = {3}", nombre, cc, puesto,
                id);
            int result = Conexion.SQL(sql);
            if (result == 1)
            {
                MessageBox.Show("Trabajador actualizado exitosamente", "Actualización", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("El trabajador no fue actualizado con éxito", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Eliminar(String id)
        {
            //Este método elimina la persona seleccionada
            String sql = "DELETE FROM persona WHERE id = " + id;
            int result = Conexion.SQL(sql);
            if (result == 1)
            {
                MessageBox.Show("El trabajador fue eliminado correctamente", "Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("El trabajador NO fue eliminado exitósamente", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public DataTable Consultar(String val)
        {
            //Se consulta el id y nombres de todas las personas
            String sql = "SELECT id, nombres FROM persona WHERE CONCAT(nombres, ' ', id, ' ', puesto) LIKE '%" + val + "%'";
            DataTable tb = Conexion.Data(sql);
            return tb;
        }

        public DataTable CargarDatos(String id)
        {
            //Se carga todos los datos de una persona en especifica
            String sql = "SELECT * FROM persona WHERE id = " + id;
            DataTable tb = Conexion.Data(sql);
            return tb;
        }

        public DataTable CargarTabla(String val)
        {
            //Se trae todos los campos de las personas ordenadas de manera descendente
            String sql = "SELECT * FROM persona WHERE CONCAT (nombres, ' ', id, ' ', puesto) LIKE '%" + val + "%' ORDER BY id DESC";
            DataTable tb = Conexion.Data(sql);
            return tb;
        }
        public void AgarrarDatos(String nombre, String cc, String puesto)
        {
            //Este método asigna valor a las variables dependiendo de los valores pasados por parámetro
            this.nombre = nombre;
            this.cc = cc;
            this.puesto = puesto;
        }
    }
}
