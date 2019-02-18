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
    public partial class CrearCaracteristica : Form
    {
        AsignarCaracteristica ac;
        public CrearCaracteristica(AsignarCaracteristica ac)
        {
            InitializeComponent();
            this.ac = ac;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtProceso.Text == "" || comboBox1.Text == "")
            {
                MessageBox.Show("Los campos no pueden estar vacíos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                GrupoClass gc = new GrupoClass();
                gc.insertarCaracteristica(txtProceso.Text, comboBox1.Text);
                txtProceso.Text = "";
                comboBox1.Text = "";
                ac.cargarTabla("");
            }
        }
    }
}
