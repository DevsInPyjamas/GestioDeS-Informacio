using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HIS
{
    public partial class PACIENTES : Form
    {
        private Usuario usuario;
        private Paciente seleccionado;

        public PACIENTES(Usuario user)
        {
            InitializeComponent();
            usuario = user;
            seleccionado = null;
        }

        private void PACIENTES_Load(object sender, EventArgs e)
        {

            if (!usuario.AccesoPantalla(this.Name)) this.Close();

            if (!usuario.ModificaPantalla(this.Name))
            {
                bADD.Enabled = false;
                bMODI.Enabled = false;
                bDEL.Enabled = false;
            }

            this.tPacienteTableAdapter.Fill(this.fIC1819DataSet.tPaciente);

            foreach (Pais p in Pais.ListaPaises()) lPais.Items.Add(p);

        }

        private void bCLEAN_Click(object sender, EventArgs e)
        {
            seleccionado=null;
            RefrescaDatos();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                int id = (int)dataGridView1.SelectedRows[0].Cells[0].Value;
                seleccionado = new Paciente(id);
                RefrescaDatos();

            }
            catch
            {
                // Se ignora si no hay nada seleccionado o cargado
            }
        }

        private void bADD_Click(object sender, EventArgs e)
        {
            seleccionado = new Paciente(int.Parse(tNumSS.Text), tNIF.Text, tNombre.Text, tApellidos.Text,
                (string)lSexo.SelectedItem, mFecha.SelectionStart, tDireccion.Text,
                tPoblacion.Text, tProvincia.Text, tCP.Text, (Pais)lPais.SelectedItem,
                tTelefono.Text, tEmail.Text);

            this.tPacienteTableAdapter.Fill(this.fIC1819DataSet.tPaciente);
        }

        private void bMODI_Click(object sender, EventArgs e)
        {
            if (seleccionado.NumeroSS_Paciente != int.Parse(tNumSS.Text))
            {
                MessageBox.Show("No está permitido cambiar el número de la SS de un paciente");
                tNumSS.Text = seleccionado.NumeroSS_Paciente.ToString();
            }

            if (!seleccionado.DNI_NIE_Paciente.Equals(tNIF.Text))
                seleccionado.DNI_NIE_Paciente = tNIF.Text;
            if (!seleccionado.Apellidos_Paciente.Equals(tApellidos.Text))
                seleccionado.Apellidos_Paciente = tApellidos.Text;
            if (!seleccionado.Nombre_Paciente.Equals(tNombre.Text))
                seleccionado.Nombre_Paciente = tNombre.Text;
            if (!seleccionado.Sexo_Paciente.Equals(lSexo.SelectedItem.ToString()))
                seleccionado.Sexo_Paciente = lSexo.SelectedItem.ToString();
            if (!seleccionado.FechaNacimiento_Paciente.Equals(mFecha.SelectionStart))
                seleccionado.FechaNacimiento_Paciente = mFecha.SelectionStart;
            if (!seleccionado.Direccion_Paciente.Equals(tDireccion.Text))
                seleccionado.Direccion_Paciente = tDireccion.Text;
            if (!seleccionado.CodigoPostal_Paciente.Equals(tCP.Text))
                seleccionado.CodigoPostal_Paciente = tCP.Text;
            if (!seleccionado.Poblacion_Paciente.Equals(tPoblacion.Text))
                seleccionado.Poblacion_Paciente = tPoblacion.Text;
            if (!seleccionado.Provincia_Paciente.Equals(tProvincia.Text))
                seleccionado.Provincia_Paciente = tProvincia.Text;
            if (!seleccionado.Telefono_Paciente.Equals(tTelefono.Text))
                seleccionado.Telefono_Paciente = tTelefono.Text;
            if (!seleccionado.Pais_Paciente.Equals(lPais.SelectedItem))
                seleccionado.Pais_Paciente = (Pais)lPais.SelectedItem;
            if (!seleccionado.e_mail_Paciente.Equals(tEmail.Text))
                seleccionado.e_mail_Paciente = tEmail.Text;

            this.tPacienteTableAdapter.Fill(this.fIC1819DataSet.tPaciente);
        }

        private void bDEL_Click(object sender, EventArgs e)
        {
            seleccionado.BorrarPaciente();
            seleccionado = null;
            this.tPacienteTableAdapter.Fill(this.fIC1819DataSet.tPaciente);
            RefrescaDatos();
        }

        private void RefrescaDatos()
        {
            if (seleccionado == null)
            {
                tNumSS.Text = "";
                tNIF.Text = "";
                tApellidos.Text = "";
                tNombre.Text = "";
                lSexo.SelectedIndex = -1;
                mFecha.SetDate(DateTime.Today);
                tDireccion.Text = "";
                tCP.Text = "";
                tPoblacion.Text = "";
                tProvincia.Text = "";
                tTelefono.Text = "";
                lPais.SelectedIndex = -1;
                tEmail.Text = "";
            }
            else
            {
                tNumSS.Text = seleccionado.NumeroSS_Paciente.ToString();
                tNIF.Text = seleccionado.DNI_NIE_Paciente;
                tApellidos.Text = seleccionado.Apellidos_Paciente;
                tNombre.Text = seleccionado.Nombre_Paciente;
                lSexo.SelectedItem = seleccionado.Sexo_Paciente;
                mFecha.SetDate(seleccionado.FechaNacimiento_Paciente);
                tDireccion.Text = seleccionado.Direccion_Paciente;
                tCP.Text = seleccionado.CodigoPostal_Paciente;
                tPoblacion.Text = seleccionado.Poblacion_Paciente;
                tProvincia.Text = seleccionado.Provincia_Paciente;
                tTelefono.Text = seleccionado.Telefono_Paciente;
                lPais.SelectedItem = seleccionado.Pais_Paciente;
                tEmail.Text = seleccionado.e_mail_Paciente;
            }
        }

        private void bExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
