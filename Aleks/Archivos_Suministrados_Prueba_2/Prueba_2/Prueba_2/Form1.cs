using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BDLibrary;

namespace Prueba_2
{
    public partial class Form1 : Form
    {
        private Medicamento selected = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bD_MEDICAMENTOSDataSet.tMedicamento' Puede moverla o quitarla según sea necesario.
            refreshGridView();
            SQLSERVERDB db = new SQLSERVERDB(Prueba_2.Properties.Settings.Default.BD_SERVER, Prueba_2.Properties.Settings.Default.BD_NAME);
            
            foreach (Laboratorio lab in Laboratorio.ListaLaboratorios())
                labList.Items.Add(lab);  
        }

        private void medicamentosGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (medicamentosGridView.SelectedRows.Count > 0)
            {
                this.selected = new Medicamento((int) medicamentosGridView.SelectedRows[0].Cells[0].Value);
                refreshFields();
            }
        }

        private void refreshFields()
        {
            if (selected != null)
            {
                idMed.Text = selected.ID.ToString();
                medCant.Text = selected.Cantidad.ToString();
                medName.Text = selected.Nombre;
                labList.SelectedItem = selected.Laboratorio;
            }
            else if (selected == null)
            {
                idMed.Text = null;
                medCant.Text = null;
                medName.Text = null;
                labList.SelectedItem = null;
            }
        }

        private void refreshGridView()
        {
            selected = null;
            this.tMedicamentoTableAdapter.Fill(this.bD_MEDICAMENTOSDataSet.tMedicamento);
            refreshFields();
            cambiarElPutoColorDeCristo();
        }

        private void cambiarElPutoColorDeCristo()
        {
            for (int i = 0; i < medicamentosGridView.Rows.Count - 1; i++ )
            {
                if ((int)(medicamentosGridView.Rows[i].Cells[2].Value) <= 10)
                {
                    medicamentosGridView.Rows[i].Cells[2].Style.ForeColor = Color.Red;
                }
            }
        }

        private void closeB_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void insB_Click(object sender, EventArgs e)
        {
            try
            {
                selected = new Medicamento(int.Parse(idMed.Text), medName.Text, int.Parse(medCant.Text), (Laboratorio)labList.SelectedItem);
                refreshGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void modB_Click(object sender, EventArgs e)
        {
            try
            {
                if (!selected.ID.Equals((int.Parse(idMed.Text)))) selected.ID = int.Parse(idMed.Text);
                if (!selected.Cantidad.Equals((int.Parse(medCant.Text)))) selected.Cantidad = (int.Parse(medCant.Text));
                if (!selected.Laboratorio.Equals(labList.SelectedItem)) selected.Laboratorio = (Laboratorio) labList.SelectedItem;
                if (!selected.Nombre.Equals(medName.Text)) selected.Nombre = medName.Text; 
                refreshGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void deleteThisB_Click(object sender, EventArgs e)
        {
            try
            {
                selected.DeleteThis();
                selected = null;
                refreshGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cleanB_Click(object sender, EventArgs e)
        {
            refreshGridView();
        }
    }
}
