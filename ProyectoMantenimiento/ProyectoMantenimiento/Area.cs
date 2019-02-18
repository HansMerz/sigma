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
    public partial class Area : Form
    {
        public Area()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Area_localizacion area = new Area_localizacion();


            try
            {
                //Se envian los datos desde los texbox
                area.Centro_costo = txtcentrocosto.Text.Trim();
                area.Localizacion = txtlocalizacion.Text.Trim();

                //Se valida que los campos no vallan vacios 
                if (txtlocalizacion.Text.Length == 0 || txtcentrocosto.Text.Length == 0)
                {
                    MessageBox.Show("Hay campos vacíos", "Revisar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    //Se  insertan los datos a la DB
                    int resultado = EquipoDAL.insertar_area(area);

                    // Se valida que se envie datos
                    if (resultado > 0)
                    {
                        MessageBox.Show("Se guardó el área correctamente", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No se pudo guardar el área", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

            catch (Exception)
            {
                MessageBox.Show("Error al guardar el área", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            txtcentrocosto.Text = "";
            txtlocalizacion.Text = "";
        }

        private void txtlocalizacion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                Area_localizacion area = new Area_localizacion();


                try
                {
                    //Se envian los datos desde los texbox
                    area.Centro_costo = txtcentrocosto.Text.Trim();
                    area.Localizacion = txtlocalizacion.Text.Trim();

                    if (txtcentrocosto.Text.Length == 0 || txtlocalizacion.Text.Length == 0)
                    {
                        MessageBox.Show("Hay campos vacíos", "Revisar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {

                        int resultad = EquipoDAL.insertar_area(area);

                        // Se valida que se envie datos
                        if (resultad > 0)
                        {
                            MessageBox.Show("Se guardó el área correctamente", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("No se pudo guardar el área", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Error al guardar el área", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                txtcentrocosto.Text = "";
                txtlocalizacion.Text = "";
            }
        }

        private void txtlocalizacion_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void txtlocalizacion_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Hide();
            new ActualizarArea().ShowDialog();
            Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Hide();
            new VisualizarArea().ShowDialog();
            Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
           
        }
    }
}
