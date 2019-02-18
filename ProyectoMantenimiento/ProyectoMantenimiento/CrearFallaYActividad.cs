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
    public partial class Falla_Actividad : Form
    {
        ActividadYFallo ayf;
        public String codA = "", descA = "", tipo = "", codF = "", descF = "";
        public Falla_Actividad()
        {
            InitializeComponent();
            ayf = new ActividadYFallo();
            cargarTablaFallos("");
            cargarTablaActividad("");
            dgActividades.RowHeadersVisible = false;
            dgFallas.RowHeadersVisible = false;
            btnEditActividades.Enabled = false;
            btnEditFallas.Enabled = false;
            btnEditFallas.BackColor = Color.LightGray;
            btnEditActividades.BackColor = Color.LightGray;
        }
        public void cargarTablaFallos(String val)
        {
            dgFallas.DataSource = ayf.cargarTablaFallo(val);
        }
        public void cargarTablaActividad(String val)
        {
            dgActividades.DataSource = ayf.cargarTablaActividad(val);
        }

        private void cboTipo_SelectionChangeCommitted(object sender, EventArgs e)
        {
            String tipo = cboTipo.Text;
            cargarTablaFallos(tipo);
        }

        private void btnAddFallas_Click(object sender, EventArgs e)
        {
            new Fallo(this).ShowDialog();
        }

        private void btnEditFallas_Click(object sender, EventArgs e)
        {
            new EditarFallo(this).ShowDialog();
        }

        private void dgActividades_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                codA = dgActividades[0, e.RowIndex].Value.ToString();
                descA = dgActividades[1, e.RowIndex].Value.ToString();            
                btnEditActividades.Enabled = true;
                btnEditActividades.BackColor = Color.Green;
            }
            catch (Exception)
            {
                MessageBox.Show("Elige un campo válido", "Revisar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnEditActividades_Click(object sender, EventArgs e)
        {
            new EditarActividad(this).ShowDialog();
        }

        private void btnAddActividades_Click(object sender, EventArgs e)
        {
            new Actividad(this).ShowDialog();
        }

        private void dgFallas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                codF = dgFallas[0, e.RowIndex].Value.ToString();
                descF = dgFallas[1, e.RowIndex].Value.ToString();
                tipo = dgFallas[2, e.RowIndex].Value.ToString();
                btnEditFallas.Enabled = true;
                btnEditFallas.BackColor = Color.Green;
            }
            catch (Exception)
            {
                MessageBox.Show("Elige un campo válido", "Revisar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
