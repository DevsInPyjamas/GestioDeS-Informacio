using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CPais;

namespace Prueba2Martes
{
    public partial class Form2 : Form
    {
        private Persona selected = null;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'prueba2DataSet.tPersona' Puede moverla o quitarla según sea necesario.
            this.tPersonaTableAdapter.Fill(this.prueba2DataSet.tPersona);
            foreach(Pais p in Pais.ListaPaises()) {
                lPais.Items.Add(p.Codigo);
            }
        }

        private void dataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if(dataGridView1.SelectedRows.Count > 0) {
                string id = (string) dataGridView1.SelectedRows[0].Cells[0].Value;
                selected = new Persona(id);
                cargar_datos();
            }
        }

        private void cargar_datos()
        {
            if(selected != null) {
                tNIF.Text = selected.NIF;
                tNombre.Text = selected.NOMBRE;
                lPais.SelectedItem = selected.PAIS.Codigo;
            }
            else if (selected == null)
            {
                tNIF.Text = null;
                tNombre.Text = null;
            }
        }

        private void bEXIT_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bDEL_Click(object sender, EventArgs e)
        {
            selected.BorrarPersona();
            selected = null;
            refrescarGrid();
        }

        private void bUPD_Click(object sender, EventArgs e)
        {
            try { 
                if (selected.NIF != tNIF.Text) selected.NIF = tNIF.Text;
                if (selected.NOMBRE != tNombre.Text) selected.NOMBRE = tNombre.Text;
                if (selected.PAIS.Codigo.Equals((string) lPais.SelectedItem)) selected.PAIS = new Pais((string)lPais.SelectedItem);
                refrescarGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void refrescarGrid() {
            selected = null;
            cargar_datos();
            this.tPersonaTableAdapter.Fill(this.prueba2DataSet.tPersona);
        }


        private void bINS_Click(object sender, EventArgs e)
        {
            try {
                selected = new Persona((string)tNIF.Text, (string)tNombre.Text, new Pais((string) lPais.SelectedItem));
                refrescarGrid();
            } catch(Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
