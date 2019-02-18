using MySql.Data.MySqlClient;
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
    public partial class Prestar : Form
    {
        //Se declaran 10 variables, dos de tipo Int, tres de tipo String, una de la clase Herramienta,
        //una de la ventana Herramientas, otra de la clase Inventario, Persona y Prestar
        HerramientaClass h;
        Herramientas he;
        InventarioClass i;
        PersonaClass p;
        PrestarClass pre;
        String minimoCant;
        String stock;
        String id;
        int operacion;
        int indice = 0;
        public Prestar(Herramientas he)
        {
            //Se instancian las variables mencionadas y se carga el método de cargarListas
            InitializeComponent();
            h = new HerramientaClass();
            this.he = he;
            i = new InventarioClass();
            p = new PersonaClass();
            pre = new PrestarClass();
            cargarLista1("");
            cargarLista2("");
            dgTable.RowHeadersVisible = false;
            btnQuitar.Enabled = false;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void cargarLista1(String val)
        {
            //Se carga las listas de todas las personas y todas las herramientas
            listPer.DataSource = p.Consultar(val);
            listPer.DisplayMember = "nombres";
            listPer.ValueMember = "id";                        
        }
        private void cargarLista2(String val)
        {
            listHerr.DataSource = h.ConsultarTodo(val);
            listHerr.DisplayMember = "nombre";
            listHerr.ValueMember = "id";
        }

        private void Prestar_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Se remueve el registro seleccionado de la tabla
            if (dgTable.Rows.Count == 0)
            {
                btnQuitar.Enabled = false;
            }
            else
            {
                dgTable.Rows.RemoveAt(dgTable.CurrentRow.Index);
            }
            numCant.Enabled = true;
        }

        private void listHerr_SelectedValueChanged(object sender, EventArgs e)
        {            
            
        }

        private void listHerr_Click(object sender, EventArgs e)
        {
            try
            {
            
                //Se escoge la herramienta y se le pone el valor máximo que puede tener esa herramienta
                indice = 0;
                numCant.Value = 0;
                for (int i = 0; i < dgTable.Rows.Count; i++)
                {
                    id = dgTable[0, i].Value.ToString();
                    if (id == listHerr.SelectedValue.ToString())
                    {
                        indice += int.Parse(dgTable[2, i].Value.ToString());
                    }
                }
                DataRow row = i.TraerCantidad(listHerr.SelectedValue.ToString()).Rows[0];
                DataRow minimo = h.TraerMinimo(listHerr.SelectedValue.ToString()).Rows[0];
                minimoCant = minimo["minimo"].ToString();
                stock = row["CantidadStock"].ToString();
                operacion = int.Parse(stock) - int.Parse(minimoCant) - indice;
                numCant.Maximum = operacion;                        
                if (minimoCant == stock || numCant.Maximum == 0)
                {
                    numCant.Enabled = false;
                }
                else
                {
                    numCant.Enabled = true;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("No hay herramientas", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //Se agrega la herramienta seleccionada a la tabla, junto con la cantidad establecida
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
                dgTable.Rows.Add(listHerr.SelectedValue.ToString(), listHerr.Text, numCant.Value, listPer.SelectedValue.ToString(), listPer.Text);
                numCant.Value = 0;               
            }
        }

        private void btnPres_Click(object sender, EventArgs e)
        {
            //Se registra en la base de datos la cantidad y la herramienta prestada a cierta persona
            if (dgTable.Rows.Count <= 0)
            {
                MessageBox.Show("No hay herramientas para prestar", "Revisar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                
                    int result = 0;

                    for (int i = 0; i < dgTable.Rows.Count; i++)
                    {
                        pre.AsignarDatos(dgTable[0, i].Value.ToString(), dgTable[3, i].Value.ToString(), dgTable[2, i].Value.ToString());
                        result += pre.Insertar();
                    }
                    if (result == dgTable.Rows.Count)
                    {
                        MessageBox.Show("Herramientas prestadas exitosamente", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Las herramientas no fueron prestadas con éxito", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    he.cargarCantidad("");
                    Hide();
                }
                catch (Exception)
                {
                    MessageBox.Show("Ocurrió un error al prestar las herrramientas", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);          
                }
            }            
        }

        private void numCant_ValueChanged(object sender, EventArgs e)
        {            
        }

        private void dgTable_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            
            
        }

        private void listPer_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dgTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
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
