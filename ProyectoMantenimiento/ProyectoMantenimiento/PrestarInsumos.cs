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
    public partial class PrestarInsumos : Form
    {
        //Se declaran 10 variables, dos de tipo int, tres de tipo String, una de la clase Persona, otra de la clase Prestar, otra
        //de la clase Persona, otra de la clase Inventario, otra de la clase Insumos, otra de la ventana Insumos
        InsumosClass ic;
        Insumos i;
        InventarioClass inv;
        PersonaClass p;
        PrestarClass pre;
        String id;
        String stock;        
        int operacion;
        int indice;
        public PrestarInsumos(Insumos i)
        {
            //Se instancian las variables y se carga el método cargarListas
            InitializeComponent();
            ic = new InsumosClass();
            this.i = i;
            inv = new InventarioClass();
            p = new PersonaClass();
            pre = new PrestarClass();
            dgTable.RowHeadersVisible = false;
            cargarLista1("");
            cargarLista2("");
            btnQuitar.Enabled = false;
        }
        private void cargarLista1(String val)
        {
            //Se cargan todas las personas y todos los insumos
            listPer.DataSource = p.Consultar(val);
            listPer.DisplayMember = "nombres";
            listPer.ValueMember = "id";            
        }
        private void cargarLista2(String val)
        {
            listIns.DataSource = ic.ConsultarTodo(val);
            listIns.DisplayMember = "nombre";
            listIns.ValueMember = "id";
        }

        private void btnPres_Click(object sender, EventArgs e)
        {
            //Se prestan los insumos a las personas establecidas
            if (dgTable.Rows.Count <= 0)
            {
                MessageBox.Show("No hay insumos para prestar", "Revisar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                int result = 0;

                for (int j = 0; j < dgTable.Rows.Count; j++)
                {
                    pre.AsignarDatos(dgTable[0, j].Value.ToString(), dgTable[3, j].Value.ToString(), dgTable[2, j].Value.ToString());
                    result += pre.InsertarInsumo();
                }
                if (result == dgTable.Rows.Count)
                {
                    MessageBox.Show("Insumos prestados exitosamente", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Los insumos no fueron prestados con éxito", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                i.cargarCantidad("");
                Hide();
            }            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //Se agregan el insumo con la cantidad y la persona seleccionada
            if (operacion == numCant.Maximum)
            {
                numCant.Enabled = false;
            }
            else
            {
                numCant.Enabled = true;
            }
            if (numCant.Value == 0)
            {
                MessageBox.Show("La cantidad no puede ser 0", "Revisar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                btnQuitar.Enabled = true;
                dgTable.Rows.Add(listIns.SelectedValue.ToString(), listIns.Text, numCant.Value, listPer.SelectedValue.ToString(), listPer.Text);
                numCant.Value = 0;
            }
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            //Se quita el registro seleccionado
            if (dgTable.Rows.Count == 0)
            {
                btnQuitar.Enabled = false;
            }
            else
            {
                dgTable.Rows.RemoveAt(dgTable.CurrentRow.Index);
            }
            numCant.Enabled = true;
            indice = 0;
        }

        private void dgTable_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
  
        }

        private void listIns_Click(object sender, EventArgs e)
        {
            //Se escoge el insumo y se le pone el valor máximo que puede tener ese insumo
            indice = 0;
            numCant.Value = 0;
            for (int i = 0; i < dgTable.Rows.Count; i++)
            {
                id = dgTable[0, i].Value.ToString();
                if (id == listIns.SelectedValue.ToString())
                {
                    indice += int.Parse(dgTable[2, i].Value.ToString());
                }
            }
            DataRow row = inv.TraerCantidadIn(listIns.SelectedValue.ToString()).Rows[0];
            stock = row["CantidadStock"].ToString();
            operacion = int.Parse(stock) - indice;
            numCant.Maximum = operacion;
            if (numCant.Maximum == 0)
            {
                numCant.Enabled = false;
            }
            else
            {
                numCant.Enabled = true;
            }
            numCant.Value = 0;
        }

        private void txtBus1_KeyUp(object sender, KeyEventArgs e)
        {
            String val = txtBus1.Text;
            cargarLista2(val);
        }

        private void txtBus2_KeyUp(object sender, KeyEventArgs e)
        {
            String val = txtBus2.Text;
            cargarLista1(val);
        }
    }
}
