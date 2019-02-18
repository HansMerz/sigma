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
    public partial class Trabajadores : Form
    {
        //Se declaran 3 variables, dos de tipo String y una de la clase Persona
        PersonaClass pc;
        String id;
        String nombre;
        public Trabajadores()
        {
            //Se instancian las variables y se llama a los métodos de cargarTabla y de inhabilitar
            pc = new PersonaClass();
            InitializeComponent();
            dataGridView1.RowHeadersVisible = false;
            cargarTabla("");
            inhabilitar();
            id = "";
        }
        private void inhabilitar()
        {
            //Se deshabilita los botones de editar y eliminar
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;            

            btnEdit.BackColor = Color.LightGray;
            btnDelete.BackColor = Color.LightGray;            
        }
        private void habilitar()
        {
            //Se habilita los botones de editar y eliminar
            btnEdit.Enabled = true;
            //btnDelete.Enabled = true;            

            btnEdit.BackColor = Color.DarkGreen;
            //btnDelete.BackColor = Color.Red;            
        }
        public void cargarTabla(String val)
        {
            //Se carga la tabla con todas las personas
            dataGridView1.DataSource = pc.CargarTabla(val);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Se muestra la ventana para AgregarTrabajador
            Hide();
            new AgregarTrabajador(this).ShowDialog();
            Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Se muestra la ventana para EditarTrabajador
            Hide();
            new EditarTrabajador(this, id).ShowDialog();
            Show();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Se recoge el id y nombre de la persona seleccionada, también se carga el método habilitar
            int ult = dataGridView1.Rows.Count;
            if (e.RowIndex >= 0 && e.RowIndex < ult)
            {
                habilitar();
                id = dataGridView1[0, e.RowIndex].Value.ToString();
                nombre = dataGridView1[1, e.RowIndex].Value.ToString();
            }
            else
            {
                inhabilitar();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //Se elimina el trabajador seleccionado, dependiendo si se acepta dicha operación
            DialogResult result;
            result = MessageBox.Show("¿Desea eliminar el trabajador: "+ nombre+"?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                pc.Eliminar(id);
                cargarTabla("");
            }            
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            String valor = textBox1.Text;
            cargarTabla(valor);
        }
    }
}
