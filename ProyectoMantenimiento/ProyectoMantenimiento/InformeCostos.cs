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
    public partial class InformeCostos : Form
    {
        public List<DatosCostos1> dc1 = new List<DatosCostos1>();
        public List<DatosCostos2> dc2 = new List<DatosCostos2>();
        public InformeCostos()
        {
            InitializeComponent();
        }

        private void InformeCostos_Load(object sender, EventArgs e)
        {
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("Datos1", dc1));
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("Datos2", dc2));
            this.reportViewer1.RefreshReport();
        }
    }
}
