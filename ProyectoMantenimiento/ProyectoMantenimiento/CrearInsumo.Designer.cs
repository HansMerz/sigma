namespace ProyectoMantenimiento
{
    partial class CrearInsumo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CrearInsumo));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtRef = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPos = new System.Windows.Forms.TextBox();
            this.numCant = new System.Windows.Forms.NumericUpDown();
            this.numPre = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDesc = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblPos = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCant)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPre)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(11, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Registrar nuevo insumo";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtRef);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtPos);
            this.groupBox1.Controls.Add(this.numCant);
            this.groupBox1.Controls.Add(this.numPre);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtDesc);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lblPos);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtMarca);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(16, 83);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(401, 397);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detalle Insumo";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(233, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 14);
            this.label7.TabIndex = 13;
            this.label7.Text = "Núm Referencia *";
            // 
            // txtRef
            // 
            this.txtRef.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtRef.Location = new System.Drawing.Point(236, 60);
            this.txtRef.Name = "txtRef";
            this.txtRef.Size = new System.Drawing.Size(144, 22);
            this.txtRef.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(236, 98);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 14);
            this.label6.TabIndex = 11;
            this.label6.Text = "Posición *";
            // 
            // txtPos
            // 
            this.txtPos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPos.Location = new System.Drawing.Point(239, 122);
            this.txtPos.Name = "txtPos";
            this.txtPos.Size = new System.Drawing.Size(141, 22);
            this.txtPos.TabIndex = 3;
            // 
            // numCant
            // 
            this.numCant.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.numCant.Location = new System.Drawing.Point(239, 192);
            this.numCant.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numCant.Name = "numCant";
            this.numCant.Size = new System.Drawing.Size(141, 22);
            this.numCant.TabIndex = 5;
            this.numCant.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numPre
            // 
            this.numPre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.numPre.Location = new System.Drawing.Point(19, 192);
            this.numPre.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.numPre.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numPre.Name = "numPre";
            this.numPre.Size = new System.Drawing.Size(159, 22);
            this.numPre.TabIndex = 4;
            this.numPre.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 234);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 14);
            this.label3.TabIndex = 9;
            this.label3.Text = "Descripción";
            // 
            // txtDesc
            // 
            this.txtDesc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtDesc.Location = new System.Drawing.Point(19, 260);
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(361, 57);
            this.txtDesc.TabIndex = 6;
            this.txtDesc.Text = "";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.RoyalBlue;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(52, 344);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(284, 38);
            this.button1.TabIndex = 7;
            this.button1.Text = "Agregar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(236, 168);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 14);
            this.label5.TabIndex = 7;
            this.label5.Text = "Cantidad *";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 14);
            this.label4.TabIndex = 6;
            this.label4.Text = "Precio *";
            // 
            // lblPos
            // 
            this.lblPos.AutoSize = true;
            this.lblPos.Location = new System.Drawing.Point(16, 98);
            this.lblPos.Name = "lblPos";
            this.lblPos.Size = new System.Drawing.Size(55, 14);
            this.lblPos.TabIndex = 5;
            this.lblPos.Text = "Marca *";
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
            // txtMarca
            // 
            this.txtMarca.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtMarca.Location = new System.Drawing.Point(19, 122);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(159, 22);
            this.txtMarca.TabIndex = 2;
            // 
            // txtName
            // 
            this.txtName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtName.Location = new System.Drawing.Point(19, 60);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(159, 22);
            this.txtName.TabIndex = 0;
            // 
            // CrearInsumo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(429, 492);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CrearInsumo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Crear Insumo";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCant)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPre)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown numCant;
        private System.Windows.Forms.NumericUpDown numPre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox txtDesc;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblPos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPos;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtRef;
    }
}