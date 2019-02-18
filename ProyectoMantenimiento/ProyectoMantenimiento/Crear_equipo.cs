using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ProyectoMantenimiento
{
    public partial class Equipo : Form
    {
        public bool IsPotsBack { get; private set; }


        // Se crea la variable correFilname para poderse utilizar en la Path y enviar la ruta de la imagen
        string correFilename = "";
        string paths;
        OpenFileDialog open = new OpenFileDialog();

        public Equipo()
        {
            InitializeComponent();
            cargarCombo();
            paths = "C:\\";            
            paths += "\\Images\\";            
        }

        private void Crear_equipo_Load(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }
        protected void Page_load()
        {
        }


        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void monthCalendar2_DateChanged(object sender, DateRangeEventArgs e)
        {


        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void button3_Click(object sender, EventArgs e)
        {

            open.InitialDirectory = "C:\\";
            open.Filter = "Image Files (*.jpg)|*.jpg|All Files(*.*)|*.*";
            open.FilterIndex = 1;

            if (open.ShowDialog() == DialogResult.OK)
            {
                if (open.CheckFileExists)
                {
                    correFilename = System.IO.Path.GetFileName(open.FileName);
                    picimagen.Image = Image.FromFile(open.FileName);
                }
            }
        }

        public void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void bindingNavigator1_RefreshItems(object sender, EventArgs e)
        {

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        /*public static String guardarImagen(Image imagen)
         {

             using (MemoryStream ms = new MemoryStream())
             {

                 Equipo crear = new Equipo();
                 imagen.Save(ms, ImageFormat.Jpeg);
                 byte[] imgArr = ms.ToArray();
                 return imgArr.ToString();
             }
         }*/

        private void button5_Click(object sender, EventArgs e)
        {
            if (txtnombre.Text != "" || cboEstado.Text != "" || cboGrup.Text != "" || txtlocalizacion.Text != "" || comboBox1.Text != "" || numFrec.Value != 0)
            {

                // Se llama la clase para traer las entidades
                equipos equipo = new equipos();
                int condicion;

                if (comboBox1.Text == "Equipo")
                {
                    condicion = 1;

                }
                else
                {
                    condicion = 0;

                }


                // Se asignan los valores a cada campo que se enviara a la base de datos
                equipo.codigo = txtcodigo.Text.Trim();
                equipo.nombre = txtnombre.Text.Trim();
                equipo.localizacion = txtlocalizacion.SelectedValue.ToString();
                equipo.fecha_ingreso_plant = dateTimePicker1.Value.Year + "-" + dateTimePicker1.Value.Month + "-" + dateTimePicker1.Value.Day + " " + DateTime.Now.ToString("hh:mm:ss");
                equipo.fecha_ingreso_siste = dateTimePicker2.Value.Year + "-" + dateTimePicker2.Value.Month + "-" + dateTimePicker2.Value.Day + " " + DateTime.Now.ToString("hh:mm:ss");
                equipo.costo_equipo = txtcosto_equipo.Text.Trim();
                equipo.modelo_equipo = txtmodelo_equipo.Text.Trim();
                equipo.serie_equipo = txtserie_equipo.Text.Trim();
                equipo.peso = txtpeso.Text.Trim();
                equipo.altura = txtaltura.Text.Trim();
                equipo.ancho = txtancho.Text.Trim();
                equipo.largo = txtlargo.Text.Trim();
                equipo.fabricante = txtfabricante.Text.Trim();
                equipo.marca = txtmarca.Text.Trim();
                equipo.realiza_por = txtrealizado_por.Text.Trim();
                equipo.caracteristicas_tecn = txtcaracte_tecn.Text.Trim();
                equipo.funcion = txtfuncion.Text.Trim();
                equipo.Imagen = correFilename;
                equipo.tipo = condicion.ToString();
                equipo.capacidad_produccion = txtcapacidad_produccion.Text.Trim();
                equipo.voltaje = txtvoltaje.Text.Trim();
                equipo.libra_presion = txtlibra_presion.Text.Trim();
                equipo.manual = txtmanual.Text.Trim();
                equipo.tipo_aceite = txttipo_aceite.Text.Trim();
                equipo.tipo_grasa = txttipo_grasa.Text.Trim();
                equipo.direccion_fabricante = txtdireccion_fabricante.Text.Trim();
                equipo.telefono_fabricante = txttelefono_fabricante.Text.Trim();
                equipo.email_fabricante = txtemail_fabricante.Text.Trim();
                equipo.ano_fabricante = date_ano_fabricacion.Value.Year + "-" + date_ano_fabricacion.Value.Month + "-" + date_ano_fabricacion.Value.Day + " " + DateTime.Now.ToString("hh:mm:ss");
                equipo.estado = cboEstado.Text.ToString();
                equipo.grupo = cboGrup.SelectedValue.ToString();
                equipo.frecuencia = numFrec.Value.ToString();

                if (condicion == 0)
                {
                    //Se hace validacion para que los campos no se vallan vacios
                    if (txtcodigo.Text.Length == 0 || txtnombre.Text.Length == 0 || txtlocalizacion.Text == "" || cboEstado.Text == "" || comboBox1.Text.Length == 0 || cboGrup.SelectedValue.ToString() == "")
                    {
                        MessageBox.Show("Los campos codigo, nombre, localización, estado, grupo y tipo no pueden ir vacios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        try
                        {
                            String code = EquipoDAL.consultarExistente(equipo.codigo);

                            if (code == equipo.codigo)
                            {
                                MessageBox.Show("El código ya existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                if (correFilename != "")
                                {                                
                                    File.Copy(open.FileName, paths + correFilename);
                                }                                
                                int resultado = EquipoDAL.Agregar(equipo);
                                // Se valida que se envie datos
                                if (resultado < 0)
                                {
                                    MessageBox.Show("No se pudo guardar correctamente", "No guardado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                }
                                else
                                {
                                    MessageBox.Show("Área locativa guardada correctamente", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    limpiar();
                                }
                            }
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Error, la imagen ya se encuentra. Por favor elegir otra imagen o cambiarle el nombre", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
                else
                {
                    if (txtcodigo.Text.Length == 0 || txtnombre.Text.Length == 0 || comboBox1.Text.Length == 0 || txtmodelo_equipo.Text == "" || txtserie_equipo.Text == "" || correFilename.Length == 0 || 
                        cboGrup.SelectedValue.ToString() == "" || txtlocalizacion.Text == "" || txtfuncion.Text == "" || cboEstado.Text == "" || txtcaracte_tecn.Text == "")
                    {
                        MessageBox.Show("Los campos codigo, nombre, tipo, modelo, serie, función, característica técnica, estado, grupo, localización e imagen no pueden estar vacios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        try
                        {
                            String code = EquipoDAL.consultarExistente(equipo.codigo);

                            if (code == equipo.codigo)
                            {
                                MessageBox.Show("El código ya existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                File.Copy(open.FileName, paths + correFilename);
                                int resultado = EquipoDAL.Agregar(equipo);

                                // Se valida que se envie datos
                                if (resultado < 0)
                                {
                                    MessageBox.Show("No se pudo guardar correctamente", "No guardado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                                else
                                {
                                    MessageBox.Show("Equipo guardado correctamente", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    limpiar();
                                }
                            }
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Error, la imagen ya se encuentra. Por favor elegir otra imagen o cambiarle el nombre", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Hay campos vacíos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem.ToString() == "Área locativa")
            {
                panel1.Visible = false;
                txtmodelo_equipo.Visible = false;
                txtcosto_equipo.Visible = false;
                txtserie_equipo.Visible = false;
                lblModelo.Visible = false;
                //lblModeloLine.Visible = false;
                //lblCosto.Visible = false;
                //lblCostoLine.Visible = false;
                lblSerie.Visible = false;
                //lblSerieLine.Visible = false;
            }
            else
            {
                panel1.Visible = true;
                txtmodelo_equipo.Visible = true;
                txtcosto_equipo.Visible = true;
                txtserie_equipo.Visible = true;
                lblModelo.Visible = true;
                //lblModeloLine.Visible = true;
                lblCosto.Visible = true;
                //lblCostoLine.Visible = true;
                lblSerie.Visible = true;
                //lblSerieLine.Visible = true;
            }
        }

        private void limpiar()
        {
            txtnombre.Text = "";
            txtaltura.Text = "";
            txtancho.Text = "";
            txtcaracte_tecn.Text = "";
            txtcodigo.Text = "";
            txtcosto_equipo.Text = "";
            txtfabricante.Text = "";
            txtfuncion.Text = "";
            txtlargo.Text = "";
            txtmarca.Text = "";
            txtmodelo_equipo.Text = "";
            txtpeso.Text = "";
            txtrealizado_por.Text = "";
            txtserie_equipo.Text = "";
            txtcapacidad_produccion.Text = "";
            txtvoltaje.Text = "";
            txtlibra_presion.Text = "";
            txtmanual.Text = "";
            txttipo_aceite.Text = "";
            txttipo_grasa.Text = "";
            txtdireccion_fabricante.Text = "";
            txttelefono_fabricante.Text = "";
            txtemail_fabricante.Text = "";
            date_ano_fabricacion.Text = "";
            numFrec.Value = 1;

            //picimagen.Image.Dispose();
            picimagen.Image = null;
        }
        private void cargarCombo()
        {
            txtlocalizacion.Items.Clear();
            EquipoDAL ed = new EquipoDAL();
            txtlocalizacion.DataSource = ed.cargarCombo();
            txtlocalizacion.DisplayMember = "localizacion";
            txtlocalizacion.ValueMember = "id";
            cboGrup.DataSource = ed.cargarGrupos();
            cboGrup.DisplayMember = "nombre";
            cboGrup.ValueMember = "id";
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            new Visualizar().ShowDialog();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Hide();
            new Actualizar_equipo().ShowDialog();
            Show();
        }

        private void button3_Click_2(object sender, EventArgs e)
        {
            Hide();
            new Hoja_vida_equipo().ShowDialog();
            Show();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtcapacidad_produccion_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtmodelo_equipo_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            Hide();
            new Fecha_Tecnica().ShowDialog();
            Show();
        }
    }
}
