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
    public partial class DevolverInsumos2 : Form
    {
        DevolverInsumos di;
        Insumos i;
        PrestarClass pre;
        String id;
        public DevolverInsumos2(DevolverInsumos di, Insumos i)
        {
            InitializeComponent();
            this.di = di;
            this.i = i;            
            pre = new PrestarClass();            
            lblName.Text = di.nombre;
            lblDate.Text = di.fecha;
            lblWorker.Text = di.trabajador;
            lblQuantity.Text = di.cant;
            lblNumRef.Text = di.numref;
            id = di.id;
            numCant.Maximum = int.Parse(di.cant);
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
                    result = MessageBox.Show("¿Desea devolver el insumo?", "Devolver", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        try
                        {
                            int operacion = int.Parse(lblQuantity.Text) - int.Parse(numCant.Value.ToString());
                            pre.ActualizarInsumo(id, operacion.ToString());
                            di.cargarLista("");
                            di.cargarTabla();                            
                            i.cargarCantidad("");
                            Hide();
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Ocurrió un error al devolver el insumo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }
    }
}
