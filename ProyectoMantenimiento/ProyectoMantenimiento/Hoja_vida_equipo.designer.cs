namespace ProyectoMantenimiento
{
    partial class Hoja_vida_equipo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Hoja_vida_equipo));
            this.label4 = new System.Windows.Forms.Label();
            this.txtcodigoingresado = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.reportExecutionService1 = new Microsoft.Reporting.WinForms.Internal.Soap.ReportingServices2005.Execution.ReportExecutionService();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.txtequipo_arealocativa = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.txtcodigo = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.txtserial = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.txtcodigo_inventario = new System.Windows.Forms.TextBox();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.txtlocalizacion = new System.Windows.Forms.TextBox();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblTotalMantenimientos = new System.Windows.Forms.Label();
            this.lblCostoMan = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.dgv_mantenimiento = new System.Windows.Forms.DataGridView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dgFallos = new System.Windows.Forms.DataGridView();
            this.cod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.desc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgActividades = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label10 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgEncargados = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_mantenimiento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgFallos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgActividades)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgEncargados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(463, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 14);
            this.label4.TabIndex = 2;
            this.label4.Text = "Ingresar código";
            // 
            // txtcodigoingresado
            // 
            this.txtcodigoingresado.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcodigoingresado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtcodigoingresado.Location = new System.Drawing.Point(449, 102);
            this.txtcodigoingresado.Multiline = true;
            this.txtcodigoingresado.Name = "txtcodigoingresado";
            this.txtcodigoingresado.Size = new System.Drawing.Size(130, 25);
            this.txtcodigoingresado.TabIndex = 0;
            this.txtcodigoingresado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtcodigoingresado.TextChanged += new System.EventHandler(this.txtcodigoingresado_TextChanged);
            this.txtcodigoingresado.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtcodigoingresado_KeyDown);
            this.txtcodigoingresado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcodigoingresado_KeyPress);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.OrangeRed;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(12, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 30);
            this.button1.TabIndex = 1;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkGreen;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(114, 6);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(92, 30);
            this.button2.TabIndex = 2;
            this.button2.Text = "Reporte";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // reportExecutionService1
            // 
            this.reportExecutionService1.Credentials = null;
            this.reportExecutionService1.ExecutionHeaderValue = null;
            this.reportExecutionService1.ServerInfoHeaderValue = null;
            this.reportExecutionService1.TrustedUserHeaderValue = null;
            this.reportExecutionService1.Url = "http://localhost/ReportServer/ReportExecution2005.asmx";
            this.reportExecutionService1.UseDefaultCredentials = false;
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.White;
            this.textBox4.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBox4.Enabled = false;
            this.textBox4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(27, 149);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(130, 27);
            this.textBox4.TabIndex = 0;
            this.textBox4.Text = "Nombre ";
            // 
            // txtequipo_arealocativa
            // 
            this.txtequipo_arealocativa.BackColor = System.Drawing.Color.White;
            this.txtequipo_arealocativa.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtequipo_arealocativa.Enabled = false;
            this.txtequipo_arealocativa.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtequipo_arealocativa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtequipo_arealocativa.Location = new System.Drawing.Point(163, 149);
            this.txtequipo_arealocativa.Multiline = true;
            this.txtequipo_arealocativa.Name = "txtequipo_arealocativa";
            this.txtequipo_arealocativa.ReadOnly = true;
            this.txtequipo_arealocativa.Size = new System.Drawing.Size(323, 27);
            this.txtequipo_arealocativa.TabIndex = 1;
            // 
            // textBox6
            // 
            this.textBox6.BackColor = System.Drawing.Color.White;
            this.textBox6.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBox6.Enabled = false;
            this.textBox6.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox6.Location = new System.Drawing.Point(27, 182);
            this.textBox6.Multiline = true;
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.Size = new System.Drawing.Size(130, 27);
            this.textBox6.TabIndex = 2;
            this.textBox6.Text = "Código";
            // 
            // txtcodigo
            // 
            this.txtcodigo.BackColor = System.Drawing.Color.White;
            this.txtcodigo.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtcodigo.Enabled = false;
            this.txtcodigo.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcodigo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtcodigo.Location = new System.Drawing.Point(163, 182);
            this.txtcodigo.Multiline = true;
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.ReadOnly = true;
            this.txtcodigo.Size = new System.Drawing.Size(323, 27);
            this.txtcodigo.TabIndex = 3;
            // 
            // textBox8
            // 
            this.textBox8.BackColor = System.Drawing.Color.White;
            this.textBox8.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBox8.Enabled = false;
            this.textBox8.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox8.Location = new System.Drawing.Point(538, 182);
            this.textBox8.Multiline = true;
            this.textBox8.Name = "textBox8";
            this.textBox8.ReadOnly = true;
            this.textBox8.Size = new System.Drawing.Size(100, 27);
            this.textBox8.TabIndex = 4;
            this.textBox8.Text = "Serial";
            // 
            // txtserial
            // 
            this.txtserial.BackColor = System.Drawing.Color.White;
            this.txtserial.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtserial.Enabled = false;
            this.txtserial.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtserial.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtserial.Location = new System.Drawing.Point(644, 182);
            this.txtserial.Multiline = true;
            this.txtserial.Name = "txtserial";
            this.txtserial.ReadOnly = true;
            this.txtserial.Size = new System.Drawing.Size(296, 27);
            this.txtserial.TabIndex = 5;
            // 
            // textBox10
            // 
            this.textBox10.BackColor = System.Drawing.Color.White;
            this.textBox10.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBox10.Enabled = false;
            this.textBox10.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox10.Location = new System.Drawing.Point(27, 215);
            this.textBox10.Multiline = true;
            this.textBox10.Name = "textBox10";
            this.textBox10.ReadOnly = true;
            this.textBox10.Size = new System.Drawing.Size(130, 27);
            this.textBox10.TabIndex = 6;
            this.textBox10.Text = "Modelo";
            // 
            // txtcodigo_inventario
            // 
            this.txtcodigo_inventario.BackColor = System.Drawing.Color.White;
            this.txtcodigo_inventario.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtcodigo_inventario.Enabled = false;
            this.txtcodigo_inventario.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcodigo_inventario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtcodigo_inventario.Location = new System.Drawing.Point(163, 215);
            this.txtcodigo_inventario.Multiline = true;
            this.txtcodigo_inventario.Name = "txtcodigo_inventario";
            this.txtcodigo_inventario.ReadOnly = true;
            this.txtcodigo_inventario.Size = new System.Drawing.Size(323, 27);
            this.txtcodigo_inventario.TabIndex = 7;
            // 
            // textBox12
            // 
            this.textBox12.BackColor = System.Drawing.Color.White;
            this.textBox12.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBox12.Enabled = false;
            this.textBox12.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox12.Location = new System.Drawing.Point(538, 215);
            this.textBox12.Multiline = true;
            this.textBox12.Name = "textBox12";
            this.textBox12.ReadOnly = true;
            this.textBox12.Size = new System.Drawing.Size(100, 27);
            this.textBox12.TabIndex = 8;
            this.textBox12.Text = "Localización";
            // 
            // txtlocalizacion
            // 
            this.txtlocalizacion.BackColor = System.Drawing.Color.White;
            this.txtlocalizacion.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtlocalizacion.Enabled = false;
            this.txtlocalizacion.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtlocalizacion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtlocalizacion.Location = new System.Drawing.Point(644, 215);
            this.txtlocalizacion.Multiline = true;
            this.txtlocalizacion.Name = "txtlocalizacion";
            this.txtlocalizacion.ReadOnly = true;
            this.txtlocalizacion.Size = new System.Drawing.Size(296, 27);
            this.txtlocalizacion.TabIndex = 9;
            // 
            // txtEstado
            // 
            this.txtEstado.BackColor = System.Drawing.Color.White;
            this.txtEstado.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtEstado.Enabled = false;
            this.txtEstado.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEstado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtEstado.Location = new System.Drawing.Point(644, 149);
            this.txtEstado.Multiline = true;
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.ReadOnly = true;
            this.txtEstado.Size = new System.Drawing.Size(296, 25);
            this.txtEstado.TabIndex = 16;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.White;
            this.textBox3.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBox3.Enabled = false;
            this.textBox3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(538, 149);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(100, 25);
            this.textBox3.TabIndex = 15;
            this.textBox3.Text = "Estado";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(24, 617);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(196, 18);
            this.label5.TabIndex = 6;
            this.label5.Text = "Total de Mantenimientos:";
            // 
            // lblTotalMantenimientos
            // 
            this.lblTotalMantenimientos.AutoSize = true;
            this.lblTotalMantenimientos.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalMantenimientos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTotalMantenimientos.Location = new System.Drawing.Point(226, 617);
            this.lblTotalMantenimientos.Name = "lblTotalMantenimientos";
            this.lblTotalMantenimientos.Size = new System.Drawing.Size(0, 18);
            this.lblTotalMantenimientos.TabIndex = 7;
            // 
            // lblCostoMan
            // 
            this.lblCostoMan.AutoSize = true;
            this.lblCostoMan.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCostoMan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblCostoMan.Location = new System.Drawing.Point(837, 617);
            this.lblCostoMan.Name = "lblCostoMan";
            this.lblCostoMan.Size = new System.Drawing.Size(0, 18);
            this.lblCostoMan.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label9.Location = new System.Drawing.Point(724, 617);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(94, 18);
            this.label9.TabIndex = 8;
            this.label9.Text = "Costo total:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label8.Location = new System.Drawing.Point(818, 617);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(18, 18);
            this.label8.TabIndex = 10;
            this.label8.Text = "$";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.White;
            this.label11.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.DimGray;
            this.label11.Location = new System.Drawing.Point(321, 34);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(383, 19);
            this.label11.TabIndex = 8;
            this.label11.Text = "HOJA DE VIDA EQUIPOS Y ÁREAS LOCATIVAS";
            // 
            // dgv_mantenimiento
            // 
            this.dgv_mantenimiento.AllowUserToAddRows = false;
            this.dgv_mantenimiento.AllowUserToDeleteRows = false;
            this.dgv_mantenimiento.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_mantenimiento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_mantenimiento.Location = new System.Drawing.Point(27, 281);
            this.dgv_mantenimiento.Name = "dgv_mantenimiento";
            this.dgv_mantenimiento.Size = new System.Drawing.Size(623, 307);
            this.dgv_mantenimiento.TabIndex = 3;
            this.dgv_mantenimiento.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_mantenimiento_CellClick);
            this.dgv_mantenimiento.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_mantenimiento_CellContentClick);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.Cantidad,
            this.Precio});
            this.dataGridView1.Location = new System.Drawing.Point(931, 281);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(278, 142);
            this.dataGridView1.TabIndex = 11;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio por unidad";
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(928, 264);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 14);
            this.label6.TabIndex = 12;
            this.label6.Text = "Insumos utilizados";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(664, 264);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 14);
            this.label7.TabIndex = 14;
            this.label7.Text = "Fallos";
            // 
            // dgFallos
            // 
            this.dgFallos.AllowUserToAddRows = false;
            this.dgFallos.AllowUserToDeleteRows = false;
            this.dgFallos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgFallos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgFallos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cod,
            this.desc});
            this.dgFallos.Location = new System.Drawing.Point(667, 281);
            this.dgFallos.Name = "dgFallos";
            this.dgFallos.ReadOnly = true;
            this.dgFallos.Size = new System.Drawing.Size(240, 142);
            this.dgFallos.TabIndex = 17;
            // 
            // cod
            // 
            this.cod.FillWeight = 35.53299F;
            this.cod.HeaderText = "COD";
            this.cod.Name = "cod";
            this.cod.ReadOnly = true;
            // 
            // desc
            // 
            this.desc.FillWeight = 164.467F;
            this.desc.HeaderText = "Descripción";
            this.desc.Name = "desc";
            this.desc.ReadOnly = true;
            // 
            // dgActividades
            // 
            this.dgActividades.AllowUserToAddRows = false;
            this.dgActividades.AllowUserToDeleteRows = false;
            this.dgActividades.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgActividades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgActividades.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.dgActividades.Location = new System.Drawing.Point(667, 446);
            this.dgActividades.Name = "dgActividades";
            this.dgActividades.ReadOnly = true;
            this.dgActividades.Size = new System.Drawing.Size(240, 142);
            this.dgActividades.TabIndex = 18;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.FillWeight = 35.53299F;
            this.dataGridViewTextBoxColumn1.HeaderText = "COD";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.FillWeight = 164.467F;
            this.dataGridViewTextBoxColumn2.HeaderText = "Descripción";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(664, 426);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 14);
            this.label10.TabIndex = 19;
            this.label10.Text = "Actividades";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(928, 426);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 14);
            this.label1.TabIndex = 21;
            this.label1.Text = "Encargados";
            // 
            // dgEncargados
            // 
            this.dgEncargados.AllowUserToAddRows = false;
            this.dgEncargados.AllowUserToDeleteRows = false;
            this.dgEncargados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgEncargados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgEncargados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn5});
            this.dgEncargados.Location = new System.Drawing.Point(931, 446);
            this.dgEncargados.Name = "dgEncargados";
            this.dgEncargados.ReadOnly = true;
            this.dgEncargados.Size = new System.Drawing.Size(278, 142);
            this.dgEncargados.TabIndex = 20;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Nombres";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(958, 77);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(246, 165);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // Hoja_vida_equipo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1216, 659);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgEncargados);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.dgActividades);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dgFallos);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtEstado);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblCostoMan);
            this.Controls.Add(this.dgv_mantenimiento);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblTotalMantenimientos);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtlocalizacion);
            this.Controls.Add(this.txtcodigoingresado);
            this.Controls.Add(this.textBox12);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtserial);
            this.Controls.Add(this.txtcodigo_inventario);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.textBox10);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.txtcodigo);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.txtequipo_arealocativa);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Hoja_vida_equipo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hoja de vida equipo y áreas locativas";
            this.Load += new System.EventHandler(this.Hoja_vida_equipo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_mantenimiento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgFallos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgActividades)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgEncargados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtcodigoingresado;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private Microsoft.Reporting.WinForms.Internal.Soap.ReportingServices2005.Execution.ReportExecutionService reportExecutionService1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox txtequipo_arealocativa;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox txtcodigo;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox txtserial;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.TextBox txtcodigo_inventario;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.TextBox txtlocalizacion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblTotalMantenimientos;
        private System.Windows.Forms.Label lblCostoMan;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView dgv_mantenimiento;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgFallos;
        private System.Windows.Forms.DataGridView dgActividades;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgEncargados;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn cod;
        private System.Windows.Forms.DataGridViewTextBoxColumn desc;
    }
}