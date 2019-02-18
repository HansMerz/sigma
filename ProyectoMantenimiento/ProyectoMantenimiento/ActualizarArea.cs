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
    public partial class ActualizarArea : Form
    {
        String id;
        public ActualizarArea()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtcodigoingresado.Text == "")
            {
                MessageBox.Show("Por favor digitar el centro de costo", "Revisar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    //Button buscar y mostrar 
                    String comd = string.Format("select * from area where centrocosto = '{0}'", txtcodigoingresado.Text);

                    DataRow reader = Conexion.Data(comd).Rows[0];
                    DataTable dt = new DataTable();

                    //Se hace la cadena para seleccionar el campo de la imagen en la tabla equipo
                    //  String comd1 = string.Format("select * from equipo where codigo = '{0}'", Codigo_ingresado.Text);

                    // DataRow read = Conexion.Data(comd1).Rows[0];

                    //Muetra los datos de la base de datos en los campos
                    txtcentrocosto.Text = reader["centrocosto"].ToString();
                    txtlocalizacion.Text = reader["localizacion"].ToString();
                    id = reader["id"].ToString();
                }
                catch (Exception)
                {
                    MessageBox.Show("No se encontró ninguna área", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    limpiar();
                }                
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Area_localizacion area = new Area_localizacion();
            if (txtcentrocosto.Text == "" || txtlocalizacion.Text == "")
            {
                MessageBox.Show("Los campos no pueden estar vacíos", "Revisar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    area.Localizacion = txtlocalizacion.Text.Trim();
                    area.Centro_costo = txtcentrocosto.Text.Trim();
                    area.id = id;

                    int resultado = EquipoDAL.actualizar_area(area);

                    if (resultado > 0)
                    {
                        MessageBox.Show("Los datos han sido actualizados correctamente", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        limpiar();
                    }
                    else
                    {
                        MessageBox.Show("Los datos no se pudieron actualizar correctamente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Ocurrió un error al actualizar el área", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);                   
                }                
            }            
        }
        public void limpiar()
        {
            txtcentrocosto.Text = "";
            txtlocalizacion.Text = "";
            txtcodigoingresado.Text = "";
        }
        private void button3_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
