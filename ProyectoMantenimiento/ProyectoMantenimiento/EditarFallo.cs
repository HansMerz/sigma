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
    public partial class EditarFallo : Form
    {
        ActividadYFallo ayf;
        Falla_Actividad fa;
        public EditarFallo(Falla_Actividad fa)
        {
            InitializeComponent();
            ayf = new ActividadYFallo();
            this.fa = fa;
            asigarDatos();
        }
        public void asigarDatos()
        {
            txtCod.Text = fa.codF;
            txtDesc.Text = fa.descF;
            cboTipo.Text = fa.tipo;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtCod.Text == "" || txtDesc.Text == "" || cboTipo.Text == "")
                {
                    MessageBox.Show("Hay campos vacíos", "Revisar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    ayf.agarraFallo(txtCod.Text, txtDesc.Text, cboTipo.Text);               
                    int result = ayf.actualizarFallo();
                    if (result > 0)
                    {
                        MessageBox.Show("Se actualizó el fallo correctamente", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        fa.cargarTablaFallos("");
                        this.Dispose();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo aztualizar el fallo", "Revisar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrió un error al aztualizar el fallo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtDesc_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCod_TextChanged(object sender, EventArgs e)
        {

        }

        private void cboTipo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
