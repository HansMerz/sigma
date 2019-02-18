namespace ProyectoMantenimiento
{
    partial class PlanMantenimiento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlanMantenimiento));
            this.DatosPlanMantenimientoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DatosPlanMantenimiento2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DatosEquipoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DatosInstruccionesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DatosProcedimientoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.DatosPlanMantenimientoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DatosPlanMantenimiento2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DatosEquipoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DatosInstruccionesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DatosProcedimientoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // DatosPlanMantenimientoBindingSource
            // 
            this.DatosPlanMantenimientoBindingSource.DataSource = typeof(ProyectoMantenimiento.DatosPlanMantenimiento);
            // 
            // DatosPlanMantenimiento2BindingSource
            // 
            this.DatosPlanMantenimiento2BindingSource.DataSource = typeof(ProyectoMantenimiento.DatosPlanMantenimiento2);
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "PlanMantenimiento";
            reportDataSource1.Value = this.DatosPlanMantenimientoBindingSource;
            reportDataSource2.Name = "PlanMantenimiento2";
            reportDataSource2.Value = this.DatosPlanMantenimiento2BindingSource;
            reportDataSource3.Name = "DatosEquipo";
            reportDataSource3.Value = this.DatosEquipoBindingSource;
            reportDataSource4.Name = "DatosInstrucciones";
            reportDataSource4.Value = this.DatosInstruccionesBindingSource;
            reportDataSource5.Name = "DatosProcedimiento";
            reportDataSource5.Value = this.DatosProcedimientoBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource4);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource5);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "SIGMA.PlanMantenimiento.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(780, 702);
            this.reportViewer1.TabIndex = 0;
            // 
            // DatosEquipoBindingSource
            // 
            this.DatosEquipoBindingSource.DataMember = "DatosEquipo";
            // 
            // DatosInstruccionesBindingSource
            // 
            this.DatosInstruccionesBindingSource.DataMember = "DatosInstrucciones";
            // 
            // DatosProcedimientoBindingSource
            // 
            this.DatosProcedimientoBindingSource.DataMember = "DatosProcedimiento";
            // 
            // PlanMantenimiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(780, 702);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PlanMantenimiento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PlanMantenimiento";
            this.Load += new System.EventHandler(this.PlanMantenimiento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DatosPlanMantenimientoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DatosPlanMantenimiento2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DatosEquipoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DatosInstruccionesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DatosProcedimientoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource DatosPlanMantenimientoBindingSource;
        private System.Windows.Forms.BindingSource DatosPlanMantenimiento2BindingSource;
        private System.Windows.Forms.BindingSource DatosEquipoBindingSource;
        private System.Windows.Forms.BindingSource DatosInstruccionesBindingSource;
        private System.Windows.Forms.BindingSource DatosProcedimientoBindingSource;
    }
}