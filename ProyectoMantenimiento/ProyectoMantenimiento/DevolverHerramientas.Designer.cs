namespace ProyectoMantenimiento
{
    partial class DevolverHerramientas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DevolverHerramientas));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.numCant = new System.Windows.Forms.NumericUpDown();
            this.btnReturn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblWorker = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numCant)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(25, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(25, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cantidad:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(25, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Encargado:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(79, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Cantidad a devolver:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // numCant
            // 
            this.numCant.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numCant.ForeColor = System.Drawing.Color.DimGray;
            this.numCant.Location = new System.Drawing.Point(252, 189);
            this.numCant.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numCant.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numCant.Name = "numCant";
            this.numCant.Size = new System.Drawing.Size(120, 22);
            this.numCant.TabIndex = 0;
            this.numCant.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numCant.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numCant.ValueChanged += new System.EventHandler(this.numCant_ValueChanged);
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.Color.MediumBlue;
            this.btnReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReturn.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.ForeColor = System.Drawing.Color.White;
            this.btnReturn.Location = new System.Drawing.Point(167, 239);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(179, 38);
            this.btnReturn.TabIndex = 1;
            this.btnReturn.Text = "Devolver";
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(263, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "Fecha:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.DimGray;
            this.lblName.Location = new System.Drawing.Point(93, 32);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(62, 16);
            this.lblName.TabIndex = 7;
            this.lblName.Text = "Nombre:";
            // 
            // lblWorker
            // 
            this.lblWorker.AutoSize = true;
            this.lblWorker.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWorker.ForeColor = System.Drawing.Color.DimGray;
            this.lblWorker.Location = new System.Drawing.Point(110, 79);
            this.lblWorker.Name = "lblWorker";
            this.lblWorker.Size = new System.Drawing.Size(62, 16);
            this.lblWorker.TabIndex = 8;
            this.lblWorker.Text = "Nombre:";
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantity.ForeColor = System.Drawing.Color.DimGray;
            this.lblQuantity.Location = new System.Drawing.Point(101, 127);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(62, 16);
            this.lblQuantity.TabIndex = 9;
            this.lblQuantity.Text = "Nombre:";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.DimGray;
            this.lblDate.Location = new System.Drawing.Point(319, 32);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(62, 16);
            this.lblDate.TabIndex = 10;
            this.lblDate.Text = "Nombre:";
            // 
            // DevolverHerramientas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(504, 305);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.lblWorker);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.numCant);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DevolverHerramientas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Devolver Herramientas";
            ((System.ComponentModel.ISupportInitialize)(this.numCant)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numCant;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblWorker;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label lblDate;
    }
}