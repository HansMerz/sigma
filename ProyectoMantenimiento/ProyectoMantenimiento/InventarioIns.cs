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
    public partial class InventarioIns : Form
    {
        //Se declaran 4 variables. Una de tio String, otra de la clase Inventario, una de la clase Insumos y otra de la ventana Insumos
        Insumos i;
        InventarioClass inv;
        InsumosClass ic;
        String id;        
        public InventarioIns(Insumos i, String id)
        {
            //Se instancian las variables y se llaman los métodos de mostrarValores y cargarTabla
            InitializeComponent();
            this.i = i;
            this.id = id;
            ic = new InsumosClass();
            inv = new InventarioClass();
            mostrarValores();
            dgInventario.RowHeadersVisible = false;
            cargarTabla();
        }

        private void mostrarValores()
        {
            //Se asigna el valor a las variables dependiendo del insumo seleccionado
            DataRow row = ic.Consultar(id).Rows[0];
            String row2 = ic.cargarCantidadInsumos(id);
            lblCant.Text = row2;

            label4.Text = row["nombre"].ToString();
            txtDesc.Text = row["descripcion"].ToString();
        }

        private void cargarTabla()
        {
            //Este método carga la tabla
            dgInventario.DataSource = ic.ConsultarInventario(id);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //Se valida que la cantidad no esté vacía, de no estarlo se agrega el insumo al inventario
            if (numCant.Value == 0)
            {
                MessageBox.Show("La cantidad a insertar no puede ser cero", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                inv.fecha = DateTime.Now.Year + "-" + DateTime.Now.Month + "-" + DateTime.Now.Day + "T" + DateTime.Now.ToString("hh:mm:ss");
                int cantidad = int.Parse(numCant.Value.ToString());
                inv.cantidad = cantidad;
                inv.descripcion = txtDesc.Text;
                inv.insumos_id = id;
                inv.InsertarInventarioI();
                MessageBox.Show("Se ha insertado la cantidad correctamente", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                mostrarValores();                
                i.cargarCantidad("");
                cargarTabla();
            }
        }
    }
}
