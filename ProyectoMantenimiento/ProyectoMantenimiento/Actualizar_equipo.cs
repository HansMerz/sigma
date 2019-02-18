using MySql.Data.MySqlClient;
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

namespace ProyectoMantenimiento
{
    public partial class Actualizar_equipo : Form
    {
        OpenFileDialog open = new OpenFileDialog();
        string correctFileName;
        string rutaGlobal;        
        MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
        public static string correFilename = "";
        string path;
        //String ruta;
        public Actualizar_equipo()
        {
            path = "C:\\";
            path += "\\Images\\";            
            InitializeComponent();
            cargarCombo();
        }
        private void cargarCombo()
        {
            EquipoDAL ed = new EquipoDAL();
            comboBox1.DataSource = ed.cargarCombo();
            comboBox1.ValueMember = "id";
            comboBox1.DisplayMember = "localizacion";
            cboGrupo.DataSource = ed.cargarGrupos();
            cboGrupo.DisplayMember = "nombre";
            cboGrupo.ValueMember = "id";
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
        private void limpiar()
        {
            Codigo_ingresado.Text = "";
            txtnombre.Text = "";
            txtaltura.Text = "";
            txtancho.Text = "";
            txtfichas_tecnicas.Text = "";
            txtcodigo.Text = "";
            txtcosto_equipo.Text = "";
            txtfabricante.Text = "";
            txtfuncion.Text = "";
            txtlargo.Text = "";            
            txtmarca.Text = "";
            txtmodelo_equipo.Text = "";
            txtpeso.Text = "";
            txtmarca.Text = "";            
            txtserie_equipo.Text = "";
            Codigo_ingresado.Text = "";
            pictureBox1.Image = null;
            txtcapacidad_produccion.Text = "";
            txtvoltaje.Text = "";
            txt_libra_presion.Text = "";
            txtmanual.Text = "";
            txttipo_aceite.Text = "";
            txttipo_grasa.Text = "";            
            txtdireccion_fabricante.Text = "";
            txtelefono_fabricante.Text = "";
            txtemail_fabricante.Text = "";
            numFrec.Value = 1;
            
        }
        private void button3_Click(object sender, EventArgs e)
        {
            buscar();
        }            
        private void ocultar()
        {

            txtpeso.Visible = false ;
            txtaltura.Visible = false;
            txtancho.Visible = false;
            txtlargo.Visible = false;
            txtfabricante.Visible = false;
            txtmarca.Visible = false;
            txtfichas_tecnicas.Visible = false;
            txtfuncion.Visible = false;            
            txtmodelo_equipo.Visible = false;
            txtserie_equipo.Visible = false;
            txtcosto_equipo.Visible = false;
            txtcapacidad_produccion.Visible = false;
            txtvoltaje.Visible = false;
            txt_libra_presion.Visible = false;
            txtmanual.Visible = false;
            txttipo_aceite.Visible = false;
            txttipo_grasa.Visible = false;
            txtdireccion_fabricante.Visible = false;
            txtelefono_fabricante.Visible = false;
            txtemail_fabricante.Visible = false;
            date_ano_fabricante.Visible = false;
            lblAltura.Visible = false;
            lblAncho.Visible = false;
            lblCaracteristicas.Visible = false;
            lblCosto.Visible = false;
            lblFuncion.Visible = false;
            lblLargo.Visible = false;
            lblMarca.Visible = false;
            lblModelo.Visible = false;
            lblPeso.Visible = false;
            lblSerie.Visible = false;
            lblFabricante.Visible = false;
            lblcapacidad_produccion.Visible = false;
            lblvoltaje.Visible = false;
            lbllibra_presion.Visible = false;
            lblmanual.Visible = false;
            lbltipo_aceite.Visible = false;
            lbltipo_grasa.Visible = false;
            lbldireccion_fabricante.Visible = false;
            lbltelefono_fabricante.Visible = false;
            lblemail_fabricante.Visible = false;
            lblanofabricante.Visible = false;
        }
        private void mostrar()
        {

            txtpeso.Visible = true;
            txtaltura.Visible = true;
            txtancho.Visible = true;
            txtlargo.Visible = true;
            txtfabricante.Visible = true;
            txtmarca.Visible = true;
            txtfichas_tecnicas.Visible = true;
            txtfuncion.Visible = true;            
            txtmodelo_equipo.Visible = true;
            txtserie_equipo.Visible = true;
            txtcosto_equipo.Visible = true;
            txtcapacidad_produccion.Visible = true;
            txtvoltaje.Visible = true;
            txt_libra_presion.Visible = true;
            txtmanual.Visible = true;
            txttipo_aceite.Visible = true;
            txttipo_grasa.Visible = true;
            txtdireccion_fabricante.Visible = true;
            txtelefono_fabricante.Visible = true;
            txtemail_fabricante.Visible = true;
            date_ano_fabricante.Visible = true;
            lblAltura.Visible = true;
            lblAncho.Visible = true;
            lblCaracteristicas.Visible = true;
            lblCosto.Visible = true;
            lblFuncion.Visible = true;
            lblLargo.Visible = true;
            lblMarca.Visible = true;
            lblModelo.Visible = true;
            lblPeso.Visible = true;
            lblSerie.Visible = true;
            lblFabricante.Visible = true;
            lblcapacidad_produccion.Visible = true;
            lblvoltaje.Visible = true;
            lbllibra_presion.Visible = true;
            lblmanual.Visible = true;
            lbltipo_aceite.Visible = true;
            lbltipo_grasa.Visible = true;
            lbldireccion_fabricante.Visible = true;
            lbltelefono_fabricante.Visible = true;
            lblemail_fabricante.Visible = true;
            lblanofabricante.Visible = true;
        }
        private void label8_Click(object sender, EventArgs e)
        {

        }
        private void buscar()
        {
            try
            {
                //Button buscar y mostrar                 
                String comd = string.Format("select * from equipo where codigo = '{0}'", Codigo_ingresado.Text.Trim());

                // Se instancia el data para  traer los datos de la base de datos
                DataRow reader = Conexion.Data(comd).Rows[0];
                DataTable dt = new DataTable();

                //Se identifica que el campo no vaya vacio
                if (Codigo_ingresado.Text == "")
                {
                    MessageBox.Show("El codigo no puede ir vacio", "Revisar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    Codigo_ingresado.Text = "";
                    btnImg.Visible = true;
                    //Muetra los datos de la base de datos en los campos
                    txtcodigo.Text = reader["codigo"].ToString();
                    txtnombre.Text = reader["nombre"].ToString();
                    dateTimePicker1.Text = reader["fecha_ingr_plant"].ToString();
                    if (reader["imagen"].ToString() != "")
                    {
                        pictureBox1.Image = Image.FromFile(path + reader["imagen"].ToString());
                    }
                    else
                    {
                        pictureBox1.Image = null;                     
                    }
                    rutaGlobal = reader["imagen"].ToString();
                    correctFileName = reader["imagen"].ToString();
                    comboBox1.SelectedValue = reader["area_id"].ToString();
                    cboEstado.Text = reader["Estado"].ToString();
                    cboGrupo.SelectedValue = reader["grupo_id"].ToString();
                    numFrec.Value = int.Parse(reader["frecuencia"].ToString());
                    if (reader["tipo"].ToString() == "True")
                    {
                        mostrar();
                        txtpeso.Text = reader["peso"].ToString().Replace(",", ".");                       
                        txtaltura.Text = reader["altura"].ToString().Replace(",", ".");                        
                        txtancho.Text = reader["ancho"].ToString().Replace(",", ".");                        
                        txtlargo.Text = reader["largo"].ToString().Replace(",", ".");
                        txtlargo.Text.Replace(",", ".");
                        txtfabricante.Text = reader["fabricante"].ToString();
                        txtmarca.Text = reader["marca"].ToString();
                        txtfichas_tecnicas.Text = reader["caract_tecni"].ToString();
                        txtfuncion.Text = reader["funcion"].ToString();
                        //pictureBox1.Image = Image.FromFile(paths + "\\Images\\" + read["imagen"]);
                        txtmodelo_equipo.Text = reader["modelo_equipo"].ToString();
                        txtserie_equipo.Text = reader["serie_equipo"].ToString();
                        txtcosto_equipo.Text = reader["costo_equipo"].ToString();
                        txtcapacidad_produccion.Text = reader["capacidad_produccion"].ToString();
                        txtvoltaje.Text = reader["voltaje"].ToString();
                        txt_libra_presion.Text = reader["libra_presion"].ToString();
                        txttipo_aceite.Text = reader["tipo_aceite"].ToString();
                        txtmanual.Text = reader["manual"].ToString();
                        txttipo_grasa.Text = reader["tipo_grasa"].ToString();
                        txtdireccion_fabricante.Text = reader["direccion_fabricante"].ToString();
                        txtelefono_fabricante.Text = reader["telefono_fabricante"].ToString();
                        txtemail_fabricante.Text = reader["email_fabricante"].ToString();
                        date_ano_fabricante.Text = reader["ano_fabricante"].ToString();                        
                    }
                    else
                    {
                        ocultar();
                    }
                }
            }
            catch (Exception)
            {
                limpiar();
                MessageBox.Show("No se encontró ningún equipo o área locativa", "Revisar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtcodigo.Text == "" || txtnombre.Text == "" || comboBox1.Text == "" || cboGrupo.Text == "" || cboEstado.Text == "")
                {
                    MessageBox.Show("El codigo, nombre, localización, grupo y estado no puede estar vacio", "Revisar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {                    
                    equipos equipo = new equipos();
                    equipo.codigo = txtcodigo.Text;
                    equipo.nombre = txtnombre.Text.Trim();
                    equipo.fecha_ingreso_plant = dateTimePicker1.Value.Year + "-" + dateTimePicker1.Value.Month + "-" + dateTimePicker1.Value.Day + " " + DateTime.Now.ToString("hh:mm:ss");
                    equipo.costo_equipo = txtcosto_equipo.Text.Trim();
                    equipo.estado = cboEstado.Text.ToString();
                    equipo.localizacion = comboBox1.SelectedValue.ToString();
                    equipo.serie_equipo = txtserie_equipo.Text.Trim();
                    equipo.modelo_equipo = txtmodelo_equipo.Text;
                    equipo.peso = txtpeso.Text.Trim();
                    equipo.altura = txtaltura.Text.Trim();
                    equipo.ancho = txtancho.Text.Trim();
                    equipo.largo = txtlargo.Text.Trim();
                    equipo.fabricante = txtfabricante.Text.Trim();
                    equipo.marca = txtmarca.Text.Trim();
                    equipo.caracteristicas_tecn = txtfichas_tecnicas.Text.Trim();
                    equipo.funcion = txtfuncion.Text.Trim();
                    equipo.localizacion = comboBox1.SelectedValue.ToString();
                    equipo.capacidad_produccion = txtcapacidad_produccion.Text.Trim();
                    equipo.voltaje = txtvoltaje.Text.Trim();
                    equipo.libra_presion = txt_libra_presion.Text.Trim();
                    equipo.manual = txtmanual.Text.Trim();
                    equipo.tipo_aceite = txttipo_aceite.Text.Trim();
                    equipo.tipo_grasa = txttipo_grasa.Text.Trim();
                    equipo.direccion_fabricante = txtdireccion_fabricante.Text.Trim();
                    equipo.telefono_fabricante = txtelefono_fabricante.Text.Trim();
                    equipo.email_fabricante = txtemail_fabricante.Text.Trim();
                    equipo.ano_fabricante = date_ano_fabricante.Value.Year + "-" + date_ano_fabricante.Value.Month + "-" + date_ano_fabricante.Value.Day + " " + DateTime.Now.ToString("hh:mm:ss");
                    equipo.grupo = cboGrupo.SelectedValue.ToString();
                    equipo.frecuencia = numFrec.Value.ToString();
                    if (rutaGlobal == correctFileName)
                    {
                        equipo.Imagen = correctFileName;
                    }
                    else if(correctFileName != "" && rutaGlobal != correctFileName)
                    {
                        equipo.Imagen = correctFileName;
                        File.Copy(open.FileName, path + correctFileName);
                    }
                    try
                    {
                        int resultado = EquipoDAL.Actualizar_equipo(equipo);

                        if (resultado > 0)
                        {
                            MessageBox.Show("Datos actualizados correctamente", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            limpiar();
                            btnImg.Visible = false;
                        }
                        else
                        {
                            MessageBox.Show("Los datos no han sido actualizados", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Ocurrió un error al actualizar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }                    
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error, no se pudo actualizar", "Revisar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
          /*  if (monthCalendar1.Visible)
            {
                monthCalendar1.Visible = false;
            }
            else
            {
                monthCalendar1.Visible = true;
            }*/
        }

        private void txtfecha_ingr_plant_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            /*monthCalendar1.Visible = false;
            monthCalendar1.Text = monthCalendar1.SelectionEnd.ToLongDateString();
            monthCalendar1.Visible = false;*/
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
           /* monthCalendar1.Visible = false;
            dateTimePicker1.Text = monthCalendar1.SelectionEnd.ToLongDateString();
            monthCalendar1.Visible = false;*/
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void btnImg_Click(object sender, EventArgs e)
        {            
            open.InitialDirectory = "C:\\";
            open.Filter = "Image Files (*.jpg)|*.jpg|All Files(*.*)|*.*";
            open.FilterIndex = 1;

            if (open.ShowDialog() == DialogResult.OK)
            {
                if (open.CheckFileExists)
                {
                    correctFileName = System.IO.Path.GetFileName(open.FileName);                                        
                    pictureBox1.Image = Image.FromFile(open.FileName);
                }
            }
        }

        private void lblCaracteristicas_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_2(object sender, EventArgs e)
        {
            
        }

        private void Actualizar_equipo_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Codigo_ingresado_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                buscar();
            }
        }
    }
}
