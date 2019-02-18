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
    public partial class CrearPlanMantenimiento : Form
    {
        // Se declaran variables de las clases  Mantenimiento, MantenimientoPersona y de la ventana Mantenimiento
        MantenimientoClass m;
        Mantenimiento man;
        MantenimientoPersonaClass mpc;
        public CrearPlanMantenimiento(Mantenimiento man)
        {
            InitializeComponent();
            // Se instancian dichas variables y se carga el método que llena las listas.    
            m = new MantenimientoClass();
            mpc = new MantenimientoPersonaClass();
            this.man = man;
            cargarListas();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Se valida que los campos no estén vacíos.
            if (dtpFecha.Value.ToString() == "" || txtSolicita.Text == "" || comboBox1.Text == "")
            {
                MessageBox.Show("Los campos marcados con (*) son obligatorios", "Revisar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {                
                String fecha = dtpFecha.Value.Year + "-" + dtpFecha.Value.Month + "-" + dtpFecha.Value.Day + "T23:59:59";
                //Se llama al método de la clase Mantenimiento que nos devuelve el último valor dependiendo de la columna que se le pase por parámetro,
                //en este caso, num_orden = número de orden
                DataRow r = m.traerUltimo("numero_orden");
                int num_orden = 0;
                //Se valida que no esté vacío, de estarlo se le pone como valor 0 al número de orden y si no está vacío, se le guarda la suma
                // del valor máximo traído más 1             
                if (r["ultimo"].ToString() == "")
                {
                    num_orden = 0;
                }
                else
                {
                    num_orden = int.Parse(r["ultimo"].ToString()) + 1;
                }
                //Se pasan el valor de los campos a las variables de la clase Mantenimiento para después insertarlo a la base de datos
                try
                {
                    String frec = comboBox1.Text;
                    m.agarrarDatos(listEquipo.SelectedValue.ToString(), num_orden.ToString(), fecha, txtSolicita.Text, true);
                    DataRow cant = m.insertar(frec).Rows[0];
                    int frecuencia = m.ObtenerFrecuencia(listEquipo.SelectedValue.ToString());
                    for (int i = 0; i < int.Parse(cant["op"].ToString()); i++)
                    {
                        DataRow row = m.traerFechaPrevista().Rows[0];
                        DataRow row2 = m.operacionFechaPrev(frecuencia, row["fecha_Prevista"].ToString()).Rows[0];
                    String arregleFecha = row2["fecha"].ToString() + "T23:59:59";
                        int anio = int.Parse(row2["fecha_prev"].ToString());
                        if (anio <= int.Parse(frec))
                        {
                            num_orden = num_orden + 1;
                            m.agarrarDatos(listEquipo.SelectedValue.ToString(), num_orden.ToString(), arregleFecha, txtSolicita.Text, true);
                            m.insertar(frec);
                        }                        
                    }

                    man.cargarTabla("");
                    man.cargarHoras();
                    Hide();
                }
                catch (Exception)
                {
                    MessageBox.Show("Ocurrió un error al guardar el plan de mantenimiento", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);                    
                }               
            }
        }
        private void cargarListas()
        {
            listEquipo.DataSource = m.consultar("");
            listEquipo.DisplayMember = "NombreArea";
            listEquipo.ValueMember = "codigo";
        }

        private void txtBusEqui_Enter(object sender, EventArgs e)
        {
            txtBusEqui.ForeColor = Color.Black;
            txtBusEqui.Text = "";
        }

        private void txtBusEqui_Leave(object sender, EventArgs e)
        {
            if (txtBusEqui.Text == "")
            {
                txtBusEqui.Text = "Buscar...";
                txtBusEqui.ForeColor = Color.DimGray;
            }
        }

        private void txtBusEqui_KeyUp(object sender, KeyEventArgs e)
        {
            String val = txtBusEqui.Text;
            listEquipo.DataSource = m.consultar(val);
            listEquipo.DisplayMember = "NombreArea";
            listEquipo.ValueMember = "codigo";
        }
    }
}
