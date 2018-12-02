using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HIS
{
    public partial class Pacientes : Form
    {
        private Usuario user;
        private Paciente seleccionado;

        public Pacientes(Usuario usr)
        {
            this.user = usr;
            InitializeComponent();
        }

        private void Pacientes_Load(object sender, EventArgs e)
        {
            if (!user.AccesoPantalla("PACIENTES")) this.Close();
            if (!user.ModificaPantalla("PACIENTES"))
            {
                addButton.Enabled = false;
                deleteButton.Enabled = false;
                modifyButton.Enabled = false;
            }

            // TODO: esta línea de código carga datos en la tabla 'gI1819DataSet.tPaciente' Puede moverla o quitarla según sea necesario.
            this.tPacienteTableAdapter.Fill(this.gI1819DataSet.tPaciente);
            foreach (Pais p in Pais.ListaPaises()) country.Items.Add(p);
        }

        private void cleanButton_Click(object sender, EventArgs e) {
            seleccionado = null;
            refrescaDatos();
        }

        private void pacientesGridView_SelectionChanged(object sender, EventArgs e) {
            if (pacientesGridView.SelectedRows.Count > 0) {
                int numSS = (int) pacientesGridView.SelectedRows[0].Cells[0].Value;
                seleccionado = new Paciente(numSS);
                refrescaDatos();
            }
        }

        private void refrescaDatos() {
            if (seleccionado == null) {
                nombreTextBox.Text = "";
                direccionTextBox.Text = "";
                apellidosBox.Text = "";
                NIF_NIEBOX.Text = "";
                dateTimePicker.Text = "";
                numSS.Text = "";
                codigoPostalTextBox.Text = "";
                poblacionTextBox.Text = "";
                provinciaTextBox.Text = "";
                telefonoTextBox.Text = "";
                emailTextBox.Text = "";
                country.SelectedItem = null;
            }
            else {
                nombreTextBox.Text = seleccionado.Nombre_Paciente;
                direccionTextBox.Text = seleccionado.Direccion_Paciente ;
                apellidosBox.Text = seleccionado.Apellidos_Paciente;
                NIF_NIEBOX.Text = seleccionado.DNI_NIE_Paciente;
                dateTimePicker.Text = seleccionado.FechaNacimiento_Paciente.ToString();
                numSS.Text = seleccionado.NumeroSS_Paciente.ToString();
                codigoPostalTextBox.Text = seleccionado.CodigoPostal_Paciente;
                poblacionTextBox.Text = seleccionado.Poblacion_Paciente;
                provinciaTextBox.Text = seleccionado.Provincia_Paciente;
                telefonoTextBox.Text = seleccionado.Telefono_Paciente;
                emailTextBox.Text = seleccionado.e_mail_Paciente;
                country.SelectedItem = seleccionado.Pais_Paciente;
            }
        }

        private void bExit_Click(object sender, EventArgs e){
            this.Close();
        }

        private void modifyButton_Click(object sender, EventArgs e) {
            try {
                if (seleccionado.Nombre_Paciente != nombreTextBox.Text) seleccionado.Nombre_Paciente = nombreTextBox.Text;
                if (seleccionado.Apellidos_Paciente != apellidosBox.Text) seleccionado.Apellidos_Paciente = apellidosBox.Text;
                if (seleccionado.CodigoPostal_Paciente != codigoPostalTextBox.Text) seleccionado.CodigoPostal_Paciente = codigoPostalTextBox.Text;
                if (seleccionado.Direccion_Paciente != direccionTextBox.Text) seleccionado.Direccion_Paciente = direccionTextBox.Text;
                if (seleccionado.DNI_NIE_Paciente != NIF_NIEBOX.Text) seleccionado.DNI_NIE_Paciente = NIF_NIEBOX.Text;
                // if (seleccionado.FechaNacimiento_Paciente.ToString() != dateTimePicker.Text) seleccionado.FechaNacimiento_Paciente = new DateTime(dateTimePicker.Text);
                if (seleccionado.Pais_Paciente.Descripcion != country.Text) seleccionado.Pais_Paciente = seleccionado.Pais_Paciente.getElDeLaDescripcion(country.Text);
                if (seleccionado.Poblacion_Paciente != poblacionTextBox.Text) seleccionado.Poblacion_Paciente = poblacionTextBox.Text;
                if (seleccionado.Provincia_Paciente != provinciaTextBox.Text) seleccionado.Provincia_Paciente = provinciaTextBox.Text;
                if (seleccionado.Sexo_Paciente != listBox1.Text) seleccionado.Sexo_Paciente = listBox1.Text;
                if (seleccionado.Telefono_Paciente != telefonoTextBox.Text) seleccionado.Telefono_Paciente = telefonoTextBox.Text;
                if (seleccionado.e_mail_Paciente != emailTextBox.Text) seleccionado.e_mail_Paciente = emailTextBox.Text;

                this.tPacienteTableAdapter.Fill(this.gI1819DataSet.tPaciente);
                refrescaDatos();
            }   
            catch (Exception ex) {
                MessageBox.Show("Error: " + ex.Message);
            }

        }

        private void deleteButton_Click(object sender, EventArgs e) {
            seleccionado.BorrarPaciente();
            seleccionado = null;
            this.tPacienteTableAdapter.Fill(this.gI1819DataSet.tPaciente);
            refrescaDatos();
        }
    }
}
