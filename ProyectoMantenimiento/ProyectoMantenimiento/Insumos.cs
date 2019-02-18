using CrystalDecisions.CrystalReports.Engine;
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
    public partial class Insumos : Form
    { 
        //Se declaran dos variables de tipo String, otra de la clase Insumos, otra de la clase Inventario y otra de la ventana Login
        InsumosClass ic;
        InventarioClass inv;
        String id;
        String name;
        Login l;
        public Insumos(Login l)
        {
            //Se instancian las variables y se carga el método de cargarTabla y cargarCantidad
            InitializeComponent();
            ic = new InsumosClass();
            inv = new InventarioClass();
            this.l = l;
            inhabilitar();            
            privilegios();
            dataGridView1.RowHeadersVisible = false;
            cargarCantidad("");
        }

        private void habilitar()
        {
            //Se habilitan los botones de Editar, de Gestionar y se le ponen los colores originales
            btnEdit.Enabled = true;
            //btnDelete.Enabled = true;
            btnGestionar.Enabled = true;

            btnEdit.BackColor = Color.DarkGreen;
            //btnDelete.BackColor = Color.Red;
            btnGestionar.BackColor = Color.DarkOrange;
            privilegios();
        }
        private void inhabilitar()
        {
            //Se inhabilitan los botones de Editar, de Gestionar y Eliminar, se le ponen grises
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
            btnGestionar.Enabled = false;

            btnEdit.BackColor = Color.LightGray;
            btnDelete.BackColor = Color.LightGray;
            btnGestionar.BackColor = Color.LightGray;
            privilegios();
        }
        public void privilegios()
        {
            if (l.tipo == "Adecuaciones")
            {
                btnAdd.Enabled = false;
                btnAdd.BackColor = Color.LightGray;
                btnGestionar.Enabled = false;
                btnGestionar.BackColor = Color.LightGray;
                btnEdit.Enabled = false;
                btnEdit.BackColor = Color.LightGray;
                btnPres.Enabled = false;
                btnPres.BackColor = Color.LightGray;
            }
        }
        public void cargarCantidad(String val)
        {
            //Se carga la tabla con las cantidades de insumos dependiendo de la herramienta
            dataGridView1.Rows.Clear();
            ic.CargarTabla(dataGridView1, val);
            ic.CargarCantidad(dataGridView1);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Se carga el método de habilitar y se recoge el nombre y id del insumos seleccionado
            int ult = dataGridView1.Rows.Count;
            if (e.RowIndex >= 0 && e.RowIndex < ult)
            {
                habilitar();
                id = dataGridView1[0, e.RowIndex].Value.ToString();
                name = dataGridView1[1, e.RowIndex].Value.ToString();
            }
            else
            {
                inhabilitar();                
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //Se abre la ventana para crear Insumo
            Hide();
            new CrearInsumo(this).ShowDialog();
            Show();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            //Se abre la ventana de editar Insumo
            Hide();
            new EditarInsumo(this, id).ShowDialog();
            Show();
        }

        private void btnGestionar_Click(object sender, EventArgs e)
        {
            //Se abre la ventana de Inventario
            Hide();
            new InventarioIns(this, id).ShowDialog();
            Show();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //Se muestra mensaje para eliminar el insumo seleccionado, de darle sí, el insumo se elimina de la base de datos 
            DialogResult res;
            res = MessageBox.Show("¿Está seguro de eliminar de manera permanente el insumo: " + name + "?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            if (res == DialogResult.Yes)
            {
                inv.EliminarInventarioH(id);
                ic.EliminarInsumo(id);
                cargarCantidad("");
            }
        }

        private void btnDevuelven_Click(object sender, EventArgs e)
        {
            //Se abre la ventana de Devolver los Insumos
            Hide();
            new DevolverInsumos(this, l).ShowDialog();
            Show();
        }

        private void btnPres_Click(object sender, EventArgs e)
        {
            //Se abre la ventana de Prestar los Insumos
            Hide();
            new PrestarInsumos(this).ShowDialog();
            Show();
        }

        private void txtSearch_KeyUp(object sender, KeyEventArgs e)
        {
            String val = txtSearch.Text;
            cargarCantidad(val);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*InsumosInforme ii = new InsumosInforme();
            DataSetHerramientas dsh = new DataSetHerramientas();
            int filas = dataGridView1.Rows.Count;

            for (int i = 0; i < filas; i++)
            {
                dsh.Tables[1].Rows.Add
                    (new object[]
                    {
                        dataGridView1[1,i].Value.ToString(),
                        dataGridView1[2,i].Value.ToString(),
                        dataGridView1[3,i].Value.ToString(),
                        dataGridView1[4,i].Value.ToString(),
                        dataGridView1[5,i].Value.ToString(),
                        dataGridView1[6,i].Value.ToString()
                    }
                    );
            }
            ReportDocument oRep = new ReportDocument();
            string path = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10));
            path += "\\InformeInsumos.rpt";
            oRep.Load(path);            
            oRep.SetDataSource(dsh);
            ii.crystalReportViewer1.ReportSource = oRep;
            ii.Show();*/
            InformeInsumosInventario iii = new InformeInsumosInventario();
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                InventarioInsumos ii = new InventarioInsumos();
                ii.cod = dataGridView1[0, i].Value.ToString();
                ii.numref = dataGridView1[1, i].Value.ToString();
                ii.nombre = dataGridView1[2, i].Value.ToString();
                ii.marca = dataGridView1[3, i].Value.ToString();
                ii.posicion = dataGridView1[4, i].Value.ToString();
                ii.precio = dataGridView1[5, i].Value.ToString();
                ii.cantidad = dataGridView1[6, i].Value.ToString();
                iii.ii.Add(ii);
            }
            iii.Show();
        }
    }
}
