using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
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
    public partial class MantenimientosEjecutados : Form
    {
        //Se declaran 5 variables, dos de tipo String, una de la clase Mantenimiento, otra de la clase MantenimientoHerramienta
        //otra de la clase MantenimientoPersona        
        MantenimientoClass mc;        
        MantenimientoPersonaClass mpc;
        InsumosClass ic;
        DatosMantenimiento dm = new DatosMantenimiento();        
        public String[] encargados;
        public String[] herramientas;
        public String[] insumos;
        public String[] cantidadIns;
        public String[] cantidadHer;
        public String[] precioIns;
        public String proceso;
        public String num_orden;
        public String id, id2;
        public String tipo_mantenimiento, fecha_dano, fecha_hora_inicio, fecha_hora_fin, equipo, fecha_prevista, solicita,
            fecha_solicita, precioTotal, tiempo_ejecucion, grupo, localizacion;        
        public MantenimientosEjecutados()
        {
            //Se instancian las variables mencionadas y se cargan los métodos cargarTabla, cargarPrecios, e inhabilitar
            InitializeComponent();
            mc = new MantenimientoClass();            
            mpc = new MantenimientoPersonaClass();
            ic = new InsumosClass();
            cargarPrecios("");
            inhabilitar();
            dataGridView1.RowHeadersVisible = false;
            dataGridView2.RowHeadersVisible = false;            
            dgIns.RowHeadersVisible = false;
            dgTra.RowHeadersVisible = false;
            deshabilitarOrden();
        }
        private void deshabilitarOrden()
        {
            foreach (DataGridViewColumn Col in dataGridView1.Columns)
            {
                Col.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            foreach (DataGridViewColumn Col in dataGridView2.Columns)
            {
                Col.SortMode = DataGridViewColumnSortMode.NotSortable;
            }            
        }
        private void consultarEncargados()
        {
            dgTra.Rows.Clear();
            MySqlDataReader reader = mpc.consultarEncargadosCantidad(id);
            Int64 j = 0;
            while (reader.Read())
            {
                j = reader.GetInt64(0);
                encargados = new String[reader.GetInt64(0)];                                
            }
            DataTable tb = mpc.consultarEncargados(id);
            DataSetHerramientas dt = new DataSetHerramientas();
            int i = 0;
            foreach (DataRow row in tb.Rows)
            {                
                encargados[i] = row["nombres"].ToString();                             
                dgTra.Rows.Add(encargados[i]);
                i++;
            }
        }       
        private void consultarInsumos()
        {
            dgIns.Rows.Clear();
            MySqlDataReader reader = ic.consultarInsumosCantidad(id);
            Int64 j = 0;
            while (reader.Read())
            {
                j = reader.GetInt64(0);
                insumos = new String[reader.GetInt64(0)];
                precioIns = new String[reader.GetInt64(0)];
                cantidadIns = new String[reader.GetInt64(0)];
                //dm.insumos = new String[reader.GetInt64(0)];
                //dm.precioIns = new String[reader.GetInt64(0)];
                //dm.cantidadIns = new String[reader.GetInt64(0)];
            }
            DataTable tb = ic.consultarInsumos(id);
            int i = 0;
            foreach (DataRow row in tb.Rows)
            {                
                String[] cuente = row["InsCan"].ToString().Split('-');
                for (int h = 0; h < cuente.Length; h++)
                {                    
                    if (h % 2 == 0)
                    {
                        insumos[i] = cuente[h];                                         
                    }
                    else
                    {
                        cantidadIns[i] = cuente[h];                        
                    }                    
                }                
                precioIns[i] = row["precio"].ToString();                
                dgIns.Rows.Add(insumos[i], cantidadIns[i], precioIns[i]);
                i++;
            }
        }
        private void consultarProceso()
        {
            DataRow row = mc.consultarTodo(id).Rows[0];
            proceso = row["observacion"].ToString();
        }
        private void habilitar()
        {
            //Este método habilita los botones de ver el proces, de ver las personas, herramientas e insumos utilizados
            //y el botón para imprimir
            btnVer1.Enabled = true;
            btnVer2.Enabled = true;
            btnImprimir.Enabled = true;

            btnVer1.BackColor = Color.Blue;
            btnVer2.BackColor = Color.Teal;
            btnImprimir.BackColor = Color.DarkGreen;
        }
        private void inhabilitar()
        {
            //Este método deshabilita los botones de ver el proces, de ver las personas, herramientas e insumos utilizados
            //y el botón para imprimir
            btnVer1.Enabled = false;
            btnVer2.Enabled = false;
            btnImprimir.Enabled = false;

            btnVer1.BackColor = Color.LightGray;
            btnVer2.BackColor = Color.LightGray;
            btnImprimir.BackColor = Color.LightGray;
        }        
        public void cargarPrecios(String val)
        {
            //Este método carga los costos de cada mantenimiento
            dataGridView2.Rows.Clear();
            dataGridView1.DataSource =  mc.cargarEjecutados(val);
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                dataGridView2.Rows.Add(mc.cargarPrecios(dataGridView1[0, i].Value.ToString()));
            }            
        }

        private void dataGridView1_Scroll(object sender, ScrollEventArgs e)
        {
            dataGridView2.FirstDisplayedScrollingRowIndex = e.NewValue;
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            EjecutadosInforme pei = new EjecutadosInforme();
            ActividadYFallo ayf = new ActividadYFallo();
            dm.id = id2;
            dm.num_orden = num_orden;
            dm.tipo_mantenimiento = tipo_mantenimiento;
            dm.proceso = proceso;
            dm.tiempo_ejecucion = tiempo_ejecucion;
            dm.solicita = solicita;
            dm.equipo = equipo;
            dm.grupo = grupo;
            dm.localizacion = localizacion;
            dm.fecha_dano = fecha_dano;
            dm.fecha_hora_fin = fecha_hora_fin;
            dm.fecha_hora_inicio = fecha_hora_inicio;
            dm.fecha_prevista = fecha_prevista;
            dm.fecha_solicita = fecha_solicita;
            dm.precioTotal = precioTotal;

            pei.datosM.Add(dm);

            for (int i = 0; i < encargados.Length; i++)
            {
                PruebaEncargados pe = new PruebaEncargados();
                pe.encargados = encargados[i];
                pei.datosE.Add(pe);
            }

            /*for (int i = 0; i < herramientas.Length; i++)
            {
                PruebaHerramienta ph = new PruebaHerramienta();
                ph.nombre = herramientas[i];
                ph.cantidad = cantidadHer[i];
                pei.datosH.Add(ph);
            }*/

            for (int i = 0; i < insumos.Length; i++)
            {
                PruebaInsumos pi = new PruebaInsumos();
                pi.nombre = insumos[i];
                pi.cantidad = cantidadIns[i];
                pi.precio = precioIns[i];
                pei.datosI.Add(pi);
            }                            
            MySqlDataReader reader = ayf.consultarFallosMantenimiento(id);
            while (reader.Read())
            {
                DatosFallas df = new DatosFallas();
                df.cod = reader.GetString(0);
                df.desc = reader.GetString(1);
                pei.datosF.Add(df);
            }
            MySqlDataReader reader2 = ayf.consultarActividadesMantenimiento(id);
            while (reader2.Read())
            {            
                DatosActividades da = new DatosActividades();                
                da.cod = reader2.GetString(0);
                da.desc = reader2.GetString(1);
                pei.datosA.Add(da);
            }

            pei.Show();
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            String val = textBox1.Text;
            cargarPrecios(val);
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Obtiene el id y número de orden del mantenimiento seleccionado
            int ult = dataGridView1.Rows.Count;
            if (e.RowIndex >= 0 && e.RowIndex < ult)
            {
                id = dataGridView1[0, e.RowIndex].Value.ToString();
                id2 = dataGridView1[7, e.RowIndex].Value.ToString();
                num_orden = dataGridView1[1, e.RowIndex].Value.ToString();
                tipo_mantenimiento = dataGridView1[2, e.RowIndex].Value.ToString();
                fecha_dano = dataGridView1[3, e.RowIndex].Value.ToString();
                fecha_hora_inicio = dataGridView1[4, e.RowIndex].Value.ToString();
                fecha_hora_fin = dataGridView1[5, e.RowIndex].Value.ToString();
                tiempo_ejecucion = dataGridView1[6, e.RowIndex].Value.ToString();
                equipo = dataGridView1[8, e.RowIndex].Value.ToString();
                grupo = dataGridView1[9, e.RowIndex].Value.ToString();
                localizacion = dataGridView1[10, e.RowIndex].Value.ToString();
                fecha_prevista = dataGridView1[11, e.RowIndex].Value.ToString();
                solicita = dataGridView1[12, e.RowIndex].Value.ToString();
                fecha_solicita = dataGridView1[13, e.RowIndex].Value.ToString();
                precioTotal = dataGridView2[0, e.RowIndex].Value.ToString();
                habilitar();
                consultarEncargados();
                consultarInsumos();
                consultarProceso();
            }
            else
            {
                MessageBox.Show("Escoge un campo válido", "Revisar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                inhabilitar();
            }
        }

        private void dgPre_Scroll(object sender, ScrollEventArgs e)
        {           
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //Muestra las personas, herramientas e insumos utilizados en ese mantenimiento
            new VerPerHerIns(this).Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Muestra el proceso realizado
            new VerProceso(this).Show();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
       
        }

        private void dataGridView2_Scroll(object sender, ScrollEventArgs e)
        {
            dataGridView1.FirstDisplayedScrollingRowIndex = e.NewValue;
        }

        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            //Obtiene el id y número de orden del mantenimiento seleccionado
            int ult = dataGridView1.Rows.Count;
            if (e.RowIndex >= 0 && e.RowIndex < ult)
            {
                id = dataGridView1[0, e.RowIndex].Value.ToString();
                id2 = dataGridView1[7, e.RowIndex].Value.ToString();
                num_orden = dataGridView1[1, e.RowIndex].Value.ToString();
                tipo_mantenimiento = dataGridView1[2, e.RowIndex].Value.ToString();
                fecha_dano = dataGridView1[3, e.RowIndex].Value.ToString();
                fecha_hora_inicio = dataGridView1[4, e.RowIndex].Value.ToString();
                fecha_hora_fin = dataGridView1[5, e.RowIndex].Value.ToString();
                tiempo_ejecucion = dataGridView1[6, e.RowIndex].Value.ToString();
                equipo = dataGridView1[8, e.RowIndex].Value.ToString();
                grupo = dataGridView1[9, e.RowIndex].Value.ToString();
                localizacion = dataGridView1[10, e.RowIndex].Value.ToString();
                fecha_prevista = dataGridView1[11, e.RowIndex].Value.ToString();
                solicita = dataGridView1[12, e.RowIndex].Value.ToString();
                fecha_solicita = dataGridView1[13, e.RowIndex].Value.ToString();
                precioTotal = dataGridView2[0, e.RowIndex].Value.ToString();
                habilitar();
                consultarEncargados();
                consultarInsumos();
                consultarProceso();
            }
            else
            {
                MessageBox.Show("Escoge un campo válido", "Revisar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                inhabilitar();
            }
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Obtiene el id y número de orden del mantenimiento seleccionado
            int ult = dataGridView1.Rows.Count;
            if (e.RowIndex >= 0 && e.RowIndex < ult)
            {
                id = dataGridView1[0, e.RowIndex].Value.ToString();
                num_orden = dataGridView1[1, e.RowIndex].Value.ToString();
                habilitar();
            }
            else
            {
                MessageBox.Show("Escoge un campo válido", "Revisar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                inhabilitar();
            }
        }
    }
}
