namespace ProyectoMantenimiento
{
    partial class DevolverIns
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDevolver = new System.Windows.Forms.Button();
            this.listPer = new System.Windows.Forms.ListBox();
            this.dgTable = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgTable)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(344, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 16);
            this.label2.TabIndex = 16;
            this.label2.Text = "Detalle";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 16);
            this.label1.TabIndex = 15;
            this.label1.Text = "Trabajadores";
            // 
            // btnDevolver
            // 
            this.btnDevolver.BackColor = System.Drawing.Color.Navy;
            this.btnDevolver.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDevolver.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDevolver.ForeColor = System.Drawing.Color.White;
            this.btnDevolver.Location = new System.Drawing.Point(288, 362);
            this.btnDevolver.Name = "btnDevolver";
            this.btnDevolver.Size = new System.Drawing.Size(255, 39);
            this.btnDevolver.TabIndex = 14;
            this.btnDevolver.Text = "Devolver";
            this.btnDevolver.UseVisualStyleBackColor = false;
            // 
            // listPer
            // 
            this.listPer.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listPer.FormattingEnabled = true;
            this.listPer.ItemHeight = 16;
            this.listPer.Location = new System.Drawing.Point(29, 82);
            this.listPer.Name = "listPer";
            this.listPer.Size = new System.Drawing.Size(238, 244);
            this.listPer.TabIndex = 13;
            // 
            // dgTable
            // 
            this.dgTable.AllowUserToAddRows = false;
            this.dgTable.AllowUserToDeleteRows = false;
            this.dgTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgTable.Location = new System.Drawing.Point(347, 82);
            this.dgTable.Name = "dgTable";
            this.dgTable.Size = new System.Drawing.Size(428, 251);
            this.dgTable.TabIndex = 12;
            // 
            // DevolverIns
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 426);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDevolver);
            this.Controls.Add(this.listPer);
            this.Controls.Add(this.dgTable);
            this.Name = "DevolverIns";
            this.Text = "DevolverIns";
            ((System.ComponentModel.ISupportInitialize)(this.dgTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDevolver;
        private System.Windows.Forms.ListBox listPer;
        private System.Windows.Forms.DataGridView dgTable;
    }
}