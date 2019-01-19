namespace HIS
{
    partial class PACIENTES
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PACIENTES));
            this.label1 = new System.Windows.Forms.Label();
            this.bCLEAN = new System.Windows.Forms.Button();
            this.bDEL = new System.Windows.Forms.Button();
            this.bMODI = new System.Windows.Forms.Button();
            this.bADD = new System.Windows.Forms.Button();
            this.tEmail = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.lPais = new System.Windows.Forms.ListBox();
            this.tTelefono = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.tProvincia = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.tPoblacion = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tCP = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tDireccion = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.mFecha = new System.Windows.Forms.MonthCalendar();
            this.lSexo = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tApellidos = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tPacienteBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.fIC1819DataSet = new HIS.GI1819DataSet();
            this.tPacienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tNombre = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tNIF = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tNumSS = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.bExit = new System.Windows.Forms.Button();
            this.tPacienteTableAdapter = new HIS.GI1819DataSetTableAdapters.tPacienteTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tPacienteBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fIC1819DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tPacienteBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(244, 39);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 55);
            this.label1.TabIndex = 1;
            this.label1.Text = "Pacientes";
            // 
            // bCLEAN
            // 
            this.bCLEAN.Location = new System.Drawing.Point(475, 690);
            this.bCLEAN.Margin = new System.Windows.Forms.Padding(2);
            this.bCLEAN.Name = "bCLEAN";
            this.bCLEAN.Size = new System.Drawing.Size(56, 19);
            this.bCLEAN.TabIndex = 104;
            this.bCLEAN.Text = "LIMPIAR";
            this.bCLEAN.UseVisualStyleBackColor = true;
            this.bCLEAN.Click += new System.EventHandler(this.bCLEAN_Click);
            // 
            // bDEL
            // 
            this.bDEL.Location = new System.Drawing.Point(394, 690);
            this.bDEL.Margin = new System.Windows.Forms.Padding(2);
            this.bDEL.Name = "bDEL";
            this.bDEL.Size = new System.Drawing.Size(68, 19);
            this.bDEL.TabIndex = 103;
            this.bDEL.Text = "BORRAR";
            this.bDEL.UseVisualStyleBackColor = true;
            this.bDEL.Click += new System.EventHandler(this.bDEL_Click);
            // 
            // bMODI
            // 
            this.bMODI.Location = new System.Drawing.Point(308, 690);
            this.bMODI.Margin = new System.Windows.Forms.Padding(2);
            this.bMODI.Name = "bMODI";
            this.bMODI.Size = new System.Drawing.Size(74, 19);
            this.bMODI.TabIndex = 102;
            this.bMODI.Text = "MODIFICAR";
            this.bMODI.UseVisualStyleBackColor = true;
            this.bMODI.Click += new System.EventHandler(this.bMODI_Click);
            // 
            // bADD
            // 
            this.bADD.Location = new System.Drawing.Point(214, 690);
            this.bADD.Margin = new System.Windows.Forms.Padding(2);
            this.bADD.Name = "bADD";
            this.bADD.Size = new System.Drawing.Size(67, 19);
            this.bADD.TabIndex = 101;
            this.bADD.Text = "AÑADIR";
            this.bADD.UseVisualStyleBackColor = true;
            this.bADD.Click += new System.EventHandler(this.bADD_Click);
            // 
            // tEmail
            // 
            this.tEmail.Location = new System.Drawing.Point(513, 635);
            this.tEmail.Margin = new System.Windows.Forms.Padding(2);
            this.tEmail.Name = "tEmail";
            this.tEmail.Size = new System.Drawing.Size(236, 20);
            this.tEmail.TabIndex = 100;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(436, 638);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(34, 13);
            this.label14.TabIndex = 99;
            this.label14.Text = "e-mail";
            // 
            // lPais
            // 
            this.lPais.FormattingEnabled = true;
            this.lPais.Location = new System.Drawing.Point(513, 549);
            this.lPais.Margin = new System.Windows.Forms.Padding(2);
            this.lPais.Name = "lPais";
            this.lPais.Size = new System.Drawing.Size(236, 43);
            this.lPais.TabIndex = 98;
            // 
            // tTelefono
            // 
            this.tTelefono.Location = new System.Drawing.Point(513, 604);
            this.tTelefono.Margin = new System.Windows.Forms.Padding(2);
            this.tTelefono.Name = "tTelefono";
            this.tTelefono.Size = new System.Drawing.Size(236, 20);
            this.tTelefono.TabIndex = 97;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(436, 607);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(49, 13);
            this.label13.TabIndex = 96;
            this.label13.Text = "Teléfono";
            // 
            // tProvincia
            // 
            this.tProvincia.Location = new System.Drawing.Point(513, 526);
            this.tProvincia.Margin = new System.Windows.Forms.Padding(2);
            this.tProvincia.Name = "tProvincia";
            this.tProvincia.Size = new System.Drawing.Size(236, 20);
            this.tProvincia.TabIndex = 95;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(436, 563);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(27, 13);
            this.label11.TabIndex = 94;
            this.label11.Text = "Pais";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(436, 526);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(51, 13);
            this.label12.TabIndex = 93;
            this.label12.Text = "Provincia";
            // 
            // tPoblacion
            // 
            this.tPoblacion.Location = new System.Drawing.Point(513, 492);
            this.tPoblacion.Margin = new System.Windows.Forms.Padding(2);
            this.tPoblacion.Name = "tPoblacion";
            this.tPoblacion.Size = new System.Drawing.Size(236, 20);
            this.tPoblacion.TabIndex = 92;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(436, 495);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 13);
            this.label10.TabIndex = 91;
            this.label10.Text = "Población";
            // 
            // tCP
            // 
            this.tCP.Location = new System.Drawing.Point(513, 459);
            this.tCP.Margin = new System.Windows.Forms.Padding(2);
            this.tCP.Name = "tCP";
            this.tCP.Size = new System.Drawing.Size(236, 20);
            this.tCP.TabIndex = 90;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(436, 462);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 13);
            this.label9.TabIndex = 89;
            this.label9.Text = "Código Postal";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(53, 463);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 13);
            this.label8.TabIndex = 88;
            this.label8.Text = "Fecha Nacimiento";
            // 
            // tDireccion
            // 
            this.tDireccion.Location = new System.Drawing.Point(308, 410);
            this.tDireccion.Margin = new System.Windows.Forms.Padding(2);
            this.tDireccion.Name = "tDireccion";
            this.tDireccion.Size = new System.Drawing.Size(432, 20);
            this.tDireccion.TabIndex = 87;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(241, 412);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 86;
            this.label7.Text = "Dirección";
            // 
            // mFecha
            // 
            this.mFecha.Location = new System.Drawing.Point(162, 463);
            this.mFecha.Margin = new System.Windows.Forms.Padding(7);
            this.mFecha.MaxSelectionCount = 1;
            this.mFecha.Name = "mFecha";
            this.mFecha.TabIndex = 85;
            // 
            // lSexo
            // 
            this.lSexo.FormattingEnabled = true;
            this.lSexo.Items.AddRange(new object[] {
            "HOMBRE",
            "MUJER"});
            this.lSexo.Location = new System.Drawing.Point(121, 398);
            this.lSexo.Margin = new System.Windows.Forms.Padding(2);
            this.lSexo.Name = "lSexo";
            this.lSexo.Size = new System.Drawing.Size(91, 30);
            this.lSexo.TabIndex = 84;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(53, 414);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 83;
            this.label6.Text = "Sexo";
            // 
            // tApellidos
            // 
            this.tApellidos.Location = new System.Drawing.Point(513, 371);
            this.tApellidos.Margin = new System.Windows.Forms.Padding(2);
            this.tApellidos.Name = "tApellidos";
            this.tApellidos.Size = new System.Drawing.Size(228, 20);
            this.tApellidos.TabIndex = 82;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(446, 374);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 81;
            this.label3.Text = "Apellidos";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13});
            this.dataGridView1.DataSource = this.tPacienteBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(56, 150);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(694, 122);
            this.dataGridView1.TabIndex = 74;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "NumSS";
            this.dataGridViewTextBoxColumn1.HeaderText = "NumSS";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "DNI_NIE";
            this.dataGridViewTextBoxColumn2.HeaderText = "DNI_NIE";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Nombre";
            this.dataGridViewTextBoxColumn3.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Apellidos";
            this.dataGridViewTextBoxColumn4.HeaderText = "Apellidos";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Sexo";
            this.dataGridViewTextBoxColumn5.HeaderText = "Sexo";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "FechaNacimiento";
            this.dataGridViewTextBoxColumn6.HeaderText = "FechaNacimiento";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Direccion";
            this.dataGridViewTextBoxColumn7.HeaderText = "Direccion";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Poblacion";
            this.dataGridViewTextBoxColumn8.HeaderText = "Poblacion";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Provincia";
            this.dataGridViewTextBoxColumn9.HeaderText = "Provincia";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "CodigoPostal";
            this.dataGridViewTextBoxColumn10.HeaderText = "CodigoPostal";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "Pais";
            this.dataGridViewTextBoxColumn11.HeaderText = "Pais";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "Telefono";
            this.dataGridViewTextBoxColumn12.HeaderText = "Telefono";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "e_mail";
            this.dataGridViewTextBoxColumn13.HeaderText = "e_mail";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.ReadOnly = true;
            // 
            // tPacienteBindingSource1
            // 
            this.tPacienteBindingSource1.DataMember = "tPaciente";
            this.tPacienteBindingSource1.DataSource = this.fIC1819DataSet;
            // 
            // fIC1819DataSet
            // 
            this.fIC1819DataSet.DataSetName = "FIC1819DataSet";
            this.fIC1819DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tNombre
            // 
            this.tNombre.Location = new System.Drawing.Point(121, 369);
            this.tNombre.Margin = new System.Windows.Forms.Padding(2);
            this.tNombre.Name = "tNombre";
            this.tNombre.Size = new System.Drawing.Size(236, 20);
            this.tNombre.TabIndex = 80;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(53, 371);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 79;
            this.label5.Text = "Nombre";
            // 
            // tNIF
            // 
            this.tNIF.Location = new System.Drawing.Point(513, 334);
            this.tNIF.Margin = new System.Windows.Forms.Padding(2);
            this.tNIF.Name = "tNIF";
            this.tNIF.Size = new System.Drawing.Size(228, 20);
            this.tNIF.TabIndex = 78;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(446, 336);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 77;
            this.label2.Text = "NIF/NIE";
            // 
            // tNumSS
            // 
            this.tNumSS.Location = new System.Drawing.Point(121, 332);
            this.tNumSS.Margin = new System.Windows.Forms.Padding(2);
            this.tNumSS.Name = "tNumSS";
            this.tNumSS.Size = new System.Drawing.Size(236, 20);
            this.tNumSS.TabIndex = 76;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(53, 334);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 75;
            this.label4.Text = "Num SS";
            // 
            // bExit
            // 
            this.bExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bExit.BackgroundImage")));
            this.bExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bExit.Location = new System.Drawing.Point(56, 50);
            this.bExit.Margin = new System.Windows.Forms.Padding(2);
            this.bExit.Name = "bExit";
            this.bExit.Size = new System.Drawing.Size(104, 46);
            this.bExit.TabIndex = 105;
            this.bExit.UseVisualStyleBackColor = true;
            this.bExit.Click += new System.EventHandler(this.bExit_Click);
            // 
            // tPacienteTableAdapter
            // 
            this.tPacienteTableAdapter.ClearBeforeFill = true;
            // 
            // PACIENTES
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(880, 744);
            this.Controls.Add(this.bExit);
            this.Controls.Add(this.bCLEAN);
            this.Controls.Add(this.bDEL);
            this.Controls.Add(this.bMODI);
            this.Controls.Add(this.bADD);
            this.Controls.Add(this.tEmail);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.lPais);
            this.Controls.Add(this.tTelefono);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.tProvincia);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.tPoblacion);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.tCP);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tDireccion);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.mFecha);
            this.Controls.Add(this.lSexo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tApellidos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.tNombre);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tNIF);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tNumSS);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "PACIENTES";
            this.Text = "Pacientes";
            this.Load += new System.EventHandler(this.PACIENTES_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tPacienteBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fIC1819DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tPacienteBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bCLEAN;
        private System.Windows.Forms.Button bDEL;
        private System.Windows.Forms.Button bMODI;
        private System.Windows.Forms.Button bADD;
        private System.Windows.Forms.TextBox tEmail;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ListBox lPais;
        private System.Windows.Forms.TextBox tTelefono;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tProvincia;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tPoblacion;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tCP;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tDireccion;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MonthCalendar mFecha;
        private System.Windows.Forms.ListBox lSexo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tApellidos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource tPacienteBindingSource;
        private System.Windows.Forms.TextBox tNombre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tNIF;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tNumSS;
        private System.Windows.Forms.Label label4;
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
        private GI1819DataSet fIC1819DataSet;
        private System.Windows.Forms.BindingSource tPacienteBindingSource1;
        private GI1819DataSetTableAdapters.tPacienteTableAdapter tPacienteTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
    }
}