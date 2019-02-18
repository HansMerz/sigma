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
    public partial class AgregarTrabajador : Form
    {
        // Se declaran variables de la clase Persona y Trabajadores
        PersonaClass p;
        Trabajadores t;
        public AgregarTrabajador(Trabajadores t)
        {           
            InitializeComponent();
            // Se instancian ambas clases
            p = new PersonaClass();
            this.t = t;
        }

        private void button1_Click(object sender, EventArgs e)
        {            
            // Se validan que los campos no estén vacíos, de no estarlo se guarda el valor de los campos en las variables de las dos clases para después 
            // insentarlos en la base de datos.
            // Luego se carga la tabla de Trabajadores con los datos del nuevo trabajador agregado. Después se oculta la ventana de Agregar Trabajador
            if (txtName.Text == "")
            {
                MessageBox.Show("Los campos marcados con (*) son obligatorios", "Revisar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    String cc = txtCc.Value.ToString();
                    if (int.Parse(cc) == 0)
                    {
                        cc = null;
                    }
                    p.AgarrarDatos(txtName.Text, cc, txtPuesto.Text);
                    p.Insertar();
                    t.cargarTabla("");
                    Hide();
                }
                catch (Exception)
                {
                    MessageBox.Show("No se pudo insertar el trabajador correctamente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
