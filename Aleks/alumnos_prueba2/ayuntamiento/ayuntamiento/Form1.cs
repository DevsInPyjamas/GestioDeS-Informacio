using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ayuntamiento
{
    public partial class listBoxPartidos : Form
    {
        public listBoxPartidos()
        {
            InitializeComponent();
        }

        private Partido partidoSelected = null;
        private Concejal concejalSelected = null;

        private void listBoxPartidos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'ayuntamientoDataSet.tPartido' Puede moverla o quitarla según sea necesario.
            this.tPartidoTableAdapter.Fill(this.ayuntamientoDataSet.tPartido);
            foreach (Partido partido in Partido.ListaPartidos()) partidosListBox.Items.Add(partido.Siglas);
        }

        private void refrescarListBox()
        {
            numeroEdilesTextBox.Text = "";
            concejalesListBox.Items.Clear();
            if(partidoSelected != null) {
                foreach (Concejal concejal in partidoSelected.Ediles)
                {
                    concejalesListBox.Items.Add(concejal);
                }
                numeroEdilesTextBox.Text = concejalesListBox.Items.Count.ToString();
            }
            refrescarDatosConcejal();
        }

        private void refrescarDatosConcejal()
        {
            if (concejalSelected != null)
            {
                nombreConcejalTextBox.Text = concejalSelected.Nombre;
                partidosListBox.SelectedItem = concejalSelected.Siglas;
            }
            else if (concejalSelected == null)
            {
                nombreConcejalTextBox.Text = null;
                partidosListBox.SelectedItem = null;
            }
        } 

        private void refrescarGridView() {
            partidoSelected = null;
            concejalSelected = null;
            refrescarListBox();
            this.tPartidoTableAdapter.Fill(this.ayuntamientoDataSet.tPartido);
        }

        private void dataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if(dataGridView1.SelectedRows.Count > 0) {
                partidoSelected = new Partido((string) dataGridView1.SelectedRows[0].Cells[0].Value);
                concejalSelected = null;
                refrescarListBox();
            }
        }

        private void concejalesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            concejalSelected = (Concejal) concejalesListBox.SelectedItem;
            refrescarDatosConcejal();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            try
            {
                concejalSelected = new Concejal((string) partidosListBox.SelectedItem, nombreConcejalTextBox.Text);
                refrescarListBox();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void modificarButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (nombreConcejalTextBox.Text != concejalSelected.Nombre) concejalSelected.Nombre = nombreConcejalTextBox.Text;
                if ((string)partidosListBox.SelectedItem != concejalSelected.Siglas) concejalSelected.Siglas = (string)partidosListBox.SelectedItem;
                refrescarGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            concejalSelected.causarBaja();
            refrescarGridView();
        }
    }
}
