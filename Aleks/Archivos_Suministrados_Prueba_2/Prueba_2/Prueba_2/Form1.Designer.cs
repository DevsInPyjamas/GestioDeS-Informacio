namespace Prueba_2
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
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
            this.medicamentosGridView = new System.Windows.Forms.DataGridView();
            this.tMedicamentoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bD_MEDICAMENTOSDataSet = new Prueba_2.BD_MEDICAMENTOSDataSet();
            this.tMedicamentoTableAdapter = new Prueba_2.BD_MEDICAMENTOSDataSetTableAdapters.tMedicamentoTableAdapter();
            this.closeB = new System.Windows.Forms.Button();
            this.insB = new System.Windows.Forms.Button();
            this.modB = new System.Windows.Forms.Button();
            this.deleteThisB = new System.Windows.Forms.Button();
            this.cleanB = new System.Windows.Forms.Button();
            this.idMed = new System.Windows.Forms.TextBox();
            this.medCant = new System.Windows.Forms.TextBox();
            this.medName = new System.Windows.Forms.TextBox();
            this.labList = new System.Windows.Forms.ListBox();
            this.iDMEDICAMENTODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nOMBREMEDICAMENTODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cANTIDADDISPONIBLEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lABORATORIODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.medicamentosGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tMedicamentoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD_MEDICAMENTOSDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // medicamentosGridView
            // 
            this.medicamentosGridView.AutoGenerateColumns = false;
            this.medicamentosGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.medicamentosGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDMEDICAMENTODataGridViewTextBoxColumn,
            this.nOMBREMEDICAMENTODataGridViewTextBoxColumn,
            this.cANTIDADDISPONIBLEDataGridViewTextBoxColumn,
            this.lABORATORIODataGridViewTextBoxColumn});
            this.medicamentosGridView.DataSource = this.tMedicamentoBindingSource;
            this.medicamentosGridView.Location = new System.Drawing.Point(69, 70);
            this.medicamentosGridView.Name = "medicamentosGridView";
            this.medicamentosGridView.Size = new System.Drawing.Size(645, 196);
            this.medicamentosGridView.TabIndex = 0;
            this.medicamentosGridView.SelectionChanged += new System.EventHandler(this.medicamentosGridView_SelectionChanged);
            // 
            // tMedicamentoBindingSource
            // 
            this.tMedicamentoBindingSource.DataMember = "tMedicamento";
            this.tMedicamentoBindingSource.DataSource = this.bD_MEDICAMENTOSDataSet;
            // 
            // bD_MEDICAMENTOSDataSet
            // 
            this.bD_MEDICAMENTOSDataSet.DataSetName = "BD_MEDICAMENTOSDataSet";
            this.bD_MEDICAMENTOSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tMedicamentoTableAdapter
            // 
            this.tMedicamentoTableAdapter.ClearBeforeFill = true;
            // 
            // closeB
            // 
            this.closeB.Location = new System.Drawing.Point(12, 437);
            this.closeB.Name = "closeB";
            this.closeB.Size = new System.Drawing.Size(75, 23);
            this.closeB.TabIndex = 1;
            this.closeB.Text = "salir";
            this.closeB.UseVisualStyleBackColor = true;
            this.closeB.Click += new System.EventHandler(this.closeB_Click);
            // 
            // insB
            // 
            this.insB.Location = new System.Drawing.Point(106, 437);
            this.insB.Name = "insB";
            this.insB.Size = new System.Drawing.Size(75, 23);
            this.insB.TabIndex = 2;
            this.insB.Text = "insertar";
            this.insB.UseVisualStyleBackColor = true;
            this.insB.Click += new System.EventHandler(this.insB_Click);
            // 
            // modB
            // 
            this.modB.Location = new System.Drawing.Point(206, 437);
            this.modB.Name = "modB";
            this.modB.Size = new System.Drawing.Size(75, 23);
            this.modB.TabIndex = 3;
            this.modB.Text = "modificar";
            this.modB.UseVisualStyleBackColor = true;
            this.modB.Click += new System.EventHandler(this.modB_Click);
            // 
            // deleteThisB
            // 
            this.deleteThisB.Location = new System.Drawing.Point(341, 437);
            this.deleteThisB.Name = "deleteThisB";
            this.deleteThisB.Size = new System.Drawing.Size(75, 23);
            this.deleteThisB.TabIndex = 4;
            this.deleteThisB.Text = "borrar";
            this.deleteThisB.UseVisualStyleBackColor = true;
            this.deleteThisB.Click += new System.EventHandler(this.deleteThisB_Click);
            // 
            // cleanB
            // 
            this.cleanB.Location = new System.Drawing.Point(422, 437);
            this.cleanB.Name = "cleanB";
            this.cleanB.Size = new System.Drawing.Size(75, 23);
            this.cleanB.TabIndex = 5;
            this.cleanB.Text = "limpiar";
            this.cleanB.UseVisualStyleBackColor = true;
            this.cleanB.Click += new System.EventHandler(this.cleanB_Click);
            // 
            // idMed
            // 
            this.idMed.Location = new System.Drawing.Point(147, 295);
            this.idMed.Name = "idMed";
            this.idMed.Size = new System.Drawing.Size(271, 20);
            this.idMed.TabIndex = 6;
            // 
            // medCant
            // 
            this.medCant.Location = new System.Drawing.Point(316, 347);
            this.medCant.Name = "medCant";
            this.medCant.Size = new System.Drawing.Size(100, 20);
            this.medCant.TabIndex = 7;
            // 
            // medName
            // 
            this.medName.Location = new System.Drawing.Point(316, 321);
            this.medName.Name = "medName";
            this.medName.Size = new System.Drawing.Size(100, 20);
            this.medName.TabIndex = 8;
            // 
            // labList
            // 
            this.labList.FormattingEnabled = true;
            this.labList.Location = new System.Drawing.Point(147, 375);
            this.labList.Name = "labList";
            this.labList.Size = new System.Drawing.Size(420, 43);
            this.labList.TabIndex = 9;
            // 
            // iDMEDICAMENTODataGridViewTextBoxColumn
            // 
            this.iDMEDICAMENTODataGridViewTextBoxColumn.DataPropertyName = "ID_MEDICAMENTO";
            this.iDMEDICAMENTODataGridViewTextBoxColumn.HeaderText = "ID_MEDICAMENTO";
            this.iDMEDICAMENTODataGridViewTextBoxColumn.Name = "iDMEDICAMENTODataGridViewTextBoxColumn";
            // 
            // nOMBREMEDICAMENTODataGridViewTextBoxColumn
            // 
            this.nOMBREMEDICAMENTODataGridViewTextBoxColumn.DataPropertyName = "NOMBRE_MEDICAMENTO";
            this.nOMBREMEDICAMENTODataGridViewTextBoxColumn.HeaderText = "NOMBRE_MEDICAMENTO";
            this.nOMBREMEDICAMENTODataGridViewTextBoxColumn.Name = "nOMBREMEDICAMENTODataGridViewTextBoxColumn";
            // 
            // cANTIDADDISPONIBLEDataGridViewTextBoxColumn
            // 
            this.cANTIDADDISPONIBLEDataGridViewTextBoxColumn.DataPropertyName = "CANTIDAD_DISPONIBLE";
            this.cANTIDADDISPONIBLEDataGridViewTextBoxColumn.HeaderText = "CANTIDAD_DISPONIBLE";
            this.cANTIDADDISPONIBLEDataGridViewTextBoxColumn.Name = "cANTIDADDISPONIBLEDataGridViewTextBoxColumn";
            // 
            // lABORATORIODataGridViewTextBoxColumn
            // 
            this.lABORATORIODataGridViewTextBoxColumn.DataPropertyName = "LABORATORIO";
            this.lABORATORIODataGridViewTextBoxColumn.HeaderText = "LABORATORIO";
            this.lABORATORIODataGridViewTextBoxColumn.Name = "lABORATORIODataGridViewTextBoxColumn";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 472);
            this.Controls.Add(this.labList);
            this.Controls.Add(this.medName);
            this.Controls.Add(this.medCant);
            this.Controls.Add(this.idMed);
            this.Controls.Add(this.cleanB);
            this.Controls.Add(this.deleteThisB);
            this.Controls.Add(this.modB);
            this.Controls.Add(this.insB);
            this.Controls.Add(this.closeB);
            this.Controls.Add(this.medicamentosGridView);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.medicamentosGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tMedicamentoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD_MEDICAMENTOSDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView medicamentosGridView;
        private BD_MEDICAMENTOSDataSet bD_MEDICAMENTOSDataSet;
        private System.Windows.Forms.BindingSource tMedicamentoBindingSource;
        private BD_MEDICAMENTOSDataSetTableAdapters.tMedicamentoTableAdapter tMedicamentoTableAdapter;
        private System.Windows.Forms.Button closeB;
        private System.Windows.Forms.Button insB;
        private System.Windows.Forms.Button modB;
        private System.Windows.Forms.Button deleteThisB;
        private System.Windows.Forms.Button cleanB;
        private System.Windows.Forms.TextBox idMed;
        private System.Windows.Forms.TextBox medCant;
        private System.Windows.Forms.TextBox medName;
        private System.Windows.Forms.ListBox labList;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDMEDICAMENTODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nOMBREMEDICAMENTODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cANTIDADDISPONIBLEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lABORATORIODataGridViewTextBoxColumn;
    }
}

