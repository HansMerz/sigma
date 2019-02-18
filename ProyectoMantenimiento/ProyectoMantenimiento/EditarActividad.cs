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
    public partial class EditarActividad : Form
    {
        ActividadYFallo ayf;
        Falla_Actividad fa;
        public EditarActividad(Falla_Actividad fa)
        {
            InitializeComponent();
            ayf = new ActividadYFallo();
            this.fa = fa;
            asignarDatos();
        }
        public void asignarDatos()
        {
            txtCod.Text = fa.codA;
            txtDesc.Text = fa.descA;
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
                    int result = ayf.actualizarActividad();
                    if (result > 0)
                    {
                        MessageBox.Show("Se actualizó la actividad correctamente", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        fa.cargarTablaActividad("");
                        this.Dispose();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo aztualizar la actividad", "Revisar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrió un error al aztualizar la actividad.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
