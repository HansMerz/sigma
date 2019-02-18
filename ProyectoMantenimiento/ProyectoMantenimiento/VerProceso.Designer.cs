namespace ProyectoMantenimiento
{
    partial class VerProceso
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VerProceso));
            this.label1 = new System.Windows.Forms.Label();
            this.lblNumOrden = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgFallas = new System.Windows.Forms.DataGridView();
            this.cod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.desc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgActividades = new System.Windows.Forms.DataGridView();
            this.cod2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.desc2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.txtProceso = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgFallas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgActividades)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(36, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Número de Orden:";
            // 
            // lblNumOrden
            // 
            this.lblNumOrden.AutoSize = true;
            this.lblNumOrden.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumOrden.ForeColor = System.Drawing.Color.DimGray;
            this.lblNumOrden.Location = new System.Drawing.Point(185, 38);
            this.lblNumOrden.Name = "lblNumOrden";
            this.lblNumOrden.Size = new System.Drawing.Size(125, 16);
            this.lblNumOrden.TabIndex = 1;
            this.lblNumOrden.Text = "Número de Orden:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(36, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Fallas:";
            // 
            // dgFallas
            // 
            this.dgFallas.AllowUserToAddRows = false;
            this.dgFallas.AllowUserToDeleteRows = false;
            this.dgFallas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgFallas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgFallas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cod,
            this.desc});
            this.dgFallas.Location = new System.Drawing.Point(39, 120);
            this.dgFallas.Name = "dgFallas";
            this.dgFallas.Size = new System.Drawing.Size(299, 150);
            this.dgFallas.TabIndex = 3;
            // 
            // cod
            // 
            this.cod.HeaderText = "CÓD";
            this.cod.Name = "cod";
            // 
            // desc
            // 
            this.desc.HeaderText = "Descripción";
            this.desc.Name = "desc";
            // 
            // dgActividades
            // 
            this.dgActividades.AllowUserToAddRows = false;
            this.dgActividades.AllowUserToDeleteRows = false;
            this.dgActividades.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgActividades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgActividades.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cod2,
            this.desc2});
            this.dgActividades.Location = new System.Drawing.Point(358, 120);
            this.dgActividades.Name = "dgActividades";
            this.dgActividades.Size = new System.Drawing.Size(295, 150);
            this.dgActividades.TabIndex = 4;
            // 
            // cod2
            // 
            this.cod2.HeaderText = "CÓD";
            this.cod2.Name = "cod2";
            // 
            // desc2
            // 
            this.desc2.HeaderText = "Descripción";
            this.desc2.Name = "desc2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(355, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Actividades realizadas:";
            // 
            // txtProceso
            // 
            this.txtProceso.BackColor = System.Drawing.Color.White;
            this.txtProceso.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProceso.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtProceso.Location = new System.Drawing.Point(39, 120);
            this.txtProceso.Name = "txtProceso";
            this.txtProceso.ReadOnly = true;
            this.txtProceso.Size = new System.Drawing.Size(614, 151);
            this.txtProceso.TabIndex = 7;
            this.txtProceso.Text = "";
            // 
            // VerProceso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(697, 300);
            this.Controls.Add(this.txtProceso);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgActividades);
            this.Controls.Add(this.dgFallas);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblNumOrden);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "VerProceso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ver Proceso";
            ((System.ComponentModel.ISupportInitialize)(this.dgFallas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgActividades)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNumOrden;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgFallas;
        private System.Windows.Forms.DataGridView dgActividades;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn cod;
        private System.Windows.Forms.DataGridViewTextBoxColumn desc;
        private System.Windows.Forms.DataGridViewTextBoxColumn cod2;
        private System.Windows.Forms.DataGridViewTextBoxColumn desc2;
        private System.Windows.Forms.RichTextBox txtProceso;
    }
}