namespace ProyectoMantenimiento
{
    partial class PrestarInsumos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrestarInsumos));
            this.listPer = new System.Windows.Forms.ListBox();
            this.btnQuitar = new System.Windows.Forms.Button();
            this.btnPres = new System.Windows.Forms.Button();
            this.dgTable = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.numCant = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.listIns = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBus2 = new System.Windows.Forms.TextBox();
            this.txtBus1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCant)).BeginInit();
            this.SuspendLayout();
            // 
            // listPer
            // 
            this.listPer.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listPer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.listPer.FormattingEnabled = true;
            this.listPer.ItemHeight = 14;
            this.listPer.Location = new System.Drawing.Point(447, 96);
            this.listPer.Name = "listPer";
            this.listPer.Size = new System.Drawing.Size(241, 186);
            this.listPer.TabIndex = 20;
            // 
            // btnQuitar
            // 
            this.btnQuitar.BackColor = System.Drawing.Color.Gray;
            this.btnQuitar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnQuitar.FlatAppearance.BorderSize = 0;
            this.btnQuitar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuitar.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuitar.ForeColor = System.Drawing.Color.White;
            this.btnQuitar.Location = new System.Drawing.Point(595, 297);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(93, 34);
            this.btnQuitar.TabIndex = 19;
            this.btnQuitar.Text = "Quitar";
            this.btnQuitar.UseVisualStyleBackColor = false;
            this.btnQuitar.Click += new System.EventHandler(this.btnQuitar_Click);
            // 
            // btnPres
            // 
            this.btnPres.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnPres.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPres.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPres.ForeColor = System.Drawing.Color.White;
            this.btnPres.Location = new System.Drawing.Point(257, 511);
            this.btnPres.Name = "btnPres";
            this.btnPres.Size = new System.Drawing.Size(202, 39);
            this.btnPres.TabIndex = 18;
            this.btnPres.Text = "Prestar";
            this.btnPres.UseVisualStyleBackColor = false;
            this.btnPres.Click += new System.EventHandler(this.btnPres_Click);
            // 
            // dgTable
            // 
            this.dgTable.AllowUserToAddRows = false;
            this.dgTable.AllowUserToDeleteRows = false;
            this.dgTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dgTable.Location = new System.Drawing.Point(22, 343);
            this.dgTable.Name = "dgTable";
            this.dgTable.ReadOnly = true;
            this.dgTable.Size = new System.Drawing.Size(666, 150);
            this.dgTable.TabIndex = 17;
            this.dgTable.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgTable_RowsAdded);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "id";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Visible = false;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Insumo";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Cantidad";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "idPer";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Visible = false;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Trabajador";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Navy;
            this.btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(309, 248);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(93, 34);
            this.btnAdd.TabIndex = 16;
            this.btnAdd.Text = "Agregar";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(306, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 16);
            this.label3.TabIndex = 15;
            this.label3.Text = "Cantidad";
            // 
            // numCant
            // 
            this.numCant.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numCant.Location = new System.Drawing.Point(309, 122);
            this.numCant.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numCant.Name = "numCant";
            this.numCant.Size = new System.Drawing.Size(79, 22);
            this.numCant.TabIndex = 14;
            this.numCant.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(444, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "Persona";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "Insumos";
            // 
            // listIns
            // 
            this.listIns.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listIns.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.listIns.FormattingEnabled = true;
            this.listIns.ItemHeight = 14;
            this.listIns.Location = new System.Drawing.Point(22, 96);
            this.listIns.Name = "listIns";
            this.listIns.Size = new System.Drawing.Size(240, 186);
            this.listIns.TabIndex = 11;
            this.listIns.Click += new System.EventHandler(this.listIns_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(444, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 16);
            this.label5.TabIndex = 24;
            this.label5.Text = "Buscar:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(19, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 16);
            this.label4.TabIndex = 23;
            this.label4.Text = "Buscar:";
            // 
            // txtBus2
            // 
            this.txtBus2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBus2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtBus2.Location = new System.Drawing.Point(511, 54);
            this.txtBus2.Name = "txtBus2";
            this.txtBus2.Size = new System.Drawing.Size(177, 21);
            this.txtBus2.TabIndex = 22;
            this.txtBus2.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtBus2_KeyUp);
            // 
            // txtBus1
            // 
            this.txtBus1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBus1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtBus1.Location = new System.Drawing.Point(86, 58);
            this.txtBus1.Name = "txtBus1";
            this.txtBus1.Size = new System.Drawing.Size(176, 21);
            this.txtBus1.TabIndex = 21;
            this.txtBus1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtBus1_KeyUp);
            // 
            // PrestarInsumos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(711, 573);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtBus2);
            this.Controls.Add(this.txtBus1);
            this.Controls.Add(this.listPer);
            this.Controls.Add(this.btnQuitar);
            this.Controls.Add(this.btnPres);
            this.Controls.Add(this.dgTable);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numCant);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listIns);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PrestarInsumos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Prestar Insumos";
            ((System.ComponentModel.ISupportInitialize)(this.dgTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCant)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listPer;
        private System.Windows.Forms.Button btnQuitar;
        private System.Windows.Forms.Button btnPres;
        private System.Windows.Forms.DataGridView dgTable;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numCant;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listIns;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBus2;
        private System.Windows.Forms.TextBox txtBus1;
    }
}