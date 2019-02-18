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
    public partial class dev : Form
    {
        //Se declaran variables de la clase Prestar, de la ventana Herramientas, de la ventana Login y un arreglo de String 
        Herramientas he;
        PrestarClass pre;
        String[] cantidad;
        public String id, nombre, cant, fecha, trabajador;
        Login l;
        public dev(Herramientas he, Login l)
        {            
            InitializeComponent();
            //Se instancia la variable de la ventana herramienta, de la clase prestar, y de la ventana Login. Además, se carga el método
            //que llena la lista. Después se valida el usuario que ha ingresado para aplicarle privilegios
            this.he = he;
            pre = new PrestarClass();
            this.l = l;
            dgTable.RowHeadersVisible = false;
            cargarLista("");
            if (l.tipo == "Adecuaciones")
            {
                btnDevolver.Enabled = false;
                btnDevolver.BackColor = Color.LightGray;
            }
            btnReturn.Enabled = false;
            btnReturn.BackColor = Color.LightGray;
        }
        //Se carga la lista de personas que tienen herramientas prestadas
        public void cargarLista(String val)
        {
            listPer.DataSource = pre.ConsultarPersona(val);
            listPer.DisplayMember = "nombres";
            listPer.ValueMember = "id";
        }
        public void cargarTabla()
        {
            dgTable.DataSource = pre.ConsultarHerramientas();
        }
        private void listPer_Click(object sender, EventArgs e)
        {
            try
            {
                //Se obtiene el id de la persona seleccionada, con ese id cargamos las herramientas que tiene asignadas y se cargará la tabla
                //con la cantidad y nombre de herramientas que tenga
                pre.idpersona = listPer.SelectedValue.ToString();
                cargarTabla();
                DataRow row = pre.ConsultarHerramientas().Rows[0];
                cantidad = new String[dgTable.Rows.Count];
                for (int i = 0; i < dgTable.Rows.Count; i++)
                {
                    cantidad[i] = dgTable[2, i].Value.ToString();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Esta persona no tiene herramientas asignadas", "Revisar", MessageBoxButtons.OK, MessageBoxIcon.Question);                                    
            }

        }

        private void btnDevolver_Click(object sender, EventArgs e)
        {
            //Se actualiza las herramientas que devolvió la persona
            if (dgTable.Rows.Count == 0)
            {
                MessageBox.Show("No hay herramientas a devolver", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //Si la persona responde "Sí", la cantidad de herramientas que se hayan seleccionado en la columna "cantidad", son devueltas
                DialogResult result;
                result = MessageBox.Show("¿Desea devolver las herramientas?", "Devolver", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        Boolean condicion = false; ;
                        for (int i = 0; i < dgTable.Rows.Count; i++)
                        {
                            if (int.Parse(cantidad[i]) >= int.Parse(dgTable[2, i].Value.ToString()))
                            {
                                int operacion = int.Parse(cantidad[i]) - int.Parse(dgTable[2, i].Value.ToString());
                                pre.Actualizar(dgTable[0, i].Value.ToString(), operacion.ToString());
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
                            he.cargarCantidad("");
                        }
                        else
                        {
                            MessageBox.Show("No se pueden devolver mayor cantidad de herramientas a las que tenía prestadas", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        Hide();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Ocurrió un error al devolver las herramientas", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);                        
                    }
                }
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

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            new DevolverHerramientas(this, he).ShowDialog();
            Show();
            btnReturn.Enabled = false;
            btnReturn.BackColor = Color.LightGray;
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
                    cant = dgTable[2, e.RowIndex].Value.ToString();
                    fecha = dgTable[3, e.RowIndex].Value.ToString();
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
