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
    public partial class menu : Form
    {
        //Se declaran 5 variables, una variable de la ventana Login, una de la clase Mantenimiento, otra de la clase advertencia
        //otra de la clase DialogResult y de la clase MySqlDataReader
        Login l;
        MantenimientoClass mc;
        Advertencia ad;
        DialogResult res;
        MySqlDataReader read;
        public menu(Login l)
        {
            //Se instancian las variables anteriores y se valida el usuario que entró
            InitializeComponent();
            this.l = l;
            mc = new MantenimientoClass();            
            ad = new Advertencia();
            res = new DialogResult();            
            if (l.tipo == "Almacen")
            {
                picEqui.Enabled = false;
                picMan.Enabled = false;
                lblEqui.Enabled = false;
                lblMan.Enabled = false;
                lblO.Enabled = false;
                lblAreas.Enabled = false;                
                picAreas.Enabled = false;
                lblArea.Enabled = false;
                picGrupo.Enabled = false;
                lblGrupo1.Enabled = false;
                lblGrupo2.Enabled = false;
                picCostos.Enabled = false;
                lblCosto.Enabled = false;
            }
            timer1.Enabled = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            //Se muestra la ventana de Herramientas
            new Herramientas(l).Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //Se muestra la fecha actual
            label2.Text = DateTime.Now.ToString();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            //Se muestra la ventana de Trabajadores
            new Trabajadores().Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            //Se muestra la ventana de Trabajadores
            new Trabajadores().Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //Se muestra la ventana de Herramientas
            new Herramientas(l).Show();
        }

        public void cargarAdvertencias()
        {
            //Se trae los mantenimientos y se ejecuta el método de cargarMensajes
            read = mc.cargarTabla("");
            while (read.Read())
            {                
                cargarMensajes();    
            }                                        
        }

        public void cargarMensajes()
        {
            //Este método carga los mantenimiento preventivos que estén entre 0 y 72 horas
            Color yellow = ColorTranslator.FromHtml("#FDF500");
            Color darkred = ColorTranslator.FromHtml("#EF0404");
            int fecha = int.Parse(mc.operacionFecha(read.GetString(0)));
            if (fecha <= 30 && fecha >= 0)
            {
                ad.asignarDatos(read.GetString(1), read.GetString(3), read.GetString(6), fecha.ToString());
                ad.BackColor = darkred;
                ponerBlanco();
                res = ad.ShowDialog();
                if (res == DialogResult.OK)
                {
                    ad.Hide();
                }
            } else if (fecha <= 90 && fecha > 30)
            {
                ad.asignarDatos(read.GetString(1), read.GetString(3), read.GetString(6), fecha.ToString());
                ad.BackColor = yellow;
                ponerNegro();
                res = ad.ShowDialog();
                if (res == DialogResult.OK)
                {
                    ad.Hide();
                }
            }           
        }
        private void ponerBlanco()
        {
            //Este método pone en blanco todo el texto de las ventanas de advertencias
            ad.lblText1.ForeColor = Color.White;
            ad.lblText2.ForeColor = Color.White;
            ad.lblText3.ForeColor = Color.White;
            ad.lblText4.ForeColor = Color.White;
            ad.lblText5.ForeColor = Color.White;
            ad.lblNumOrden.ForeColor = Color.White;
            ad.lblEquipo.ForeColor = Color.White;
            ad.lblFecha.ForeColor = Color.White;
            ad.lblHorasRes.ForeColor = Color.White;
        }
        private void ponerNegro()
        {
            //Este método pone en negro todo el texto de las ventanas de advertencias
            ad.lblText1.ForeColor = Color.Black;
            ad.lblText2.ForeColor = Color.Black;
            ad.lblText3.ForeColor = Color.Black;
            ad.lblText4.ForeColor = Color.Black;
            ad.lblText5.ForeColor = Color.Black;
            ad.lblNumOrden.ForeColor = Color.Black;
            ad.lblEquipo.ForeColor = Color.Black;
            ad.lblFecha.ForeColor = Color.Black;
            ad.lblHorasRes.ForeColor = Color.Black;
        }
        private void pictureBox6_Click(object sender, EventArgs e)
        {
            //Aquí se abre la ventana de Mantenimiento
            new Mantenimiento().Show();
        }

        private void lblEqui_Click(object sender, EventArgs e)
        {
            new Equipo().Show();
        }

        private void lblMan_Click(object sender, EventArgs e)
        {
            //Aquí se abre la ventana de Mantenimiento
            new Mantenimiento().Show();
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            //Aquí se abre la ventana de Insumos
            new Insumos(l).Show();  
        }

        private void menu_Load(object sender, EventArgs e)
        {
            //Se cargan el método de advertencias al momento de cargar el menú
            if (l.tipo != "Almacen")
            {
                cargarAdvertencias();
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            new Area().Show();
        }

        private void menu_Activated(object sender, EventArgs e)
        {
        }

        private void picInfor_Click(object sender, EventArgs e)
        {           
        }

        private void pictureBox3_Click_1(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void picEqui_Click(object sender, EventArgs e)
        {
            new Equipo().Show();
        }

        private void label9_Click(object sender, EventArgs e)
        {
            new Insumos(l).Show();
        }

        private void lblO_Click(object sender, EventArgs e)
        {
            new Equipo().Show();
        }

        private void lblAreas_Click(object sender, EventArgs e)
        {
            new Equipo().Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            new Area().Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            new Grupos().Show();
        }

        private void picCostos_Click(object sender, EventArgs e)
        {
            new Informe_equipo_area().Show();
        }

        private void menu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
