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
    public partial class EditarHerramienta : Form
    {
        //Se declaran las variables de tipo DataRow, y String, también las clases Herramienta e Inventario
        DataRow row;
        HerramientaClass h;
        InventarioClass i;
        String id;
        Herramientas he;
        public EditarHerramienta(Herramientas he, String id)
        {
            //Se instrancian las variables mencionadas y se carga el método mostrar
            h = new HerramientaClass();
            i = new InventarioClass();
            this.id = id;
            this.he = he;
            row = h.Consultar(id).Rows[0];
            InitializeComponent();
            mostrar();
        }
        private void mostrar()
        {
            //Se muestran los datos a actualizar
            txtName.Text = row["nombre"].ToString();
            txtPosi.Text = row["pos"].ToString();
            numMin.Value = int.Parse(row["minimo"].ToString());            
            txtDesc.Text =  row["descripcion"].ToString();
        }

        private void btnAct_Click(object sender, EventArgs e)
        {
            //Se valida que los campos no estén vacíos, de no estarlos se actualiza el registro en la base de datos
            if (txtName.Text == "" || txtPosi.Text == "" || numMin.Value == 0)
            {
                MessageBox.Show("Los campos marcador por (*) son obligatorios", "Llenar los campos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {                
                    int minimo = int.Parse(numMin.Value.ToString());
                    h.AsignarDatos(txtName.Text, txtPosi.Text, minimo);
                    h.ActualizarHerramienta(id);
                    i.descripcion = txtDesc.Text;
                    i.ActualizarInventarioH(id);          
                    he.cargarCantidad("");
                    Hide();
                }
                catch (Exception)
                {
                    MessageBox.Show("Ocurrió un error al actualizar la herramienta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);                 
                }
            }
        }
    }
}
