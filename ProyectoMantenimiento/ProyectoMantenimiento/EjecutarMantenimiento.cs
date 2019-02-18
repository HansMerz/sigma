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
    public partial class EjecutarMantenimiento : Form
    {
        //Se declaran las variables de las clases Mantenimiento, Persona, Herramienta, MantenimientoHerramienta, MantenimientoPersona, Insumos, Inventario
        // y la ventana Mantenimiento. 
        MantenimientoClass mc;
        Mantenimiento m;
        PersonaClass p;
        HerramientaClass h;        
        MantenimientoPersonaClass mpc;
        InsumosClass ic;
        InventarioClass inv;
        ActividadYFallo ayf;
        public EjecutarMantenimiento(Mantenimiento m)
        {
            //Se instancian las variables mencionadas y se ejecuta el método de asignarcampos y llenarlistas
            InitializeComponent();
            mc = new MantenimientoClass();
            this.m = m;
            p = new PersonaClass();
            h = new HerramientaClass();            
            mpc = new MantenimientoPersonaClass();
            ic = new InsumosClass();
            inv = new InventarioClass();
            ayf = new ActividadYFallo();                   
            dgIns.RowHeadersVisible = false;
            dgPersonas.RowHeadersVisible = false;
            asignarCampos();
            llenarListas();
        }
        private void asignarCampos()
        {
            //Este método asigna el nombre de equipo o área, el tipo de mantenimiento, el número de orden y el código del mantenimiento que se va a ejecutar 
            lblEquipo.Text = m.equipo;
            lblTipo.Text = m.tipo;
            lblNumOrden.Text = m.num_orden;
            lblCodigo.Text = m.id;
        }
           
        private void llenarListas()
        {
            //Este método se encarga de cargar la lista de todos los trabajadores, herramientas, insumos
            listTrabajadores.DataSource = p.Consultar("");
            listTrabajadores.DisplayMember = "nombres";
            listTrabajadores.ValueMember = "id";

            listIns.DataSource = ic.ConsultarTodo("");
            listIns.DisplayMember = "nombre";
            listIns.ValueMember = "id";
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregarHerramienta_Click(object sender, EventArgs e)
        {            
        }

        private void btnAgregarTrabajadores_Click(object sender, EventArgs e)
        {
            //Se agrega el trabajador a la tabla, en caso de estarlo, no se deja agregar
            Boolean condicion = false;
            for (int i = 0; i < dgPersonas.Rows.Count; i++)
            {
                if (dgPersonas[0, i].Value.ToString() == listTrabajadores.SelectedValue.ToString())
                {
                    MessageBox.Show("Ya agregaste este trabajador", "Corregir", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    condicion = true;
                }
            }
            if (!condicion)
            {
                dgPersonas.Rows.Add(listTrabajadores.SelectedValue.ToString(), listTrabajadores.Text);
            }
        }

        private void dgHerramientas_CellClick(object sender, DataGridViewCellEventArgs e)
        {            
        }

        private void btnQuitarHerramienta_Click(object sender, EventArgs e)
        {
        }

        private void btnQuitarPersona_Click(object sender, EventArgs e)
        {
            //Quita la persona seleccionada de la tabla
            try
            {
                dgPersonas.Rows.RemoveAt(dgPersonas.CurrentRow.Index);
            }
            catch (Exception)
            {
                MessageBox.Show("No hay registros para quitar", "Revisar", MessageBoxButtons.OK, MessageBoxIcon.Warning);                
            }            
        }

        private void btnEjecutar_Click(object sender, EventArgs e)
        {
            // Se llama al método validacion
            Boolean condicion = validacion();
            if (!condicion)
            {
                MessageBox.Show("Los campos marcados con (*) son obligatorios", "Revisar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {                                                       
                    //Se inserta los insumos utilizados en el mantenimiento
                    if (dgIns.Rows.Count > 0)
                    {
                        for (int i = 0; i < dgIns.Rows.Count; i++)
                        {
                            ic.InsertarInsumosHasMantenimiento(dgIns[0, i].Value.ToString(), lblCodigo.Text, dgIns[2, i].Value.ToString());
                        }

                    }
                    //Se inserta los trabajadores encargados del mantenimiento
                    for (int i = 0; i < dgPersonas.Rows.Count; i++)
                     {
                         mpc.asignarValores(lblCodigo.Text, dgPersonas[0, i].Value.ToString());
                         mpc.insertar();
                     }
                    
                    // Se actualiza el mantenimiento
                    String fecha_inicio = dtpFechaInicio.Value.Year + "-" + dtpFechaInicio.Value.Month + "-" + dtpFechaInicio.Value.Day + "T" + dtpTiempoInicio.Value.ToString("HH:mm:ss");
                     String fecha_fin = dtpFechaFin.Value.Year + "-" + dtpFechaFin.Value.Month + "-" + dtpFechaFin.Value.Day + "T" + dtpTiempoFin.Value.ToString("HH:mm:ss");            
                     mc.agarrarDatosAct(fecha_inicio, fecha_fin, txtProceso.Text);
                     mc.actualizarEjecucion(lblCodigo.Text);                
                     m.cargarTabla("");
                     m.cargarHoras();
                     Hide();
                }
                catch (Exception)
                {
                    MessageBox.Show("Ocurrió un error al ejectuar el mantenimiento preventivo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);                 
                }
            }
        }

        private Boolean validacion()
        {
            //Se valida que los campos no estén vacíos
            Boolean condicion = false;
            if (dtpFechaInicio.Value.ToString("yyyy-mm-dd") == "0000-00-00" ||
                dtpTiempoInicio.Value.ToString("HH:mm:ss") == "00:00:00" || dtpFechaFin.Value.ToString("yyyy-mm-dd") == "0000-00-00" || dtpTiempoFin.Value.ToString("HH:mm:ss") == "00:00:00" ||
                txtProceso.Text == "" || dgPersonas.Rows.Count == 0)
            {
                condicion = false;
            }
            else
            {
                condicion = true;
            }
            return condicion;
        }

        private void checkBox1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {                        
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Se agrega el insumo utilizado a la tabla
            Boolean condicion = false;
            for (int i = 0; i < dgIns.Rows.Count; i++)
            {
                if (dgIns[0, i].Value.ToString() == listIns.SelectedValue.ToString())
                {
                    MessageBox.Show("Ya agregaste este insumo", "Corregir", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    condicion = true;
                }
            }
            if (!condicion)
            {
                DataRow row = ic.ConsultarPrecio(listIns.SelectedValue.ToString());
                int costo = int.Parse(row["precio"].ToString()) * int.Parse(numCantIns.Value.ToString());
                dgIns.Rows.Add(listIns.SelectedValue.ToString(), listIns.Text, numCantIns.Value, costo);
                numCantIns.Value = 1;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Quita el insumo de la tabla
            try
            {
                dgIns.Rows.RemoveAt(dgIns.CurrentRow.Index);
            }
            catch (Exception)
            {
                MessageBox.Show("No hay registros para quitar", "Revisar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void listIns_Click(object sender, EventArgs e)
        {
            
        }

        private void listHerramientas_Click(object sender, EventArgs e)
        {
            
        }

        private void listIns_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            txtBusIns.Text = "";
            txtBusIns.ForeColor = Color.Black;
        }

        private void txtBusIns_Leave(object sender, EventArgs e)
        {
            if (txtBusIns.Text == "")
            {
                txtBusIns.Text = "Buscar...";
                txtBusIns.ForeColor = Color.DimGray;
            }
        }

        private void txtBusHer_Enter(object sender, EventArgs e)
        {
           
        }

        private void txtBusHer_Leave(object sender, EventArgs e)
        {
            
        }

        private void txtBusTra_Enter(object sender, EventArgs e)
        {
            txtBusTra.Text = "";
            txtBusTra.ForeColor = Color.Black;
        }

        private void txtBusTra_Leave(object sender, EventArgs e)
        {
            if (txtBusTra.Text == "")
            {
                txtBusTra.Text = "Buscar...";
                txtBusTra.ForeColor = Color.DimGray;
            }
        }

        private void txtBusIns_KeyUp(object sender, KeyEventArgs e)
        {
            String val = txtBusIns.Text;
            listIns.DataSource = ic.ConsultarTodo(val);
            listIns.DisplayMember = "nombre";
            listIns.ValueMember = "id";
        }

        private void txtBusHer_KeyUp(object sender, KeyEventArgs e)
        {
            
        }

        private void txtBusTra_KeyUp(object sender, KeyEventArgs e)
        {
            String val = txtBusTra.Text;
            listTrabajadores.DataSource = p.Consultar(val);
            listTrabajadores.DisplayMember = "nombres";
            listTrabajadores.ValueMember = "id";
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            new Fallo().ShowDialog(); 
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new Actividad().ShowDialog();
        }
    }
}
