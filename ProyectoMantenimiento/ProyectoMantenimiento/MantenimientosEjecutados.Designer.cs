namespace ProyectoMantenimiento
{
    partial class MantenimientosEjecutados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MantenimientosEjecutados));
            this.label1 = new System.Windows.Forms.Label();
            this.btnVer1 = new System.Windows.Forms.Button();
            this.btnVer2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Costo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.dgIns = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgTra = new System.Windows.Forms.DataGridView();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgIns)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgTra)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(10, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mantenimientos Ejecutados";
            // 
            // btnVer1
            // 
            this.btnVer1.BackColor = System.Drawing.Color.MediumBlue;
            this.btnVer1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnVer1.FlatAppearance.BorderSize = 0;
            this.btnVer1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVer1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVer1.ForeColor = System.Drawing.Color.White;
            this.btnVer1.Location = new System.Drawing.Point(29, 92);
            this.btnVer1.Name = "btnVer1";
            this.btnVer1.Size = new System.Drawing.Size(196, 32);
            this.btnVer1.TabIndex = 3;
            this.btnVer1.Text = "Ver Insumos y Encargados";
            this.btnVer1.UseVisualStyleBackColor = false;
            this.btnVer1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnVer2
            // 
            this.btnVer2.BackColor = System.Drawing.Color.Teal;
            this.btnVer2.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnVer2.FlatAppearance.BorderSize = 0;
            this.btnVer2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVer2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVer2.ForeColor = System.Drawing.Color.White;
            this.btnVer2.Location = new System.Drawing.Point(264, 92);
            this.btnVer2.Name = "btnVer2";
            this.btnVer2.Size = new System.Drawing.Size(132, 32);
            this.btnVer2.TabIndex = 5;
            this.btnVer2.Text = "Ver Proceso";
            this.btnVer2.UseVisualStyleBackColor = false;
            this.btnVer2.Click += new System.EventHandler(this.button3_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(10, 150);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(734, 341);
            this.dataGridView1.TabIndex = 12;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick_1);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Costo});
            this.dataGridView2.Location = new System.Drawing.Point(756, 150);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(126, 341);
            this.dataGridView2.TabIndex = 13;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            this.dataGridView2.Scroll += new System.Windows.Forms.ScrollEventHandler(this.dataGridView2_Scroll);
            // 
            // Costo
            // 
            this.Costo.HeaderText = "Costo";
            this.Costo.Name = "Costo";
            this.Costo.ReadOnly = true;
            // 
            // btnImprimir
            // 
            this.btnImprimir.BackColor = System.Drawing.Color.DarkGreen;
            this.btnImprimir.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnImprimir.FlatAppearance.BorderSize = 0;
            this.btnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImprimir.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimir.ForeColor = System.Drawing.Color.White;
            this.btnImprimir.Location = new System.Drawing.Point(756, 92);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(126, 32);
            this.btnImprimir.TabIndex = 14;
            this.btnImprimir.Text = "Reporte";
            this.btnImprimir.UseVisualStyleBackColor = false;
            this.btnImprimir.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // dgIns
            // 
            this.dgIns.AllowUserToAddRows = false;
            this.dgIns.AllowUserToDeleteRows = false;
            this.dgIns.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgIns.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgIns.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dgIns.Location = new System.Drawing.Point(893, 150);
            this.dgIns.Name = "dgIns";
            this.dgIns.ReadOnly = true;
            this.dgIns.Size = new System.Drawing.Size(206, 157);
            this.dgIns.TabIndex = 16;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Nombre";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Cantidad";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Costo x U";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // dgTra
            // 
            this.dgTra.AllowUserToAddRows = false;
            this.dgTra.AllowUserToDeleteRows = false;
            this.dgTra.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgTra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgTra.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column4});
            this.dgTra.Location = new System.Drawing.Point(893, 339);
            this.dgTra.Name = "dgTra";
            this.dgTra.ReadOnly = true;
            this.dgTra.Size = new System.Drawing.Size(206, 152);
            this.dgTra.TabIndex = 17;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Nombre";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(890, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 16);
            this.label3.TabIndex = 19;
            this.label3.Text = "Insumos utilizados";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(890, 316);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(174, 16);
            this.label4.TabIndex = 20;
            this.label4.Text = "Trabajadores encargados";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBox1.Location = new System.Drawing.Point(498, 101);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(181, 23);
            this.textBox1.TabIndex = 21;
            this.textBox1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyUp);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(435, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 16);
            this.label2.TabIndex = 22;
            this.label2.Text = "Buscar:";
            // 
            // MantenimientosEjecutados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1107, 503);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgTra);
            this.Controls.Add(this.dgIns);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnVer2);
            this.Controls.Add(this.btnVer1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MantenimientosEjecutados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mantenimientos Ejecutados";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgIns)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgTra)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnVer1;
        private System.Windows.Forms.Button btnVer2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Costo;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        public System.Windows.Forms.DataGridView dgIns;
        public System.Windows.Forms.DataGridView dgTra;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}