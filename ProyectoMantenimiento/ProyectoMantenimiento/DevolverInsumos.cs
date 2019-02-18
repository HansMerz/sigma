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
    public partial class DevolverInsumos : Form
    {
        //Se declaran las variables de la clase prestar, la ventana de insumos y de login, además la variable de tipo String
        Insumos i;
        PrestarClass pre;
        String[] cantidad;
        public String id, nombre, cant, fecha, trabajador, numref;
        Login l;
        public DevolverInsumos(Insumos i, Login l)
        {
            InitializeComponent();
            //Se instancian las variables anteriormente mencionadas y se valida dependiendo del usuario que entre
            this.i = i;
            pre = new PrestarClass();
            this.l = l;
            cargarLista("");
            if (l.tipo == "Adecuaciones")
            {
                btnDevolver.Enabled = false;
                btnDevolver.BackColor = Color.LightGray;                
            }
            btnReturn.Enabled = false;
            btnReturn.BackColor = Color.LightGray;
            dgTable.RowHeadersVisible = false;
        }
        public void cargarLista(String val)
        {
            //Se carga la lista de los insumos prestados
            listPer.DataSource = pre.ConsultarPersonaInsumo(val);
            listPer.DisplayMember = "nombres";
            listPer.ValueMember = "id";
        }

        private void btnDevolver_Click(object sender, EventArgs e)
        {
            //Se valida que no esté vacía la tabla
            if (dgTable.Rows.Count == 0)
            {
                MessageBox.Show("No hay insumos a devolver", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //Se pregunta si desean devolver los insumos, en caso de afirmarlo, se devuelven la cantidad digitada
                DialogResult result;
                result = MessageBox.Show("¿Desea devolver los insumos?", "Devolver", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        Boolean condicion = false;                
                        for (int i = 0; i < dgTable.Rows.Count; i++)
                        {
                            if (int.Parse(cantidad[i]) >= int.Parse(dgTable[3, i].Value.ToString()))
                            {
                                int operacion = int.Parse(cantidad[i]) - int.Parse(dgTable[3, i].Value.ToString());
                                pre.ActualizarInsumo(dgTable[0, i].Value.ToString(), operacion.ToString());
                                condicion = true;
                            }                            
                            else
                            {
                                condicion = false;
                            }
                        }
                        if (condicion)
                        {
                            dgTable.DataSource = pre.ConsultarHerramientas();                            
                            i.cargarCantidad("");
                        }
                        else
                        {
                            MessageBox.Show("No se pueden devolver mayor cantidad de insumos a los que tenía prestados", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        Hide();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Ocurrió un error al devolver los insumos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            Hide();
            new DevolverInsumos2(this, i).ShowDialog();
            Show();
            btnReturn.Enabled = false;
            btnReturn.BackColor = Color.LightGray;
        }
        public void cargarTabla()
        {
            dgTable.DataSource = pre.ConsultarInsumos();
        }
        private void listPer_Click(object sender, EventArgs e)
        {
            try
            {
                //Se recoge el id de la persona seleccionada para después cargar la tabla con los insumos que se les hayan dado
                pre.idpersona = listPer.SelectedValue.ToString();
                cargarTabla();
                DataRow row = pre.ConsultarInsumos().Rows[0];
                cantidad = new String[dgTable.Rows.Count];
                for (int i = 0; i < dgTable.Rows.Count; i++)
                {
                    cantidad[i] = dgTable[3, i].Value.ToString();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Esta persona no tiene insumos asignados", "Revisar", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox1.ForeColor = Color.Black;
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            textBox1.Text = "Buscar...";
            textBox1.ForeColor = Color.Gray;
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            String val = textBox1.Text;
            cargarLista(val);
        }

        private void dgTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int ult = dgTable.Rows.Count;
            if (e.RowIndex >= 0 && e.RowIndex < ult)
            {
                if (l.tipo == "Adecuaciones")
                {
                    btnReturn.Enabled = false;
                    btnReturn.BackColor = Color.LightGray;
                }
                else
                {
                    id = dgTable[0, e.RowIndex].Value.ToString();
                    nombre = dgTable[1, e.RowIndex].Value.ToString();
                    numref = dgTable[2, e.RowIndex].Value.ToString(); 
                    cant = dgTable[3, e.RowIndex].Value.ToString();
                    fecha = dgTable[4, e.RowIndex].Value.ToString();
                    trabajador = listPer.Text;
                    btnReturn.Enabled = true;
                    btnReturn.BackColor = Color.Navy;
                }
            }
            else
            {
                btnReturn.Enabled = false;
                btnReturn.BackColor = Color.LightGray;
            }
        }
    }
}
