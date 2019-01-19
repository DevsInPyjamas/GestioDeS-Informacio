namespace HIS
{
    partial class ROLES
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ROLES));
            this.bPermisos = new System.Windows.Forms.Button();
            this.bCLEAR = new System.Windows.Forms.Button();
            this.bDEL = new System.Windows.Forms.Button();
            this.bUPD = new System.Windows.Forms.Button();
            this.bINS = new System.Windows.Forms.Button();
            this.bExit = new System.Windows.Forms.Button();
            this.tRolDes = new System.Windows.Forms.TextBox();
            this.tRolName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.cEsAdmin = new System.Windows.Forms.CheckBox();
            this.gI1819DataSet = new HIS.GI1819DataSet();
            this.tRolBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tRolTableAdapter = new HIS.GI1819DataSetTableAdapters.tRolTableAdapter();
            this.rolNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rolDesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adminDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gI1819DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRolBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // bPermisos
            // 
            this.bPermisos.Location = new System.Drawing.Point(459, 479);
            this.bPermisos.Name = "bPermisos";
            this.bPermisos.Size = new System.Drawing.Size(96, 23);
            this.bPermisos.TabIndex = 27;
            this.bPermisos.Text = "Permisos";
            this.bPermisos.UseVisualStyleBackColor = true;
            this.bPermisos.Click += new System.EventHandler(this.bPermisos_Click);
            // 
            // bCLEAR
            // 
            this.bCLEAR.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bCLEAR.Location = new System.Drawing.Point(482, 589);
            this.bCLEAR.Margin = new System.Windows.Forms.Padding(2);
            this.bCLEAR.Name = "bCLEAR";
            this.bCLEAR.Size = new System.Drawing.Size(123, 34);
            this.bCLEAR.TabIndex = 26;
            this.bCLEAR.Text = "LIMPIAR";
            this.bCLEAR.UseVisualStyleBackColor = true;
            this.bCLEAR.Click += new System.EventHandler(this.bCLEAR_Click);
            // 
            // bDEL
            // 
            this.bDEL.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bDEL.Location = new System.Drawing.Point(345, 589);
            this.bDEL.Margin = new System.Windows.Forms.Padding(2);
            this.bDEL.Name = "bDEL";
            this.bDEL.Size = new System.Drawing.Size(123, 34);
            this.bDEL.TabIndex = 25;
            this.bDEL.Text = "BORRAR";
            this.bDEL.UseVisualStyleBackColor = true;
            this.bDEL.Click += new System.EventHandler(this.bDEL_Click);
            // 
            // bUPD
            // 
            this.bUPD.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bUPD.Location = new System.Drawing.Point(206, 589);
            this.bUPD.Margin = new System.Windows.Forms.Padding(2);
            this.bUPD.Name = "bUPD";
            this.bUPD.Size = new System.Drawing.Size(123, 34);
            this.bUPD.TabIndex = 24;
            this.bUPD.Text = "ACTUALIZAR";
            this.bUPD.UseVisualStyleBackColor = true;
            this.bUPD.Click += new System.EventHandler(this.bUPD_Click);
            // 
            // bINS
            // 
            this.bINS.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bINS.Location = new System.Drawing.Point(70, 589);
            this.bINS.Margin = new System.Windows.Forms.Padding(2);
            this.bINS.Name = "bINS";
            this.bINS.Size = new System.Drawing.Size(123, 34);
            this.bINS.TabIndex = 23;
            this.bINS.Text = "INSERTAR";
            this.bINS.UseVisualStyleBackColor = true;
            this.bINS.Click += new System.EventHandler(this.bINS_Click);
            // 
            // bExit
            // 
            this.bExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bExit.BackgroundImage")));
            this.bExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bExit.Location = new System.Drawing.Point(488, 69);
            this.bExit.Margin = new System.Windows.Forms.Padding(2);
            this.bExit.Name = "bExit";
            this.bExit.Size = new System.Drawing.Size(116, 59);
            this.bExit.TabIndex = 22;
            this.bExit.UseVisualStyleBackColor = true;
            this.bExit.Click += new System.EventHandler(this.bExit_Click);
            // 
            // tRolDes
            // 
            this.tRolDes.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tRolDes.Location = new System.Drawing.Point(285, 407);
            this.tRolDes.Margin = new System.Windows.Forms.Padding(2);
            this.tRolDes.Name = "tRolDes";
            this.tRolDes.Size = new System.Drawing.Size(270, 30);
            this.tRolDes.TabIndex = 20;
            this.tRolDes.TextChanged += new System.EventHandler(this.tRolDes_TextChanged);
            // 
            // tRolName
            // 
            this.tRolName.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tRolName.Location = new System.Drawing.Point(285, 345);
            this.tRolName.Margin = new System.Windows.Forms.Padding(2);
            this.tRolName.Name = "tRolName";
            this.tRolName.Size = new System.Drawing.Size(270, 30);
            this.tRolName.TabIndex = 19;
            this.tRolName.TextChanged += new System.EventHandler(this.tRolName_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(88, 473);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 23);
            this.label4.TabIndex = 18;
            this.label4.Text = "Admin";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(88, 412);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 23);
            this.label3.TabIndex = 17;
            this.label3.Text = "Rol Des";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(92, 345);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 23);
            this.label2.TabIndex = 16;
            this.label2.Text = "RolName";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rolNameDataGridViewTextBoxColumn,
            this.rolDesDataGridViewTextBoxColumn,
            this.adminDataGridViewCheckBoxColumn});
            this.dataGridView1.DataSource = this.tRolBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(92, 147);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(463, 139);
            this.dataGridView1.TabIndex = 15;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(226, 69);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 46);
            this.label1.TabIndex = 14;
            this.label1.Text = "ROLES";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // cEsAdmin
            // 
            this.cEsAdmin.AutoSize = true;
            this.cEsAdmin.Location = new System.Drawing.Point(285, 479);
            this.cEsAdmin.Name = "cEsAdmin";
            this.cEsAdmin.Size = new System.Drawing.Size(15, 14);
            this.cEsAdmin.TabIndex = 28;
            this.cEsAdmin.UseVisualStyleBackColor = true;
            this.cEsAdmin.CheckedChanged += new System.EventHandler(this.cEsAdmin_CheckedChanged);
            // 
            // gI1819DataSet
            // 
            this.gI1819DataSet.DataSetName = "GI1819DataSet";
            this.gI1819DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tRolBindingSource
            // 
            this.tRolBindingSource.DataMember = "tRol";
            this.tRolBindingSource.DataSource = this.gI1819DataSet;
            // 
            // tRolTableAdapter
            // 
            this.tRolTableAdapter.ClearBeforeFill = true;
            // 
            // rolNameDataGridViewTextBoxColumn
            // 
            this.rolNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.rolNameDataGridViewTextBoxColumn.DataPropertyName = "rolName";
            this.rolNameDataGridViewTextBoxColumn.HeaderText = "rolName";
            this.rolNameDataGridViewTextBoxColumn.Name = "rolNameDataGridViewTextBoxColumn";
            this.rolNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rolDesDataGridViewTextBoxColumn
            // 
            this.rolDesDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.rolDesDataGridViewTextBoxColumn.DataPropertyName = "rolDes";
            this.rolDesDataGridViewTextBoxColumn.HeaderText = "rolDes";
            this.rolDesDataGridViewTextBoxColumn.Name = "rolDesDataGridViewTextBoxColumn";
            this.rolDesDataGridViewTextBoxColumn.ReadOnly = true;
            this.rolDesDataGridViewTextBoxColumn.Width = 62;
            // 
            // adminDataGridViewCheckBoxColumn
            // 
            this.adminDataGridViewCheckBoxColumn.DataPropertyName = "admin";
            this.adminDataGridViewCheckBoxColumn.HeaderText = "admin";
            this.adminDataGridViewCheckBoxColumn.Name = "adminDataGridViewCheckBoxColumn";
            this.adminDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // ROLES
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(674, 693);
            this.Controls.Add(this.cEsAdmin);
            this.Controls.Add(this.bPermisos);
            this.Controls.Add(this.bCLEAR);
            this.Controls.Add(this.bDEL);
            this.Controls.Add(this.bUPD);
            this.Controls.Add(this.bINS);
            this.Controls.Add(this.bExit);
            this.Controls.Add(this.tRolDes);
            this.Controls.Add(this.tRolName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "ROLES";
            this.Text = "ROLES";
            this.Load += new System.EventHandler(this.ROLES_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gI1819DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRolBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bPermisos;
        private System.Windows.Forms.Button bCLEAR;
        private System.Windows.Forms.Button bDEL;
        private System.Windows.Forms.Button bUPD;
        private System.Windows.Forms.Button bINS;
        private System.Windows.Forms.Button bExit;
        private System.Windows.Forms.TextBox tRolDes;
        private System.Windows.Forms.TextBox tRolName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cEsAdmin;
        private GI1819DataSet gI1819DataSet;
        private System.Windows.Forms.BindingSource tRolBindingSource;
        private GI1819DataSetTableAdapters.tRolTableAdapter tRolTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn rolNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rolDesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn adminDataGridViewCheckBoxColumn;

    }
}