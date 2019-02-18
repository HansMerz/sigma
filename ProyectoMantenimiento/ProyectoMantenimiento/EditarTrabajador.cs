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
    public partial class EditarTrabajador : Form
    {
        //Se declaran variables, una de la clase Persona, otra de tipo String y la última de la ventana Trabajadores
        Trabajadores t;
        PersonaClass p;
        String id;
        public EditarTrabajador(Trabajadores t, String id)
        {
            //Se instancian las variables mencionadas y además se carga el método MostrarDatos
            InitializeComponent();
            this.t = t;
            p = new PersonaClass();
            this.id = id;
            MostrarDatos();
        }
        public void MostrarDatos()
        {
            // Este método es el encargado de cargar la información del trabajador a actualizar
            DataRow row = p.CargarDatos(id).Rows[0];
            txtName.Text = row["nombres"].ToString();
            txtCc.Text = row["cc"].ToString();
            txtPuesto.Text = row["puesto"].ToString();
        }
        private void btnAct_Click(object sender, EventArgs e)
        {
            //Se valida que los campos no estén vacíos, de no estarlo se actualiza la información del trabajador
            if (txtName.Text == "")
            {
                MessageBox.Show("Los campos marcados con (*) son obligatorios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                    p.Actualizar(id);
                    t.cargarTabla("");
                    Hide();
                }
                catch (Exception)
                {
                    MessageBox.Show("Ocurrió un error al actualizar el trabajador", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);                    
                }                
            }
        }
    }
}
