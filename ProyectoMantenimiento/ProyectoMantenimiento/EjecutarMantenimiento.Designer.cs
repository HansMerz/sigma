namespace ProyectoMantenimiento
{
    partial class EjecutarMantenimiento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EjecutarMantenimiento));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblEquipo = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblTipo = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblNumOrden = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtBusTra = new System.Windows.Forms.TextBox();
            this.txtBusIns = new System.Windows.Forms.TextBox();
            this.btnAddIns = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.numCantIns = new System.Windows.Forms.NumericUpDown();
            this.listIns = new System.Windows.Forms.ListBox();
            this.btnAgregarTrabajadores = new System.Windows.Forms.Button();
            this.listTrabajadores = new System.Windows.Forms.ListBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtProceso = new System.Windows.Forms.RichTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.dtpTiempoFin = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaFin = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.dtpTiempoInicio = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dgPersonas = new System.Windows.Forms.DataGridView();
            this.Col1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEjecutar = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.btnQuitarPersona = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.dgIns = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Costo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCantIns)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgPersonas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgIns)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(9, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ejecutar Mantenimiento";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(301, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 14);
            this.label2.TabIndex = 1;
            this.label2.Text = "Equipo:";
            // 
            // lblEquipo
            // 
            this.lblEquipo.AutoSize = true;
            this.lblEquipo.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEquipo.ForeColor = System.Drawing.Color.Black;
            this.lblEquipo.Location = new System.Drawing.Point(351, 16);
            this.lblEquipo.Name = "lblEquipo";
            this.lblEquipo.Size = new System.Drawing.Size(53, 14);
            this.lblEquipo.TabIndex = 2;
            this.lblEquipo.Text = "Equipo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(301, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 14);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tipo de Mantenimiento:";
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipo.ForeColor = System.Drawing.Color.Black;
            this.lblTipo.Location = new System.Drawing.Point(450, 53);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(53, 14);
            this.lblTipo.TabIndex = 4;
            this.lblTipo.Text = "Equipo:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label6.Location = new System.Drawing.Point(623, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 14);
            this.label6.TabIndex = 5;
            this.label6.Text = "Código:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label7.Location = new System.Drawing.Point(623, 53);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(117, 14);
            this.label7.TabIndex = 6;
            this.label7.Text = "Número de orden:";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.ForeColor = System.Drawing.Color.Black;
            this.lblCodigo.Location = new System.Drawing.Point(683, 16);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(53, 14);
            this.lblCodigo.TabIndex = 7;
            this.lblCodigo.Text = "Equipo:";
            // 
            // lblNumOrden
            // 
            this.lblNumOrden.AutoSize = true;
            this.lblNumOrden.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumOrden.ForeColor = System.Drawing.Color.Black;
            this.lblNumOrden.Location = new System.Drawing.Point(746, 53);
            this.lblNumOrden.Name = "lblNumOrden";
            this.lblNumOrden.Size = new System.Drawing.Size(53, 14);
            this.lblNumOrden.TabIndex = 8;
            this.lblNumOrden.Text = "Equipo:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtBusTra);
            this.groupBox1.Controls.Add(this.txtBusIns);
            this.groupBox1.Controls.Add(this.btnAddIns);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.numCantIns);
            this.groupBox1.Controls.Add(this.listIns);
            this.groupBox1.Controls.Add(this.btnAgregarTrabajadores);
            this.groupBox1.Controls.Add(this.listTrabajadores);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.txtProceso);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.dtpTiempoFin);
            this.groupBox1.Controls.Add(this.dtpFechaFin);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.dtpTiempoInicio);
            this.groupBox1.Controls.Add(this.dtpFechaInicio);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(13, 79);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(808, 541);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detalles de Ejecución";
            // 
            // txtBusTra
            // 
            this.txtBusTra.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBusTra.ForeColor = System.Drawing.Color.DimGray;
            this.txtBusTra.Location = new System.Drawing.Point(420, 321);
            this.txtBusTra.Name = "txtBusTra";
            this.txtBusTra.Size = new System.Drawing.Size(244, 21);
            this.txtBusTra.TabIndex = 9;
            this.txtBusTra.Text = "Buscar...";
            this.txtBusTra.Enter += new System.EventHandler(this.txtBusTra_Enter);
            this.txtBusTra.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtBusTra_KeyUp);
            this.txtBusTra.Leave += new System.EventHandler(this.txtBusTra_Leave);
            // 
            // txtBusIns
            // 
            this.txtBusIns.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBusIns.ForeColor = System.Drawing.Color.DimGray;
            this.txtBusIns.Location = new System.Drawing.Point(22, 320);
            this.txtBusIns.Name = "txtBusIns";
            this.txtBusIns.Size = new System.Drawing.Size(213, 21);
            this.txtBusIns.TabIndex = 4;
            this.txtBusIns.Text = "Buscar...";
            this.txtBusIns.Enter += new System.EventHandler(this.textBox2_Enter);
            this.txtBusIns.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtBusIns_KeyUp);
            this.txtBusIns.Leave += new System.EventHandler(this.txtBusIns_Leave);
            // 
            // btnAddIns
            // 
            this.btnAddIns.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnAddIns.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAddIns.FlatAppearance.BorderSize = 0;
            this.btnAddIns.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddIns.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddIns.ForeColor = System.Drawing.Color.White;
            this.btnAddIns.Location = new System.Drawing.Point(265, 489);
            this.btnAddIns.Name = "btnAddIns";
            this.btnAddIns.Size = new System.Drawing.Size(81, 40);
            this.btnAddIns.TabIndex = 7;
            this.btnAddIns.Text = "Agregar";
            this.btnAddIns.UseVisualStyleBackColor = false;
            this.btnAddIns.Click += new System.EventHandler(this.button1_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label16.Location = new System.Drawing.Point(262, 369);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(65, 16);
            this.label16.TabIndex = 31;
            this.label16.Text = "Cantidad";
            // 
            // numCantIns
            // 
            this.numCantIns.Location = new System.Drawing.Point(265, 408);
            this.numCantIns.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numCantIns.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numCantIns.Name = "numCantIns";
            this.numCantIns.Size = new System.Drawing.Size(65, 23);
            this.numCantIns.TabIndex = 6;
            this.numCantIns.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // listIns
            // 
            this.listIns.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.listIns.FormattingEnabled = true;
            this.listIns.ItemHeight = 16;
            this.listIns.Location = new System.Drawing.Point(23, 349);
            this.listIns.Name = "listIns";
            this.listIns.Size = new System.Drawing.Size(212, 180);
            this.listIns.TabIndex = 5;
            this.listIns.Click += new System.EventHandler(this.listIns_Click);
            this.listIns.SelectedIndexChanged += new System.EventHandler(this.listIns_SelectedIndexChanged);
            // 
            // btnAgregarTrabajadores
            // 
            this.btnAgregarTrabajadores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnAgregarTrabajadores.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAgregarTrabajadores.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarTrabajadores.ForeColor = System.Drawing.Color.White;
            this.btnAgregarTrabajadores.Location = new System.Drawing.Point(684, 489);
            this.btnAgregarTrabajadores.Name = "btnAgregarTrabajadores";
            this.btnAgregarTrabajadores.Size = new System.Drawing.Size(81, 40);
            this.btnAgregarTrabajadores.TabIndex = 11;
            this.btnAgregarTrabajadores.Text = "Agregar";
            this.btnAgregarTrabajadores.UseVisualStyleBackColor = false;
            this.btnAgregarTrabajadores.Click += new System.EventHandler(this.btnAgregarTrabajadores_Click);
            // 
            // listTrabajadores
            // 
            this.listTrabajadores.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.listTrabajadores.FormattingEnabled = true;
            this.listTrabajadores.ItemHeight = 16;
            this.listTrabajadores.Location = new System.Drawing.Point(420, 349);
            this.listTrabajadores.Name = "listTrabajadores";
            this.listTrabajadores.Size = new System.Drawing.Size(244, 180);
            this.listTrabajadores.TabIndex = 10;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label13.Location = new System.Drawing.Point(417, 295);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(106, 16);
            this.label13.TabIndex = 26;
            this.label13.Text = "Trabajadores *";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // txtProceso
            // 
            this.txtProceso.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtProceso.Location = new System.Drawing.Point(273, 88);
            this.txtProceso.Name = "txtProceso";
            this.txtProceso.Size = new System.Drawing.Size(492, 191);
            this.txtProceso.TabIndex = 8;
            this.txtProceso.Text = "";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label10.Location = new System.Drawing.Point(270, 49);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(179, 16);
            this.label10.TabIndex = 19;
            this.label10.Text = "Observaciones generales*";
            // 
            // dtpTiempoFin
            // 
            this.dtpTiempoFin.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dtpTiempoFin.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dtpTiempoFin.CalendarTrailingForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dtpTiempoFin.CustomFormat = "HH:mm:ss";
            this.dtpTiempoFin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTiempoFin.Location = new System.Drawing.Point(129, 178);
            this.dtpTiempoFin.Name = "dtpTiempoFin";
            this.dtpTiempoFin.ShowUpDown = true;
            this.dtpTiempoFin.Size = new System.Drawing.Size(78, 23);
            this.dtpTiempoFin.TabIndex = 3;
            // 
            // dtpFechaFin
            // 
            this.dtpFechaFin.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dtpFechaFin.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dtpFechaFin.CalendarTrailingForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dtpFechaFin.CustomFormat = "";
            this.dtpFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaFin.Location = new System.Drawing.Point(21, 178);
            this.dtpFechaFin.Name = "dtpFechaFin";
            this.dtpFechaFin.Size = new System.Drawing.Size(102, 23);
            this.dtpFechaFin.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label9.Location = new System.Drawing.Point(20, 144);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(199, 16);
            this.label9.TabIndex = 16;
            this.label9.Text = "Fecha y hora de Finalización *";
            // 
            // dtpTiempoInicio
            // 
            this.dtpTiempoInicio.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dtpTiempoInicio.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dtpTiempoInicio.CalendarTrailingForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dtpTiempoInicio.CustomFormat = "HH:mm:ss";
            this.dtpTiempoInicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTiempoInicio.Location = new System.Drawing.Point(129, 83);
            this.dtpTiempoInicio.Name = "dtpTiempoInicio";
            this.dtpTiempoInicio.ShowUpDown = true;
            this.dtpTiempoInicio.Size = new System.Drawing.Size(78, 23);
            this.dtpTiempoInicio.TabIndex = 1;
            // 
            // dtpFechaInicio
            // 
            this.dtpFechaInicio.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dtpFechaInicio.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dtpFechaInicio.CalendarTrailingForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dtpFechaInicio.CustomFormat = "";
            this.dtpFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaInicio.Location = new System.Drawing.Point(21, 83);
            this.dtpFechaInicio.Name = "dtpFechaInicio";
            this.dtpFechaInicio.Size = new System.Drawing.Size(102, 23);
            this.dtpFechaInicio.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label8.Location = new System.Drawing.Point(20, 49);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(161, 16);
            this.label8.TabIndex = 13;
            this.label8.Text = "Fecha y hora de Inicio *";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(20, 295);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 16);
            this.label5.TabIndex = 2;
            this.label5.Text = "Insumos";
            // 
            // dgPersonas
            // 
            this.dgPersonas.AllowUserToAddRows = false;
            this.dgPersonas.AllowUserToDeleteRows = false;
            this.dgPersonas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgPersonas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPersonas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Col1,
            this.Column4});
            this.dgPersonas.Location = new System.Drawing.Point(844, 351);
            this.dgPersonas.Name = "dgPersonas";
            this.dgPersonas.Size = new System.Drawing.Size(311, 215);
            this.dgPersonas.TabIndex = 14;
            // 
            // Col1
            // 
            this.Col1.HeaderText = "ID";
            this.Col1.Name = "Col1";
            this.Col1.Visible = false;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Nombres";
            this.Column4.Name = "Column4";
            // 
            // btnEjecutar
            // 
            this.btnEjecutar.BackColor = System.Drawing.Color.Navy;
            this.btnEjecutar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnEjecutar.FlatAppearance.BorderSize = 0;
            this.btnEjecutar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEjecutar.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEjecutar.ForeColor = System.Drawing.Color.White;
            this.btnEjecutar.Location = new System.Drawing.Point(910, 586);
            this.btnEjecutar.Name = "btnEjecutar";
            this.btnEjecutar.Size = new System.Drawing.Size(186, 34);
            this.btnEjecutar.TabIndex = 16;
            this.btnEjecutar.Text = "Ejecutar";
            this.btnEjecutar.UseVisualStyleBackColor = false;
            this.btnEjecutar.Click += new System.EventHandler(this.btnEjecutar_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label15.Location = new System.Drawing.Point(841, 316);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(148, 16);
            this.label15.TabIndex = 31;
            this.label15.Text = "Personas encargadas";
            // 
            // btnQuitarPersona
            // 
            this.btnQuitarPersona.BackColor = System.Drawing.Color.Gray;
            this.btnQuitarPersona.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnQuitarPersona.FlatAppearance.BorderSize = 0;
            this.btnQuitarPersona.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuitarPersona.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuitarPersona.ForeColor = System.Drawing.Color.White;
            this.btnQuitarPersona.Location = new System.Drawing.Point(1074, 308);
            this.btnQuitarPersona.Name = "btnQuitarPersona";
            this.btnQuitarPersona.Size = new System.Drawing.Size(81, 33);
            this.btnQuitarPersona.TabIndex = 15;
            this.btnQuitarPersona.Text = "Quitar";
            this.btnQuitarPersona.UseVisualStyleBackColor = false;
            this.btnQuitarPersona.Click += new System.EventHandler(this.btnQuitarPersona_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Gray;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(1074, 27);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(81, 29);
            this.button2.TabIndex = 13;
            this.button2.Text = "Quitar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label17.Location = new System.Drawing.Point(841, 40);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(127, 16);
            this.label17.TabIndex = 35;
            this.label17.Text = "Insumos Utilizados";
            // 
            // dgIns
            // 
            this.dgIns.AllowUserToAddRows = false;
            this.dgIns.AllowUserToDeleteRows = false;
            this.dgIns.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgIns.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgIns.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.Costo});
            this.dgIns.Location = new System.Drawing.Point(844, 70);
            this.dgIns.Name = "dgIns";
            this.dgIns.Size = new System.Drawing.Size(311, 224);
            this.dgIns.TabIndex = 12;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Cantidad";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // Costo
            // 
            this.Costo.HeaderText = "Costo";
            this.Costo.Name = "Costo";
            // 
            // EjecutarMantenimiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1176, 632);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.dgIns);
            this.Controls.Add(this.btnQuitarPersona);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.btnEjecutar);
            this.Controls.Add(this.dgPersonas);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblNumOrden);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblEquipo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EjecutarMantenimiento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ejecutar Preventivo";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCantIns)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgPersonas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgIns)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblEquipo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblNumOrden;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpTiempoFin;
        private System.Windows.Forms.DateTimePicker dtpFechaFin;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dtpTiempoInicio;
        private System.Windows.Forms.DateTimePicker dtpFechaInicio;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RichTextBox txtProceso;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnAgregarTrabajadores;
        private System.Windows.Forms.ListBox listTrabajadores;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridView dgPersonas;
        private System.Windows.Forms.Button btnEjecutar;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Button btnQuitarPersona;
        private System.Windows.Forms.ListBox listIns;
        private System.Windows.Forms.Button btnAddIns;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.NumericUpDown numCantIns;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.DataGridView dgIns;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Costo;
        private System.Windows.Forms.TextBox txtBusTra;
        private System.Windows.Forms.TextBox txtBusIns;
    }
}