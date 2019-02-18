namespace ProyectoMantenimiento
{
    partial class InventarioIns
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InventarioIns));
            this.dgInventario = new System.Windows.Forms.DataGridView();
            this.txtDesc = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.numCant = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblCant = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgInventario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCant)).BeginInit();
            this.SuspendLayout();
            // 
            // dgInventario
            // 
            this.dgInventario.AllowUserToAddRows = false;
            this.dgInventario.AllowUserToDeleteRows = false;
            this.dgInventario.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgInventario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgInventario.Location = new System.Drawing.Point(29, 235);
            this.dgInventario.Name = "dgInventario";
            this.dgInventario.ReadOnly = true;
            this.dgInventario.Size = new System.Drawing.Size(615, 199);
            this.dgInventario.TabIndex = 21;
            // 
            // txtDesc
            // 
            this.txtDesc.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDesc.Location = new System.Drawing.Point(29, 139);
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(615, 57);
            this.txtDesc.TabIndex = 1;
            this.txtDesc.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(26, 100);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 14);
            this.label6.TabIndex = 19;
            this.label6.Text = "Descripción:";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.DarkCyan;
            this.btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(279, 16);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(113, 58);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Agregar";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // numCant
            // 
            this.numCant.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numCant.Location = new System.Drawing.Point(98, 54);
            this.numCant.Name = "numCant";
            this.numCant.Size = new System.Drawing.Size(120, 22);
            this.numCant.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(26, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 14);
            this.label5.TabIndex = 16;
            this.label5.Text = "Cantidad:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(95, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 14);
            this.label4.TabIndex = 15;
            this.label4.Text = "label4";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 14);
            this.label3.TabIndex = 14;
            this.label3.Text = "Nombre:";
            // 
            // lblCant
            // 
            this.lblCant.AutoSize = true;
            this.lblCant.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCant.Location = new System.Drawing.Point(540, 60);
            this.lblCant.Name = "lblCant";
            this.lblCant.Size = new System.Drawing.Size(32, 33);
            this.lblCant.TabIndex = 13;
            this.lblCant.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(468, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 23);
            this.label1.TabIndex = 12;
            this.label1.Text = "Cantidad Existente";
            // 
            // InventarioIns
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(675, 450);
            this.Controls.Add(this.dgInventario);
            this.Controls.Add(this.txtDesc);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.numCant);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblCant);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "InventarioIns";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inventario Insumos";
            ((System.ComponentModel.ISupportInitialize)(this.dgInventario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCant)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgInventario;
        private System.Windows.Forms.RichTextBox txtDesc;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.NumericUpDown numCant;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblCant;
        private System.Windows.Forms.Label label1;
    }
}