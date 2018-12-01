namespace HIS
{
    partial class USUARIOS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(USUARIOS));
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tUsuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gI1819DataSet = new HIS.GI1819DataSet();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tUser = new System.Windows.Forms.TextBox();
            this.tPwd = new System.Windows.Forms.TextBox();
            this.lRol = new System.Windows.Forms.ListBox();
            this.bExit = new System.Windows.Forms.Button();
            this.bINS = new System.Windows.Forms.Button();
            this.bUPD = new System.Windows.Forms.Button();
            this.bCLEAR = new System.Windows.Forms.Button();
            this.bDEL = new System.Windows.Forms.Button();
            this.tUsuarioTableAdapter = new HIS.GI1819DataSetTableAdapters.tUsuarioTableAdapter();
            this.bEditRol = new System.Windows.Forms.Button();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rolNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tUsuarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gI1819DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(163, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(249, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "USUARIOS";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombreDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn,
            this.rolNameDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tUsuarioBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(62, 110);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(463, 139);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // tUsuarioBindingSource
            // 
            this.tUsuarioBindingSource.DataMember = "tUsuario";
            this.tUsuarioBindingSource.DataSource = this.gI1819DataSet;
            // 
            // gI1819DataSet
            // 
            this.gI1819DataSet.DataSetName = "GI1819DataSet";
            this.gI1819DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(62, 308);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre usuario";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(58, 375);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "Contraseña";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(58, 436);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 23);
            this.label4.TabIndex = 4;
            this.label4.Text = "Rol";
            // 
            // tUser
            // 
            this.tUser.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tUser.Location = new System.Drawing.Point(255, 308);
            this.tUser.Margin = new System.Windows.Forms.Padding(2);
            this.tUser.Name = "tUser";
            this.tUser.Size = new System.Drawing.Size(270, 30);
            this.tUser.TabIndex = 5;
            // 
            // tPwd
            // 
            this.tPwd.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tPwd.Location = new System.Drawing.Point(255, 370);
            this.tPwd.Margin = new System.Windows.Forms.Padding(2);
            this.tPwd.Name = "tPwd";
            this.tPwd.Size = new System.Drawing.Size(270, 30);
            this.tPwd.TabIndex = 6;
            // 
            // lRol
            // 
            this.lRol.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lRol.FormattingEnabled = true;
            this.lRol.ItemHeight = 22;
            this.lRol.Location = new System.Drawing.Point(255, 418);
            this.lRol.Margin = new System.Windows.Forms.Padding(2);
            this.lRol.Name = "lRol";
            this.lRol.Size = new System.Drawing.Size(270, 70);
            this.lRol.TabIndex = 7;
            // 
            // bExit
            // 
            this.bExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bExit.BackgroundImage")));
            this.bExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bExit.Location = new System.Drawing.Point(458, 32);
            this.bExit.Margin = new System.Windows.Forms.Padding(2);
            this.bExit.Name = "bExit";
            this.bExit.Size = new System.Drawing.Size(116, 59);
            this.bExit.TabIndex = 8;
            this.bExit.UseVisualStyleBackColor = true;
            this.bExit.Click += new System.EventHandler(this.bExit_Click);
            // 
            // bINS
            // 
            this.bINS.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bINS.Location = new System.Drawing.Point(40, 552);
            this.bINS.Margin = new System.Windows.Forms.Padding(2);
            this.bINS.Name = "bINS";
            this.bINS.Size = new System.Drawing.Size(123, 34);
            this.bINS.TabIndex = 9;
            this.bINS.Text = "INSERTAR";
            this.bINS.UseVisualStyleBackColor = true;
            this.bINS.Click += new System.EventHandler(this.bINS_Click);
            // 
            // bUPD
            // 
            this.bUPD.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bUPD.Location = new System.Drawing.Point(176, 552);
            this.bUPD.Margin = new System.Windows.Forms.Padding(2);
            this.bUPD.Name = "bUPD";
            this.bUPD.Size = new System.Drawing.Size(123, 34);
            this.bUPD.TabIndex = 10;
            this.bUPD.Text = "ACTUALIZAR";
            this.bUPD.UseVisualStyleBackColor = true;
            this.bUPD.Click += new System.EventHandler(this.bUPD_Click);
            // 
            // bCLEAR
            // 
            this.bCLEAR.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bCLEAR.Location = new System.Drawing.Point(452, 552);
            this.bCLEAR.Margin = new System.Windows.Forms.Padding(2);
            this.bCLEAR.Name = "bCLEAR";
            this.bCLEAR.Size = new System.Drawing.Size(123, 34);
            this.bCLEAR.TabIndex = 12;
            this.bCLEAR.Text = "LIMPIAR";
            this.bCLEAR.UseVisualStyleBackColor = true;
            this.bCLEAR.Click += new System.EventHandler(this.bCLEAR_Click);
            // 
            // bDEL
            // 
            this.bDEL.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bDEL.Location = new System.Drawing.Point(315, 552);
            this.bDEL.Margin = new System.Windows.Forms.Padding(2);
            this.bDEL.Name = "bDEL";
            this.bDEL.Size = new System.Drawing.Size(123, 34);
            this.bDEL.TabIndex = 11;
            this.bDEL.Text = "BORRAR";
            this.bDEL.UseVisualStyleBackColor = true;
            this.bDEL.Click += new System.EventHandler(this.bDEL_Click);
            // 
            // tUsuarioTableAdapter
            // 
            this.tUsuarioTableAdapter.ClearBeforeFill = true;
            // 
            // bEditRol
            // 
            this.bEditRol.Location = new System.Drawing.Point(133, 436);
            this.bEditRol.Name = "bEditRol";
            this.bEditRol.Size = new System.Drawing.Size(96, 23);
            this.bEditRol.TabIndex = 13;
            this.bEditRol.Text = "Editar";
            this.bEditRol.UseVisualStyleBackColor = true;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            this.passwordDataGridViewTextBoxColumn.DataPropertyName = "password";
            this.passwordDataGridViewTextBoxColumn.HeaderText = "password";
            this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            this.passwordDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rolNameDataGridViewTextBoxColumn
            // 
            this.rolNameDataGridViewTextBoxColumn.DataPropertyName = "rolName";
            this.rolNameDataGridViewTextBoxColumn.HeaderText = "rolName";
            this.rolNameDataGridViewTextBoxColumn.Name = "rolNameDataGridViewTextBoxColumn";
            this.rolNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // USUARIOS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(612, 633);
            this.Controls.Add(this.bEditRol);
            this.Controls.Add(this.bCLEAR);
            this.Controls.Add(this.bDEL);
            this.Controls.Add(this.bUPD);
            this.Controls.Add(this.bINS);
            this.Controls.Add(this.bExit);
            this.Controls.Add(this.lRol);
            this.Controls.Add(this.tPwd);
            this.Controls.Add(this.tUser);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "USUARIOS";
            this.Text = "USUARIOS";
            this.Load += new System.EventHandler(this.USUARIOS_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tUsuarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gI1819DataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tUser;
        private System.Windows.Forms.TextBox tPwd;
        private System.Windows.Forms.ListBox lRol;
        private System.Windows.Forms.Button bExit;
        private System.Windows.Forms.Button bINS;
        private System.Windows.Forms.Button bUPD;
        private System.Windows.Forms.Button bCLEAR;
        private System.Windows.Forms.Button bDEL;
        private GI1819DataSet gI1819DataSet;
        private System.Windows.Forms.BindingSource tUsuarioBindingSource;
        private GI1819DataSetTableAdapters.tUsuarioTableAdapter tUsuarioTableAdapter;
        private System.Windows.Forms.Button bEditRol;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rolNameDataGridViewTextBoxColumn;
    }
}