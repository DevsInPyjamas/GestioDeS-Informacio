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
    public partial class CITAS : Form
    {
        Cita seleccionado = null;
        private Usuario user = null;

        public CITAS(Usuario user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void CITAS_Load(object sender, EventArgs e)
        {
            idTextBox.Enabled = false;
            if (!user.AccesoPantalla(this.Name)) this.Close();
            if (!user.ModificaPantalla(this.Name))
            {
                addButton.Enabled = false;
                deleteButton.Enabled = false;
                modifyButton.Enabled = false;
            }

            foreach (Paciente p in Paciente.ListaPacientes()) listaPacientes.Items.Add(p);
            
        }

        private void bExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listaPacientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            citasGridView.Rows.Clear();
            if (listaPacientes.SelectedItem == null) return;
            foreach (Cita c in Cita.ListaCitas((Paciente)listaPacientes.SelectedItem)) {
                object[] row = { c.ID, c.NumSS, c.Fecha_Hora, c.Consulta };
                citasGridView.Rows.Add(row); 
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            int numSS = (int)citasGridView.SelectedRows[0].Cells[1].Value;
            DateTime fechaHora = (DateTime)citasGridView.SelectedRows[0].Cells[2].Value;
            string consulta = (string)citasGridView.SelectedRows[0].Cells[3].Value;
            seleccionado = new Cita(numSS, fechaHora, consulta);
            refrescaDatos();
        }

        private void citasGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (citasGridView.SelectedRows.Count > 0)
            {
                int id = (int) citasGridView.SelectedRows[0].Cells[0].Value;

                seleccionado = new Cita(id);
                refrescaDatos();
            }

        }

        private void refrescaDatos()
        {
            if (seleccionado == null)
            {
                timeTextBox.Text = "";
                numSSTextBox.Text = "";
                idTextBox.Text = "";
                consultTextBox.Text = "";
                dateTimePicker.Value = DateTimePicker.MinimumDateTime;
            }
            else
            {
                idTextBox.Text = seleccionado.ID.ToString();
                numSSTextBox.Text = seleccionado.NumSS.ToString();
                timeTextBox.Text = seleccionado.Fecha_Hora.ToShortTimeString();
                consultTextBox.Text = seleccionado.Consulta;
                dateTimePicker.Value = seleccionado.Fecha_Hora;
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            seleccionado.BorrarCita();
            seleccionado = null;
            refrescaDatos();
            citasGridView.Rows.Clear();
        }

        private void modifyButton_Click(object sender, EventArgs e)
        {
            int numSS = (int)citasGridView.SelectedRows[0].Cells[1].Value;
            DateTime fechaHora = (DateTime)citasGridView.SelectedRows[0].Cells[2].Value;
            string consulta = (string)citasGridView.SelectedRows[0].Cells[3].Value;
            seleccionado.NumSS = numSS;
            seleccionado.Fecha_Hora = fechaHora;
            seleccionado.Consulta = consulta;
            refrescaDatos();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            seleccionado = null;
            refrescaDatos();
        }
    }
}
