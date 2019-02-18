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
    public partial class CrearGrupoEquipos : Form
    {
        GrupoClass gc;
        Grupos g;
        public CrearGrupoEquipos(Grupos g)
        {
            InitializeComponent();
            gc = new GrupoClass();
            this.g = g;        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "")
            {
                MessageBox.Show("El nombre es obligatorio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    gc.agarrarDatos(txtNombre.Text);
                    gc.insertar();
                    g.cargarTabla("");
                    Hide();
                }
                catch (Exception)
                {
                    MessageBox.Show("Ocurrió un error al crear el grupo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);                    
                }
            }
        }
    }
}
