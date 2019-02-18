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
    public partial class PreventivosLista : Form
    {
        public List<DatosListaPreventivo> dlp = new List<DatosListaPreventivo>();
        public PreventivosLista()
        {
            InitializeComponent();
        }

        private void PreventivosLista_Load(object sender, EventArgs e)
        {
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("ListaPreventivo", dlp));
            this.reportViewer1.RefreshReport();
        }
    }
}
