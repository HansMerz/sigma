namespace ProyectoMantenimiento
{
    partial class EjecutadosInforme
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource4 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource5 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EjecutadosInforme));
            this.PruebaHerramientaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.PruebaInsumosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DatosMantenimientoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.PruebaEncargadosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DatosFallasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DatosActividadesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.PruebaHerramientaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PruebaInsumosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DatosMantenimientoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PruebaEncargadosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DatosFallasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DatosActividadesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // PruebaHerramientaBindingSource
            // 
            this.PruebaHerramientaBindingSource.DataSource = typeof(ProyectoMantenimiento.PruebaHerramienta);
            // 
            // PruebaInsumosBindingSource
            // 
            this.PruebaInsumosBindingSource.DataSource = typeof(ProyectoMantenimiento.PruebaInsumos);
            // 
            // DatosMantenimientoBindingSource
            // 
            this.DatosMantenimientoBindingSource.DataSource = typeof(ProyectoMantenimiento.DatosMantenimiento);
            // 
            // PruebaEncargadosBindingSource
            // 
            this.PruebaEncargadosBindingSource.DataSource = typeof(ProyectoMantenimiento.PruebaEncargados);
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "Insumos";
            reportDataSource1.Value = this.PruebaInsumosBindingSource;
            reportDataSource2.Name = "Mantenimiento";
            reportDataSource2.Value = this.DatosMantenimientoBindingSource;
            reportDataSource3.Name = "Encargados";
            reportDataSource3.Value = this.PruebaEncargadosBindingSource;
            reportDataSource4.Name = "Fallas";
            reportDataSource4.Value = this.DatosFallasBindingSource;
            reportDataSource5.Name = "Actividades";
            reportDataSource5.Value = this.DatosActividadesBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource4);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource5);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "SIGMA.ReporteEjecutados.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(786, 702);
            this.reportViewer1.TabIndex = 0;
            // 
            // DatosFallasBindingSource
            // 
            this.DatosFallasBindingSource.DataMember = "DatosFallas";
            // 
            // DatosActividadesBindingSource
            // 
            this.DatosActividadesBindingSource.DataMember = "DatosActividades";
            // 
            // EjecutadosInforme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 702);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EjecutadosInforme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Informe Ejecutados";
            this.Load += new System.EventHandler(this.pruebaencargadoir_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PruebaHerramientaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PruebaInsumosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DatosMantenimientoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PruebaEncargadosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DatosFallasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DatosActividadesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource PruebaEncargadosBindingSource;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource PruebaHerramientaBindingSource;
        private System.Windows.Forms.BindingSource PruebaInsumosBindingSource;
        private System.Windows.Forms.BindingSource DatosMantenimientoBindingSource;
        private System.Windows.Forms.BindingSource DatosFallasBindingSource;
        private System.Windows.Forms.BindingSource DatosActividadesBindingSource;
    }
}