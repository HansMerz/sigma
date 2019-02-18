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
    public partial class Informe_equipo_area : Form
    {
        EquipoDAL ed = new EquipoDAL();

        public Informe_equipo_area()
        {
            InitializeComponent();
            // Cargar_combobox_CentoCosto();
            bloquearCombo();
            dtglista.RowHeadersVisible = false;
            //String sql = 
        }
        private void bloquearCombo()
        {
            Pfiltro_1.Enabled = false;
            Pfiltro_2.Enabled = false;            
            CBEquAr.Enabled = false;
        }

        public void DataGriviinforme_Area(DataGridView datagri, String val)
        {
            String sql = "SELECT m.id as Codigo, numero_orden as Num_Orden, tipo_mantenimiento as Tipo, e.codigo as Codigo, e.nombre as Equipo, a.localizacion as Localizacion, DATE_FORMAT(fecha_prevista,'%Y-%m-%d') as Fecha_Prevista, solicita as Solicita, fecha_solicitada as Fecha_Solicitud FROM mantenimiento m INNER JOIN equipo e ON m.equipo_codigo = e.codigo INNER JOIN area a ON e.area_id = a.id WHERE e.tipo = 0 ORDER BY m.id DESC";
            DataTable tb = Conexion.Data(sql);
            datagri.DataSource = tb;
        }

        private void Informe_equipo_area_Load(object sender, EventArgs e)
        {
            //comboBox2_SelectedIndexChanged(dtglista);
        }

        private void comboBox2_SelectedIndexChanged(DataGridView datagri)
        {
            String sql = "SELECT m.id as Codigo, numero_orden as Num_Orden, tipo_mantenimiento as Tipo, e.codigo as Codigo, e.nombre as Equipo, a.localizacion as Localizacion, DATE_FORMAT(fecha_prevista,'%Y-%m-%d') as Fecha_Prevista, solicita as Solicita, fecha_solicitada as Fecha_Solicitud, fecha_hora_fin as fecha_hora_fin FROM mantenimiento m INNER JOIN equipo e ON m.equipo_codigo = e.codigo INNER JOIN area a ON e.area_id = a.id WHERE CONCAT(e.codigo, ' ', m.id, ' ', numero_orden, ' ', tipo_mantenimiento, ' ', Fecha_Prevista) LIKE '%%' AND fecha_hora_fin BETWEEN '{0}' AND '{1}' ORDER BY m.id DESC"; dtpFecha_inicio.ToString(); dptFecha_fin.ToString();
            DataTable dt = Conexion.Data(sql);
            datagri.DataSource = dt;
        }


        public void Buscar_Localizacion(String filtro)
        {
            //Se realiza el formato de la fecha de inicio 
            String Fecha_inicio = dtpFecha_inicio.Value.Year + "-" + dtpFecha_inicio.Value.Month + '-' + dtpFecha_inicio.Value.Day;
            //Se realiza el formato de la fecha fin
            String Fecha_fin = dptFecha_fin.Value.Year + "-" + dptFecha_fin.Value.Month + '-' + dptFecha_fin.Value.Day;
            String sql = String.Format("SELECT e.codigo Codigo, e.nombre Equipo_Area_Locativa, g.nombre Grupo, a.localizacion Localizacion, COUNT(m.equipo_codigo) as Total_Mantenimientos, SUM(ins.precio * ihm.cantidad) as Costos FROM equipo e INNER JOIN grupo g ON e.grupo_id = g.id INNER JOIN area a ON e.area_id = a.id INNER JOIN mantenimiento m ON e.codigo = m.equipo_codigo LEFT JOIN insumos_has_mantenimiento ihm ON m.id = ihm.mantenimiento_id LEFT JOIN insumos ins ON ihm.insumos_id = ins.id WHERE CONCAT(e.codigo, ' ', e.nombre) LIKE '%%' AND m.observacion IS NOT NULL AND m.fecha_hora_fin BETWEEN '{0}' AND '{1}' AND a.localizacion = '{2}' GROUP BY e.codigo ORDER BY Costos DESC", Fecha_inicio.ToString(), Fecha_fin.ToString(), filtro);
            DataTable dt = Conexion.Data(sql);
            dtglista.DataSource = dt;
        }

        public void Buscar_grupo(String filtro)
        {
            //Se realiza el formato de la fecha de inicio 
            String Fecha_inicio = dtpFecha_inicio.Value.Year + "-" + dtpFecha_inicio.Value.Month + '-' + dtpFecha_inicio.Value.Day;
            //Se realiza el formato de la fecha fin
            String Fecha_fin = dptFecha_fin.Value.Year + "-" + dptFecha_fin.Value.Month + '-' + dptFecha_fin.Value.Day;

            String sql = String.Format("SELECT e.codigo Codigo, e.nombre Equipo_Area_Locativa, g.nombre Grupo, a.localizacion Localizacion, COUNT(m.equipo_codigo) as Total_Mantenimientos, SUM(ins.precio * ihm.cantidad) as Costos FROM equipo e INNER JOIN grupo g ON e.grupo_id = g.id INNER JOIN area a ON e.area_id = a.id INNER JOIN mantenimiento m ON e.codigo = m.equipo_codigo LEFT JOIN insumos_has_mantenimiento ihm ON m.id = ihm.mantenimiento_id LEFT JOIN insumos ins ON ihm.insumos_id = ins.id WHERE CONCAT(e.codigo, ' ', e.nombre) LIKE '%%' AND m.observacion IS NOT NULL AND m.fecha_hora_fin BETWEEN '{0}' AND '{1}' AND g.nombre = '{2}' GROUP BY e.codigo ORDER BY Costos DESC", Fecha_inicio.ToString(), Fecha_fin.ToString(), filtro);
            DataTable dt = Conexion.Data(sql);
            dtglista.DataSource = dt;
        }


        private void Pfiltro_2_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Se realiza el if donde valida si esta seleccionado centro de cost y llenar el combo
            if (Pfiltro_1.Text == "Centro de costo")
            {
                Buscar_Localizacion(Pfiltro_2.Text);
            }
            else
            {
                Buscar_grupo(Pfiltro_2.Text);
            }

            //Se habilita el texto de b uscar            

            cargarPrecio();
        }

        private void Pfiltro_1_SelectedIndexChanged(object sender, EventArgs e)
        {

            //Se llenan los combobox dependiendo de la seleccion del filtro1
            if (Pfiltro_1.SelectedItem.ToString() == "Centro de costo")
            {
                //Se llena el combo cuando se escoje el centro de costo
                Pfiltro_2.Enabled = true;
                CBEquAr.Enabled = true;
                CBEquAr.SelectedIndex = 0;
                Pfiltro_2.DataSource = ed.cargarCombo();
                Pfiltro_2.DisplayMember = "localizacion";
                Pfiltro_2.ValueMember = "id";
                cargarPrecio();
            }

            else if (Pfiltro_1.SelectedItem.ToString() == "Grupo")
            {
                //Se llena el combo cuando se selecciona grupo
                Pfiltro_2.Enabled = true;
                CBEquAr.Enabled = false;
                CBEquAr.SelectedIndex = 0;
                Pfiltro_2.DataSource = ed.Combo_grupo();
                Pfiltro_2.DisplayMember = "nombre";
                Pfiltro_2.ValueMember = "id";
                cargarPrecio();
            }
            else if (Pfiltro_1.SelectedItem.ToString() == "Todos")
            {
                Pfiltro_2.Enabled = false;                
                CBEquAr.Enabled = true;
                CBEquAr.SelectedIndex = 0;
                Pfiltro_2.DataSource = null;
                String Fecha_inicio = dtpFecha_inicio.Value.Year + "-" + dtpFecha_inicio.Value.Month + '-' + dtpFecha_inicio.Value.Day;
                //Se realiza el formato de la fecha fin
                String Fecha_fin = dptFecha_fin.Value.Year + "-" + dptFecha_fin.Value.Month + '-' + dptFecha_fin.Value.Day;
                //Se llena el dt
                dtglista.DataSource = ed.Llenar_grilla("", Fecha_inicio, Fecha_fin);
                cargarPrecio();
            }
            cargarPrecio();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
           
        }

        public void Llenar_grilla()
        {
            EquipoDAL dal = new EquipoDAL();


        }

        private void dptFecha_fin_ValueChanged(object sender, EventArgs e)
        {
            if (!Pfiltro_1.Enabled)
            {
                Pfiltro_1.Enabled = true;
            }
            else
            {
                if (Pfiltro_1.Text.ToString() == "Centro de costo")
                {
                    Buscar_Localizacion(Pfiltro_2.Text);
                    cargarPrecio();
                }
                else if (Pfiltro_1.Text.ToString() == "Grupo")
                {
                    Buscar_grupo(Pfiltro_2.Text);
                    cargarPrecio();
                }
                else if (Pfiltro_1.Text.ToString() == "Todos")
                {
                    //Se realiza el formato de la fecha inicio
                    String Fecha_inicio = dtpFecha_inicio.Value.Year + "-" + dtpFecha_inicio.Value.Month + '-' + dtpFecha_inicio.Value.Day;
                    //Se realiza el formato de la fecha fin
                    String Fecha_fin = dptFecha_fin.Value.Year + "-" + dptFecha_fin.Value.Month + '-' + dptFecha_fin.Value.Day;
                    dtglista.DataSource = ed.Llenar_grilla("", Fecha_inicio, Fecha_fin);
                    cargarPrecio();
                }
                else
                {
                    String Fecha_inicio = dtpFecha_inicio.Value.Year + "-" + dtpFecha_inicio.Value.Month + '-' + dtpFecha_inicio.Value.Day;
                    //Se realiza el formato de la fecha fin
                    String Fecha_fin = dptFecha_fin.Value.Year + "-" + dptFecha_fin.Value.Month + '-' + dptFecha_fin.Value.Day;
                    dtglista.DataSource = ed.Llenar_grilla("", Fecha_inicio, Fecha_fin);
                    cargarPrecio();
                }                
            } 
        }


        private void cargarPrecio()
        {

            //Suma de la columna de costos
            float sumar = 0;

            for (int i = 0; i < dtglista.Rows.Count; i++)
            {
                float cont;
                if (dtglista[5, i].Value.ToString() == "")
                {
                    cont = 0;
                }
                else
                {
                    cont = float.Parse(dtglista[5, i].Value.ToString());
                }
                sumar += cont;
            }
            txtsuma.Text = sumar.ToString();
        }

        private void CBEquAr_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Pfiltro_1.SelectedItem.ToString() == "Centro de costo" || Pfiltro_1.SelectedItem.ToString() == "Todos")
            {
                if(CBEquAr.SelectedItem.ToString() == "Equipos")
                 {
                    //Se realiza el formato de la fecha para inicio
                    String Fecha_inicio = dtpFecha_inicio.Value.Year + "-" + dtpFecha_inicio.Value.Month + "-" + dtpFecha_inicio.Value.Day;
                    //Se realiza el formato de la fecha fin
                    String fecha_fin = dptFecha_fin.Value.Year + "-" + dptFecha_fin.Value.Month + "-" + dptFecha_fin.Value.Day;                    
                    if (Pfiltro_1.Text == "Centro de costo")
                    {
                        String Localizacion = Pfiltro_2.Text;
                        dtglista.DataSource = ed.Filtro_equipo_area_porcentrodecosto("", Fecha_inicio, fecha_fin, Localizacion);
                    }
                    else
                    {
                        dtglista.DataSource = ed.FiltroTodoEquipoArea("", Fecha_inicio, fecha_fin);
                    }                    
                }

                else if(CBEquAr.SelectedItem.ToString() == "Áreas locativas")
                {
                    //Se realiza el formato de la fecha para inicio
                    String Fecha_inicio = dtpFecha_inicio.Value.Year + "-" + dtpFecha_inicio.Value.Month + "-" + dtpFecha_inicio.Value.Day;
                    //Se realiza el formato de la fecha fin
                    String fecha_fin = dptFecha_fin.Value.Year + "-" + dptFecha_fin.Value.Month + "-" + dptFecha_fin.Value.Day;                    
                    if (Pfiltro_1.Text == "Centro de costo")
                    {
                        String Localizacion = Pfiltro_2.Text;
                        dtglista.DataSource = ed.Fltro_equipo_area_porcentrocosto1("", Fecha_inicio, fecha_fin, Localizacion);
                    }
                    else
                    {
                        dtglista.DataSource = ed.FiltroTodoEquipoArea1("", Fecha_inicio, fecha_fin);
                    }
                    
                }
            }
            cargarPrecio();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            if (dtglista.Rows.Count == 0)
            {
                MessageBox.Show("No se puede realizar el reporte", "Revisar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                InformeCostos ic = new InformeCostos();
                DatosCostos1 d1 = new DatosCostos1();
                d1.desde = dtpFecha_inicio.Value.Year + "-" + dtpFecha_inicio.Value.Month + "-" + dtpFecha_inicio.Value.Day;
                d1.hasta = dptFecha_fin.Value.Year + "-" + dptFecha_fin.Value.Month + '-' + dptFecha_fin.Value.Day;
                d1.tipo = Pfiltro_1.Text;
                d1.total = txtsuma.Text;
                if (Pfiltro_1.Text == "Todos")
                {
                    d1.tipo_GruLo = " ";
                    d1.gruLo = " ";
                    d1.equipo_area = " ";
                }
                else
                {
                    d1.tipo_GruLo = Pfiltro_1.Text + ": ";
                    if (Pfiltro_2.Enabled)
                    {
                        d1.gruLo = Pfiltro_2.Text;
                    }
                    else
                    {
                        d1.gruLo = " ";
                    }
                    if (CBEquAr.Enabled && CBEquAr.SelectedIndex != 0)
                    {
                        d1.equipo_area = CBEquAr.Text;
                    }
                    else
                    {
                        d1.equipo_area = " ";
                    }
                }
                ic.dc1.Add(d1);
                for (int i = 0; i < dtglista.Rows.Count; i++)
                {
                    DatosCostos2 dc2 = new DatosCostos2();
                    dc2.cod = dtglista[0, i].Value.ToString();
                    dc2.nombre = dtglista[1, i].Value.ToString();
                    dc2.grupo = dtglista[2, i].Value.ToString();
                    dc2.localizacion = dtglista[3, i].Value.ToString();
                    dc2.totalMantenimientos = dtglista[4, i].Value.ToString();
                    dc2.costo = dtglista[5, i].Value.ToString();

                    ic.dc2.Add(dc2);
                }
                ic.Show();
            }
        }
    }
}

