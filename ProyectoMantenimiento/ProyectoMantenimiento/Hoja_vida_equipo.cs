using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using MySql.Data.MySqlClient;
using Image = System.Drawing.Image;

namespace ProyectoMantenimiento
{
    public partial class Hoja_vida_equipo : Form
    {
        EquipoDAL ed;
        DatosHojaVida dhv;
        ActividadYFallo ayf;        
        MantenimientoPersonaClass mpc;
        string path = "C:\\";        
        public Hoja_vida_equipo()
        {
            InitializeComponent();
            ed = new EquipoDAL();
            dhv = new DatosHojaVida();
            ayf = new ActividadYFallo();            
            mpc = new MantenimientoPersonaClass();
            path += "\\Images\\";
            dgv_mantenimiento.RowHeadersVisible = false;
            dataGridView1.RowHeadersVisible = false;
            dgFallos.RowHeadersVisible = false;
            dgActividades.RowHeadersVisible = false;
            dgEncargados.RowHeadersVisible = false;
        }
        public void cargarTabla(String val)
        {
            lblCostoMan.Text = "";
            int cantidad = int.Parse(ed.consultarCantidadMantenimientos(val));
            if (cantidad > 0)
            {
                dgv_mantenimiento.DataSource = ed.cargarTablaHojaVida(val);
                DataRow costo = ed.costoTotalMantenimiento(val).Rows[0];
                lblCostoMan.Text = costo["Costo"].ToString();
            }            
        }
        public void buscar()
        {
            try
            {
                if (txtcodigoingresado.Text == "")
                {
                    MessageBox.Show("El código no puede estar vacío", "Revisar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    vaciarTablas();
                    String comando = string.Format("SELECT e.codigo, e.nombre, e.serie_equipo, e.imagen, a.localizacion, e.estado, e.modelo_equipo FROM equipo e INNER JOIN area a ON e.area_id = a.id" +
                    " WHERE e.codigo = '{0}' group by e.codigo", txtcodigoingresado.Text.Trim());
                    cargarTabla(txtcodigoingresado.Text.Trim());
                    DataRow reader = Conexion.Data(comando).Rows[0];
                    txtcodigoingresado.Text = "";
                    txtcodigo.Text = reader["codigo"].ToString();
                    txtequipo_arealocativa.Text = reader["nombre"].ToString();
                    txtserial.Text = reader["serie_equipo"].ToString();
                    txtlocalizacion.Text = reader["localizacion"].ToString();
                    txtcodigo_inventario.Text = reader["modelo_equipo"].ToString();
                    if (reader["imagen"].ToString() != "")
                    {
                        pictureBox1.Image = Image.FromFile(path + reader["imagen"].ToString());
                        pictureBox1.Tag = path + reader["imagen"].ToString();
                    }
                    else
                    {
                        pictureBox1.Image = null;
                        pictureBox1.Tag = "";
                    }                                  
                    lblTotalMantenimientos.Text = dgv_mantenimiento.Rows.Count.ToString();
                    txtEstado.Text = reader["estado"].ToString();
                }

            }
            catch (Exception)
            {
                vaciarTablas();
                vaciarCampos();
                MessageBox.Show("El código ingresado no coincide", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void vaciarTablas()
        {
            dataGridView1.Rows.Clear();
            dgFallos.Rows.Clear();
            dgActividades.Rows.Clear();            
            dgEncargados.Rows.Clear();
            dgv_mantenimiento.DataSource = null;
        }
        private void vaciarCampos()
        {
            txtcodigoingresado.Text = "";
            txtcodigo.Text = "";
            txtequipo_arealocativa.Text = "";
            txtserial.Text = "";
            txtlocalizacion.Text = "";
            txtcodigo_inventario.Text = "";
            pictureBox1.Image = null;
            pictureBox1.Tag = null;
            lblTotalMantenimientos.Text = "";
            txtEstado.Text = "";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            buscar();
        }

        private void dgv_mantenimiento_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {                   
            try
            {
                HojaDeVida hoja;
                dhv.codigo = txtcodigo.Text;
                dhv.nombre = txtequipo_arealocativa.Text;
                dhv.modelo = txtcodigo_inventario.Text;
                dhv.estado = txtEstado.Text;
                dhv.serial = txtserial.Text;
                dhv.localizacion = txtlocalizacion.Text;
                dhv.totalman = lblTotalMantenimientos.Text;
                dhv.costototal = lblCostoMan.Text;
                dhv.imagen = "\\Images\\"+Path.GetFileName(pictureBox1.Tag.ToString());                
                hoja = new HojaDeVida(dhv.imagen);
                hoja.dhv.Add(dhv);
                /*DataSetHerramientas dsh = new DataSetHerramientas();
                dsh.Tables["Img"].Rows.Add(new object[]
                { dhv.imagen }
                );*/
                for (int i = 0; i < dgv_mantenimiento.Rows.Count; i++)
                {
                    DatosEquipoMan dem = new DatosEquipoMan();
                    dem.ID = dgv_mantenimiento[0, i].Value.ToString();
                    dem.tipo = dgv_mantenimiento[1, i].Value.ToString();
                    dem.numorden = dgv_mantenimiento[2, i].Value.ToString();
                    dem.fechainicio = dgv_mantenimiento[3, i].Value.ToString();
                    dem.fechafin = dgv_mantenimiento[4, i].Value.ToString();
                    dem.tiempoejecucion = dgv_mantenimiento[5, i].Value.ToString();
                    dem.observacion = dgv_mantenimiento[6, i].Value.ToString();
                    MySqlDataReader reader = ayf.consultarFallosMantenimiento(dem.ID);
                    dem.fallo = "";
                    while (reader.Read())
                    {
                        dem.fallo += reader.GetString(1) + ". ";
                    }
                    MySqlDataReader reader2 = ayf.consultarActividadesMantenimiento(dem.ID);
                    dem.actividades = "";
                    while (reader2.Read())
                    {
                        dem.actividades += reader2.GetString(1) + ". ";
                    }
                    MySqlDataReader reader3 = ed.verInsumos(dem.ID);
                    while (reader3.Read())
                    {
                        dem.insumos += reader3.GetString(1) + " / " + reader3.GetString(2) + " / $" + reader3.GetString(3) + ". ";
                    }
                    MySqlDataReader reader4 = mpc.consultarEncargadosReader(dem.ID);
                    while (reader4.Read())
                    {
                        dem.trabajadores += reader4.GetString(1) + ". ";
                    }
                    hoja.em.Add(dem);                    
                }

                hoja.ShowDialog();
            }
            catch (Exception)
            {
                MessageBox.Show("Primero busca el equipo o área locativa", "Revisar", MessageBoxButtons.OK, MessageBoxIcon.Warning);                
            }            
            
        }

        private void button3_Click(object sender, EventArgs e)
        {          
        }

        private void Hoja_vida_equipo_Load(object sender, EventArgs e)
        {

        }

        private void dgv_mantenimiento_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int ult = dgv_mantenimiento.Rows.Count;
            if (e.RowIndex >= 0 && e.RowIndex < ult)
            {
                String id = dgv_mantenimiento[0, e.RowIndex].Value.ToString();
                MySqlDataReader row = ed.verInsumos(id);
                dataGridView1.Rows.Clear();
                while (row.Read())
                {
                    dataGridView1.Rows.Add(row.GetString(1), row.GetString(2), row.GetString(3));
                }
                dgFallos.Rows.Clear();
                MySqlDataReader reader = ayf.consultarFallosMantenimiento(id);
                while (reader.Read())
                {
                    dgFallos.Rows.Add(reader.GetString(0), reader.GetString(1));
                }
                dgActividades.Rows.Clear();
                MySqlDataReader reader2 = ayf.consultarActividadesMantenimiento(id);
                while (reader2.Read())
                {
                    dgActividades.Rows.Add(reader2.GetString(0), reader2.GetString(1));
                }
                MySqlDataReader reader3 = mpc.consultarEncargadosReader(id);
                dgEncargados.Rows.Clear();
                while (reader3.Read())
                {
                    dgEncargados.Rows.Add(reader3.GetString(1));
                }
            }            
        }

        private void txtcodigoingresado_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtcodigoingresado_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void txtcodigoingresado_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                buscar();
            }
        }
    }
}
