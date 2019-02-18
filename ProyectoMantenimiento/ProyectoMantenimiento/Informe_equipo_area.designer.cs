namespace ProyectoMantenimiento
{
    partial class Informe_equipo_area
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Informe_equipo_area));
            this.dtglista = new System.Windows.Forms.DataGridView();
            this.Pfiltro_1 = new System.Windows.Forms.ComboBox();
            this.Pfiltro_2 = new System.Windows.Forms.ComboBox();
            this.dtpFecha_inicio = new System.Windows.Forms.DateTimePicker();
            this.dptFecha_fin = new System.Windows.Forms.DateTimePicker();
            this.txtsuma = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.CBEquAr = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnImprimir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtglista)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtglista
            // 
            this.dtglista.AllowUserToAddRows = false;
            this.dtglista.AllowUserToDeleteRows = false;
            this.dtglista.AllowUserToOrderColumns = true;
            this.dtglista.AllowUserToResizeColumns = false;
            this.dtglista.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtglista.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dtglista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtglista.Location = new System.Drawing.Point(12, 213);
            this.dtglista.Name = "dtglista";
            this.dtglista.Size = new System.Drawing.Size(940, 290);
            this.dtglista.TabIndex = 0;
            // 
            // Pfiltro_1
            // 
            this.Pfiltro_1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Pfiltro_1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pfiltro_1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Pfiltro_1.FormattingEnabled = true;
            this.Pfiltro_1.Items.AddRange(new object[] {
            "Todos",
            "Grupo",
            "Centro de costo"});
            this.Pfiltro_1.Location = new System.Drawing.Point(409, 17);
            this.Pfiltro_1.Name = "Pfiltro_1";
            this.Pfiltro_1.Size = new System.Drawing.Size(245, 22);
            this.Pfiltro_1.TabIndex = 2;
            this.Pfiltro_1.SelectedIndexChanged += new System.EventHandler(this.Pfiltro_1_SelectedIndexChanged);
            // 
            // Pfiltro_2
            // 
            this.Pfiltro_2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Pfiltro_2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pfiltro_2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Pfiltro_2.FormattingEnabled = true;
            this.Pfiltro_2.Location = new System.Drawing.Point(409, 78);
            this.Pfiltro_2.Name = "Pfiltro_2";
            this.Pfiltro_2.Size = new System.Drawing.Size(245, 22);
            this.Pfiltro_2.TabIndex = 3;
            this.Pfiltro_2.SelectedIndexChanged += new System.EventHandler(this.Pfiltro_2_SelectedIndexChanged);
            // 
            // dtpFecha_inicio
            // 
            this.dtpFecha_inicio.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dtpFecha_inicio.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dtpFecha_inicio.CalendarTrailingForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dtpFecha_inicio.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFecha_inicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha_inicio.Location = new System.Drawing.Point(109, 17);
            this.dtpFecha_inicio.Name = "dtpFecha_inicio";
            this.dtpFecha_inicio.Size = new System.Drawing.Size(134, 22);
            this.dtpFecha_inicio.TabIndex = 0;
            // 
            // dptFecha_fin
            // 
            this.dptFecha_fin.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dptFecha_fin.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dptFecha_fin.CalendarTrailingForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dptFecha_fin.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dptFecha_fin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dptFecha_fin.Location = new System.Drawing.Point(109, 78);
            this.dptFecha_fin.Name = "dptFecha_fin";
            this.dptFecha_fin.Size = new System.Drawing.Size(134, 22);
            this.dptFecha_fin.TabIndex = 1;
            this.dptFecha_fin.ValueChanged += new System.EventHandler(this.dptFecha_fin_ValueChanged);
            // 
            // txtsuma
            // 
            this.txtsuma.BackColor = System.Drawing.Color.White;
            this.txtsuma.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsuma.Location = new System.Drawing.Point(819, 522);
            this.txtsuma.Name = "txtsuma";
            this.txtsuma.ReadOnly = true;
            this.txtsuma.Size = new System.Drawing.Size(100, 23);
            this.txtsuma.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(712, 526);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Costo total:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 14);
            this.label2.TabIndex = 10;
            this.label2.Text = "Desde";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(34, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 14);
            this.label3.TabIndex = 11;
            this.label3.Text = "Hasta";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(258, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(145, 14);
            this.label5.TabIndex = 13;
            this.label5.Text = "Opciones de búsqueda";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(282, 81);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 14);
            this.label6.TabIndex = 14;
            this.label6.Text = "Filtro de búsqueda";
            // 
            // CBEquAr
            // 
            this.CBEquAr.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBEquAr.Enabled = false;
            this.CBEquAr.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBEquAr.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CBEquAr.FormattingEnabled = true;
            this.CBEquAr.ImeMode = System.Windows.Forms.ImeMode.On;
            this.CBEquAr.Items.AddRange(new object[] {
            "<--- Seleccione --->",
            "Equipos",
            "Áreas locativas"});
            this.CBEquAr.Location = new System.Drawing.Point(713, 51);
            this.CBEquAr.Name = "CBEquAr";
            this.CBEquAr.Size = new System.Drawing.Size(194, 22);
            this.CBEquAr.TabIndex = 4;
            this.CBEquAr.SelectedIndexChanged += new System.EventHandler(this.CBEquAr_SelectedIndexChanged);
            this.CBEquAr.DropDownClosed += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.dtpFecha_inicio);
            this.panel1.Controls.Add(this.CBEquAr);
            this.panel1.Controls.Add(this.dptFecha_fin);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.Pfiltro_1);
            this.panel1.Controls.Add(this.Pfiltro_2);
            this.panel1.Location = new System.Drawing.Point(12, 76);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(940, 117);
            this.panel1.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(654, 55);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 14);
            this.label7.TabIndex = 16;
            this.label7.Text = "Tipo";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DimGray;
            this.label8.Location = new System.Drawing.Point(15, 23);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 24);
            this.label8.TabIndex = 17;
            this.label8.Text = "Costos";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(803, 525);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(16, 16);
            this.label9.TabIndex = 18;
            this.label9.Text = "$";
            // 
            // btnImprimir
            // 
            this.btnImprimir.BackColor = System.Drawing.Color.DarkGreen;
            this.btnImprimir.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnImprimir.FlatAppearance.BorderSize = 0;
            this.btnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImprimir.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimir.ForeColor = System.Drawing.Color.White;
            this.btnImprimir.Location = new System.Drawing.Point(839, 16);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(113, 31);
            this.btnImprimir.TabIndex = 5;
            this.btnImprimir.Text = "Reporte";
            this.btnImprimir.UseVisualStyleBackColor = false;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // Informe_equipo_area
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(966, 563);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtsuma);
            this.Controls.Add(this.dtglista);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Informe_equipo_area";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Costos";
            this.Load += new System.EventHandler(this.Informe_equipo_area_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtglista)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtglista;
        private System.Windows.Forms.ComboBox Pfiltro_1;
        private System.Windows.Forms.ComboBox Pfiltro_2;
        private System.Windows.Forms.DateTimePicker dtpFecha_inicio;
        private System.Windows.Forms.DateTimePicker dptFecha_fin;
        private System.Windows.Forms.TextBox txtsuma;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox CBEquAr;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnImprimir;
    }
}