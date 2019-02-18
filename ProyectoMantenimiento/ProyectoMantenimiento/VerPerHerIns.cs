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
    public partial class VerPerHerIns : Form
    {
        //Se crean 4 variables, una de la ventana de MantenimientoEjecutados, otra de la clase MantenimientoPersona,
        //otra de la clase MantenimientoHerramienta y otra de la clase Insumos
        MantenimientosEjecutados me;
        MantenimientoPersonaClass mpc;        
        InsumosClass ic;
        public VerPerHerIns(MantenimientosEjecutados me)
        {
            //Se instancian las variables anteriores
            //Se carga el método cargarListas
            InitializeComponent();
            this.me = me;
            mpc = new MantenimientoPersonaClass();            
            ic = new InsumosClass();
            label2.Text = me.num_orden;
            cargarListas();
        }
        private void cargarListas()
        {
            //Se carga las listas de los trabajadores, Herramientas e insumos utilizados dependiendo del mantenimiento
            listTrabajadores.DataSource = mpc.consultarEncargados(me.id);
            listTrabajadores.DisplayMember = "nombres";
            listTrabajadores.ValueMember = "id";            

            listIns.DataSource = ic.consultarInsumos(me.id);
            listIns.DisplayMember = "InsCan";
            listIns.ValueMember = "id";
        }
    }
}
