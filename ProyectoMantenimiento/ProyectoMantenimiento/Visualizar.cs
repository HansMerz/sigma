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
    public partial class Visualizar : Form
    {
        EquipoDAL ed;
        public Visualizar()
        {
            InitializeComponent();
            dataGridView1.RowHeadersVisible = false;
            ed = new EquipoDAL();
            cargarTabla();
            cargarCombo();
        }

        public void cargarTabla()
        {            
            dataGridView1.DataSource = ed.cargarTablaTodos();
            txtCantidad.Text = dataGridView1.Rows.Count.ToString();
        }
        public void cargarTablaAreas()
        {            
            dataGridView1.DataSource = ed.cargarTablaAreas();
            txtCantidad.Text = dataGridView1.Rows.Count.ToString();
        }
        public void cargarTablaEquipos()
        {            
            dataGridView1.DataSource = ed.cargarTablaEquipos();
            txtCantidad.Text = dataGridView1.Rows.Count.ToString();
        }
        public void cargarCombo()
        {
            cboGroups.DataSource = ed.cargarGrupos();
            cboGroups.DisplayMember = "nombre";
            cboGroups.ValueMember = "id";
            txtCantidad.Text = dataGridView1.Rows.Count.ToString();
        }
        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Áreas Locativas")
            {                
                cargarTablaAreas();
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;                
            }
            else if (comboBox1.Text == "Equipos")
            {                
                cargarTablaEquipos();
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;                
            }
            else if (comboBox1.Text == "Todo")
            {                
                cargarTabla();
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;                
            }
        }

        private void cboGroups_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtSearch.Text = "";
            String value = cboGroups.SelectedValue.ToString();
            dataGridView1.DataSource = ed.FiltrarPorGrupo(value);
            txtCantidad.Text = dataGridView1.Rows.Count.ToString();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
            String val = txtSearch.Text;
            dataGridView1.DataSource = ed.FiltrarPorCodigoNombre(val);
            txtCantidad.Text = dataGridView1.Rows.Count.ToString();
        }
    }
}
