using Microsoft.Reporting.WinForms;
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
    public partial class PlanMantenimiento : Form
    {
        public List<DatosPlanMantenimiento> dpm = new List<DatosPlanMantenimiento>();
        public List<DatosPlanMantenimiento2> dpm2 = new List<DatosPlanMantenimiento2>();
        public List<DatosEquipo> dpm3 = new List<DatosEquipo>();
        public List<DatosInstrucciones> dpm4 = new List<DatosInstrucciones>();
        public List<DatosProcedimiento> dpm5 = new List<DatosProcedimiento>();
        public PlanMantenimiento()
        {
            InitializeComponent();
        }

        private void PlanMantenimiento_Load(object sender, EventArgs e)
        {
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DatosInstrucciones", dpm4));
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DatosProcedimiento", dpm5));
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DatosEquipo", dpm3));
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("PlanMantenimiento2", dpm2));
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("PlanMantenimiento", dpm));            
            this.reportViewer1.RefreshReport();
        }
    }
}
