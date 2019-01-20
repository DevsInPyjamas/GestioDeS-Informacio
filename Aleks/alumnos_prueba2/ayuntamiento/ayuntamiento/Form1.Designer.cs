namespace ayuntamiento
{
    partial class listBoxPartidos
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
            this.ayuntamientoLabel = new System.Windows.Forms.Label();
            this.partidoLabel = new System.Windows.Forms.Label();
            this.concejalesLabel = new System.Windows.Forms.Label();
            this.numeroEdilesLabel = new System.Windows.Forms.Label();
            this.nombreLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.partidosListBox = new System.Windows.Forms.ListBox();
            this.concejalesListBox = new System.Windows.Forms.ListBox();
            this.numeroEdilesTextBox = new System.Windows.Forms.TextBox();
            this.nombreConcejalTextBox = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.modificarButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.cleanButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ayuntamientoDataSet = new ayuntamiento.AyuntamientoDataSet();
            this.tPartidoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tPartidoTableAdapter = new ayuntamiento.AyuntamientoDataSetTableAdapters.tPartidoTableAdapter();
            this.siglasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ayuntamientoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tPartidoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ayuntamientoLabel
            // 
            this.ayuntamientoLabel.AutoSize = true;
            this.ayuntamientoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ayuntamientoLabel.Location = new System.Drawing.Point(153, 24);
            this.ayuntamientoLabel.Name = "ayuntamientoLabel";
            this.ayuntamientoLabel.Size = new System.Drawing.Size(415, 39);
            this.ayuntamientoLabel.TabIndex = 0;
            this.ayuntamientoLabel.Text = "Ayuntamiento de Málaga";
            // 
            // partidoLabel
            // 
            this.partidoLabel.AutoSize = true;
            this.partidoLabel.Location = new System.Drawing.Point(46, 100);
            this.partidoLabel.Name = "partidoLabel";
            this.partidoLabel.Size = new System.Drawing.Size(40, 13);
            this.partidoLabel.TabIndex = 1;
            this.partidoLabel.Text = "Partido";
            // 
            // concejalesLabel
            // 
            this.concejalesLabel.AutoSize = true;
            this.concejalesLabel.Location = new System.Drawing.Point(387, 100);
            this.concejalesLabel.Name = "concejalesLabel";
            this.concejalesLabel.Size = new System.Drawing.Size(59, 13);
            this.concejalesLabel.TabIndex = 2;
            this.concejalesLabel.Text = "Concejales";
            // 
            // numeroEdilesLabel
            // 
            this.numeroEdilesLabel.AutoSize = true;
            this.numeroEdilesLabel.Location = new System.Drawing.Point(429, 204);
            this.numeroEdilesLabel.Name = "numeroEdilesLabel";
            this.numeroEdilesLabel.Size = new System.Drawing.Size(90, 13);
            this.numeroEdilesLabel.TabIndex = 3;
            this.numeroEdilesLabel.Text = "Numero de Ediles";
            // 
            // nombreLabel
            // 
            this.nombreLabel.AutoSize = true;
            this.nombreLabel.Location = new System.Drawing.Point(152, 266);
            this.nombreLabel.Name = "nombreLabel";
            this.nombreLabel.Size = new System.Drawing.Size(44, 13);
            this.nombreLabel.TabIndex = 4;
            this.nombreLabel.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(156, 301);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Partido";
            // 
            // partidosListBox
            // 
            this.partidosListBox.FormattingEnabled = true;
            this.partidosListBox.Location = new System.Drawing.Point(279, 301);
            this.partidosListBox.Name = "partidosListBox";
            this.partidosListBox.Size = new System.Drawing.Size(386, 82);
            this.partidosListBox.TabIndex = 6;
            // 
            // concejalesListBox
            // 
            this.concejalesListBox.FormattingEnabled = true;
            this.concejalesListBox.Location = new System.Drawing.Point(390, 116);
            this.concejalesListBox.Name = "concejalesListBox";
            this.concejalesListBox.Size = new System.Drawing.Size(264, 69);
            this.concejalesListBox.TabIndex = 7;
            this.concejalesListBox.SelectedIndexChanged += new System.EventHandler(this.concejalesListBox_SelectedIndexChanged);
            // 
            // numeroEdilesTextBox
            // 
            this.numeroEdilesTextBox.Location = new System.Drawing.Point(525, 201);
            this.numeroEdilesTextBox.Name = "numeroEdilesTextBox";
            this.numeroEdilesTextBox.Size = new System.Drawing.Size(129, 20);
            this.numeroEdilesTextBox.TabIndex = 8;
            // 
            // nombreConcejalTextBox
            // 
            this.nombreConcejalTextBox.Location = new System.Drawing.Point(279, 259);
            this.nombreConcejalTextBox.Name = "nombreConcejalTextBox";
            this.nombreConcejalTextBox.Size = new System.Drawing.Size(386, 20);
            this.nombreConcejalTextBox.TabIndex = 9;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(88, 411);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 10;
            this.addButton.Text = "Añadir";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // modificarButton
            // 
            this.modificarButton.Location = new System.Drawing.Point(279, 411);
            this.modificarButton.Name = "modificarButton";
            this.modificarButton.Size = new System.Drawing.Size(75, 23);
            this.modificarButton.TabIndex = 11;
            this.modificarButton.Text = "Modificar";
            this.modificarButton.UseVisualStyleBackColor = true;
            this.modificarButton.Click += new System.EventHandler(this.modificarButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(390, 411);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 23);
            this.deleteButton.TabIndex = 12;
            this.deleteButton.Text = "Borrar";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // cleanButton
            // 
            this.cleanButton.Location = new System.Drawing.Point(493, 411);
            this.cleanButton.Name = "cleanButton";
            this.cleanButton.Size = new System.Drawing.Size(75, 23);
            this.cleanButton.TabIndex = 13;
            this.cleanButton.Text = "Limpiar";
            this.cleanButton.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.siglasDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tPartidoBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(49, 119);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(316, 101);
            this.dataGridView1.TabIndex = 14;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView_SelectionChanged);
            // 
            // ayuntamientoDataSet
            // 
            this.ayuntamientoDataSet.DataSetName = "AyuntamientoDataSet";
            this.ayuntamientoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tPartidoBindingSource
            // 
            this.tPartidoBindingSource.DataMember = "tPartido";
            this.tPartidoBindingSource.DataSource = this.ayuntamientoDataSet;
            // 
            // tPartidoTableAdapter
            // 
            this.tPartidoTableAdapter.ClearBeforeFill = true;
            // 
            // siglasDataGridViewTextBoxColumn
            // 
            this.siglasDataGridViewTextBoxColumn.DataPropertyName = "siglas";
            this.siglasDataGridViewTextBoxColumn.HeaderText = "siglas";
            this.siglasDataGridViewTextBoxColumn.Name = "siglasDataGridViewTextBoxColumn";
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            // 
            // listBoxPartidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 446);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cleanButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.modificarButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.nombreConcejalTextBox);
            this.Controls.Add(this.numeroEdilesTextBox);
            this.Controls.Add(this.concejalesListBox);
            this.Controls.Add(this.partidosListBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nombreLabel);
            this.Controls.Add(this.numeroEdilesLabel);
            this.Controls.Add(this.concejalesLabel);
            this.Controls.Add(this.partidoLabel);
            this.Controls.Add(this.ayuntamientoLabel);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "listBoxPartidos";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.listBoxPartidos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ayuntamientoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tPartidoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ayuntamientoLabel;
        private System.Windows.Forms.Label partidoLabel;
        private System.Windows.Forms.Label concejalesLabel;
        private System.Windows.Forms.Label numeroEdilesLabel;
        private System.Windows.Forms.Label nombreLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox partidosListBox;
        private System.Windows.Forms.ListBox concejalesListBox;
        private System.Windows.Forms.TextBox numeroEdilesTextBox;
        private System.Windows.Forms.TextBox nombreConcejalTextBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button modificarButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button cleanButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private AyuntamientoDataSet ayuntamientoDataSet;
        private System.Windows.Forms.BindingSource tPartidoBindingSource;
        private AyuntamientoDataSetTableAdapters.tPartidoTableAdapter tPartidoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn siglasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
    }
}

