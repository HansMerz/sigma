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
    public partial class InformeHerramientas : Form
    {
        public List<InventarioHerramientas> ih = new List<InventarioHerramientas>();
        public InformeHerramientas()
        {
            InitializeComponent();            
        }

        private void InformeHerramientas_Load(object sender, EventArgs e)
        {
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("Inventario", ih));
            this.reportViewer1.RefreshReport();
        }
    }
}
