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
    public partial class Grupos : Form
    {
        GrupoClass gc;
        public String id, nombre;
        public Grupos()
        {
            InitializeComponent();
            gc = new GrupoClass();
            cargarTabla("");
            dataGridView1.RowHeadersVisible = false;
            deshabilitarBotones();
        }
        private void deshabilitarBotones()
        {
            /*btnBorrar.BackColor = Color.LightGray;
            btnBorrar.Enabled = false;*/

            btnEditar.BackColor = Color.LightGray;
            btnEditar.Enabled = false;

            btnCarac.BackColor = Color.LightGray;
            btnCarac.Enabled = false;
        }
        private void habilitarBotones()
        {
            /*btnBorrar.BackColor = Color.LightGray;
            btnBorrar.Enabled = false;*/

            btnEditar.BackColor = Color.DarkGreen;
            btnEditar.Enabled = true;

            btnCarac.BackColor = Color.Black;
            btnCarac.Enabled = true;
        }
        public void cargarTabla(String val)
        {
            dataGridView1.DataSource = gc.cargarTabla(val);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            new EditarGrupoEquipos(this).ShowDialog();
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            textBox1.ForeColor = Color.Black;
            textBox1.Text = "";
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            textBox1.ForeColor = Color.Gray;
            textBox1.Text = "Buscar...";
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            String val = textBox1.Text;
            cargarTabla(val);
        }

        private void btnCarac_Click(object sender, EventArgs e)
        {
            new AsignarCaracteristica(this).ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new CrearGrupoEquipos(this).ShowDialog();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int ult = dataGridView1.Rows.Count;
            if (e.RowIndex >= 0 && e.RowIndex < ult)
            {
                id = dataGridView1[0, e.RowIndex].Value.ToString();
                nombre = dataGridView1[1, e.RowIndex].Value.ToString();                

                habilitarBotones();
            }
            else
            {
                deshabilitarBotones();
            }
        }
    }
}
