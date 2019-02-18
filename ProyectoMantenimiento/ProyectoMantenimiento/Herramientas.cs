using CrystalDecisions.CrystalReports.Engine;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoMantenimiento
{
    public partial class Herramientas : Form
    {
        //Se declaran dos variables de tipo String, una de la clase Herramienta, otra de la clase Inventario, otra de la ventana Login
        //Y se le asigna valor a 3 colores
        HerramientaClass h;
        InventarioClass i;        
        System.Drawing.Color col2 = System.Drawing.ColorTranslator.FromHtml("#E70602");
        System.Drawing.Color col3 = System.Drawing.ColorTranslator.FromHtml("#FB6F0C");
        String id;
        String name;
        Login l;       
        public Herramientas(Login l)
        {
            //Se instancian las variables mencionadas, se valida el usuario que se logueo
            //Se carga el método inhabiitar, el método de cargarTabla y el de cargarCantidad
            i = new InventarioClass();
            h = new HerramientaClass();
            this.l = l;
            InitializeComponent();            
            inhabilitar();
            dataGridView1.RowHeadersVisible = false;
            cargarCantidad("");
        }
        public void cargarCantidad(String val)
        {
            //Se carga la tabla cantidad
            dataGridView1.Rows.Clear();
            h.CargarTabla(dataGridView1, val);
            h.CargarCantidad(dataGridView1);
         
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            //Abre la ventana para agregar herramienta
            Hide();
            new AgregarHerramienta(this).ShowDialog();
            Show();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            //Abre la ventana para editar la herramienta
            Hide();
            new EditarHerramienta(this, id).ShowDialog();
            Show();    
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //Se pregunta si desea eliminar la herramienta seleccionada, en caso de aceptar, se elimina la herramienta
            DialogResult res;
            res = MessageBox.Show("¿Está seguro de eliminar de manera permanente la herramienta: "+name+"?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            if (res == DialogResult.Yes)
            {
                i.EliminarInventarioH(id);
                h.EliminarHerramienta(id);
                h.CargarTabla(dataGridView1, "");
            }            
        }

        private void btnGestionar_Click(object sender, EventArgs e)
        {
            //Se abre la ventana de Inventario y se oculta la actual
            Hide();
            new Inventario(this, id).ShowDialog();
            Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Se abre la ventana de Prestar y se oculta la actual
            Hide();
            new Prestar(this).ShowDialog();
            Show();
        }
        private void inhabilitar()
        {
            //Este método se encarga de inhabilitar los botones de Eliminar, Gestionar y Eliminar. También se les cambia el color
            //para verse desactivado
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
            btnGestionar.Enabled = false;

            btnEdit.BackColor = Color.LightGray;
            btnDelete.BackColor = Color.LightGray;
            btnGestionar.BackColor = Color.LightGray;
            privilegios();

        }
        private void habilitar()
        {
            //Este método lo que hace es habilitar los botones de Editar y Gestionar. También se les devuelve el color al actual
            btnEdit.Enabled = true;
            //btnDelete.Enabled = true;
            btnGestionar.Enabled = true;

            btnEdit.BackColor = Color.DarkGreen;
            //btnDelete.BackColor = col2;
            btnGestionar.BackColor = col3;
            privilegios();
        }
        private void privilegios()
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
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Se activan los botones si se da click a un registro de la tabla, también se le recoge el id y el nombre de la herramienta
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

        private void btnDevuelven_Click(object sender, EventArgs e)
        {
            //Abre la ventana para devolver herramientas
            Hide();
            new dev(this, l).ShowDialog();
            Show();
        }

        private void dataGridView1_Scroll(object sender, ScrollEventArgs e)
        {
            //Se pone el mismo valor a la tabla de cantidad para sincronizar sus movimientos
            
        }

        private void dgCant_Scroll(object sender, ScrollEventArgs e)
        {
            //Se pone el mismo valor a la tabla de herramientas para sincronizar sus movimientos
           
        }

        private void dgCant_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {            
        }

        private void txtSearch_KeyUp(object sender, KeyEventArgs e)
        {
            //Se buscan las herramientas mediante se pulse una tecla
            String val = txtSearch.Text;            
            cargarCantidad(val);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            /*InventarioInforme ii = new InventarioInforme();
            DataSetHerramientas dsh = new DataSetHerramientas();
            int filas = dataGridView1.Rows.Count;

            for (int i = 0; i < filas; i++)
            {
                dsh.Tables[0].Rows.Add
                    (new object[]
                    {
                        dataGridView1[0,i].Value.ToString(),
                        dataGridView1[1,i].Value.ToString(),
                        dataGridView1[2,i].Value.ToString(),
                        dataGridView1[3,i].Value.ToString(),
                        dataGridView1[4,i].Value.ToString()
                    }
                    );
            }
            ReportDocument oRep = new ReportDocument();
            string path = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10));
            path += "\\InformeInventario.rpt";            
            oRep.Load(path);
            oRep.SetDataSource(dsh);            
            ii.crystalReportViewer1.ReportSource = oRep;
            ii.Show();    */
            InformeHerramientas ih = new InformeHerramientas();
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                InventarioHerramientas inv = new InventarioHerramientas();
                inv.cod = dataGridView1[0, i].Value.ToString();
                inv.nombre = dataGridView1[1, i].Value.ToString();
                inv.posicion = dataGridView1[2, i].Value.ToString();
                inv.minimo = dataGridView1[3, i].Value.ToString();
                inv.cantidad = dataGridView1[4, i].Value.ToString();
                ih.ih.Add(inv);
            }
            ih.Show();
        }

        private void generarCódigoToolStripMenuItem_Click(object sender, EventArgs e)
        {                   
        }         

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {          
        }

        private void dataGridView1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                int position = dataGridView1.HitTest(e.X, e.Y).RowIndex;
                if(position >= 0)
                {
                    id = dataGridView1[0, position].Value.ToString();
                }                
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

        }
    }
}
