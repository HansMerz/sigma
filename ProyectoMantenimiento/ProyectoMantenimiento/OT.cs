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
    public partial class OT : Form
    {
        GrupoClass gc;
        String id;
        Mantenimiento m;        
        List<int> ln = new List<int>();
        public OT(Mantenimiento m)
        {
            InitializeComponent();
            gc = new GrupoClass();
            this.m = m;
            cargarCombo();
        }
        public void cargarCombo()
        {            
            comboBox1.DataSource = gc.cargarTabla("");
            comboBox1.DisplayMember = "nombre";
            comboBox1.ValueMember = "id";                        
        }

        public void cargarTabla(String val, String id)
        {
            dataGridView1.DataSource = gc.cargarTablaEquipo(val, id);
        }
        public void cargarHoras()
        {
            //Este método se encarga de cargar las horas que faltan para ejecutar el mantenimiento
            //además le da color a los registros dependiendo de las horas que falten para su ejecución
            //dgHoras.Rows.Clear();
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                String id = dataGridView1[0, i].Value.ToString();
                //dgHoras.Rows.Add(m.operacionFecha(id));
            }
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                Color lightblue = ColorTranslator.FromHtml("#B3EEEC");
                Color ligthred = ColorTranslator.FromHtml("#F5A59F");
                Color yellow = ColorTranslator.FromHtml("#FDF500");
                Color darkred = ColorTranslator.FromHtml("#EF0404");
                Color morered = ColorTranslator.FromHtml("#C02121");
                int horas = int.Parse(dataGridView1[10, i].Value.ToString());

                if (horas > 120)
                {
                    dataGridView1.Rows[i].DefaultCellStyle.BackColor = lightblue;
                    //dgHoras.Rows[i].DefaultCellStyle.BackColor = lightblue;
                }
                else if (horas <= 120 && horas > 90)
                {
                    dataGridView1.Rows[i].DefaultCellStyle.BackColor = ligthred;
                    //dgHoras.Rows[i].DefaultCellStyle.BackColor = ligthred;
                }
                else if (horas <= 90 && horas > 30)
                {
                    dataGridView1.Rows[i].DefaultCellStyle.BackColor = yellow;
                    //dgHoras.Rows[i].DefaultCellStyle.BackColor = yellow;
                }
                else if (horas <= 30 && horas >= 0)
                {
                    dataGridView1.Rows[i].DefaultCellStyle.BackColor = darkred;
                    //dgHoras.Rows[i].DefaultCellStyle.BackColor = darkred;
                    dataGridView1.Rows[i].DefaultCellStyle.ForeColor = Color.White;
                    //dgHoras.Rows[i].DefaultCellStyle.ForeColor = Color.White;
                }
                else if (horas < 0)
                {
                    dataGridView1.Rows[i].DefaultCellStyle.BackColor = morered;
                    //dgHoras.Rows[i].DefaultCellStyle.BackColor = morered;
                    dataGridView1.Rows[i].DefaultCellStyle.ForeColor = Color.White;
                    //dgHoras.Rows[i].DefaultCellStyle.ForeColor = Color.White;
                    dataGridView1[10, i].Value = "CANCELADO";
                }
            }
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            id = comboBox1.SelectedValue.ToString();
            cargarTabla("", id);
            cargarHoras();
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
            cargarTabla(val, id);
            cargarHoras();
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int n = dataGridView1.CurrentRow.Index;

            dataGridView1.Rows[n].Selected = false;


            if (ln.Contains(n))
            {
                ln.Remove(n);
            }
            else
            {
                ln.Add(n);
            }

            foreach (var i in ln)
            {
                dataGridView1.Rows[i].Selected = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtEncargado.Text != "" && ln.Count > 0)
            {                
                PlanMantenimiento pm = new PlanMantenimiento();
                DatosPlanMantenimiento2 dpm2 = new DatosPlanMantenimiento2();
                dpm2.grupo = comboBox1.Text;
                dpm2.encargado = txtEncargado.Text;
                dpm2.tipo = "Preventivo";                

                pm.dpm2.Add(dpm2);
                foreach (var i in ln)
                {
                    DatosPlanMantenimiento dpm = new DatosPlanMantenimiento();
                    dpm.codigo = dataGridView1[2, i].Value.ToString();
                    dpm.num_orden = dataGridView1[1, i].Value.ToString();
                    dpm.equipo_area = dataGridView1[3, i].Value.ToString();
                    dpm.frecuencia = dataGridView1[6, i].Value.ToString();
                    dpm.fecha_prevista = dataGridView1[7, i].Value.ToString();
                    dpm.fecha_solicitud = dataGridView1[9, i].Value.ToString();
                    dpm.horas_faltantes = dataGridView1[10, i].Value.ToString();
                    dpm.localizacion = dataGridView1[5, i].Value.ToString();
                    dpm.solicita = dataGridView1[8, i].Value.ToString();                       
                    pm.dpm.Add(dpm);
                }
                MySqlDataReader reader = gc.cargarTablaGruCar("", comboBox1.SelectedValue.ToString());

                while (reader.Read())
                {
                    if (reader.GetString(2) == "Instrucciones")
                    {
                        DatosInstrucciones dpm4 = new DatosInstrucciones();
                        dpm4.idInstruccion = reader.GetString(0);
                        dpm4.desc= reader.GetString(1);
                        pm.dpm4.Add(dpm4);
                    }
                    if(reader.GetString(2) == "Equipo")
                    {
                        DatosEquipo dpm3 = new DatosEquipo();
                        dpm3.idEquipo = reader.GetString(0);
                        dpm3.desc = reader.GetString(1);
                        pm.dpm3.Add(dpm3);
                    }
                    if (reader.GetString(2) == "Procedimiento")
                    {
                        DatosProcedimiento dpm5 = new DatosProcedimiento();
                        dpm5.idProcedimiento = reader.GetString(0);
                        dpm5.desc = reader.GetString(1);
                        pm.dpm5.Add(dpm5);
                    }                    
                }
                pm.Show();
            }
            else
            {
                MessageBox.Show("Digite el encargado o escoja los grupos a generar la OT", "Revisar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
