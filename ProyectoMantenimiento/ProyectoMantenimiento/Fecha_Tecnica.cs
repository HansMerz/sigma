using iTextSharp.text;
using iTextSharp.text.pdf;
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
using MySql.Data.MySqlClient;
using System.Drawing.Imaging;

namespace ProyectoMantenimiento
{
    public partial class Fecha_Tecnica : Form
    {
        String id;
        public Fecha_Tecnica()
        {
            InitializeComponent();
        }

        private void Fecha_Tecnica_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Fecha_Tecnica redi = new Fecha_Tecnica();
            redi.Show();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            try
            {

            }
            catch (Exception Error)
            {
                MessageBox.Show("Error" + Error);
            }
        }
        private void buscar()
        {
            try
            {
                if (txtcodigoingresado.Text == "")
                {
                    MessageBox.Show("El código no puede ir vacío", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    String comando = String.Format("SELECT e.codigo, e.nombre, e.fabricante, e.modelo_equipo, e.marca, e.peso, " +
                "e.altura, e.ancho, e.largo, e.funcion, e.imagen, e.caract_tecni, a.localizacion FROM equipo e JOIN area a ON e.area_id = a.id" +
                " where e.codigo = '{0}'", txtcodigoingresado.Text.Trim());

                    // Se llaman los datos para mostrarlos en el PDF
                    DataRow reader = Conexion.Data(comando).Rows[0];                                  
                    //Ruta de la imagen
                    string paths = "C:\\";
                    txtcodigoingresado.Text = "";
                    //Se leen los datos de la BD
                    id = reader["codigo"].ToString();
                    txtequipoArea.Text = reader["nombre"].ToString();
                    txtfabricante.Text = reader["fabricante"].ToString();
                    txtmodelo.Text = reader["modelo_equipo"].ToString();
                    txtmarca.Text = reader["marca"].ToString();                    
                    txtpeso.Text = reader["peso"].ToString();
                    txtaltura.Text = reader["altura"].ToString();
                    txtancho.Text = reader["ancho"].ToString();
                    txtlargo.Text = reader["largo"].ToString();
                    txtcaract_tecni.Text = reader["caract_tecni"].ToString();
                    txtfuncion.Text = reader["funcion"].ToString();
                    txtlocalizacion.Text = reader["localizacion"].ToString();
                    txtinventario.Text = reader["codigo"].ToString();
                    if(reader["imagen"].ToString() != "")
                    {
                        pictureBox1.Image = System.Drawing.Image.FromFile(paths + "\\Images\\" + reader["imagen"].ToString());
                    }
                    else
                    {
                        pictureBox1.Image = null;                     
                    }
                }                
            }
            catch (Exception)
            {
                vaciarCampos();
                MessageBox.Show("Ocurrió un error al buscar el equipo o área locativa", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void vaciarCampos()
        {
            txtcodigoingresado.Text = "";
            txtequipoArea.Text = "";
            txtfabricante.Text = "";
            txtmodelo.Text = "";
            txtmarca.Text = "";
            txtpeso.Text = "";
            txtaltura.Text = "";
            txtancho.Text = "";
            txtlargo.Text = "";
            txtcaract_tecni.Text = "";
            txtfuncion.Text = "";
            txtlocalizacion.Text = "";
            txtinventario.Text = "";
            pictureBox1.Image = null;
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            buscar();
        }

        public System.Drawing.Image Base64ToImage(string base64String)
        {
            // Convierte tu string 64 a un byte[]
            var imagenBytes = Convert.FromBase64String(base64String);
            var ms = new MemoryStream(imagenBytes, 0,
                imagenBytes.Length);

            // Convierte tu byte[] a imagen 
            ms.Write(imagenBytes, 0, imagenBytes.Length);
            var image = System.Drawing.Image.FromStream(ms, true);
            return image;
        }

        private void button1_Click_1(object sender, EventArgs e, string imageByte)
        {        
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
           /* try
            {*/
                String comando = String.Format("SELECT * FROM equipo WHERE codigo = '{0}'", id);
                string paths = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10));

                //Se lee los datos de la base de datos
                DataRow reader = Conexion.Data(comando).Rows[0];
                //Variable de salto de linea
                Paragraph saltoDeLinea = new Paragraph("                                                                                                                                                                                                                                                                                                                                                                                   ");

                //Se trae la fecha actual
                DateTime fecha_actual = DateTime.Now;

                //Se inicializa el documento PDF
                Document doc = new Document(iTextSharp.text.PageSize.LETTER, 10, 10, 42, 35);
                doc.SetMargins(0, 0, 10, 10);
                PdfWriter wri = PdfWriter.GetInstance(doc, new FileStream(@"C:\fichas_tecnicas\" + reader["nombre"] + ".pdf", FileMode.Create));

                doc.Open();

                iTextSharp.text.Image PNG = iTextSharp.text.Image.GetInstance("Cabecera.PNG");
                doc.Add(PNG);

                Paragraph paragrah1 = new Paragraph("Ficha técnica", FontFactory.GetFont("Arial", 20));
                paragrah1.Alignment = Element.ALIGN_CENTER;
                doc.Add(paragrah1);

                doc.Add(saltoDeLinea);


                //Se crea la tabla para mostrar los datos de la BD
                iTextSharp.text.pdf.PdfPTable table = new iTextSharp.text.pdf.PdfPTable(10);
                PdfPCell celda1 = new PdfPCell(new Paragraph("Código", FontFactory.GetFont("Tahoma", 10)));
                table.AddCell(celda1);
                PdfPCell celda2 = new PdfPCell(new Paragraph("Nombre", FontFactory.GetFont("Tahoma", 10)));
                table.AddCell(celda2);
                PdfPCell celda3 = new PdfPCell(new Paragraph("Costo del equipo", FontFactory.GetFont("Tahoma", 10)));
                table.AddCell(celda3);
                PdfPCell celda4 = new PdfPCell(new Paragraph("Modelo del equipo", FontFactory.GetFont("Tahoma", 10)));
                table.AddCell(celda4);
                PdfPCell celda5 = new PdfPCell(new Paragraph("Capacidad de producción", FontFactory.GetFont("Tahoma", 10)));
                table.AddCell(celda5);
                PdfPCell celda6 = new PdfPCell(new Paragraph("Peso equipo", FontFactory.GetFont("Tahoma", 10)));
                table.AddCell(celda6);
                PdfPCell celda7 = new PdfPCell(new Paragraph("Altura equipo", FontFactory.GetFont("Tahoma", 10)));
                table.AddCell(celda7);
                PdfPCell celda8 = new PdfPCell(new Paragraph("Ancho equipo", FontFactory.GetFont("Tahoma", 10)));
                table.AddCell(celda8);
                PdfPCell celda9 = new PdfPCell(new Paragraph("Largo equipo".ToString(), FontFactory.GetFont("Tahoma", 10)));
                table.AddCell(celda9);
                PdfPCell celda10 = new PdfPCell(new Paragraph("Marca equipo", FontFactory.GetFont("Tahoma", 10)));
                table.AddCell(celda10);
                PdfPCell celda12 = new PdfPCell(new Paragraph(reader["codigo"].ToString(), FontFactory.GetFont("Times New Roman", 8)));
                table.AddCell(celda12);
                PdfPCell celda13 = new PdfPCell(new Paragraph(reader["nombre"].ToString(), FontFactory.GetFont("Times New Roman", 8)));
                table.AddCell(celda13);
                PdfPCell celda14 = new PdfPCell(new Paragraph(reader["costo_equipo"].ToString(), FontFactory.GetFont("Times New Roman", 8)));
                table.AddCell(celda14);
                PdfPCell celda15 = new PdfPCell(new Paragraph(reader["modelo_equipo"].ToString(), FontFactory.GetFont("Times New Roman", 8)));
                table.AddCell(celda15);
                PdfPCell celda16 = new PdfPCell(new Paragraph(reader["capacidad_produccion"].ToString(), FontFactory.GetFont("Times New Roman", 8)));
                table.AddCell(celda16);
                PdfPCell celda17 = new PdfPCell(new Paragraph(reader["peso"].ToString(), FontFactory.GetFont("Times New Roman", 8)));
                table.AddCell(celda17);
                PdfPCell celda18 = new PdfPCell(new Paragraph(reader["altura"].ToString(), FontFactory.GetFont("Times New Roman", 8)));
                table.AddCell(celda18);
                PdfPCell celda19 = new PdfPCell(new Paragraph(reader["ancho"].ToString(), FontFactory.GetFont("Times New Roman", 8)));
                table.AddCell(celda19);
                PdfPCell celda20 = new PdfPCell(new Paragraph(reader["largo"].ToString(), FontFactory.GetFont("Times New Roman", 8)));
                table.AddCell(celda20);
                PdfPCell celda21 = new PdfPCell(new Paragraph(reader["marca"].ToString(), FontFactory.GetFont("Times New Romanº", 8)));
                table.AddCell(celda21);
                doc.Add(table);

                doc.Add(saltoDeLinea);
                //Se muestran las caracteristicas del equipo
                Paragraph paragrah5 = new Paragraph("Características técnicas", FontFactory.GetFont("Arial", 15));
                paragrah5.Alignment = Element.ALIGN_CENTER;
                doc.Add(paragrah5);
                Paragraph paragrah3 = new Paragraph("El equipo tiene las siguientes características técnicas: " + reader["caract_tecni"].ToString(), FontFactory.GetFont("Arial", 12));
                paragrah3.Alignment = Element.ALIGN_JUSTIFIED;
                doc.Add(paragrah3);
                doc.Add(saltoDeLinea);

                // Se muestra fecha actual
                Paragraph paragraph4 = new Paragraph("" + fecha_actual, FontFactory.GetFont("Arial", 13));
                doc.Add(saltoDeLinea);
                paragraph4.Alignment = Element.ALIGN_RIGHT;
                doc.Add(paragraph4);
                //Se coloca imagen de pie de pagina
                iTextSharp.text.Image PNG1 = iTextSharp.text.Image.GetInstance("PieDePagina.PNG");
                PNG1.SetAbsolutePosition(0, -10);
                doc.Add(PNG1);

                if (doc.ToString() != "")
                {
                    MessageBox.Show("El documento se ha descargado satisfactoriamente", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("El documento no se pudo descargar, vuelva a intentar en unos minutos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                doc.NewPage();

                doc.Close();
            /*}
            catch (Exception)
            {
                MessageBox.Show("Error al descargar el PDF", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }*/
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
