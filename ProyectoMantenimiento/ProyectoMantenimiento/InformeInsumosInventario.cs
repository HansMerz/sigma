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
    public partial class InformeInsumosInventario : Form
    {
        public List<InventarioInsumos> ii = new List<InventarioInsumos>();
        public InformeInsumosInventario()
        {
            InitializeComponent();            
        }

        private void InformeInsumosInventario_Load(object sender, EventArgs e)
        {
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("InventarioInsumos", ii));
            this.reportViewer1.RefreshReport();
        }
    }
}
