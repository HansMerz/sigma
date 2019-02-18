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
    public partial class Mantenimiento : Form
    {
        //Se declaran 6 variables, 4 de tipo String, una de la clase Persona y otra de la clase Mantenimiento
        PersonaClass pc;
        MantenimientoClass m;
        public String id;
        public String num_orden;
        public String tipo = "Preventivo";
        public String equipo;
        public String grupo;
        public String codigo;
        public String localizacion;
        public String solicita;
        public String fecha_prevista;
        public String horas_faltantes;
        public String fecha_solicitud;
        public Mantenimiento()
        {
            //Se instancian las variables, se ejecutan los métodos de inhabilitar, cargarTabla y cargarHoras
            InitializeComponent();
            pc = new PersonaClass();
            m = new MantenimientoClass();
            inhabilitar();
            dataGridView1.RowHeadersVisible = false;
            //dgHoras.RowHeadersVisible = false;
            cargarTabla("");
            cargarHoras();
            deshabilitarOrden();
        }
        private void deshabilitarBotones()
        {
            btnExecute.Enabled = false;
            btnExecute.BackColor = Color.LightGray;            
        }
        private void deshabilitarOrden()
        {
            foreach (DataGridViewColumn Col in dataGridView1.Columns)
            {
                Col.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            /*foreach (DataGridViewColumn Col in dgHoras.Columns)
            {
                Col.SortMode = DataGridViewColumnSortMode.NotSortable;
            }*/
        }
        private void habilitar()
        {
            //Este método se encarga de habilitar los botones de Editar, Eliminar y Ejecutar
            //y de establecerle los colores originales a los botones
            btnEdit.Enabled = true;
            btnDelete.Enabled = true;
            btnExecute.Enabled = true;
            //btnImprimir.Enabled = true;

            btnEdit.BackColor = Color.DarkGreen;
            btnDelete.BackColor = Color.Red;
            btnExecute.BackColor = Color.Navy;
            //btnImprimir.BackColor = Color.OrangeRed;
        }

        private void inhabilitar()
        {
            //Este método se encarga de deshabilitar los botones de Editar, Eliminar y Ejecutar
            //y se les pone color gris
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
            btnExecute.Enabled = false;
            //btnImprimir.Enabled = false;

            btnEdit.BackColor = Color.LightGray;
            btnDelete.BackColor = Color.LightGray;
            btnExecute.BackColor = Color.LightGray;
            //btnImprimir.BackColor = Color.LightGray;
        }

        public void cargarTabla(String val)
        {
            //Este método se encarga de cargar la tabla 
            dataGridView1.Rows.Clear();
            MySqlDataReader read = m.cargarTabla(val);
            while (read.Read())
            {
                dataGridView1.Rows.Add(read.GetString(0), read.GetString(1), read.GetString(2), read.GetString(3), 
                    read.GetString(4), read.GetString(5), read.GetString(6), read.GetString(7), read.GetString(8), read.GetString(9));
            }
        }
        public void cargarTabla2(String val, String val2)
        {
            //Este método se encarga de cargar la tabla 
            dataGridView1.Rows.Clear();
            MySqlDataReader read = m.cargarTabla2(val, val2);
            while (read.Read())
            {
                dataGridView1.Rows.Add(read.GetString(0), read.GetString(1), read.GetString(2), read.GetString(3),
                    read.GetString(4), read.GetString(5), read.GetString(6), read.GetString(7), read.GetString(8), read.GetString(9));
            }
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
                int horas = int.Parse(dataGridView1[9, i].Value.ToString());
                
                if (horas > 120)
                {
                    dataGridView1.Rows[i].DefaultCellStyle.BackColor = lightblue;
                    //dgHoras.Rows[i].DefaultCellStyle.BackColor = lightblue;
                }
                else if(horas <= 120 && horas > 90)
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
                    dataGridView1[9, i].Value = "CANCELADO";
                }
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Muestra la ventana para crear un nuevo plan de mantenimiento
            Hide();
            new CrearPlanMantenimiento(this).ShowDialog();
            Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Se recoge el valor del id, num_orden, tipo, equipo del registro seleccionado
            int ult = dataGridView1.Rows.Count;
            if (e.RowIndex >= 0 && e.RowIndex < ult)
            {
                id = dataGridView1[0, e.RowIndex].Value.ToString();                
                num_orden = dataGridView1[1, e.RowIndex].Value.ToString();                
                codigo = dataGridView1[2, e.RowIndex].Value.ToString();
                equipo = dataGridView1[3, e.RowIndex].Value.ToString();
                grupo = dataGridView1[4, e.RowIndex].Value.ToString();
                localizacion = dataGridView1[5, e.RowIndex].Value.ToString();
                fecha_prevista = dataGridView1[6, e.RowIndex].Value.ToString();
                solicita = dataGridView1[7, e.RowIndex].Value.ToString();
                fecha_solicitud = dataGridView1[8, e.RowIndex].Value.ToString();
                horas_faltantes = dataGridView1[9, e.RowIndex].Value.ToString();
                habilitar();
                String fecha = dataGridView1[9, e.RowIndex].Value.ToString();
                if (fecha == "CANCELADO")
                {
                    deshabilitarBotones();
                }                
            }
            else
            {
                inhabilitar();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Hide();
            new EditarMantenimiento(this, id).ShowDialog();
            Show();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //Muestra mensaje de confirmación para eliminar, de confirmarlo, se elimina el plan de mantenimiento
            DialogResult dr;
            dr = MessageBox.Show("¿Desea cerrar el plan de mantenimiento con el número de orden: "+num_orden+"?", "Cerrar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                //m.eliminar(id);
                m.cambiarEstado(id);
                cargarTabla("");
                cargarHoras();
            }
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            //Se busca el plan de mantenimiento dependiendo de la tecla presionada
            String val = textBox1.Text;
            cargarTabla(val);
            cargarHoras();
        }

        private void btnExecute_Click(object sender, EventArgs e)
        {
            //Despliega el formulario para ejecutar el mantenimiento
            Hide();
            deshabilitarBotones();
            new EjecutarMantenimiento(this).ShowDialog();
            Show();
        }

        private void btnSeeExecute_Click(object sender, EventArgs e)
        {
            //Muestra el formulario de los mantenimientos ejecutados
            Hide();
            new MantenimientosEjecutados().ShowDialog();
            Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //Muestra el formulario para ejecutar el mantenimiento correctivo
            Hide();
            new EjecutarCorrectivo(this).Show();
        }

        private void dgHoras_Scroll(object sender, ScrollEventArgs e)
        {
            //Establece la sincronización con la tabla de los planes de mantenimiento
            dataGridView1.FirstDisplayedScrollingRowIndex = e.NewValue;
        }

        private void dataGridView1_Scroll(object sender, ScrollEventArgs e)
        {
            //Establece la sincronización con las horas faltantes a ejecutar el plan de mantenimiento
            
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            deshabilitarBotones();
            Hide();
            new OT(this).ShowDialog();
            Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
            new Falla_Actividad().ShowDialog();
            Show();    
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("No se puede ejecutar el reporte", "Revisar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                PreventivosLista pl = new PreventivosLista();
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    DatosListaPreventivo dlp = new DatosListaPreventivo();
                    dlp.id = dataGridView1[0, i].Value.ToString();
                    dlp.numOrden = dataGridView1[1, i].Value.ToString();
                    dlp.codEquipo = dataGridView1[2, i].Value.ToString();
                    dlp.equipoArea = dataGridView1[3, i].Value.ToString();
                    dlp.grupo = dataGridView1[4, i].Value.ToString();
                    dlp.localizacion = dataGridView1[5, i].Value.ToString();
                    dlp.fechaPrevista = dataGridView1[6, i].Value.ToString();
                    dlp.solicita = dataGridView1[7, i].Value.ToString();
                    dlp.fechaSolicitud = dataGridView1[8, i].Value.ToString();
                    dlp.diasFaltantes = dataGridView1[9, i].Value.ToString();
                    pl.dlp.Add(dlp);
                }
                pl.Show();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            String val = "";
            if (comboBox1.Text == "Equipos")
            {
                val = "1";
                cargarTabla2("", val);
                cargarHoras();
            }
            else if(comboBox1.Text == "Áreas Locativas")
            {
                val = "0";
                cargarTabla2("", val);
                cargarHoras();
            }
            else if(comboBox1.Text == "Todos")
            {
                cargarTabla("");
                cargarHoras();
            }            
        }
    }
}
