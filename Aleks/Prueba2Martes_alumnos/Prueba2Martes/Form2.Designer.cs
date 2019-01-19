namespace Prueba2Martes
{
    partial class Form2
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nIFDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nOMBREDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pAISDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tPersonaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.prueba2DataSet = new Prueba2Martes.Prueba2DataSet();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tNIF = new System.Windows.Forms.TextBox();
            this.tNombre = new System.Windows.Forms.TextBox();
            this.lPais = new System.Windows.Forms.ListBox();
            this.bINS = new System.Windows.Forms.Button();
            this.bUPD = new System.Windows.Forms.Button();
            this.bDEL = new System.Windows.Forms.Button();
            this.bEXIT = new System.Windows.Forms.Button();
            this.tPersonaTableAdapter = new Prueba2Martes.Prueba2DataSetTableAdapters.tPersonaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tPersonaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prueba2DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(207, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Personas";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nIFDataGridViewTextBoxColumn,
            this.nOMBREDataGridViewTextBoxColumn,
            this.pAISDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tPersonaBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(108, 117);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(430, 122);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView_SelectionChanged);
            // 
            // nIFDataGridViewTextBoxColumn
            // 
            this.nIFDataGridViewTextBoxColumn.DataPropertyName = "NIF";
            this.nIFDataGridViewTextBoxColumn.HeaderText = "NIF";
            this.nIFDataGridViewTextBoxColumn.Name = "nIFDataGridViewTextBoxColumn";
            this.nIFDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nOMBREDataGridViewTextBoxColumn
            // 
            this.nOMBREDataGridViewTextBoxColumn.DataPropertyName = "NOMBRE";
            this.nOMBREDataGridViewTextBoxColumn.HeaderText = "NOMBRE";
            this.nOMBREDataGridViewTextBoxColumn.Name = "nOMBREDataGridViewTextBoxColumn";
            this.nOMBREDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pAISDataGridViewTextBoxColumn
            // 
            this.pAISDataGridViewTextBoxColumn.DataPropertyName = "PAIS";
            this.pAISDataGridViewTextBoxColumn.HeaderText = "PAIS";
            this.pAISDataGridViewTextBoxColumn.Name = "pAISDataGridViewTextBoxColumn";
            this.pAISDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tPersonaBindingSource
            // 
            this.tPersonaBindingSource.DataMember = "tPersona";
            this.tPersonaBindingSource.DataSource = this.prueba2DataSet;
            // 
            // prueba2DataSet
            // 
            this.prueba2DataSet.DataSetName = "Prueba2DataSet";
            this.prueba2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(108, 274);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "NIF";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(108, 319);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "NOMBRE";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(352, 274);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "PAIS";
            // 
            // tNIF
            // 
            this.tNIF.Location = new System.Drawing.Point(180, 274);
            this.tNIF.Margin = new System.Windows.Forms.Padding(2);
            this.tNIF.Name = "tNIF";
            this.tNIF.Size = new System.Drawing.Size(152, 20);
            this.tNIF.TabIndex = 5;
            // 
            // tNombre
            // 
            this.tNombre.Location = new System.Drawing.Point(180, 319);
            this.tNombre.Margin = new System.Windows.Forms.Padding(2);
            this.tNombre.Name = "tNombre";
            this.tNombre.Size = new System.Drawing.Size(152, 20);
            this.tNombre.TabIndex = 6;
            // 
            // lPais
            // 
            this.lPais.FormattingEnabled = true;
            this.lPais.Location = new System.Drawing.Point(414, 274);
            this.lPais.Margin = new System.Windows.Forms.Padding(2);
            this.lPais.Name = "lPais";
            this.lPais.Size = new System.Drawing.Size(126, 69);
            this.lPais.TabIndex = 7;
            // 
            // bINS
            // 
            this.bINS.Location = new System.Drawing.Point(110, 377);
            this.bINS.Margin = new System.Windows.Forms.Padding(2);
            this.bINS.Name = "bINS";
            this.bINS.Size = new System.Drawing.Size(56, 19);
            this.bINS.TabIndex = 8;
            this.bINS.Text = "Insertar";
            this.bINS.UseVisualStyleBackColor = true;
            this.bINS.Click += new System.EventHandler(this.bINS_Click);
            // 
            // bUPD
            // 
            this.bUPD.Location = new System.Drawing.Point(226, 377);
            this.bUPD.Margin = new System.Windows.Forms.Padding(2);
            this.bUPD.Name = "bUPD";
            this.bUPD.Size = new System.Drawing.Size(56, 19);
            this.bUPD.TabIndex = 9;
            this.bUPD.Text = "Modificar";
            this.bUPD.UseVisualStyleBackColor = true;
            this.bUPD.Click += new System.EventHandler(this.bUPD_Click);
            // 
            // bDEL
            // 
            this.bDEL.Location = new System.Drawing.Point(343, 377);
            this.bDEL.Margin = new System.Windows.Forms.Padding(2);
            this.bDEL.Name = "bDEL";
            this.bDEL.Size = new System.Drawing.Size(56, 19);
            this.bDEL.TabIndex = 10;
            this.bDEL.Text = "Borrar";
            this.bDEL.UseVisualStyleBackColor = true;
            this.bDEL.Click += new System.EventHandler(this.bDEL_Click);
            // 
            // bEXIT
            // 
            this.bEXIT.Location = new System.Drawing.Point(482, 377);
            this.bEXIT.Margin = new System.Windows.Forms.Padding(2);
            this.bEXIT.Name = "bEXIT";
            this.bEXIT.Size = new System.Drawing.Size(56, 19);
            this.bEXIT.TabIndex = 11;
            this.bEXIT.Text = "Salir";
            this.bEXIT.UseVisualStyleBackColor = true;
            this.bEXIT.Click += new System.EventHandler(this.bEXIT_Click);
            // 
            // tPersonaTableAdapter
            // 
            this.tPersonaTableAdapter.ClearBeforeFill = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 414);
            this.Controls.Add(this.bEXIT);
            this.Controls.Add(this.bDEL);
            this.Controls.Add(this.bUPD);
            this.Controls.Add(this.bINS);
            this.Controls.Add(this.lPais);
            this.Controls.Add(this.tNombre);
            this.Controls.Add(this.tNIF);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form2";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tPersonaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prueba2DataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tNIF;
        private System.Windows.Forms.TextBox tNombre;
        private System.Windows.Forms.ListBox lPais;
        private System.Windows.Forms.Button bINS;
        private System.Windows.Forms.Button bUPD;
        private System.Windows.Forms.Button bDEL;
        private System.Windows.Forms.Button bEXIT;
        private Prueba2DataSet prueba2DataSet;
        private System.Windows.Forms.BindingSource tPersonaBindingSource;
        private Prueba2DataSetTableAdapters.tPersonaTableAdapter tPersonaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nIFDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nOMBREDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pAISDataGridViewTextBoxColumn;
    }
}

