namespace ProyectoMantenimiento
{
    partial class EditarHerramienta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditarHerramienta));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.numMin = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAct = new System.Windows.Forms.Button();
            this.txtDesc = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblPos = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPosi = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMin)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(17, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Editar herramienta";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.numMin);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnAct);
            this.groupBox1.Controls.Add(this.txtDesc);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.lblPos);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtPosi);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(21, 90);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(401, 342);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detalle Herramienta";
            // 
            // numMin
            // 
            this.numMin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.numMin.Location = new System.Drawing.Point(243, 92);
            this.numMin.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numMin.Name = "numMin";
            this.numMin.Size = new System.Drawing.Size(141, 22);
            this.numMin.TabIndex = 1;
            this.numMin.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 14);
            this.label3.TabIndex = 11;
            this.label3.Text = "Descripción";
            // 
            // btnAct
            // 
            this.btnAct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(143)))), ((int)(((byte)(16)))));
            this.btnAct.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAct.FlatAppearance.BorderSize = 0;
            this.btnAct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAct.ForeColor = System.Drawing.Color.White;
            this.btnAct.Location = new System.Drawing.Point(53, 289);
            this.btnAct.Name = "btnAct";
            this.btnAct.Size = new System.Drawing.Size(284, 38);
            this.btnAct.TabIndex = 4;
            this.btnAct.Text = "Actualizar";
            this.btnAct.UseVisualStyleBackColor = false;
            this.btnAct.Click += new System.EventHandler(this.btnAct_Click);
            // 
            // txtDesc
            // 
            this.txtDesc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtDesc.Location = new System.Drawing.Point(19, 202);
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(361, 57);
            this.txtDesc.TabIndex = 3;
            this.txtDesc.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(240, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 14);
            this.label5.TabIndex = 7;
            this.label5.Text = "Mínimo *";
            // 
            // lblPos
            // 
            this.lblPos.AutoSize = true;
            this.lblPos.Location = new System.Drawing.Point(16, 107);
            this.lblPos.Name = "lblPos";
            this.lblPos.Size = new System.Drawing.Size(69, 14);
            this.lblPos.TabIndex = 5;
            this.lblPos.Text = "Posición *";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 14);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nombre *";
            // 
            // txtPosi
            // 
            this.txtPosi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPosi.Location = new System.Drawing.Point(19, 131);
            this.txtPosi.Name = "txtPosi";
            this.txtPosi.Size = new System.Drawing.Size(159, 22);
            this.txtPosi.TabIndex = 2;
            // 
            // txtName
            // 
            this.txtName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtName.Location = new System.Drawing.Point(19, 60);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(159, 22);
            this.txtName.TabIndex = 0;
            // 
            // EditarHerramienta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(448, 455);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EditarHerramienta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editar Herramienta";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAct;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblPos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPosi;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox txtDesc;
        private System.Windows.Forms.NumericUpDown numMin;
    }
}