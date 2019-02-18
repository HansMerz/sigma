
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace ProyectoMantenimiento
{
    public partial class EjecutadosInforme : Form
    {
        public List<PruebaEncargados> datosE = new List<PruebaEncargados>();        
        public List<PruebaInsumos> datosI = new List<PruebaInsumos>();
        public List<DatosMantenimiento> datosM = new List<DatosMantenimiento>();
        public List<DatosFallas> datosF = new List<DatosFallas>();
        public List<DatosActividades> datosA = new List<DatosActividades>();        
        public EjecutadosInforme()
        {
            InitializeComponent();            
        }
        private void pruebaencargadoir_Load(object sender, EventArgs e)
        {
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Remove(new ReportDataSource("Encargados"));
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("Encargados", datosE));            
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("Insumos", datosI));
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("Mantenimiento", datosM));
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("Fallas", datosF));
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("Actividades", datosA));
            /*Impresor imp = new Impresor();
            imp.Imprime(reportViewer1.LocalReport);*/
            this.reportViewer1.RefreshReport();
        }
    }
}
