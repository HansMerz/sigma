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
    public partial class Advertencia : Form
    {
        //Esta es la ventana que nos mostrará las alertas a la hora de iniciar la sesión
        public Advertencia()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            //Cuando le den click en aceptar, se guardará el valor de "OK"
            this.DialogResult = DialogResult.OK;
        }
        public void asignarDatos(String numero_orden, String equipo, String fecha_prevista, String horas_restantes)
        {
            //Se les asigna el número de orden, el equipo o área locativa, la fecha prevista y las horas que faltan para ejecutar el mantenimiento. 
            lblNumOrden.Text = numero_orden;
            lblEquipo.Text = equipo;
            lblFecha.Text = fecha_prevista;
            lblHorasRes.Text = horas_restantes;
        }
    }
}
