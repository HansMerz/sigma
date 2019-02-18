using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoMantenimiento
{
    public partial class HojaDeVida : Form
    {
        public List<DatosHojaVida> dhv = new List<DatosHojaVida>();
        public List<DatosEquipoMan> em = new List<DatosEquipoMan>();
        string ruta;
        public HojaDeVida(string ruta)
        {
            InitializeComponent();
            this.ruta = ruta;
        }

        private void HojaDeVida_Load(object sender, EventArgs e)
        {
            reportViewer1.LocalReport.DataSources.Clear();            
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("Equipo", dhv));
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("EquipoMan", em));
            this.reportViewer1.RefreshReport();
        }
    }
}
