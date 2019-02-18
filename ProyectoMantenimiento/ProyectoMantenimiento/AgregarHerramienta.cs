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
    public partial class AgregarHerramienta : Form
    {
        //Se declaran las variables de las clases Herramienta, Inventario y de la ventana Herramientas
        HerramientaClass h;
        InventarioClass i;
        Herramientas he;
        public AgregarHerramienta(Herramientas ha)
        {
            InitializeComponent();
            //Se instancian las variables declaradas anteriormente
            he = ha;
            i = new InventarioClass();
            h = new HerramientaClass();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Se valida que los campos no estén vacíos; de no estarlo, se llaman métodos de la clase Herramienta e Inventario, que lo que hacen
            // es asignar los valores de los campos a laas variables de la clase para después insertar los datos en la base de datos.
            // Después se carga la tabla con las nuevas herramientas creadas y se oculta esta ventana de AgregarHerramienta
            if (txtName.Text == "" || txtPosi.Text == "" || numCant.Value == 0 ||numMin.Value == 0)
            {
                MessageBox.Show("Los campos marcador por (*) son obligatorios", "Llenar los campos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                /*try
                {*/
                
                    int cantidad = int.Parse(numCant.Value.ToString());
                    int minimo = int.Parse(numMin.Value.ToString());
                    h.AsignarDatos(txtName.Text, txtPosi.Text, minimo);
                    h.InsertarHerramienta();
                    String id = h.TraerUltimo();
                    i.AsignarValores(cantidad, txtDesc.Text, id, null, null);
                    i.InsertarInventarioH();             
                    he.cargarCantidad("");
                    Hide();
                /*}
                catch (Exception)
                {
                    MessageBox.Show("No se pudo insertar la herramienta correctamente. Probablemente el código ya existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }*/
            }
            
        }
    }
}
