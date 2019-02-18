namespace ProyectoMantenimiento
{
    partial class dev
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dev));
            this.dgTable = new System.Windows.Forms.DataGridView();
            this.listPer = new System.Windows.Forms.ListBox();
            this.btnDevolver = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnReturn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgTable)).BeginInit();
            this.SuspendLayout();
            // 
            // dgTable
            // 
            this.dgTable.AllowUserToAddRows = false;
            this.dgTable.AllowUserToDeleteRows = false;
            this.dgTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgTable.Location = new System.Drawing.Point(348, 90);
            this.dgTable.Name = "dgTable";
            this.dgTable.ReadOnly = true;
            this.dgTable.Size = new System.Drawing.Size(428, 251);
            this.dgTable.TabIndex = 2;
            this.dgTable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgTable_CellClick);
            // 
            // listPer
            // 
            this.listPer.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listPer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.listPer.FormattingEnabled = true;
            this.listPer.ItemHeight = 16;
            this.listPer.Location = new System.Drawing.Point(30, 122);
            this.listPer.Name = "listPer";
            this.listPer.Size = new System.Drawing.Size(238, 212);
            this.listPer.TabIndex = 1;
            this.listPer.Click += new System.EventHandler(this.listPer_Click);
            // 
            // btnDevolver
            // 
            this.btnDevolver.BackColor = System.Drawing.Color.Navy;
            this.btnDevolver.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnDevolver.FlatAppearance.BorderSize = 0;
            this.btnDevolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDevolver.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDevolver.ForeColor = System.Drawing.Color.White;
            this.btnDevolver.Location = new System.Drawing.Point(289, 370);
            this.btnDevolver.Name = "btnDevolver";
            this.btnDevolver.Size = new System.Drawing.Size(255, 39);
            this.btnDevolver.TabIndex = 3;
            this.btnDevolver.Text = "Devolver";
            this.btnDevolver.UseVisualStyleBackColor = false;
            this.btnDevolver.Visible = false;
            this.btnDevolver.Click += new System.EventHandler(this.btnDevolver_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Trabajadores";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(345, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "Detalle";
            // 
            // textBox1
            // 
            this.textBox1.ForeColor = System.Drawing.Color.Gray;
            this.textBox1.Location = new System.Drawing.Point(30, 90);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(238, 21);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Buscar...";
            this.textBox1.Enter += new System.EventHandler(this.textBox1_Enter);
            this.textBox1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyUp);
            this.textBox1.Leave += new System.EventHandler(this.textBox1_Leave);
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.Color.Navy;
            this.btnReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReturn.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.ForeColor = System.Drawing.Color.White;
            this.btnReturn.Location = new System.Drawing.Point(683, 42);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(93, 38);
            this.btnReturn.TabIndex = 12;
            this.btnReturn.Text = "Devolución";
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.button1_Click);
            // 
            // dev
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 424);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDevolver);
            this.Controls.Add(this.listPer);
            this.Controls.Add(this.dgTable);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "dev";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Devolución";
            ((System.ComponentModel.ISupportInitialize)(this.dgTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgTable;
        private System.Windows.Forms.ListBox listPer;
        private System.Windows.Forms.Button btnDevolver;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnReturn;
    }
}