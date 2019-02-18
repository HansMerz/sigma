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
    public partial class Actividad : Form
    {
        ActividadYFallo ayf = new ActividadYFallo();
        Falla_Actividad fa;
        Boolean valide = false;
        public Actividad(Falla_Actividad fa)
        {
            InitializeComponent();
            this.fa = fa;
            valide = true;
        }
        public Actividad()
        {
            InitializeComponent();
            valide = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtCod.Text == "" || txtDesc.Text == "")
                {
                    MessageBox.Show("Hay campos vacíos", "Revisar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    ayf.agarraActividad(txtCod.Text, txtDesc.Text);
                    int result = ayf.insertarActividad();
                    if (result > 0)
                    {
                        MessageBox.Show("Se guardó la actividad correctamente", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (valide)
                        {
                            fa.cargarTablaActividad("");
                        }                        
                        this.Dispose();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo guardar la actividad", "Revisar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrió un error al agregar la actividad. Probablemente el código ya existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
