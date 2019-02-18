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
    public partial class AsignarCaracteristica : Form
    {
        Grupos g;
        GrupoClass gc;
        String id, name, tipo, idGrupo, idCarac;
        public AsignarCaracteristica(Grupos g)
        {
            InitializeComponent();
            this.g = g;
            idGrupo = g.id;
            gc = new GrupoClass();
            cargarTabla("");
            cargarTabla2("");
            cargarDatos();
            dataGridView1.RowHeadersVisible = false;
            dataGridView2.RowHeadersVisible = false;
            dataGridView3.RowHeadersVisible = false;
            btnDelete.Enabled = false;
            btnDelete.BackColor = Color.LightGray;
        }
        private void cargarDatos()
        {            
            lblGrupo.Text = g.nombre;
        }
        public void cargarTabla(String val)
        {
            MySqlDataReader row = gc.cargarTablaCarac(val);
            dataGridView2.Rows.Clear();
            while (row.Read())
            {
                dataGridView2.Rows.Add(row.GetString(0), row.GetString(1), row.GetString(2));
            }
        }
        private void cargarTabla2(String val)
        {
            MySqlDataReader row = gc.cargarTablaGruCar(val, idGrupo);
            dataGridView3.Rows.Clear();
            while (row.Read())
            {
                dataGridView3.Rows.Add(row["id"].ToString(), row["descripcion"].ToString(), row["tipo"].ToString());
            }                                      
        }
        private void textBox1_Enter(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox1.ForeColor = Color.Black;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);
            }
            catch (Exception)
            {
                MessageBox.Show("No hay registros para quitar", "Revisar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            String val = textBox1.Text;
            cargarTabla(val);
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            textBox2.Text = "";
            textBox2.ForeColor = Color.Black;
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            textBox2.Text = "Buscar...";
            textBox2.ForeColor = Color.DimGray;
        }

        private void button3_Click(object sender, EventArgs e)
        {
           try
            {
                DialogResult result;
                result = MessageBox.Show("¿Desea eliminar la característica del grupo: "+lblGrupo.Text+" permanentemente?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (result == DialogResult.Yes)
                {                
                    gc.eliminarCaracteristica(idGrupo, idCarac);
                    cargarTabla2("");
                }                
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrió un error al quitar la asignación de la característica al grupo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox2_KeyUp(object sender, KeyEventArgs e)
        {
            String val = textBox2.Text;
            cargarTabla2(val);
        }

        private void dataGridView2_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dataGridView2_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int ult = dataGridView2.Rows.Count;
            if (e.RowIndex >= 0 && e.RowIndex < ult)
            {
                id = dataGridView2[0, e.RowIndex].Value.ToString();
                name = dataGridView2[1, e.RowIndex].Value.ToString();
                tipo = dataGridView2[2, e.RowIndex].Value.ToString();
                Boolean condicion = false;
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    if (dataGridView1[0, i].Value.ToString() == id)
                    {
                        MessageBox.Show("Ya agregaste esta descripción", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        condicion = true;
                    }
                }
                if (!condicion)
                {
                    String exist = gc.consultarCaracExist(idGrupo, id);
                    if (exist == id)
                    {
                        MessageBox.Show("La característica ya está asignada al grupo de: " + lblGrupo.Text + "", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        dataGridView1.Rows.Add(id, name, tipo);
                    }
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new CrearCaracteristica(this).ShowDialog();
        }

        private void dataGridView3_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int ult = dataGridView3.Rows.Count;
            if (e.RowIndex >= 0 && e.RowIndex < ult)
            {
                idCarac = dataGridView3[0, e.RowIndex].Value.ToString();
                btnDelete.Enabled = true;
                btnDelete.BackColor = Color.Red;
            }
            else
            {
                btnDelete.Enabled = false;
                btnDelete.BackColor = Color.LightGray;
            }
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {                         
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int boolean = 0;
            if (dataGridView1.Rows.Count > 0)
            {
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    boolean += gc.insertarCaracGrupo(idGrupo, dataGridView1[0, i].Value.ToString());
                }
                if (boolean == dataGridView1.Rows.Count)
                {
                    MessageBox.Show("Se asignó correctamente la característica al grupo: "+lblGrupo.Text+"", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se pudo asignar la característica correctamente", "Incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                cargarTabla2("");
                dataGridView1.Rows.Clear();
            }
            else
            {
                MessageBox.Show("No hay caracteristicas para asignar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            textBox1.Text = "Buscar...";
            textBox1.ForeColor = Color.DimGray;
        }

        private void dataGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
