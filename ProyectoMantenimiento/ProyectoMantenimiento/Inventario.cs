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
    public partial class Inventario : Form
    {
        //Se declaran 4 variables, una de tipo String, otra de la clase Inventario, otra de la clase Herramienta y otra de la ventana Herramientas
        InventarioClass i;
        HerramientaClass h;
        String id;
        Herramientas he;
        public Inventario(Herramientas he, String id)
        {
            //Se instancian las variables mencionadas, se llama al método mostrarValores y cargarTabla()
            InitializeComponent();
            this.id = id;
            h = new HerramientaClass();
            i = new InventarioClass();
            this.he = he;
            dgInventario.RowHeadersVisible = false;
            mostrarValores();
            cargarTabla();
        }

        private void mostrarValores()
        {
            //Este método lo que hace es establecer los valores traídos de la base de datos
            DataRow row = h.Consultar(id).Rows[0];
            DataRow row2 = i.TraerCantidad(id).Rows[0];
            lblCant.Text = row2["CantidadStock"].ToString();

            label4.Text = row["nombre"].ToString();
            txtDesc.Text = row["descripcion"].ToString();
        }

        private void cargarTabla()
        {
            //Este método carga la tabla 
            dgInventario.DataSource = h.ConsultarInventario(id);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //Se valida que la cantidad a insertar en el inventario no sea cero, de no serlo, se inserta en la base de datos la cantidad
            //de herramientas que entraron de ese tipo
            if (numCant.Value == 0)
            {
                MessageBox.Show("La cantidad a insertar no puede ser 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                i.fecha = DateTime.Now.Year + "-" + DateTime.Now.Month + "-" + DateTime.Now.Day + "T" + DateTime.Now.ToString("hh:mm:ss");
                int cantidad = int.Parse(numCant.Value.ToString());
                i.cantidad = cantidad;
                i.descripcion = txtDesc.Text;
                i.herramientas_id = id;
                i.InsertarInventarioH();
                MessageBox.Show("Se ha agregado a inventario correctamente", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                mostrarValores();              
                he.cargarCantidad("");
                cargarTabla();
                numCant.Value = 0;
            }            
        }
    }
}
