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
    public partial class EditarInsumo : Form
    {
        // Se declaran las variables de la clase Insumos e Inventario, también una de la ventana Insumos y las variables de tipo DataRow y String
        Insumos i;
        DataRow row;
        InsumosClass ic;
        InventarioClass inve;
        String id;
        public EditarInsumo(Insumos i, String id)
        {
            //Se instancian las variables de las clases y se cargan los datos a actualizar
            InitializeComponent();
            this.i = i;
            this.id = id;
            ic = new InsumosClass();
            inve = new InventarioClass();
            row = ic.Consultar(id).Rows[0];            
            mostrar();
        }
        private void mostrar()
        {
            //Se les asigna valor a los campos de texto dependiendo del campo seleccionado
            txtName.Text = row["nombre"].ToString();
            txtMarca.Text = row["marca"].ToString();
            numPre.Value = int.Parse(row["precio"].ToString());
            txtDesc.Text = row["descripcion"].ToString();
            txtPos.Text = row["pos"].ToString();
            txtRef.Text = row["ref"].ToString();
        }

        private void btnAct_Click(object sender, EventArgs e)
        {
            //Se valida si los campos están vacíos, de no estarlo se actualiza el registro en la base de datos
            if (txtName.Text == "" || txtMarca.Text == "" || txtPos.Text == "" || numPre.Value == 0)
            {
                MessageBox.Show("Los campos marcador por (*) son obligatorios", "Llenar los campos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    int precio = int.Parse(numPre.Value.ToString());
                    ic.AsignarDatos(txtRef.Text, txtName.Text, txtMarca.Text, txtPos.Text, precio);
                    ic.ActualizarInsumo(id);
                    inve.descripcion = txtDesc.Text;
                    inve.ActualizarInventarioI(id);
                    i.cargarCantidad("");
                    Hide();
                }
                catch (Exception)
                {
                    MessageBox.Show("Ocurrió un error al actualizar el insumo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }                
            }
        }
    }
}
