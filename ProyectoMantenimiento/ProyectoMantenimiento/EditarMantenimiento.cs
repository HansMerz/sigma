using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoMantenimiento
{
    public partial class EditarMantenimiento : Form
    {
        //Se declaran las variables, una de tipo String, otra de la clase Mantenimiento y otra de la ventana Mantenimiento
        String id;
        Mantenimiento m;
        MantenimientoClass man;
        public EditarMantenimiento(Mantenimiento m, String id)
        {
            //Se instancian las variables y se carga la lista con el equipo o área que se va a actualizar, después se llama al método asignardatos
            InitializeComponent();
            this.id = id;
            this.m = m;
            man = new MantenimientoClass();
            cargarListas("");
            asignarDatos();
        }
        private void asignarDatos()
        {
            //Se encarga de ponerle los valores a actualizar en los campos de texto 
            DataRow row = man.consultarPorId(id).Rows[0];            
            dtpFecha.Text = row["fecha_prevista"].ToString();
            txtSolicita.Text = row["solicita"].ToString();            
            listEquipo.Text = row["nombre"].ToString();
        }
        private void cargarListas(String val)
        {
            //Se encarga de cargar la lista con todos los equipos o áreas locativas
            listEquipo.DataSource = man.consultar(val);
            listEquipo.DisplayMember = "nombre";
            listEquipo.ValueMember = "codigo";
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            //Se valida que los campos no estén vacíos, de no estarlo se actualiza el registro del mantenimiento
            if (dtpFecha.Value.ToString() == "" || txtSolicita.Text == "")
            {
                MessageBox.Show("Los campos marcados con (*) son obligatorios", "Revisar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    String fecha = dtpFecha.Value.Year + "-" + dtpFecha.Value.Month + "-" + dtpFecha.Value.Day + "T18:00:00";
                    man.agarrarDatos(listEquipo.SelectedValue.ToString(), "3", fecha, txtSolicita.Text, false);
                    man.actualizar(id);
                    m.cargarTabla("");
                    m.cargarHoras();
                    Hide();
                }
                catch (Exception)
                {
                    MessageBox.Show("Ocurrió un error al actualizar el plan de mantenimiento", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);                       
                }               
            }
        }

        private void txtBusEqui_KeyUp(object sender, KeyEventArgs e)
        {
            String val = txtBusEqui.Text;
            cargarListas(val);
        }
    }
}
