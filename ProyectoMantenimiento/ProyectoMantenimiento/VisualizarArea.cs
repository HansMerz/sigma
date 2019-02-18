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
    public partial class VisualizarArea : Form
    {
        Area_localizacion al;
        public VisualizarArea()
        {
            InitializeComponent();
            al = new Area_localizacion();
            dataGridView1.RowHeadersVisible = false;
            cargarTabla("");
        }

        public void cargarTabla(String val)
        {
            dataGridView1.DataSource = al.cargarTabla(val);
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            String val = textBox1.Text;
            cargarTabla(val);
        }
    }
}
