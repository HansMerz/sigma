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
    public partial class CrearInsumo : Form
    {
        InsumosClass ic;
        InventarioClass inv;
        Insumos i;
        public CrearInsumo(Insumos i)
        {
            InitializeComponent();
            ic = new InsumosClass();
            inv = new InventarioClass();
            this.i = i;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtRef.Text == "" || txtName.Text == "" || txtMarca.Text == "" || txtPos.Text == "" || numCant.Value == 0 || numPre.Value == 0)
            {
                MessageBox.Show("Los campos marcados con (*) son obligatorios", "Revisar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {                
                    int cantidad = int.Parse(numCant.Value.ToString());
                    int precio = int.Parse(numPre.Value.ToString());
                    ic.AsignarDatos(txtRef.Text, txtName.Text, txtMarca.Text, txtPos.Text, precio);
                    ic.InsertarInsumo();
                    String row = ic.TraerUltimo();
                    inv.AsignarValores(cantidad, txtDesc.Text, null, null, row);
                    inv.InsertarInventarioI();                
                    i.cargarCantidad("");
                    Hide();
                }
                catch (Exception)
                {
                    MessageBox.Show("El insumo no se agregó correctamente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);                 
                }
            }
        }

    }
}
