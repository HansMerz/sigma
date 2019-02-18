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
    public partial class Fallo : Form
    {
        ActividadYFallo ayf = new ActividadYFallo();
        Falla_Actividad fa;
        Boolean valide = false;
        public Fallo(Falla_Actividad fa)
        {
            InitializeComponent();
            this.fa = fa;
            valide = true;
        }
        public Fallo()
        {
            InitializeComponent();
            valide = false;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Dispose();
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
                    int result = ayf.insertarFallo();
                    if (result > 0)
                    {
                        MessageBox.Show("Se guardó el fallo correctamente", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (valide)
                        {
                            fa.cargarTablaFallos("");
                        }                        
                        this.Dispose();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo guardar el fallo", "Revisar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrió un error al agregar el fallo. Probablemente el código ya existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
