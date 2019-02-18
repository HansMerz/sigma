namespace ProyectoMantenimiento
{
    partial class EjecutarCorrectivo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EjecutarCorrectivo));
            this.button2 = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.dgIns = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Costo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnQuitarPersona = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.btnEjecutar = new System.Windows.Forms.Button();
            this.dgPersonas = new System.Windows.Forms.DataGridView();
            this.Col1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.txtBusTra = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtBusEqui = new System.Windows.Forms.TextBox();
            this.txtBusIns = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.dtpFechaSoli = new System.Windows.Forms.DateTimePicker();
            this.lblFechaSoli = new System.Windows.Forms.Label();
            this.dgFallo = new System.Windows.Forms.DataGridView();
            this.Cod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtSoli = new System.Windows.Forms.TextBox();
            this.lblSoli = new System.Windows.Forms.Label();
            this.dgActividad = new System.Windows.Forms.DataGridView();
            this.codigoactividad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.listEqui = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAddIns = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.numCantIns = new System.Windows.Forms.NumericUpDown();
            this.listIns = new System.Windows.Forms.ListBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.dtpFechaDano = new System.Windows.Forms.DateTimePicker();
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
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgIns)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgPersonas)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgFallo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgActividad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCantIns)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Gray;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(1126, 40);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(77, 29);
            this.button2.TabIndex = 24;
            this.button2.Text = "Quitar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label17.Location = new System.Drawing.Point(889, 53);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(127, 16);
            this.label17.TabIndex = 55;
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
            this.dgIns.Location = new System.Drawing.Point(892, 83);
            this.dgIns.Name = "dgIns";
            this.dgIns.Size = new System.Drawing.Size(311, 227);
            this.dgIns.TabIndex = 23;
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
            // btnQuitarPersona
            // 
            this.btnQuitarPersona.BackColor = System.Drawing.Color.Gray;
            this.btnQuitarPersona.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnQuitarPersona.FlatAppearance.BorderSize = 0;
            this.btnQuitarPersona.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuitarPersona.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuitarPersona.ForeColor = System.Drawing.Color.White;
            this.btnQuitarPersona.Location = new System.Drawing.Point(1122, 328);
            this.btnQuitarPersona.Name = "btnQuitarPersona";
            this.btnQuitarPersona.Size = new System.Drawing.Size(81, 33);
            this.btnQuitarPersona.TabIndex = 26;
            this.btnQuitarPersona.Text = "Quitar";
            this.btnQuitarPersona.UseVisualStyleBackColor = false;
            this.btnQuitarPersona.Click += new System.EventHandler(this.btnQuitarPersona_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label15.Location = new System.Drawing.Point(889, 336);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(148, 16);
            this.label15.TabIndex = 51;
            this.label15.Text = "Personas encargadas";
            // 
            // btnEjecutar
            // 
            this.btnEjecutar.BackColor = System.Drawing.Color.Navy;
            this.btnEjecutar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnEjecutar.FlatAppearance.BorderSize = 0;
            this.btnEjecutar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEjecutar.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEjecutar.ForeColor = System.Drawing.Color.White;
            this.btnEjecutar.Location = new System.Drawing.Point(958, 634);
            this.btnEjecutar.Name = "btnEjecutar";
            this.btnEjecutar.Size = new System.Drawing.Size(186, 34);
            this.btnEjecutar.TabIndex = 27;
            this.btnEjecutar.Text = "Ejecutar";
            this.btnEjecutar.UseVisualStyleBackColor = false;
            this.btnEjecutar.Click += new System.EventHandler(this.btnEjecutar_Click);
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
            this.dgPersonas.Location = new System.Drawing.Point(892, 371);
            this.dgPersonas.Name = "dgPersonas";
            this.dgPersonas.Size = new System.Drawing.Size(311, 244);
            this.dgPersonas.TabIndex = 25;
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.txtBusTra);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.txtBusEqui);
            this.groupBox1.Controls.Add(this.txtBusIns);
            this.groupBox1.Controls.Add(this.label19);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.dtpFechaSoli);
            this.groupBox1.Controls.Add(this.lblFechaSoli);
            this.groupBox1.Controls.Add(this.dgFallo);
            this.groupBox1.Controls.Add(this.txtSoli);
            this.groupBox1.Controls.Add(this.lblSoli);
            this.groupBox1.Controls.Add(this.dgActividad);
            this.groupBox1.Controls.Add(this.listEqui);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnAddIns);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.numCantIns);
            this.groupBox1.Controls.Add(this.listIns);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.dtpFechaDano);
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
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(14, 78);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(859, 594);
            this.groupBox1.TabIndex = 45;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detalles de Ejecución";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Teal;
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(497, 50);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(47, 33);
            this.button3.TabIndex = 14;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // txtBusTra
            // 
            this.txtBusTra.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBusTra.ForeColor = System.Drawing.Color.DimGray;
            this.txtBusTra.Location = new System.Drawing.Point(567, 371);
            this.txtBusTra.Name = "txtBusTra";
            this.txtBusTra.Size = new System.Drawing.Size(192, 21);
            this.txtBusTra.TabIndex = 20;
            this.txtBusTra.Text = "Buscar...";
            this.txtBusTra.Enter += new System.EventHandler(this.txtBusTra_Enter);
            this.txtBusTra.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtBusTra_KeyUp);
            this.txtBusTra.Leave += new System.EventHandler(this.txtBusTra_Leave);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Teal;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(674, 48);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(47, 33);
            this.button1.TabIndex = 16;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtBusEqui
            // 
            this.txtBusEqui.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBusEqui.ForeColor = System.Drawing.Color.DimGray;
            this.txtBusEqui.Location = new System.Drawing.Point(321, 371);
            this.txtBusEqui.Name = "txtBusEqui";
            this.txtBusEqui.Size = new System.Drawing.Size(223, 21);
            this.txtBusEqui.TabIndex = 18;
            this.txtBusEqui.Text = "Buscar...";
            this.txtBusEqui.Enter += new System.EventHandler(this.txtBusEqui_Enter);
            this.txtBusEqui.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtBusEqui_KeyUp);
            this.txtBusEqui.Leave += new System.EventHandler(this.txtBusEqui_Leave);
            // 
            // txtBusIns
            // 
            this.txtBusIns.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBusIns.ForeColor = System.Drawing.Color.DimGray;
            this.txtBusIns.Location = new System.Drawing.Point(235, 50);
            this.txtBusIns.Name = "txtBusIns";
            this.txtBusIns.Size = new System.Drawing.Size(128, 21);
            this.txtBusIns.TabIndex = 10;
            this.txtBusIns.Text = "Buscar...";
            this.txtBusIns.Enter += new System.EventHandler(this.txtBusIns_Enter);
            this.txtBusIns.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBusIns_KeyDown);
            this.txtBusIns.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtBusIns_KeyUp);
            this.txtBusIns.Leave += new System.EventHandler(this.txtBusIns_Leave);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label19.Location = new System.Drawing.Point(494, 24);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(81, 16);
            this.label19.TabIndex = 45;
            this.label19.Text = "Actividad *";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label18.Location = new System.Drawing.Point(673, 23);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(48, 16);
            this.label18.TabIndex = 44;
            this.label18.Text = "Fallo *";
            // 
            // dtpFechaSoli
            // 
            this.dtpFechaSoli.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dtpFechaSoli.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dtpFechaSoli.CalendarTrailingForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dtpFechaSoli.CustomFormat = "";
            this.dtpFechaSoli.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaSoli.Location = new System.Drawing.Point(255, 304);
            this.dtpFechaSoli.Name = "dtpFechaSoli";
            this.dtpFechaSoli.Size = new System.Drawing.Size(184, 23);
            this.dtpFechaSoli.TabIndex = 8;
            this.dtpFechaSoli.Value = new System.DateTime(2018, 10, 11, 0, 0, 0, 0);
            // 
            // lblFechaSoli
            // 
            this.lblFechaSoli.AutoSize = true;
            this.lblFechaSoli.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaSoli.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblFechaSoli.Location = new System.Drawing.Point(252, 277);
            this.lblFechaSoli.Name = "lblFechaSoli";
            this.lblFechaSoli.Size = new System.Drawing.Size(134, 16);
            this.lblFechaSoli.TabIndex = 37;
            this.lblFechaSoli.Text = "Fecha de solicitud *";
            // 
            // dgFallo
            // 
            this.dgFallo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgFallo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgFallo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Cod});
            this.dgFallo.Location = new System.Drawing.Point(674, 91);
            this.dgFallo.Name = "dgFallo";
            this.dgFallo.Size = new System.Drawing.Size(118, 166);
            this.dgFallo.TabIndex = 17;
            // 
            // Cod
            // 
            this.Cod.HeaderText = "CÓD";
            this.Cod.Name = "Cod";
            // 
            // txtSoli
            // 
            this.txtSoli.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtSoli.Location = new System.Drawing.Point(23, 304);
            this.txtSoli.Name = "txtSoli";
            this.txtSoli.Size = new System.Drawing.Size(184, 23);
            this.txtSoli.TabIndex = 7;
            // 
            // lblSoli
            // 
            this.lblSoli.AutoSize = true;
            this.lblSoli.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoli.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblSoli.Location = new System.Drawing.Point(20, 277);
            this.lblSoli.Name = "lblSoli";
            this.lblSoli.Size = new System.Drawing.Size(66, 16);
            this.lblSoli.TabIndex = 34;
            this.lblSoli.Text = "Solicita *";
            // 
            // dgActividad
            // 
            this.dgActividad.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgActividad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgActividad.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigoactividad});
            this.dgActividad.Location = new System.Drawing.Point(497, 91);
            this.dgActividad.Name = "dgActividad";
            this.dgActividad.Size = new System.Drawing.Size(122, 166);
            this.dgActividad.TabIndex = 15;
            // 
            // codigoactividad
            // 
            this.codigoactividad.HeaderText = "CÓD";
            this.codigoactividad.Name = "codigoactividad";
            // 
            // listEqui
            // 
            this.listEqui.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.listEqui.FormattingEnabled = true;
            this.listEqui.ItemHeight = 16;
            this.listEqui.Location = new System.Drawing.Point(321, 401);
            this.listEqui.Name = "listEqui";
            this.listEqui.Size = new System.Drawing.Size(223, 180);
            this.listEqui.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(318, 347);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 16);
            this.label2.TabIndex = 33;
            this.label2.Text = "Equipos/Áreas Locativas *";
            // 
            // btnAddIns
            // 
            this.btnAddIns.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnAddIns.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAddIns.FlatAppearance.BorderSize = 0;
            this.btnAddIns.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddIns.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddIns.ForeColor = System.Drawing.Color.White;
            this.btnAddIns.Location = new System.Drawing.Point(374, 217);
            this.btnAddIns.Name = "btnAddIns";
            this.btnAddIns.Size = new System.Drawing.Size(81, 40);
            this.btnAddIns.TabIndex = 13;
            this.btnAddIns.Text = "Agregar";
            this.btnAddIns.UseVisualStyleBackColor = false;
            this.btnAddIns.Click += new System.EventHandler(this.btnAddIns_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label16.Location = new System.Drawing.Point(371, 97);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(65, 16);
            this.label16.TabIndex = 31;
            this.label16.Text = "Cantidad";
            // 
            // numCantIns
            // 
            this.numCantIns.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.numCantIns.Location = new System.Drawing.Point(374, 136);
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
            this.numCantIns.TabIndex = 12;
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
            this.listIns.Location = new System.Drawing.Point(235, 77);
            this.listIns.Name = "listIns";
            this.listIns.Size = new System.Drawing.Size(128, 180);
            this.listIns.TabIndex = 11;
            this.listIns.Click += new System.EventHandler(this.listIns_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(21, 29);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(15, 14);
            this.checkBox1.TabIndex = 1;
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // dtpFechaDano
            // 
            this.dtpFechaDano.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dtpFechaDano.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dtpFechaDano.CalendarTrailingForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dtpFechaDano.CustomFormat = "";
            this.dtpFechaDano.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaDano.Location = new System.Drawing.Point(23, 71);
            this.dtpFechaDano.Name = "dtpFechaDano";
            this.dtpFechaDano.Size = new System.Drawing.Size(184, 23);
            this.dtpFechaDano.TabIndex = 2;
            this.dtpFechaDano.Value = new System.DateTime(2018, 9, 3, 0, 0, 0, 0);
            // 
            // btnAgregarTrabajadores
            // 
            this.btnAgregarTrabajadores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnAgregarTrabajadores.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAgregarTrabajadores.FlatAppearance.BorderSize = 0;
            this.btnAgregarTrabajadores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarTrabajadores.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarTrabajadores.ForeColor = System.Drawing.Color.White;
            this.btnAgregarTrabajadores.Location = new System.Drawing.Point(767, 541);
            this.btnAgregarTrabajadores.Name = "btnAgregarTrabajadores";
            this.btnAgregarTrabajadores.Size = new System.Drawing.Size(81, 40);
            this.btnAgregarTrabajadores.TabIndex = 22;
            this.btnAgregarTrabajadores.Text = "Agregar";
            this.btnAgregarTrabajadores.UseVisualStyleBackColor = false;
            this.btnAgregarTrabajadores.Click += new System.EventHandler(this.btnAgregarTrabajadores_Click);
            // 
            // listTrabajadores
            // 
            this.listTrabajadores.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.listTrabajadores.FormattingEnabled = true;
            this.listTrabajadores.ItemHeight = 16;
            this.listTrabajadores.Location = new System.Drawing.Point(567, 401);
            this.listTrabajadores.Name = "listTrabajadores";
            this.listTrabajadores.Size = new System.Drawing.Size(192, 180);
            this.listTrabajadores.TabIndex = 21;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label13.Location = new System.Drawing.Point(564, 347);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(106, 16);
            this.label13.TabIndex = 26;
            this.label13.Text = "Trabajadores *";
            // 
            // txtProceso
            // 
            this.txtProceso.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtProceso.Location = new System.Drawing.Point(21, 371);
            this.txtProceso.Name = "txtProceso";
            this.txtProceso.Size = new System.Drawing.Size(285, 210);
            this.txtProceso.TabIndex = 9;
            this.txtProceso.Text = "";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label10.Location = new System.Drawing.Point(18, 347);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(115, 16);
            this.label10.TabIndex = 19;
            this.label10.Text = "Observaciones *";
            // 
            // dtpTiempoFin
            // 
            this.dtpTiempoFin.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dtpTiempoFin.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dtpTiempoFin.CalendarTrailingForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dtpTiempoFin.CustomFormat = "HH:mm:ss";
            this.dtpTiempoFin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTiempoFin.Location = new System.Drawing.Point(129, 222);
            this.dtpTiempoFin.Name = "dtpTiempoFin";
            this.dtpTiempoFin.ShowUpDown = true;
            this.dtpTiempoFin.Size = new System.Drawing.Size(78, 23);
            this.dtpTiempoFin.TabIndex = 6;
            // 
            // dtpFechaFin
            // 
            this.dtpFechaFin.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dtpFechaFin.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dtpFechaFin.CalendarTrailingForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dtpFechaFin.CustomFormat = "";
            this.dtpFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaFin.Location = new System.Drawing.Point(21, 222);
            this.dtpFechaFin.Name = "dtpFechaFin";
            this.dtpFechaFin.Size = new System.Drawing.Size(102, 23);
            this.dtpFechaFin.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label9.Location = new System.Drawing.Point(20, 188);
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
            this.dtpTiempoInicio.Location = new System.Drawing.Point(129, 143);
            this.dtpTiempoInicio.Name = "dtpTiempoInicio";
            this.dtpTiempoInicio.ShowUpDown = true;
            this.dtpTiempoInicio.Size = new System.Drawing.Size(78, 23);
            this.dtpTiempoInicio.TabIndex = 4;
            // 
            // dtpFechaInicio
            // 
            this.dtpFechaInicio.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dtpFechaInicio.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dtpFechaInicio.CalendarTrailingForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dtpFechaInicio.CustomFormat = "";
            this.dtpFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaInicio.Location = new System.Drawing.Point(21, 143);
            this.dtpFechaInicio.Name = "dtpFechaInicio";
            this.dtpFechaInicio.Size = new System.Drawing.Size(102, 23);
            this.dtpFechaInicio.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label8.Location = new System.Drawing.Point(20, 109);
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
            this.label5.Location = new System.Drawing.Point(232, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 16);
            this.label5.TabIndex = 2;
            this.label5.Text = "Insumos *";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(48, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Fecha de daño ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(10, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(344, 23);
            this.label1.TabIndex = 36;
            this.label1.Text = "Ejecutar Mantenimiento Correctivo";
            // 
            // btnImprimir
            // 
            this.btnImprimir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnImprimir.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnImprimir.FlatAppearance.BorderSize = 0;
            this.btnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImprimir.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimir.ForeColor = System.Drawing.Color.White;
            this.btnImprimir.Location = new System.Drawing.Point(673, 26);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(200, 34);
            this.btnImprimir.TabIndex = 0;
            this.btnImprimir.Text = "Generar OT de Equipos";
            this.btnImprimir.UseVisualStyleBackColor = false;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Brown;
            this.button4.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(389, 26);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(200, 34);
            this.button4.TabIndex = 56;
            this.button4.Text = "Generar OT de Áreas locativas";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // EjecutarCorrectivo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1221, 684);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.dgIns);
            this.Controls.Add(this.btnQuitarPersona);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.btnEjecutar);
            this.Controls.Add(this.dgPersonas);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EjecutarCorrectivo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EjecutarCorrectivo";
            ((System.ComponentModel.ISupportInitialize)(this.dgIns)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgPersonas)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgFallo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgActividad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCantIns)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.DataGridView dgIns;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Costo;
        private System.Windows.Forms.Button btnQuitarPersona;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btnEjecutar;
        private System.Windows.Forms.DataGridView dgPersonas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAddIns;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.NumericUpDown numCantIns;
        private System.Windows.Forms.ListBox listIns;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.DateTimePicker dtpFechaDano;
        private System.Windows.Forms.Button btnAgregarTrabajadores;
        private System.Windows.Forms.ListBox listTrabajadores;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.RichTextBox txtProceso;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dtpTiempoFin;
        private System.Windows.Forms.DateTimePicker dtpFechaFin;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dtpTiempoInicio;
        private System.Windows.Forms.DateTimePicker dtpFechaInicio;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpFechaSoli;
        private System.Windows.Forms.Label lblFechaSoli;
        private System.Windows.Forms.TextBox txtSoli;
        private System.Windows.Forms.Label lblSoli;
        private System.Windows.Forms.ListBox listEqui;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBusIns;
        private System.Windows.Forms.TextBox txtBusTra;
        private System.Windows.Forms.TextBox txtBusEqui;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.DataGridView dgActividad;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoactividad;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.DataGridView dgFallo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cod;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button button4;
    }
}