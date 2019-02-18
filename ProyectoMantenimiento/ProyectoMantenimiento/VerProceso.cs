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
    public partial class VerProceso : Form
    {
        //Se crean 2 variables. Una de la ventana MantenimientoEjecutados y otra de la clase Mantenimiento
        MantenimientosEjecutados me;
        ActividadYFallo ayf;
        MantenimientoClass mc;
        public VerProceso(MantenimientosEjecutados me)
        {            
            //Se instancian las variables y se ejecuta el método de cargarDatos
            InitializeComponent();
            this.me = me;
            mc = new MantenimientoClass();
            ayf = new ActividadYFallo();
            dgFallas.RowHeadersVisible = false;
            dgActividades.RowHeadersVisible = false;
            cargarDatos();
        }
        public void cargarDatos()
        {
            //Se carga el proceso que se le realizó al mantenimiento seleccionado
            DataRow tipo = mc.tipoMantenimiento(me.id).Rows[0];
            if (tipo["tipo_mantenimiento"].ToString() == "Correctivo")
            {
                MySqlDataReader reader = ayf.consultarFallosMantenimiento(me.id);
                while (reader.Read())
                {
                    dgFallas.Rows.Add(reader.GetString(0), reader.GetString(1));
                }
                MySqlDataReader reader2 = ayf.consultarActividadesMantenimiento(me.id);
                while (reader2.Read())
                {
                    dgActividades.Rows.Add(reader2.GetString(0), reader2.GetString(1));
                }
                txtProceso.Visible = false;
            }
            else
            {
                dgActividades.Visible = false;
                dgFallas.Visible = false;
                label2.Visible = false;
                label3.Text = "Observaciones generales";
                txtProceso.Visible = true;
                txtProceso.Text = tipo["observacion"].ToString();
                txtProceso.BackColor = Color.White;
            }            
            lblNumOrden.Text = me.num_orden;
        }
    }
}
