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
    public partial class EjecutarCorrectivo : Form
    {
        //Se declaran variables de la clase Mantenimiento, Persona, Herramienta, MantenimientoHerramienta, MantenimientoPersona,
        //Insumos e Inventario. También de las ventanas Mantenimiento y MantenimientosEjecutados
        MantenimientoClass mc;
        PersonaClass pc;
        HerramientaClass hc;        
        MantenimientoPersonaClass mpc;
        InsumosClass ic;
        InventarioClass inv;
        Mantenimiento m;
        MantenimientosEjecutados me;
        ActividadYFallo ayf;
        public EjecutarCorrectivo(Mantenimiento m)
        {
            //Se instancian las variables mencionadas y se llama al método llenarListas()
            InitializeComponent();
            mc = new MantenimientoClass();
            pc = new PersonaClass();
            hc = new HerramientaClass();            
            mpc = new MantenimientoPersonaClass();
            ic = new InsumosClass();
            inv = new InventarioClass();
            this.m = m;
            me = new MantenimientosEjecutados();
            ayf = new ActividadYFallo();
            dgActividad.RowHeadersVisible = false;
            dgFallo.RowHeadersVisible = false;
            llenarListas();
        }

        private void btnEjecutar_Click(object sender, EventArgs e)
        {
            // Con el método validacion validamos que los campos no estén vacíos
            Boolean condicion = validacion();
            if (!condicion)
            {
                MessageBox.Show("Los campos marcados con (*) son obligatorios", "Revisar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {               
                    //Se trae el valor de la fecha de daño, de estar deshabilitado la fecha se le pone nulo
                    String fecha_dano = dtpFechaDano.Value.Year + "-" + dtpFechaDano.Value.Month + "-" + dtpFechaDano.Value.Day;
                    if (!checkBox1.Checked)
                    {
                        fecha_dano = "";
                    }

                    //Se inserta el mantenimiento Correctivo
                    String fecha_inicio = dtpFechaInicio.Value.Year + "-" + dtpFechaInicio.Value.Month + "-" + dtpFechaInicio.Value.Day + "T" + dtpTiempoInicio.Value.ToString("HH:mm:ss");
                    String fecha_fin = dtpFechaFin.Value.Year + "-" + dtpFechaFin.Value.Month + "-" + dtpFechaFin.Value.Day + "T" + dtpTiempoFin.Value.ToString("HH:mm:ss");                
                    String fecha_solicitada = dtpFechaSoli.Value.Year + "-" + dtpFechaSoli.Value.Month + "-" + dtpFechaSoli.Value.Day + "T" + dtpFechaSoli.Value.ToString("HH:mm:ss");
                    DataRow r = mc.traerUltimo("numero_orden");
                    int num_orden = int.Parse(r["ultimo"].ToString()) + 1;
                    mc.agarrarDatosTodos("Correctivo", fecha_dano, fecha_inicio, fecha_fin, txtProceso.Text, listEqui.SelectedValue.ToString(), num_orden.ToString(), txtSoli.Text, fecha_solicitada);
                    mc.insertarTodo();

                    DataRow code = mc.traerUltimo("id");
                    //Se inserta en las tablas InsumosHasMantenimiento, MantenimientoHasHerramienta, MantenimientoHasPersona
                    for (int i = 0; i < dgIns.Rows.Count; i++)
                    {
                        ic.InsertarInsumosHasMantenimiento(dgIns[0, i].Value.ToString(), code["ultimo"].ToString(), dgIns[2, i].Value.ToString());
                    }
                    
                    for (int i = 0; i < dgPersonas.Rows.Count; i++)
                    {
                        mpc.asignarValores(code["ultimo"].ToString(), dgPersonas[0, i].Value.ToString());
                        mpc.insertar();
                    }
                    for (int i = 0; i < dgFallo.Rows.Count - 1; i++)
                    {                        
                        if (dgFallo[0, i].Value.ToString() != "")
                        {                        
                            ayf.agarrarMantenimiento(dgFallo[0, i].Value.ToString(), code["ultimo"].ToString());
                            ayf.insertarFalloMantenimiento();
                        }
                    }
                    for (int i = 0; i < dgActividad.Rows.Count - 1; i++)
                    {
                        if (dgActividad[0, i].Value.ToString() != "")
                        {
                            ayf.agarrarMantenimiento(dgActividad[0, i].Value.ToString(), code["ultimo"].ToString());
                            ayf.insertarActividadMantenimiento();
                        }
                    }

                    me.cargarPrecios("");                
                    Hide();
                    me.Show();
                }
                catch (Exception)
                {
                    MessageBox.Show("Ocurrió un error al ejecutar el mantenimiento correctivo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);                 
                }
            }
        }
        private void llenarListas()
        {
            // Se cargan las listas de los trabajadores, herramientas, insumos y equipos o áreas locativas
            listTrabajadores.DataSource = pc.Consultar("");
            listTrabajadores.DisplayMember = "nombres";
            listTrabajadores.ValueMember = "id";            

            listIns.DataSource = ic.ConsultarTodo("");
            listIns.DisplayMember = "nombre";
            listIns.ValueMember = "id";

            listEqui.DataSource = mc.consultar("");
            listEqui.DisplayMember = "NombreArea";
            listEqui.ValueMember = "codigo";
        }
        private Boolean validacion()
        {
            //Se valida que los campos no estén vacíos
            Boolean condicion = false;
            if (dtpFechaInicio.Value.ToString("yyyy-mm-dd") == "0000-00-00" ||
                dtpTiempoInicio.Value.ToString("HH:mm:ss") == "00:00:00" || dtpFechaFin.Value.ToString("yyyy-mm-dd") == "0000-00-00" || txtSoli.Text == "" || dtpTiempoFin.Value.ToString("HH:mm:ss") == "00:00:00" ||
                txtProceso.Text == "" || dgPersonas.Rows.Count == 0 || dgIns.Rows.Count == 0 || dgActividad.Rows.Count == 1 || dgFallo.Rows.Count == 1)
            {
                condicion = false;
            }
            else
            {
                condicion = true;
            }
            return condicion;
        }
        private void btnAddIns_Click(object sender, EventArgs e)
        {
            //Se agrega el insumo con la cantidad digitada en la tabla, si este insumo ya está en la tabla, no se agregará de nuevo y saldrá mensaje de error
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

        private void btnAgregarHerramienta_Click(object sender, EventArgs e)
        {
            
        }

        private void btnAgregarTrabajadores_Click(object sender, EventArgs e)
        {
            // Se agrega el trabajador en la tabla, si este insumo ya está en la tabla, no se agregará de nuevo y saldrá mensaje de error
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

        private void button2_Click(object sender, EventArgs e)
        {
            //Quita el insumo seleccionado de la tabla
            try
            {
                dgIns.Rows.RemoveAt(dgIns.CurrentRow.Index);
            }
            catch (Exception)
            {
                MessageBox.Show("No hay registros para quitar", "Revisar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnQuitarHerramienta_Click(object sender, EventArgs e)
        {
            
        }

        private void btnQuitarPersona_Click(object sender, EventArgs e)
        {
            //Quita el trabajador seleccionado de la tabla
            try
            {
                dgPersonas.Rows.RemoveAt(dgPersonas.CurrentRow.Index);
            }
            catch (Exception)
            {
                MessageBox.Show("No hay registros para quitar", "Revisar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            //Si el checkbox está activo, se habilita la fecha de daño, de no estarlo, se deshabilita
            if (checkBox1.Checked)
            {
                label3.Enabled = true;
                dtpFechaDano.Enabled = true;
            }
            else
            {
                label3.Enabled = false;
                dtpFechaDano.Enabled = false;
            }
        }

        private void listIns_Click(object sender, EventArgs e)
        {
          
        }

        private void listHerramientas_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
          
        }

        private void txtBusIns_Leave(object sender, EventArgs e)
        {
            if (txtBusIns.Text == "")
            {
                txtBusIns.Text = "Buscar...";
                txtBusIns.ForeColor = Color.DimGray;
            }
        }

        private void txtBusIns_Enter(object sender, EventArgs e)
        {
            txtBusIns.Text = "";
            txtBusIns.ForeColor = Color.Black;
        }

        private void txtBusIns_KeyUp(object sender, KeyEventArgs e)
        {
            String val = txtBusIns.Text;
            listIns.DataSource = ic.ConsultarTodo(val);
            listIns.DisplayMember = "nombre";
            listIns.ValueMember = "id";
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            
        }

        private void txtBusEqui_KeyUp(object sender, KeyEventArgs e)
        {
            String val = txtBusEqui.Text;
            listEqui.DataSource = mc.consultar(val);
            listEqui.DisplayMember = "NombreArea";
            listEqui.ValueMember = "codigo";
        }

        private void txtBusTra_KeyUp(object sender, KeyEventArgs e)
        {
            String val = txtBusTra.Text;
            listTrabajadores.DataSource = pc.Consultar(val);
            listTrabajadores.DisplayMember = "nombres";
            listTrabajadores.ValueMember = "id";
        }

        private void txtBusIns_KeyDown(object sender, KeyEventArgs e)
        {          
        }

        private void txtBusHer_Enter(object sender, EventArgs e)
        {
            
        }

        private void txtBusHer_Leave(object sender, EventArgs e)
        {
            
        }

        private void txtBusEqui_Enter(object sender, EventArgs e)
        {
            txtBusEqui.Text = "";
            txtBusEqui.ForeColor = Color.Black;
        }

        private void txtBusEqui_Leave(object sender, EventArgs e)
        {
            if (txtBusEqui.Text == "")
            {
                txtBusEqui.Text = "Buscar...";
                txtBusEqui.ForeColor = Color.DimGray;
            }
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

        private void button3_Click(object sender, EventArgs e)
        {
            new Actividad().ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Fallo().ShowDialog();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {

            OrdenTrabajoCorrectivo ot = new OrdenTrabajoCorrectivo();
            DatosCorrectivo dc = new DatosCorrectivo();
            dc.tipo = "Correctivo";
            ot.ot.Add(dc);
            ot.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OrdenCorrectivoAreas oca = new OrdenCorrectivoAreas();
            DatosCorrectivoGeneral dcg1 = new DatosCorrectivoGeneral();
            MySqlDataReader read = dcg1.traerPrimeros();
            while (read.Read())
            {
                DatosCorrectivoGeneral dcg = new DatosCorrectivoGeneral();
                if (read.GetString(0) == "" && read.GetString(1) == "")
                {
                    dcg.cod = " ";
                    dcg.desc = " ";
                }
                else
                {
                    dcg.cod = read.GetString(0);
                    dcg.desc = read.GetString(1);
                }                
                oca.ot.Add(dcg);
            }
            MySqlDataReader read2 = dcg1.traerSegundos();
            while (read2.Read())
            {
                DatosCorrectivoGeneral dcg = new DatosCorrectivoGeneral();
                if (read2.GetString(0) == "" && read2.GetString(1) == "")
                {
                    dcg.cod = " ";
                    dcg.desc = " ";
                }
                else
                {
                    dcg.cod = read2.GetString(0);
                    dcg.desc = read2.GetString(1);
                }
                oca.ot2.Add(dcg);
            }
            MySqlDataReader read3 = dcg1.traerTerceros();
            while (read3.Read())
            {
                DatosCorrectivoGeneral dcg = new DatosCorrectivoGeneral();
                if (read3.GetString(0) == "" && read3.GetString(1) == "")
                {
                    dcg.cod = " ";
                    dcg.desc = " ";
                }
                else
                {
                    dcg.cod = read3.GetString(0);
                    dcg.desc = read3.GetString(1);
                }
                oca.ot3.Add(dcg);
            }
            MySqlDataReader read4 = dcg1.traerTerceros();
            while (read4.Read())
            {
                DatosCorrectivoGeneral dcg = new DatosCorrectivoGeneral();
                if (read4.GetString(0) == "" && read4.GetString(1) == "")
                {
                    dcg.cod = " ";
                    dcg.desc = " ";
                }
                else
                {
                    dcg.cod = read4.GetString(0);
                    dcg.desc = read4.GetString(1);
                }
                oca.ot4.Add(dcg);
            }
            oca.Show();
        }
    }
}
