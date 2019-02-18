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
    public partial class DevolverHerramientas : Form
    {
        dev d;
        String id;
        PrestarClass pre;
        Herramientas he;
        public DevolverHerramientas(dev d, Herramientas he)
        {
            InitializeComponent();
            pre = new PrestarClass();
            this.d = d;
            this.he = he;
            lblName.Text = d.nombre;
            lblDate.Text = d.fecha;
            lblWorker.Text = d.trabajador;
            lblQuantity.Text = d.cant;
            id = d.id;
            numCant.Maximum = int.Parse(d.cant);
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            if (int.Parse(numCant.Value.ToString()) <= 0)
            {
                MessageBox.Show("La cantidad a devolver tiene que ser mayor a 0 (cero)", "Revisar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (int.Parse(numCant.Value.ToString()) > int.Parse(lblQuantity.Text))
                {
                    MessageBox.Show("La cantidad a devolver tiene que ser menor o igual a la cantidad que tiene asignada", "Revisar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    DialogResult result;
                    result = MessageBox.Show("¿Desea devolver la herramienta?", "Devolver", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        try
                        {
                            int operacion = int.Parse(lblQuantity.Text) - int.Parse(numCant.Value.ToString());
                            pre.Actualizar(id, operacion.ToString());
                            d.cargarLista("");
                            d.cargarTabla();
                            he.cargarCantidad("");                            
                            Hide();
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Ocurrió un error al devolver la herramienta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        private void numCant_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
