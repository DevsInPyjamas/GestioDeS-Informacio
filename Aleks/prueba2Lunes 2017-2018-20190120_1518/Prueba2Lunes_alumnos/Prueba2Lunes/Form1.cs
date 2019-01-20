using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CPais;

namespace Prueba2Lunes
{
    public partial class Form1 : Form
    {
        Producto selected = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'prueba2DataSet.tProducto' Puede moverla o quitarla según sea necesario.
            this.tProductoTableAdapter.Fill(this.prueba2DataSet.tProducto);
            foreach (Pais pais in Pais.ListaPaises()) lPais.Items.Add(pais.Codigo);
        }

        private void bINS_Click(object sender, EventArgs e)
        {
            try
            {
                selected = new Producto(int.Parse(tCodigo.Text), tNombre.Text, new Pais((string) lPais.SelectedItem));
                refreshDataGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void bUPD_Click(object sender, EventArgs e)
        {
            try
            {
                if (selected.PAIS.Codigo != lPais.SelectedItem) selected.PAIS = new Pais((string)lPais.SelectedItem);
                if (selected.CODIGO != int.Parse(tCodigo.Text)) selected.CODIGO = int.Parse(tCodigo.Text);
                if (selected.NOMBRE != tNombre.Text) selected.NOMBRE = tNombre.Text;
                refreshDataGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void bDEL_Click(object sender, EventArgs e)
        {
            selected.BorrarProducto();
            selected = null;
            refreshDataGridView();
        }

        private void bEXIT_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cargarDatos()
        {
            if (selected == null)
            {
                tNombre.Text = null;
                tCodigo.Text = null;
                lPais.SelectedItem = null;
            }
            else if (selected != null)
            {
                tNombre.Text = selected.NOMBRE;
                tCodigo.Text = selected.CODIGO.ToString();
                lPais.SelectedItem = selected.PAIS.Codigo;
            } 
        }

        private void refreshDataGridView()
        {
            selected = null;
            cargarDatos();
            this.tProductoTableAdapter.Fill(this.prueba2DataSet.tProducto);
        }

        private void dataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                selected = new Producto((int) dataGridView1.SelectedRows[0].Cells[0].Value);
                cargarDatos();
            }
        }   
    }
}
