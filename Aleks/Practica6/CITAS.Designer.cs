namespace HIS
{
    partial class CITAS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CITAS));
            this.bExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.citasGridView = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumSS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaHora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Consulta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.listaPacientes = new System.Windows.Forms.ListBox();
            this.idCita = new System.Windows.Forms.Label();
            this.consultaLabel = new System.Windows.Forms.Label();
            this.horaLabel = new System.Windows.Forms.Label();
            this.fechaLabel = new System.Windows.Forms.Label();
            this.numSSPaciente = new System.Windows.Forms.Label();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.numSSTextBox = new System.Windows.Forms.TextBox();
            this.consultTextBox = new System.Windows.Forms.TextBox();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.timeTextBox = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.modifyButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.citasGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // bExit
            // 
            this.bExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bExit.BackgroundImage")));
            this.bExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bExit.Location = new System.Drawing.Point(600, 11);
            this.bExit.Margin = new System.Windows.Forms.Padding(2);
            this.bExit.Name = "bExit";
            this.bExit.Size = new System.Drawing.Size(80, 59);
            this.bExit.TabIndex = 9;
            this.bExit.UseVisualStyleBackColor = true;
            this.bExit.Click += new System.EventHandler(this.bExit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(242, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 46);
            this.label1.TabIndex = 10;
            this.label1.Text = "CITAS";
            // 
            // citasGridView
            // 
            this.citasGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.citasGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.NumSS,
            this.FechaHora,
            this.Consulta});
            this.citasGridView.Location = new System.Drawing.Point(12, 173);
            this.citasGridView.Name = "citasGridView";
            this.citasGridView.Size = new System.Drawing.Size(789, 120);
            this.citasGridView.TabIndex = 11;
            this.citasGridView.SelectionChanged += new System.EventHandler(this.citasGridView_SelectionChanged);
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.Name = "id";
            // 
            // NumSS
            // 
            this.NumSS.HeaderText = "NumSS";
            this.NumSS.Name = "NumSS";
            // 
            // FechaHora
            // 
            this.FechaHora.HeaderText = "FechaHora";
            this.FechaHora.Name = "FechaHora";
            // 
            // Consulta
            // 
            this.Consulta.HeaderText = "Consulta";
            this.Consulta.Name = "Consulta";
            // 
            // listaPacientes
            // 
            this.listaPacientes.FormattingEnabled = true;
            this.listaPacientes.Location = new System.Drawing.Point(12, 75);
            this.listaPacientes.Name = "listaPacientes";
            this.listaPacientes.Size = new System.Drawing.Size(789, 82);
            this.listaPacientes.TabIndex = 12;
            this.listaPacientes.SelectedIndexChanged += new System.EventHandler(this.listaPacientes_SelectedIndexChanged);
            // 
            // idCita
            // 
            this.idCita.AutoSize = true;
            this.idCita.Location = new System.Drawing.Point(22, 335);
            this.idCita.Name = "idCita";
            this.idCita.Size = new System.Drawing.Size(39, 13);
            this.idCita.TabIndex = 13;
            this.idCita.Text = "ID Cita";
            // 
            // consultaLabel
            // 
            this.consultaLabel.AutoSize = true;
            this.consultaLabel.Location = new System.Drawing.Point(22, 360);
            this.consultaLabel.Name = "consultaLabel";
            this.consultaLabel.Size = new System.Drawing.Size(48, 13);
            this.consultaLabel.TabIndex = 14;
            this.consultaLabel.Text = "Consulta";
            // 
            // horaLabel
            // 
            this.horaLabel.AutoSize = true;
            this.horaLabel.Location = new System.Drawing.Point(413, 388);
            this.horaLabel.Name = "horaLabel";
            this.horaLabel.Size = new System.Drawing.Size(30, 13);
            this.horaLabel.TabIndex = 15;
            this.horaLabel.Text = "Hora";
            // 
            // fechaLabel
            // 
            this.fechaLabel.AutoSize = true;
            this.fechaLabel.Location = new System.Drawing.Point(22, 388);
            this.fechaLabel.Name = "fechaLabel";
            this.fechaLabel.Size = new System.Drawing.Size(37, 13);
            this.fechaLabel.TabIndex = 16;
            this.fechaLabel.Text = "Fecha";
            // 
            // numSSPaciente
            // 
            this.numSSPaciente.AutoSize = true;
            this.numSSPaciente.Location = new System.Drawing.Point(413, 335);
            this.numSSPaciente.Name = "numSSPaciente";
            this.numSSPaciente.Size = new System.Drawing.Size(49, 13);
            this.numSSPaciente.TabIndex = 17;
            this.numSSPaciente.Text = "NUM SS";
            // 
            // idTextBox
            // 
            this.idTextBox.Location = new System.Drawing.Point(76, 328);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(331, 20);
            this.idTextBox.TabIndex = 18;
            // 
            // numSSTextBox
            // 
            this.numSSTextBox.Location = new System.Drawing.Point(468, 328);
            this.numSSTextBox.Name = "numSSTextBox";
            this.numSSTextBox.Size = new System.Drawing.Size(322, 20);
            this.numSSTextBox.TabIndex = 19;
            // 
            // consultTextBox
            // 
            this.consultTextBox.Location = new System.Drawing.Point(76, 357);
            this.consultTextBox.Name = "consultTextBox";
            this.consultTextBox.Size = new System.Drawing.Size(714, 20);
            this.consultTextBox.TabIndex = 20;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(76, 388);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(250, 20);
            this.dateTimePicker.TabIndex = 21;
            // 
            // timeTextBox
            // 
            this.timeTextBox.Location = new System.Drawing.Point(468, 383);
            this.timeTextBox.Name = "timeTextBox";
            this.timeTextBox.Size = new System.Drawing.Size(322, 20);
            this.timeTextBox.TabIndex = 22;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(147, 574);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 23;
            this.addButton.Text = "añadir";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // modifyButton
            // 
            this.modifyButton.Location = new System.Drawing.Point(319, 574);
            this.modifyButton.Name = "modifyButton";
            this.modifyButton.Size = new System.Drawing.Size(75, 23);
            this.modifyButton.TabIndex = 24;
            this.modifyButton.Text = "modificar";
            this.modifyButton.UseVisualStyleBackColor = true;
            this.modifyButton.Click += new System.EventHandler(this.modifyButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(402, 574);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 23);
            this.deleteButton.TabIndex = 25;
            this.deleteButton.Text = "borrar";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(483, 574);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 26;
            this.clearButton.Text = "Limpiar";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // CITAS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(829, 609);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.modifyButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.timeTextBox);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.consultTextBox);
            this.Controls.Add(this.numSSTextBox);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(this.numSSPaciente);
            this.Controls.Add(this.fechaLabel);
            this.Controls.Add(this.horaLabel);
            this.Controls.Add(this.consultaLabel);
            this.Controls.Add(this.idCita);
            this.Controls.Add(this.listaPacientes);
            this.Controls.Add(this.citasGridView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bExit);
            this.Name = "CITAS";
            this.Text = "CITAS";
            this.Load += new System.EventHandler(this.CITAS_Load);
            ((System.ComponentModel.ISupportInitialize)(this.citasGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView citasGridView;
        private System.Windows.Forms.ListBox listaPacientes;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumSS;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaHora;
        private System.Windows.Forms.DataGridViewTextBoxColumn Consulta;
        private System.Windows.Forms.Label idCita;
        private System.Windows.Forms.Label consultaLabel;
        private System.Windows.Forms.Label horaLabel;
        private System.Windows.Forms.Label fechaLabel;
        private System.Windows.Forms.Label numSSPaciente;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox numSSTextBox;
        private System.Windows.Forms.TextBox consultTextBox;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.TextBox timeTextBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button modifyButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button clearButton;
    }
}