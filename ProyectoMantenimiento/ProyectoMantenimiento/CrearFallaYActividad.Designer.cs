namespace ProyectoMantenimiento
{
    partial class Falla_Actividad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Falla_Actividad));
            this.dgFallas = new System.Windows.Forms.DataGridView();
            this.dgActividades = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAddFallas = new System.Windows.Forms.Button();
            this.btnEditFallas = new System.Windows.Forms.Button();
            this.btnEditActividades = new System.Windows.Forms.Button();
            this.btnAddActividades = new System.Windows.Forms.Button();
            this.cboTipo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgFallas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgActividades)).BeginInit();
            this.SuspendLayout();
            // 
            // dgFallas
            // 
            this.dgFallas.AllowUserToAddRows = false;
            this.dgFallas.AllowUserToDeleteRows = false;
            this.dgFallas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgFallas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgFallas.Location = new System.Drawing.Point(12, 124);
            this.dgFallas.Name = "dgFallas";
            this.dgFallas.Size = new System.Drawing.Size(424, 150);
            this.dgFallas.TabIndex = 0;
            this.dgFallas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgFallas_CellClick);
            // 
            // dgActividades
            // 
            this.dgActividades.AllowUserToAddRows = false;
            this.dgActividades.AllowUserToDeleteRows = false;
            this.dgActividades.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgActividades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgActividades.Location = new System.Drawing.Point(497, 124);
            this.dgActividades.Name = "dgActividades";
            this.dgActividades.Size = new System.Drawing.Size(440, 150);
            this.dgActividades.TabIndex = 1;
            this.dgActividades.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgActividades_CellClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Location = new System.Drawing.Point(460, -32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(14, 323);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(504, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Actividades";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(12, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Fallas";
            // 
            // btnAddFallas
            // 
            this.btnAddFallas.BackColor = System.Drawing.Color.Navy;
            this.btnAddFallas.FlatAppearance.BorderSize = 0;
            this.btnAddFallas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddFallas.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddFallas.ForeColor = System.Drawing.Color.White;
            this.btnAddFallas.Location = new System.Drawing.Point(12, 78);
            this.btnAddFallas.Name = "btnAddFallas";
            this.btnAddFallas.Size = new System.Drawing.Size(100, 28);
            this.btnAddFallas.TabIndex = 0;
            this.btnAddFallas.Text = "Agregar";
            this.btnAddFallas.UseVisualStyleBackColor = false;
            this.btnAddFallas.Click += new System.EventHandler(this.btnAddFallas_Click);
            // 
            // btnEditFallas
            // 
            this.btnEditFallas.BackColor = System.Drawing.Color.Green;
            this.btnEditFallas.FlatAppearance.BorderSize = 0;
            this.btnEditFallas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditFallas.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditFallas.ForeColor = System.Drawing.Color.White;
            this.btnEditFallas.Location = new System.Drawing.Point(128, 78);
            this.btnEditFallas.Name = "btnEditFallas";
            this.btnEditFallas.Size = new System.Drawing.Size(89, 28);
            this.btnEditFallas.TabIndex = 1;
            this.btnEditFallas.Text = "Editar";
            this.btnEditFallas.UseVisualStyleBackColor = false;
            this.btnEditFallas.Click += new System.EventHandler(this.btnEditFallas_Click);
            // 
            // btnEditActividades
            // 
            this.btnEditActividades.BackColor = System.Drawing.Color.Green;
            this.btnEditActividades.FlatAppearance.BorderSize = 0;
            this.btnEditActividades.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditActividades.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditActividades.ForeColor = System.Drawing.Color.White;
            this.btnEditActividades.Location = new System.Drawing.Point(630, 78);
            this.btnEditActividades.Name = "btnEditActividades";
            this.btnEditActividades.Size = new System.Drawing.Size(89, 28);
            this.btnEditActividades.TabIndex = 4;
            this.btnEditActividades.Text = "Editar";
            this.btnEditActividades.UseVisualStyleBackColor = false;
            this.btnEditActividades.Click += new System.EventHandler(this.btnEditActividades_Click);
            // 
            // btnAddActividades
            // 
            this.btnAddActividades.BackColor = System.Drawing.Color.Navy;
            this.btnAddActividades.FlatAppearance.BorderSize = 0;
            this.btnAddActividades.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddActividades.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddActividades.ForeColor = System.Drawing.Color.White;
            this.btnAddActividades.Location = new System.Drawing.Point(497, 78);
            this.btnAddActividades.Name = "btnAddActividades";
            this.btnAddActividades.Size = new System.Drawing.Size(100, 28);
            this.btnAddActividades.TabIndex = 3;
            this.btnAddActividades.Text = "Agregar";
            this.btnAddActividades.UseVisualStyleBackColor = false;
            this.btnAddActividades.Click += new System.EventHandler(this.btnAddActividades_Click);
            // 
            // cboTipo
            // 
            this.cboTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipo.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTipo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cboTipo.FormattingEnabled = true;
            this.cboTipo.Items.AddRange(new object[] {
            "COSTURA",
            "ELECTRICO",
            "GENERAL",
            "MECANICO - NEUMATICO"});
            this.cboTipo.Location = new System.Drawing.Point(315, 85);
            this.cboTipo.Name = "cboTipo";
            this.cboTipo.Size = new System.Drawing.Size(121, 21);
            this.cboTipo.TabIndex = 2;
            this.cboTipo.SelectionChangeCommitted += new System.EventHandler(this.cboTipo_SelectionChangeCommitted);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(258, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 14);
            this.label3.TabIndex = 10;
            this.label3.Text = "Buscar:";
            // 
            // Falla_Actividad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(958, 289);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cboTipo);
            this.Controls.Add(this.btnEditActividades);
            this.Controls.Add(this.btnAddActividades);
            this.Controls.Add(this.btnEditFallas);
            this.Controls.Add(this.btnAddFallas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgActividades);
            this.Controls.Add(this.dgFallas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Falla_Actividad";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Falla y actividad";
            ((System.ComponentModel.ISupportInitialize)(this.dgFallas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgActividades)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgFallas;
        private System.Windows.Forms.DataGridView dgActividades;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAddFallas;
        private System.Windows.Forms.Button btnEditFallas;
        private System.Windows.Forms.Button btnEditActividades;
        private System.Windows.Forms.Button btnAddActividades;
        private System.Windows.Forms.ComboBox cboTipo;
        private System.Windows.Forms.Label label3;
    }
}