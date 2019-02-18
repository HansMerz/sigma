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
    public partial class OrdenCorrectivoAreas : Form
    {
        public List<DatosCorrectivoGeneral> ot = new List<DatosCorrectivoGeneral>();
        public List<DatosCorrectivoGeneral> ot2 = new List<DatosCorrectivoGeneral>();
        public List<DatosCorrectivoGeneral> ot3 = new List<DatosCorrectivoGeneral>();
        public List<DatosCorrectivoGeneral> ot4 = new List<DatosCorrectivoGeneral>();
        public OrdenCorrectivoAreas()
        {
            InitializeComponent();
        }

        private void OrdenCorrectivoAreas_Load(object sender, EventArgs e)
        {
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("Datos", ot));
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("Datos2", ot2));
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("Datos3", ot3));
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("Datos4", ot4));
            this.reportViewer1.RefreshReport();
        }
    }
}
