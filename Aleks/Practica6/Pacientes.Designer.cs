namespace HIS
{
    partial class Pacientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pacientes));
            this.pacientesGridView = new System.Windows.Forms.DataGridView();
            this.numSSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dNINIEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sexoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaNacimientoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.poblacionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.provinciaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoPostalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pacientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gI1819DataSet = new HIS.GI1819DataSet();
            this.tPacienteTableAdapter = new HIS.GI1819DataSetTableAdapters.tPacienteTableAdapter();
            this.bExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.numSS = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.apellidosBox = new System.Windows.Forms.TextBox();
            this.NIF_NIEBOX = new System.Windows.Forms.TextBox();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.provinciaTextBox = new System.Windows.Forms.TextBox();
            this.poblacionTextBox = new System.Windows.Forms.TextBox();
            this.telefonoTextBox = new System.Windows.Forms.TextBox();
            this.direccionTextBox = new System.Windows.Forms.TextBox();
            this.codigoPostalTextBox = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.country = new System.Windows.Forms.ListBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.cleanButton = new System.Windows.Forms.Button();
            this.modifyButton = new System.Windows.Forms.Button();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label14 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pacientesGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gI1819DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // pacientesGridView
            // 
            this.pacientesGridView.AllowUserToAddRows = false;
            this.pacientesGridView.AllowUserToDeleteRows = false;
            this.pacientesGridView.AllowUserToOrderColumns = true;
            this.pacientesGridView.AutoGenerateColumns = false;
            this.pacientesGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numSSDataGridViewTextBoxColumn,
            this.dNINIEDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.apellidosDataGridViewTextBoxColumn,
            this.sexoDataGridViewTextBoxColumn,
            this.fechaNacimientoDataGridViewTextBoxColumn,
            this.direccionDataGridViewTextBoxColumn,
            this.poblacionDataGridViewTextBoxColumn,
            this.provinciaDataGridViewTextBoxColumn,
            this.codigoPostalDataGridViewTextBoxColumn,
            this.paisDataGridViewTextBoxColumn,
            this.telefonoDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn});
            this.pacientesGridView.DataSource = this.pacientesBindingSource;
            this.pacientesGridView.Location = new System.Drawing.Point(12, 75);
            this.pacientesGridView.MultiSelect = false;
            this.pacientesGridView.Name = "pacientesGridView";
            this.pacientesGridView.ReadOnly = true;
            this.pacientesGridView.RowTemplate.Height = 24;
            this.pacientesGridView.Size = new System.Drawing.Size(922, 139);
            this.pacientesGridView.TabIndex = 2;
            // 
            // numSSDataGridViewTextBoxColumn
            // 
            this.numSSDataGridViewTextBoxColumn.DataPropertyName = "NumSS";
            this.numSSDataGridViewTextBoxColumn.HeaderText = "NumSS";
            this.numSSDataGridViewTextBoxColumn.Name = "numSSDataGridViewTextBoxColumn";
            this.numSSDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dNINIEDataGridViewTextBoxColumn
            // 
            this.dNINIEDataGridViewTextBoxColumn.DataPropertyName = "DNI_NIE";
            this.dNINIEDataGridViewTextBoxColumn.HeaderText = "DNI_NIE";
            this.dNINIEDataGridViewTextBoxColumn.Name = "dNINIEDataGridViewTextBoxColumn";
            this.dNINIEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // apellidosDataGridViewTextBoxColumn
            // 
            this.apellidosDataGridViewTextBoxColumn.DataPropertyName = "Apellidos";
            this.apellidosDataGridViewTextBoxColumn.HeaderText = "Apellidos";
            this.apellidosDataGridViewTextBoxColumn.Name = "apellidosDataGridViewTextBoxColumn";
            this.apellidosDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sexoDataGridViewTextBoxColumn
            // 
            this.sexoDataGridViewTextBoxColumn.DataPropertyName = "Sexo";
            this.sexoDataGridViewTextBoxColumn.HeaderText = "Sexo";
            this.sexoDataGridViewTextBoxColumn.Name = "sexoDataGridViewTextBoxColumn";
            this.sexoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fechaNacimientoDataGridViewTextBoxColumn
            // 
            this.fechaNacimientoDataGridViewTextBoxColumn.DataPropertyName = "FechaNacimiento";
            this.fechaNacimientoDataGridViewTextBoxColumn.HeaderText = "FechaNacimiento";
            this.fechaNacimientoDataGridViewTextBoxColumn.Name = "fechaNacimientoDataGridViewTextBoxColumn";
            this.fechaNacimientoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // direccionDataGridViewTextBoxColumn
            // 
            this.direccionDataGridViewTextBoxColumn.DataPropertyName = "Direccion";
            this.direccionDataGridViewTextBoxColumn.HeaderText = "Direccion";
            this.direccionDataGridViewTextBoxColumn.Name = "direccionDataGridViewTextBoxColumn";
            this.direccionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // poblacionDataGridViewTextBoxColumn
            // 
            this.poblacionDataGridViewTextBoxColumn.DataPropertyName = "Poblacion";
            this.poblacionDataGridViewTextBoxColumn.HeaderText = "Poblacion";
            this.poblacionDataGridViewTextBoxColumn.Name = "poblacionDataGridViewTextBoxColumn";
            this.poblacionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // provinciaDataGridViewTextBoxColumn
            // 
            this.provinciaDataGridViewTextBoxColumn.DataPropertyName = "Provincia";
            this.provinciaDataGridViewTextBoxColumn.HeaderText = "Provincia";
            this.provinciaDataGridViewTextBoxColumn.Name = "provinciaDataGridViewTextBoxColumn";
            this.provinciaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // codigoPostalDataGridViewTextBoxColumn
            // 
            this.codigoPostalDataGridViewTextBoxColumn.DataPropertyName = "CodigoPostal";
            this.codigoPostalDataGridViewTextBoxColumn.HeaderText = "CodigoPostal";
            this.codigoPostalDataGridViewTextBoxColumn.Name = "codigoPostalDataGridViewTextBoxColumn";
            this.codigoPostalDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // paisDataGridViewTextBoxColumn
            // 
            this.paisDataGridViewTextBoxColumn.DataPropertyName = "Pais";
            this.paisDataGridViewTextBoxColumn.HeaderText = "Pais";
            this.paisDataGridViewTextBoxColumn.Name = "paisDataGridViewTextBoxColumn";
            this.paisDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // telefonoDataGridViewTextBoxColumn
            // 
            this.telefonoDataGridViewTextBoxColumn.DataPropertyName = "Telefono";
            this.telefonoDataGridViewTextBoxColumn.HeaderText = "Telefono";
            this.telefonoDataGridViewTextBoxColumn.Name = "telefonoDataGridViewTextBoxColumn";
            this.telefonoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "e_mail";
            this.emailDataGridViewTextBoxColumn.HeaderText = "e_mail";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pacientesBindingSource
            // 
            this.pacientesBindingSource.DataMember = "tPaciente";
            this.pacientesBindingSource.DataSource = this.gI1819DataSet;
            // 
            // gI1819DataSet
            // 
            this.gI1819DataSet.DataSetName = "GI1819DataSet";
            this.gI1819DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tPacienteTableAdapter
            // 
            this.tPacienteTableAdapter.ClearBeforeFill = true;
            // 
            // bExit
            // 
            this.bExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bExit.BackgroundImage")));
            this.bExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bExit.Location = new System.Drawing.Point(3, 11);
            this.bExit.Margin = new System.Windows.Forms.Padding(2);
            this.bExit.Name = "bExit";
            this.bExit.Size = new System.Drawing.Size(116, 59);
            this.bExit.TabIndex = 9;
            this.bExit.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(320, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(264, 46);
            this.label1.TabIndex = 10;
            this.label1.Text = "PACIENTES";
            // 
            // numSS
            // 
            this.numSS.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numSS.Location = new System.Drawing.Point(102, 256);
            this.numSS.Margin = new System.Windows.Forms.Padding(2);
            this.numSS.Name = "numSS";
            this.numSS.Size = new System.Drawing.Size(324, 30);
            this.numSS.TabIndex = 11;
            // 
            // emailTextBox
            // 
            this.emailTextBox.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailTextBox.Location = new System.Drawing.Point(603, 627);
            this.emailTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(270, 30);
            this.emailTextBox.TabIndex = 12;
            // 
            // apellidosBox
            // 
            this.apellidosBox.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.apellidosBox.Location = new System.Drawing.Point(540, 290);
            this.apellidosBox.Margin = new System.Windows.Forms.Padding(2);
            this.apellidosBox.Name = "apellidosBox";
            this.apellidosBox.Size = new System.Drawing.Size(333, 30);
            this.apellidosBox.TabIndex = 13;
            // 
            // NIF_NIEBOX
            // 
            this.NIF_NIEBOX.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NIF_NIEBOX.Location = new System.Drawing.Point(540, 256);
            this.NIF_NIEBOX.Margin = new System.Windows.Forms.Padding(2);
            this.NIF_NIEBOX.Name = "NIF_NIEBOX";
            this.NIF_NIEBOX.Size = new System.Drawing.Size(333, 30);
            this.NIF_NIEBOX.TabIndex = 14;
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreTextBox.Location = new System.Drawing.Point(102, 290);
            this.nombreTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(324, 30);
            this.nombreTextBox.TabIndex = 15;
            // 
            // provinciaTextBox
            // 
            this.provinciaTextBox.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.provinciaTextBox.Location = new System.Drawing.Point(603, 455);
            this.provinciaTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.provinciaTextBox.Name = "provinciaTextBox";
            this.provinciaTextBox.Size = new System.Drawing.Size(270, 30);
            this.provinciaTextBox.TabIndex = 16;
            // 
            // poblacionTextBox
            // 
            this.poblacionTextBox.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.poblacionTextBox.Location = new System.Drawing.Point(603, 421);
            this.poblacionTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.poblacionTextBox.Name = "poblacionTextBox";
            this.poblacionTextBox.Size = new System.Drawing.Size(270, 30);
            this.poblacionTextBox.TabIndex = 17;
            // 
            // telefonoTextBox
            // 
            this.telefonoTextBox.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.telefonoTextBox.Location = new System.Drawing.Point(603, 583);
            this.telefonoTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.telefonoTextBox.Name = "telefonoTextBox";
            this.telefonoTextBox.Size = new System.Drawing.Size(270, 30);
            this.telefonoTextBox.TabIndex = 18;
            // 
            // direccionTextBox
            // 
            this.direccionTextBox.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.direccionTextBox.Location = new System.Drawing.Point(365, 335);
            this.direccionTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.direccionTextBox.Name = "direccionTextBox";
            this.direccionTextBox.Size = new System.Drawing.Size(508, 30);
            this.direccionTextBox.TabIndex = 19;
            // 
            // codigoPostalTextBox
            // 
            this.codigoPostalTextBox.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codigoPostalTextBox.Location = new System.Drawing.Point(603, 387);
            this.codigoPostalTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.codigoPostalTextBox.Name = "codigoPostalTextBox";
            this.codigoPostalTextBox.Size = new System.Drawing.Size(270, 30);
            this.codigoPostalTextBox.TabIndex = 20;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "HOMBRE",
            "MUJER"});
            this.listBox1.Location = new System.Drawing.Point(102, 335);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(147, 30);
            this.listBox1.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 266);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "numSS";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(485, 266);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "NIF/NIE";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(485, 300);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "apellidos";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(45, 307);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "nombre";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(45, 352);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 27;
            this.label6.Text = "sexo";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(297, 345);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 13);
            this.label7.TabIndex = 28;
            this.label7.Text = "direccion";
            // 
            // country
            // 
            this.country.FormattingEnabled = true;
            this.country.Location = new System.Drawing.Point(603, 493);
            this.country.Name = "country";
            this.country.Size = new System.Drawing.Size(270, 82);
            this.country.TabIndex = 29;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(529, 397);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 13);
            this.label8.TabIndex = 30;
            this.label8.Text = "CodigoPostal";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(537, 431);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 13);
            this.label9.TabIndex = 31;
            this.label9.Text = "Poblacion";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(537, 465);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 13);
            this.label10.TabIndex = 32;
            this.label10.Text = "Provincia";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(537, 493);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(27, 13);
            this.label11.TabIndex = 33;
            this.label11.Text = "Pais";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(537, 593);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(49, 13);
            this.label12.TabIndex = 34;
            this.label12.Text = "Teléfono";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(537, 637);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(34, 13);
            this.label13.TabIndex = 35;
            this.label13.Text = "e-mail";
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(174, 684);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 36;
            this.addButton.Text = "Añadir";
            this.addButton.UseVisualStyleBackColor = true;
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(255, 684);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 23);
            this.deleteButton.TabIndex = 37;
            this.deleteButton.Text = "Borrar";
            this.deleteButton.UseVisualStyleBackColor = true;
            // 
            // cleanButton
            // 
            this.cleanButton.Location = new System.Drawing.Point(458, 684);
            this.cleanButton.Name = "cleanButton";
            this.cleanButton.Size = new System.Drawing.Size(75, 23);
            this.cleanButton.TabIndex = 38;
            this.cleanButton.Text = "Limpiar";
            this.cleanButton.UseVisualStyleBackColor = true;
            // 
            // modifyButton
            // 
            this.modifyButton.Location = new System.Drawing.Point(336, 684);
            this.modifyButton.Name = "modifyButton";
            this.modifyButton.Size = new System.Drawing.Size(75, 23);
            this.modifyButton.TabIndex = 39;
            this.modifyButton.Text = "Modificar";
            this.modifyButton.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.AllowDrop = true;
            this.dateTimePicker.Location = new System.Drawing.Point(147, 428);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker.TabIndex = 40;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(45, 434);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(90, 13);
            this.label14.TabIndex = 41;
            this.label14.Text = "FechaNacimiento";
            // 
            // Pacientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(937, 719);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.modifyButton);
            this.Controls.Add(this.cleanButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.country);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.codigoPostalTextBox);
            this.Controls.Add(this.direccionTextBox);
            this.Controls.Add(this.telefonoTextBox);
            this.Controls.Add(this.poblacionTextBox);
            this.Controls.Add(this.provinciaTextBox);
            this.Controls.Add(this.nombreTextBox);
            this.Controls.Add(this.NIF_NIEBOX);
            this.Controls.Add(this.apellidosBox);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.numSS);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bExit);
            this.Controls.Add(this.pacientesGridView);
            this.Name = "Pacientes";
            this.Text = "Pacientes";
            this.Load += new System.EventHandler(this.Pacientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pacientesGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gI1819DataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView pacientesGridView;
        private GI1819DataSet gI1819DataSet;
        private System.Windows.Forms.BindingSource pacientesBindingSource;
        private GI1819DataSetTableAdapters.tPacienteTableAdapter tPacienteTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn numSSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dNINIEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sexoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaNacimientoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn poblacionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn provinciaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoPostalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paisDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button bExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox numSS;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox apellidosBox;
        private System.Windows.Forms.TextBox NIF_NIEBOX;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.TextBox provinciaTextBox;
        private System.Windows.Forms.TextBox poblacionTextBox;
        private System.Windows.Forms.TextBox telefonoTextBox;
        private System.Windows.Forms.TextBox direccionTextBox;
        private System.Windows.Forms.TextBox codigoPostalTextBox;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox country;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button cleanButton;
        private System.Windows.Forms.Button modifyButton;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Label label14;
    }
}