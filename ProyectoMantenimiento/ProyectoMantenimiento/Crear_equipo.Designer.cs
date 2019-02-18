namespace ProyectoMantenimiento
{
    partial class Equipo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Equipo));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Fecha_ingre_sist = new System.Windows.Forms.Label();
            this.txtcodigo = new System.Windows.Forms.TextBox();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.cargar_imagen = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.picimagen = new System.Windows.Forms.PictureBox();
            this.button5 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.date_ano_fabricacion = new System.Windows.Forms.DateTimePicker();
            this.label17 = new System.Windows.Forms.Label();
            this.txtemail_fabricante = new System.Windows.Forms.TextBox();
            this.txttelefono_fabricante = new System.Windows.Forms.TextBox();
            this.txtdireccion_fabricante = new System.Windows.Forms.TextBox();
            this.txttipo_grasa = new System.Windows.Forms.TextBox();
            this.txttipo_aceite = new System.Windows.Forms.TextBox();
            this.txtmanual = new System.Windows.Forms.TextBox();
            this.txtlibra_presion = new System.Windows.Forms.TextBox();
            this.txtvoltaje = new System.Windows.Forms.TextBox();
            this.txtcapacidad_produccion = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtserie_equipo = new System.Windows.Forms.TextBox();
            this.txtmodelo_equipo = new System.Windows.Forms.TextBox();
            this.txtcosto_equipo = new System.Windows.Forms.TextBox();
            this.lblSerie = new System.Windows.Forms.Label();
            this.lblModelo = new System.Windows.Forms.Label();
            this.lblCosto = new System.Windows.Forms.Label();
            this.txtfuncion = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.txtrealizado_por = new System.Windows.Forms.TextBox();
            this.txtcaracte_tecn = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.txtmarca = new System.Windows.Forms.TextBox();
            this.txtfabricante = new System.Windows.Forms.TextBox();
            this.txtlargo = new System.Windows.Forms.TextBox();
            this.txtancho = new System.Windows.Forms.TextBox();
            this.txtaltura = new System.Windows.Forms.TextBox();
            this.txtpeso = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label27 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txtlocalizacion = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.cboEstado = new System.Windows.Forms.ComboBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.cboGrup = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.numFrec = new System.Windows.Forms.NumericUpDown();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picimagen)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numFrec)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1043, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "Guardar";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "Salir";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(29, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Crear Equipo o Área Locativa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(244, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 14);
            this.label2.TabIndex = 3;
            this.label2.Text = "Código *";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(36, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 14);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nombre *";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(244, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 14);
            this.label4.TabIndex = 5;
            this.label4.Text = "Localización *";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(36, 201);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(170, 14);
            this.label5.TabIndex = 6;
            this.label5.Text = "Fecha de ingreso a la planta *";
            // 
            // Fecha_ingre_sist
            // 
            this.Fecha_ingre_sist.AutoSize = true;
            this.Fecha_ingre_sist.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fecha_ingre_sist.Location = new System.Drawing.Point(244, 201);
            this.Fecha_ingre_sist.Name = "Fecha_ingre_sist";
            this.Fecha_ingre_sist.Size = new System.Drawing.Size(167, 14);
            this.Fecha_ingre_sist.TabIndex = 7;
            this.Fecha_ingre_sist.Text = "Fecha de ingreso al sistema *";
            // 
            // txtcodigo
            // 
            this.txtcodigo.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcodigo.Location = new System.Drawing.Point(247, 112);
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Size = new System.Drawing.Size(194, 21);
            this.txtcodigo.TabIndex = 1;
            // 
            // txtnombre
            // 
            this.txtnombre.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnombre.Location = new System.Drawing.Point(35, 165);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(194, 21);
            this.txtnombre.TabIndex = 3;
            // 
            // cargar_imagen
            // 
            this.cargar_imagen.BackColor = System.Drawing.Color.Green;
            this.cargar_imagen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cargar_imagen.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cargar_imagen.ForeColor = System.Drawing.Color.White;
            this.cargar_imagen.Location = new System.Drawing.Point(772, 34);
            this.cargar_imagen.Name = "cargar_imagen";
            this.cargar_imagen.Size = new System.Drawing.Size(193, 40);
            this.cargar_imagen.TabIndex = 9;
            this.cargar_imagen.Text = "Cargar imagen";
            this.cargar_imagen.UseVisualStyleBackColor = false;
            this.cargar_imagen.Click += new System.EventHandler(this.button3_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Archivos JPG|*.jpg|Archivos PNG|*.png|Archivos GIF|*.gif|Todos los archivos|*.*";
            // 
            // picimagen
            // 
            this.picimagen.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.picimagen.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picimagen.Location = new System.Drawing.Point(724, 86);
            this.picimagen.Name = "picimagen";
            this.picimagen.Size = new System.Drawing.Size(275, 172);
            this.picimagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picimagen.TabIndex = 32;
            this.picimagen.TabStop = false;
            this.picimagen.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.DarkGreen;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(66, -1);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 26);
            this.button5.TabIndex = 32;
            this.button5.Text = "Guardar";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PapayaWhip;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.date_ano_fabricacion);
            this.panel1.Controls.Add(this.label17);
            this.panel1.Controls.Add(this.txtemail_fabricante);
            this.panel1.Controls.Add(this.txttelefono_fabricante);
            this.panel1.Controls.Add(this.txtdireccion_fabricante);
            this.panel1.Controls.Add(this.txttipo_grasa);
            this.panel1.Controls.Add(this.txttipo_aceite);
            this.panel1.Controls.Add(this.txtmanual);
            this.panel1.Controls.Add(this.txtlibra_presion);
            this.panel1.Controls.Add(this.txtvoltaje);
            this.panel1.Controls.Add(this.txtcapacidad_produccion);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txtserie_equipo);
            this.panel1.Controls.Add(this.txtmodelo_equipo);
            this.panel1.Controls.Add(this.txtcosto_equipo);
            this.panel1.Controls.Add(this.lblSerie);
            this.panel1.Controls.Add(this.lblModelo);
            this.panel1.Controls.Add(this.lblCosto);
            this.panel1.Controls.Add(this.txtfuncion);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label18);
            this.panel1.Controls.Add(this.txtrealizado_por);
            this.panel1.Controls.Add(this.txtcaracte_tecn);
            this.panel1.Controls.Add(this.label19);
            this.panel1.Controls.Add(this.txtmarca);
            this.panel1.Controls.Add(this.txtfabricante);
            this.panel1.Controls.Add(this.txtlargo);
            this.panel1.Controls.Add(this.txtancho);
            this.panel1.Controls.Add(this.txtaltura);
            this.panel1.Controls.Add(this.txtpeso);
            this.panel1.Controls.Add(this.label20);
            this.panel1.Controls.Add(this.label21);
            this.panel1.Controls.Add(this.label22);
            this.panel1.Controls.Add(this.label23);
            this.panel1.Controls.Add(this.label24);
            this.panel1.Controls.Add(this.label25);
            this.panel1.Controls.Add(this.label26);
            this.panel1.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(12, 264);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1013, 343);
            this.panel1.TabIndex = 35;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // date_ano_fabricacion
            // 
            this.date_ano_fabricacion.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_ano_fabricacion.Location = new System.Drawing.Point(819, 292);
            this.date_ano_fabricacion.Name = "date_ano_fabricacion";
            this.date_ano_fabricacion.Size = new System.Drawing.Size(147, 21);
            this.date_ano_fabricacion.TabIndex = 31;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(816, 272);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(118, 14);
            this.label17.TabIndex = 47;
            this.label17.Text = "Fecha de fabricación";
            // 
            // txtemail_fabricante
            // 
            this.txtemail_fabricante.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtemail_fabricante.Location = new System.Drawing.Point(819, 229);
            this.txtemail_fabricante.Name = "txtemail_fabricante";
            this.txtemail_fabricante.Size = new System.Drawing.Size(147, 21);
            this.txtemail_fabricante.TabIndex = 29;
            // 
            // txttelefono_fabricante
            // 
            this.txttelefono_fabricante.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttelefono_fabricante.Location = new System.Drawing.Point(648, 229);
            this.txttelefono_fabricante.Name = "txttelefono_fabricante";
            this.txttelefono_fabricante.Size = new System.Drawing.Size(122, 21);
            this.txttelefono_fabricante.TabIndex = 28;
            // 
            // txtdireccion_fabricante
            // 
            this.txtdireccion_fabricante.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdireccion_fabricante.Location = new System.Drawing.Point(819, 177);
            this.txtdireccion_fabricante.Name = "txtdireccion_fabricante";
            this.txtdireccion_fabricante.Size = new System.Drawing.Size(147, 21);
            this.txtdireccion_fabricante.TabIndex = 27;
            // 
            // txttipo_grasa
            // 
            this.txttipo_grasa.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttipo_grasa.Location = new System.Drawing.Point(648, 177);
            this.txttipo_grasa.Name = "txttipo_grasa";
            this.txttipo_grasa.Size = new System.Drawing.Size(122, 21);
            this.txttipo_grasa.TabIndex = 26;
            // 
            // txttipo_aceite
            // 
            this.txttipo_aceite.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttipo_aceite.Location = new System.Drawing.Point(819, 123);
            this.txttipo_aceite.Name = "txttipo_aceite";
            this.txttipo_aceite.Size = new System.Drawing.Size(147, 21);
            this.txttipo_aceite.TabIndex = 25;
            // 
            // txtmanual
            // 
            this.txtmanual.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmanual.Location = new System.Drawing.Point(648, 292);
            this.txtmanual.Name = "txtmanual";
            this.txtmanual.Size = new System.Drawing.Size(122, 21);
            this.txtmanual.TabIndex = 30;
            // 
            // txtlibra_presion
            // 
            this.txtlibra_presion.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtlibra_presion.Location = new System.Drawing.Point(648, 123);
            this.txtlibra_presion.Name = "txtlibra_presion";
            this.txtlibra_presion.Size = new System.Drawing.Size(122, 21);
            this.txtlibra_presion.TabIndex = 24;
            // 
            // txtvoltaje
            // 
            this.txtvoltaje.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtvoltaje.Location = new System.Drawing.Point(819, 65);
            this.txtvoltaje.Name = "txtvoltaje";
            this.txtvoltaje.Size = new System.Drawing.Size(147, 21);
            this.txtvoltaje.TabIndex = 23;
            // 
            // txtcapacidad_produccion
            // 
            this.txtcapacidad_produccion.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcapacidad_produccion.Location = new System.Drawing.Point(648, 65);
            this.txtcapacidad_produccion.Name = "txtcapacidad_produccion";
            this.txtcapacidad_produccion.Size = new System.Drawing.Size(122, 21);
            this.txtcapacidad_produccion.TabIndex = 22;
            this.txtcapacidad_produccion.TextChanged += new System.EventHandler(this.txtcapacidad_produccion_TextChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(816, 211);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(34, 14);
            this.label16.TabIndex = 36;
            this.label16.Text = "Email";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(645, 211);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(56, 14);
            this.label15.TabIndex = 35;
            this.label15.Text = "Teléfono";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(816, 157);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(56, 14);
            this.label14.TabIndex = 34;
            this.label14.Text = "Dirección";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(645, 160);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(81, 14);
            this.label12.TabIndex = 32;
            this.label12.Text = "Tipo de grasa";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(816, 102);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(86, 14);
            this.label11.TabIndex = 31;
            this.label11.Text = "Tipo de aceite";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(645, 275);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 14);
            this.label10.TabIndex = 30;
            this.label10.Text = "Manual";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(645, 102);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 14);
            this.label9.TabIndex = 29;
            this.label9.Text = "Libra de presion";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(816, 45);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 14);
            this.label8.TabIndex = 28;
            this.label8.Text = "Voltaje ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(643, 45);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(143, 14);
            this.label7.TabIndex = 27;
            this.label7.Text = "Capacidad de producción";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // txtserie_equipo
            // 
            this.txtserie_equipo.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtserie_equipo.Location = new System.Drawing.Point(156, 301);
            this.txtserie_equipo.Name = "txtserie_equipo";
            this.txtserie_equipo.Size = new System.Drawing.Size(122, 21);
            this.txtserie_equipo.TabIndex = 19;
            // 
            // txtmodelo_equipo
            // 
            this.txtmodelo_equipo.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmodelo_equipo.Location = new System.Drawing.Point(14, 301);
            this.txtmodelo_equipo.Name = "txtmodelo_equipo";
            this.txtmodelo_equipo.Size = new System.Drawing.Size(122, 21);
            this.txtmodelo_equipo.TabIndex = 18;
            this.txtmodelo_equipo.TextChanged += new System.EventHandler(this.txtmodelo_equipo_TextChanged);
            // 
            // txtcosto_equipo
            // 
            this.txtcosto_equipo.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcosto_equipo.Location = new System.Drawing.Point(156, 243);
            this.txtcosto_equipo.Multiline = true;
            this.txtcosto_equipo.Name = "txtcosto_equipo";
            this.txtcosto_equipo.Size = new System.Drawing.Size(122, 24);
            this.txtcosto_equipo.TabIndex = 17;
            // 
            // lblSerie
            // 
            this.lblSerie.AutoSize = true;
            this.lblSerie.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSerie.Location = new System.Drawing.Point(153, 275);
            this.lblSerie.Name = "lblSerie";
            this.lblSerie.Size = new System.Drawing.Size(86, 14);
            this.lblSerie.TabIndex = 26;
            this.lblSerie.Text = "Serie equipo *";
            // 
            // lblModelo
            // 
            this.lblModelo.AutoSize = true;
            this.lblModelo.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModelo.Location = new System.Drawing.Point(11, 275);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(98, 14);
            this.lblModelo.TabIndex = 25;
            this.lblModelo.Text = "Modelo equipo *";
            // 
            // lblCosto
            // 
            this.lblCosto.AutoSize = true;
            this.lblCosto.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCosto.Location = new System.Drawing.Point(153, 223);
            this.lblCosto.Name = "lblCosto";
            this.lblCosto.Size = new System.Drawing.Size(99, 14);
            this.lblCosto.TabIndex = 24;
            this.lblCosto.Text = "Costo del equipo";
            // 
            // txtfuncion
            // 
            this.txtfuncion.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfuncion.Location = new System.Drawing.Point(302, 199);
            this.txtfuncion.Multiline = true;
            this.txtfuncion.Name = "txtfuncion";
            this.txtfuncion.Size = new System.Drawing.Size(307, 120);
            this.txtfuncion.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(299, 177);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 14);
            this.label6.TabIndex = 20;
            this.label6.Text = "Función *";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(11, 223);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(82, 14);
            this.label18.TabIndex = 19;
            this.label18.Text = "Realizado por:";
            // 
            // txtrealizado_por
            // 
            this.txtrealizado_por.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtrealizado_por.Location = new System.Drawing.Point(14, 243);
            this.txtrealizado_por.Name = "txtrealizado_por";
            this.txtrealizado_por.Size = new System.Drawing.Size(122, 21);
            this.txtrealizado_por.TabIndex = 16;
            // 
            // txtcaracte_tecn
            // 
            this.txtcaracte_tecn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtcaracte_tecn.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcaracte_tecn.Location = new System.Drawing.Point(302, 65);
            this.txtcaracte_tecn.Multiline = true;
            this.txtcaracte_tecn.Name = "txtcaracte_tecn";
            this.txtcaracte_tecn.Size = new System.Drawing.Size(307, 96);
            this.txtcaracte_tecn.TabIndex = 20;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(17, 9);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(200, 18);
            this.label19.TabIndex = 16;
            this.label19.Text = "Características generales";
            // 
            // txtmarca
            // 
            this.txtmarca.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmarca.Location = new System.Drawing.Point(156, 188);
            this.txtmarca.Name = "txtmarca";
            this.txtmarca.Size = new System.Drawing.Size(122, 21);
            this.txtmarca.TabIndex = 15;
            // 
            // txtfabricante
            // 
            this.txtfabricante.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfabricante.Location = new System.Drawing.Point(14, 188);
            this.txtfabricante.Name = "txtfabricante";
            this.txtfabricante.Size = new System.Drawing.Size(122, 21);
            this.txtfabricante.TabIndex = 14;
            // 
            // txtlargo
            // 
            this.txtlargo.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtlargo.Location = new System.Drawing.Point(14, 65);
            this.txtlargo.Name = "txtlargo";
            this.txtlargo.Size = new System.Drawing.Size(122, 21);
            this.txtlargo.TabIndex = 10;
            // 
            // txtancho
            // 
            this.txtancho.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtancho.Location = new System.Drawing.Point(156, 123);
            this.txtancho.Name = "txtancho";
            this.txtancho.Size = new System.Drawing.Size(122, 21);
            this.txtancho.TabIndex = 13;
            // 
            // txtaltura
            // 
            this.txtaltura.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtaltura.Location = new System.Drawing.Point(14, 123);
            this.txtaltura.Name = "txtaltura";
            this.txtaltura.Size = new System.Drawing.Size(122, 21);
            this.txtaltura.TabIndex = 12;
            // 
            // txtpeso
            // 
            this.txtpeso.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpeso.Location = new System.Drawing.Point(156, 62);
            this.txtpeso.Name = "txtpeso";
            this.txtpeso.Size = new System.Drawing.Size(122, 21);
            this.txtpeso.TabIndex = 11;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(153, 168);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(49, 14);
            this.label20.TabIndex = 7;
            this.label20.Text = "Marca *";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(11, 168);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(63, 14);
            this.label21.TabIndex = 6;
            this.label21.Text = "Fabricante";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(299, 45);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(142, 14);
            this.label22.TabIndex = 5;
            this.label22.Text = "Características técnicas *";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(11, 45);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(37, 14);
            this.label23.TabIndex = 4;
            this.label23.Text = "Largo";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(153, 106);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(42, 14);
            this.label24.TabIndex = 3;
            this.label24.Text = "Ancho";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(11, 106);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(39, 14);
            this.label25.TabIndex = 2;
            this.label25.Text = "Altura";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(153, 45);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(33, 14);
            this.label26.TabIndex = 1;
            this.label26.Text = "Peso";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(35, 222);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(194, 21);
            this.dateTimePicker1.TabIndex = 6;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker2.Location = new System.Drawing.Point(247, 222);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(194, 21);
            this.dateTimePicker2.TabIndex = 7;
            this.dateTimePicker2.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.Location = new System.Drawing.Point(32, 91);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(42, 14);
            this.label27.TabIndex = 38;
            this.label27.Text = "Tipo *";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Área locativa",
            "Equipo"});
            this.comboBox1.Location = new System.Drawing.Point(35, 112);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(194, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectionChangeCommitted += new System.EventHandler(this.comboBox1_SelectionChangeCommitted);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.OrangeRed;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(157, -1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 26);
            this.button1.TabIndex = 33;
            this.button1.Text = "Visualizar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Navy;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(247, -1);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 26);
            this.button2.TabIndex = 34;
            this.button2.Text = "Actualizar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // txtlocalizacion
            // 
            this.txtlocalizacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtlocalizacion.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtlocalizacion.FormattingEnabled = true;
            this.txtlocalizacion.Location = new System.Drawing.Point(247, 165);
            this.txtlocalizacion.Name = "txtlocalizacion";
            this.txtlocalizacion.Size = new System.Drawing.Size(194, 21);
            this.txtlocalizacion.TabIndex = 4;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Teal;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(338, -1);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(108, 26);
            this.button3.TabIndex = 35;
            this.button3.Text = "Historial";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click_2);
            // 
            // cboEstado
            // 
            this.cboEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEstado.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboEstado.FormattingEnabled = true;
            this.cboEstado.Items.AddRange(new object[] {
            "Activo",
            "Inactivo",
            "Danado"});
            this.cboEstado.Location = new System.Drawing.Point(466, 222);
            this.cboEstado.Name = "cboEstado";
            this.cboEstado.Size = new System.Drawing.Size(216, 21);
            this.cboEstado.TabIndex = 8;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.Location = new System.Drawing.Point(463, 201);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(55, 14);
            this.lblEstado.TabIndex = 40;
            this.lblEstado.Text = "Estado *";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.DimGray;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(466, -1);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(114, 26);
            this.button4.TabIndex = 36;
            this.button4.Text = "Ficha técnica";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // cboGrup
            // 
            this.cboGrup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGrup.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboGrup.FormattingEnabled = true;
            this.cboGrup.Location = new System.Drawing.Point(466, 112);
            this.cboGrup.Name = "cboGrup";
            this.cboGrup.Size = new System.Drawing.Size(216, 21);
            this.cboGrup.TabIndex = 2;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(463, 91);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(51, 14);
            this.label13.TabIndex = 43;
            this.label13.Text = "Grupo *";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.Location = new System.Drawing.Point(463, 144);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(218, 14);
            this.label28.TabIndex = 45;
            this.label28.Text = "Frecuencia de mantenimiento en días*";
            // 
            // numFrec
            // 
            this.numFrec.Location = new System.Drawing.Point(466, 165);
            this.numFrec.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numFrec.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numFrec.Name = "numFrec";
            this.numFrec.Size = new System.Drawing.Size(216, 21);
            this.numFrec.TabIndex = 5;
            this.numFrec.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numFrec.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Equipo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1043, 619);
            this.Controls.Add(this.numFrec);
            this.Controls.Add(this.label28);
            this.Controls.Add(this.cboGrup);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.cboEstado);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.txtlocalizacion);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label27);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.picimagen);
            this.Controls.Add(this.cargar_imagen);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.txtcodigo);
            this.Controls.Add(this.Fecha_ingre_sist);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Equipo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Crear equipo";
            this.Load += new System.EventHandler(this.Crear_equipo_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picimagen)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numFrec)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label Fecha_ingre_sist;
        private System.Windows.Forms.TextBox txtcodigo;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.Button cargar_imagen;
        private System.Windows.Forms.PictureBox picimagen;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtfuncion;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtrealizado_por;
        private System.Windows.Forms.TextBox txtcaracte_tecn;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtmarca;
        private System.Windows.Forms.TextBox txtfabricante;
        private System.Windows.Forms.TextBox txtlargo;
        private System.Windows.Forms.TextBox txtancho;
        private System.Windows.Forms.TextBox txtaltura;
        private System.Windows.Forms.TextBox txtpeso;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox txtlocalizacion;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox txtserie_equipo;
        private System.Windows.Forms.TextBox txtmodelo_equipo;
        private System.Windows.Forms.TextBox txtcosto_equipo;
        private System.Windows.Forms.Label lblSerie;
        private System.Windows.Forms.Label lblModelo;
        private System.Windows.Forms.Label lblCosto;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtemail_fabricante;
        private System.Windows.Forms.TextBox txttelefono_fabricante;
        private System.Windows.Forms.TextBox txtdireccion_fabricante;
        private System.Windows.Forms.TextBox txttipo_grasa;
        private System.Windows.Forms.TextBox txttipo_aceite;
        private System.Windows.Forms.TextBox txtmanual;
        private System.Windows.Forms.TextBox txtlibra_presion;
        private System.Windows.Forms.TextBox txtvoltaje;
        private System.Windows.Forms.TextBox txtcapacidad_produccion;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker date_ano_fabricacion;
        private System.Windows.Forms.ComboBox cboEstado;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ComboBox cboGrup;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.NumericUpDown numFrec;
    }
}